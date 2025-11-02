using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using MISLiveMed.DataLayers.DataAccess;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Administration.Connections;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Main.Administration.Configuration;
using MISLiveMed.UI.Properties;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.MailSystem;
using Newtonsoft.Json;

namespace MISLiveMed.UI.Utilities
{
	public static class HelperApplication
	{
		private static bool _changeDatabase = false;

		public static void InitDefaultStyle()
		{
			WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(Settings.Default.ApplicationSkinName,
				Settings.Default.ApplicationPalette);

			//      WindowsFormsSettings.EnableFormSkins();
			//         WindowsFormsSettings.ForceDirectXPaint();
			////WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinStyle.Office2019Colorful);
			////WindowsFormsSettings.DefaultRibbonStyle = DefaultRibbonControlStyle.Office2019;
			//WindowsFormsSettings.FindPanelBehavior = FindPanelBehavior.Search;
			//         WindowsFormsSettings.FilterCriteriaDisplayStyle = FilterCriteriaDisplayStyle.Visual;
			//         //WindowsFormsSettings.AllowPixelScrolling = DefaultBoolean.True;
			//         AppearanceObject.DefaultFont = new Font("Segoe UI", GetDefaultSize());

			//         WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
			//         WindowsFormsSettings.CustomizationFormSnapMode = SnapMode.OwnerControl;
			//         WindowsFormsSettings.ColumnFilterPopupMode = ColumnFilterPopupMode.Excel;
			//         WindowsFormsSettings.AllowSkinEditorAttach = DefaultBoolean.True;
		}

		public static float GetDefaultSize()
		{
			return 8.25F;
		}

		public static void InitTitleComboBox(RepositoryItemImageComboBox edit)
		{
			var iCollection = new SvgImageCollection();
			iCollection.Add(Resources.Doctor);
			iCollection.Add(Resources.Miss);
			iCollection.Add(Resources.Mr);
			iCollection.Add(Resources.Mrs);
			iCollection.Add(Resources.Ms);
			iCollection.Add(Resources.Professor);
			edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Dr), PersonPrefix.Dr, 0));
			edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Miss), PersonPrefix.Miss, 1));
			edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Mr), PersonPrefix.Mr, 2));
			edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Mrs), PersonPrefix.Mrs, 3));
			edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Ms), PersonPrefix.Ms, 4));
			edit.SmallImages = iCollection;
		}

		public static string GetTitleNameByContactTitle(PersonPrefix title)
		{
			switch (title)
			{
				case PersonPrefix.Dr: return Resources.ContactTitleDr;
				case PersonPrefix.Miss: return Resources.ContactTitleMiss;
				case PersonPrefix.Mr: return Resources.ContactTitleMr;
				case PersonPrefix.Mrs: return Resources.ContactTitleMrs;
				case PersonPrefix.Ms: return Resources.ContactTitleMs;
			}

			return string.Empty;
		}

		/// <summary>
		/// Thread-safe method to show message boxes that can be called from any thread
		/// </summary>
		public static DialogResult SafeShowMessageBox(string message, string caption = "Error", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error)
		{
			DialogResult result = DialogResult.OK;
			try
			{
				if (Application.OpenForms.Count > 0 && Application.OpenForms[0] != null)
				{
					var mainForm = Application.OpenForms[0];
					if (mainForm.InvokeRequired)
					{
						result = (DialogResult)mainForm.Invoke(new Func<DialogResult>(() =>
						{
							return XtraMessageBox.Show(message, caption, buttons, icon);
						}));
					}
					else
					{
						result = XtraMessageBox.Show(message, caption, buttons, icon);
					}
				}
				else
				{
					// Fallback to standard MessageBox if no forms are available
					result = MessageBox.Show(message, caption, buttons, icon);
				}
			}
			catch (Exception ex)
			{
				// Last resort: use standard MessageBox
				try
				{
					result = MessageBox.Show(@$"Error displaying message: {ex.Message}\nOriginal message: {message}", 
						@"Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch
				{
					// If even this fails, write to debug output
					System.Diagnostics.Debug.WriteLine($"Critical error: {ex.Message}, Original: {message}");
				}
			}
			return result;
		}

		/// <summary>
		/// Validates and establishes database connection with proper error handling and user interaction
		/// </summary>
		/// <returns>True if connection is successful, false otherwise</returns>
		public static bool CheckDatabaseConnection()
		{
			const int maxRetryAttempts = 3;
			int currentAttempt = 0;

			while (true)
			{
				try
				{
					currentAttempt++;
					var connectionResult = AttemptDatabaseConnection();
					
					switch (connectionResult.Status)
					{
						case DatabaseConnectionStatus.Success:
							return true;
							
						case DatabaseConnectionStatus.DatabaseNotFound:
							if (HandleDatabaseNotFound(connectionResult.ConnectionModel))
								return CheckDatabaseConnection(); // Retry after database creation
							return false;
							
						case DatabaseConnectionStatus.ConnectionFailed:
							if (currentAttempt >= maxRetryAttempts)
							{
								return HandleConnectionFailure();
							}
							break;
							
						case DatabaseConnectionStatus.ConfigurationRequired:
							return HandleConfigurationRequired();
							
						default:
							return false;
					}
				}
				catch (Exception ex)
				{
					if (currentAttempt >= maxRetryAttempts)
					{
						return HandleCriticalError(ex);
					}
					
					// Log the error for debugging purposes
					System.Diagnostics.Debug.WriteLine($"Database connection attempt {currentAttempt} failed: {ex.Message}");
				}
			}

			return false;
		}

		/// <summary>
		/// Attempts to establish database connection and returns detailed result
		/// </summary>
		private static DatabaseConnectionResult AttemptDatabaseConnection()
		{
			var connectionModel = DatabaseFactory.ConnectionParamsGet();
			
			if (connectionModel == null || string.IsNullOrWhiteSpace(connectionModel.DatabaseHost))
			{
				return new DatabaseConnectionResult 
				{ 
					Status = DatabaseConnectionStatus.ConfigurationRequired,
					ConnectionModel = connectionModel,
					ErrorMessage = "Database configuration is missing or invalid"
				};
			}

			var database = DatabaseFactory.Get(
				connectionModel.DatabaseName, 
				connectionModel.DatabaseType,
				connectionModel.DatabaseHost, 
				connectionModel.DatabasePort, 
				connectionModel.DatabaseName,
				connectionModel.DatabaseUser, 
				connectionModel.DatabasePassword);

			var connectionState = database.CheckConnection();
			
			if (connectionState == ConnectionState.Open)
			{
				if (database.AllowCreateDataBase() && !database.CheckDatabaseExists(connectionModel.DatabaseName))
				{
					return new DatabaseConnectionResult 
					{ 
						Status = DatabaseConnectionStatus.DatabaseNotFound,
						ConnectionModel = connectionModel,
						Database = database
					};
				}

				// Update current user context on successful connection
				UpdateUserContext(connectionModel);
				
				return new DatabaseConnectionResult 
				{ 
					Status = DatabaseConnectionStatus.Success,
					ConnectionModel = connectionModel,
					Database = database
				};
			}

			return new DatabaseConnectionResult 
			{ 
				Status = DatabaseConnectionStatus.ConnectionFailed,
				ConnectionModel = connectionModel,
				ErrorMessage = $"Connection failed. State: {connectionState}"
			};
		}

		/// <summary>
		/// Handles the case when database is not found and prompts user for action
		/// </summary>
		private static bool HandleDatabaseNotFound(ConnectionModel connectionModel)
		{
			var userChoice = SafeShowMessageBox(
				$"The database '{connectionModel.DatabaseName}' could not be found.\n\nWould you like to create it?",
				"Database Not Found",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (userChoice == DialogResult.Yes)
			{
				try
				{
					var database = DatabaseFactory.Get(
						connectionModel.DatabaseName, 
						connectionModel.DatabaseType,
						connectionModel.DatabaseHost, 
						connectionModel.DatabasePort, 
						connectionModel.DatabaseName,
						connectionModel.DatabaseUser, 
						connectionModel.DatabasePassword);
						
					database.CreateDatabase(connectionModel.DatabaseName);
					_changeDatabase = true;
					
					SafeShowMessageBox(
						$"Database '{connectionModel.DatabaseName}' has been created successfully.",
						"Database Created",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
						
					return true;
				}
				catch (Exception ex)
				{
					SafeShowMessageBox(
						$"Failed to create database: {ex.Message}",
						"Database Creation Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return false;
				}
			}

			return ShowServerConfigurationDialog();
		}

		/// <summary>
		/// Handles connection failure by showing configuration dialog
		/// </summary>
		private static bool HandleConnectionFailure()
		{
			SafeShowMessageBox(
				"Unable to connect to the database. Please check your connection settings.",
				"Connection Failed",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);

			return ShowServerConfigurationDialog();
		}

		/// <summary>
		/// Handles configuration requirement by showing configuration dialog
		/// </summary>
		private static bool HandleConfigurationRequired()
		{
			SafeShowMessageBox(
				"Database configuration is required. Please configure your database settings.",
				"Configuration Required",
				MessageBoxButtons.OK,
				MessageBoxIcon.Warning);

			return ShowServerConfigurationDialog();
		}

		/// <summary>
		/// Handles critical errors during database connection
		/// </summary>
		private static bool HandleCriticalError(Exception ex)
		{
			SafeShowMessageBox(
				$"A critical error occurred while connecting to the database:\n\n{ex.Message}\n\nPlease check your configuration and try again.",
				"Critical Database Error",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);

			return ShowServerConfigurationDialog();
		}

		/// <summary>
		/// Shows server configuration dialog and returns success status
		/// </summary>
		private static bool ShowServerConfigurationDialog()
		{
			try
			{
				using var configForm = new ServerConfigurationForm();
				return configForm.ShowDialog() == DialogResult.OK;
			}
			catch (Exception ex)
			{
				SafeShowMessageBox(
					$"Failed to open configuration dialog: {ex.Message}",
					"Configuration Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// Updates current user context with connection information
		/// </summary>
		private static void UpdateUserContext(ConnectionModel connectionModel)
		{
			if (connectionModel != null)
			{
				CurrentUser.HostName = connectionModel.DatabaseHost;
				CurrentUser.DatabaseName = connectionModel.DatabaseName;
			}
		}

		/// <summary>
		/// Represents the result of a database connection attempt
		/// </summary>
		private class DatabaseConnectionResult
		{
			public DatabaseConnectionStatus Status { get; set; }
			public ConnectionModel ConnectionModel { get; set; }
			public IDatabase Database { get; set; }
			public string ErrorMessage { get; set; }
		}

		/// <summary>
		/// Represents the status of a database connection attempt
		/// </summary>
		private enum DatabaseConnectionStatus
		{
			Success,
			DatabaseNotFound,
			ConnectionFailed,
			ConfigurationRequired
		}

		public static bool CheckDatabaseConnection_Old()
		{
			var succeed = false;
			try
			{
				var connectionModel = DatabaseFactory.ConnectionParamsGet();

				IDatabase database = DatabaseFactory.Get(connectionModel.DatabaseName, connectionModel.DatabaseType,
					connectionModel.DatabaseHost, connectionModel.DatabasePort, connectionModel.DatabaseName,
					connectionModel.DatabaseUser, connectionModel.DatabasePassword);

				if (database.CheckConnection() == ConnectionState.Open)
				{
					if (database.AllowCreateDataBase() && !database.CheckDatabaseExists(connectionModel.DatabaseName))
					{
						if (SafeShowMessageBox(
							    @"The database " + connectionModel.DatabaseName +
							    @" could not be found. Do you want to create it?",
							    $@"Create database {connectionModel.DatabaseName}", MessageBoxButtons.YesNo,
							    MessageBoxIcon.Question) == DialogResult.Yes)
						{
							//If yes then we can create the database, set default values and login to the app
							database.CreateDatabase(connectionModel.DatabaseName);
							_changeDatabase = true;

						}
						else
						{
							ServerConfigurationForm dbForm = new ServerConfigurationForm();
							if (dbForm.ShowDialog() == DialogResult.OK)
							{
								CheckDatabaseConnection();
							}
						}
					}

					if (_changeDatabase)
					{
						ServerConfigurationForm dbForm = new ServerConfigurationForm();
						if (dbForm.ShowDialog() == DialogResult.OK)
						{
							succeed = true;
							CheckDatabaseConnection();
						}
					}
					//if create success, configure schema tables and apply default configuration
					//ISchemaDatabase schemaDatabase = SchemaDatabaseFactory.Get(database);
					//schemaDatabase.Configure();
					//schemaDatabase.Upgrade();

					//Update status
					CurrentUser.HostName = connectionModel.DatabaseHost;
					CurrentUser.DatabaseName = connectionModel.DatabaseName;
					
				}
				else
				{
					SafeShowMessageBox(@"Initialize Data Error", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					ServerConfigurationForm dbForm = new ServerConfigurationForm();
					if (dbForm.ShowDialog() == DialogResult.OK)
					{
						succeed = true;
						CheckDatabaseConnection();
					}
				}
			}
			catch (Exception e)
			{
				SafeShowMessageBox(e.Message, $@"Error {e.HResult.ToString()}", MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				ServerConfigurationForm dbForm = new ServerConfigurationForm();
				if (dbForm.ShowDialog() == DialogResult.OK)
				{
					CheckDatabaseConnection();
					succeed = false;
				}
			}
			return succeed;
		}

		public static void ApplyDefaultSettings()
		{
			try
			{
				if (!Settings.Default.UpgradeRequired) return;

				IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
				UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();

				_userPermission = _userPermissionRepository.SelectUserPermissionById(1);
				if (_userPermission == null) return;

				if (_userPermission.Count <= 0)
				{
					CurrentUser.UserId = 1;
					CurrentUser.CompanyId = 1;
					CurrentUser.BranchId = 1;

					_userPermissionRepository.SeedUserPermissionsData(1, true);

					//UpgradeRequired
					Settings.Default.UpgradeRequired = false;
					Settings.Default.Save();
				}

				//Fix missing UserId in users
				UserRepository _userRepository = new UserRepository();
				_userRepository.FixTableUsers();
			}
			catch (Exception e)
			{
				SafeShowMessageBox(e.Message, $@"Error {e.HResult.ToString()}", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		public static void CheckDefaultFolderStructure()
		{
			var path = ".";
			var data = "Data";
			var logo = "logo.png";
			string subPath = "Static";

			var staticPath = Path.Combine(Path.GetFullPath(path), subPath);
			var dataPath = Path.Combine(Path.GetFullPath(path), data);
			string fileToCopy = Path.Combine(Directory.GetParent(staticPath).ToString(), @"..\..\..", subPath, logo);

			try
			{
				if (!Directory.Exists(staticPath))
					Directory.CreateDirectory(staticPath);

				if (!Directory.Exists(dataPath))
					Directory.CreateDirectory(dataPath);

				//copy static resources to static folder
				if (File.Exists(fileToCopy))
				{
					File.Copy(fileToCopy, Path.Combine(staticPath, logo), true);
				}
				//CurrentUserModel.CustomAppLogo = Path.Combine(staticPath, logo);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		public static string SaveJsonFilterList(IList<InitDataModelExtended> filterList)
		{
			var json = new List<InitDataModelExtended>();

			// Write MemberType List from listbox to json array
			foreach (var filter in filterList)
			{
				json.Add(new InitDataModelExtended
				{
					Name = filter.Name,
					Value = filter.Value,
					ValuesList = filter.ValuesList
				});
			}

			string jsonString = JsonConvert.SerializeObject(json, Formatting.None,
				new JsonSerializerSettings
					{ NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented });

			return jsonString;
		}

		public static IList<InitDataModelExtended> ReadJsonFilterList(string filterList)
		{
			var filterDataList = new List<InitDataModelExtended>();
			var jsonList = JsonConvert.DeserializeObject<IList<InitDataModelExtended>>(filterList);

			//if (jsonList != null)
			//{
			//    foreach (var json in jsonList)
			//    {
			//        jsonList.Add(new InitDataModel{Name = json.Name, Value = json.Value});
			//    }
			//}
			return jsonList;
		}

		public static PortType SelectPortType(int departmentId)
		{
			PortType returnValue = 0;

			switch (departmentId)
			{
				case 2: // AIR EXPORT
					returnValue = PortType.Airport;
					break;

				case 5: //AIR IMPORT
					returnValue = PortType.Airport;
					break;

				case 6: //LAND FREIGHT
					returnValue = PortType.LandBorder;
					break;

				case 8: //AIR CLEARANCE
					returnValue = PortType.Airport;
					break;

				case 16: //SEA IMPORT
					returnValue = PortType.Seaport;
					break;

				case 17: //SEA CLEARANCE
					returnValue = PortType.Seaport;
					break;

				case 18: //SEA EXPORT
					returnValue = PortType.Seaport;
					break;

				case 24: //WAREHOUSE
					returnValue = PortType.Seaport;
					break;

				case 27: //SEA CROSS
					returnValue = PortType.Seaport;
					break;

				default:
					break;

			}

			return returnValue;
		}

		#region Assembly Attribute Accessors

		public static string AssemblyTitle
		{
			get
			{
				// Get all Title attributes on this assembly
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				// If there is at least one Title attribute
				if (attributes.Length > 0)
				{
					// Select the first one
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					// If it is not an empty string, return it
					if (titleAttribute.Title != "")
						return titleAttribute.Title;
				}

				// If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
				return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public static string AssemblyVersion
		{
			get
			{
				//return Assembly.GetExecutingAssembly().GetName().Version.ToString();   //get assembly version

				System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
				System.Diagnostics.FileVersionInfo fvi =
					System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
				string version = fvi.FileVersion; // get file version

				return version;
			}
		}

		public static string AssemblyDescription
		{
			get
			{
				// Get all Description attributes on this assembly
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				// If there aren't any Description attributes, return an empty string
				if (attributes.Length == 0)
					return "";
				// If there is a Description attribute, return its value
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public static string AssemblyProduct
		{
			get
			{
				// Get all Product attributes on this assembly
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				// If there aren't any Product attributes, return an empty string
				if (attributes.Length == 0)
					return "";
				// If there is a Product attribute, return its value
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public static string AssemblyCopyright
		{
			get
			{
				// Get all Copyright attributes on this assembly
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				// If there aren't any Copyright attributes, return an empty string
				if (attributes.Length == 0)
					return "";
				// If there is a Copyright attribute, return its value
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public static string AssemblyCompany
		{
			get
			{
				// Get all Company attributes on this assembly
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				// If there aren't any Company attributes, return an empty string
				if (attributes.Length == 0)
					return "";
				// If there is a Company attribute, return its value
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}

		#endregion

		public static void NotifyByEmail(string subject, string body)
		{
			try
			{
				NoReplyMailMessage noReply = new NoReplyMailMessage();

				noReply.SendEmail(new NoReplyMailModel
				{
					MailFrom = "noreply@xolog.com",
					MailDisplayNameFrom = "no-reply",
					MailTo = "audit@xolog.com",
					MailDisplayNameTo = "Audit",
					MailSubject = subject,
					MailBody = body,
					MailOutgoingPort = 587,
					MailHost = "mail.xolog.com",
					MailUserName = "noreply@xolog.com",
					MailPassword = "Parallax#16"
				});
			}
			catch (Exception exception)
			{
				SafeShowMessageBox(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public static void SaveCustomFilter(string filterName, string jSonToString)
		{
			try
			{
				if (jSonToString == "")
				{
					throw new Exception(
						"Error while saving content filter. \nPlease contact your system administrator!");
				}

				string filePath = Path.Combine(Path.GetTempPath(), filterName) + ".json";

				if (File.Exists(filePath))
				{
					File.SetAttributes(filePath, FileAttributes.Normal);
					File.Delete(filePath);
				}

				File.WriteAllText(filePath, jSonToString);

				File.SetAttributes(filePath, FileAttributes.Hidden);
				//File.Delete(filePath);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public static void DeleteCustomFilter(string filterName)
		{
			try
			{
				string filePath = Path.Combine(Path.GetTempPath(), filterName) + ".json";
				//File.SetAttributes(filePath, FileAttributes.Normal);
				File.Delete(filePath);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		public class DetailControlTypeFormatter : IFormatProvider, ICustomFormatter
		{
			public object GetFormat(System.Type formatType)
			{
				if (formatType == typeof(ICustomFormatter))
					return this;
				else
					return null;
			}

			public string Format(string format, object arg, IFormatProvider formatProvider)
			{
				if (arg == null) return String.Empty;
				EnumDebCred value = (EnumDebCred)arg;

				switch (value)
				{
					case EnumDebCred.D:
						return "Debit";
					case EnumDebCred.C:
						return "Credit";
				}

				return string.Empty;
			}

			public enum WorkingYearPeriod
			{
				Year2016 = 2016,
				Year2017 = 2017,
				Year2018 = 2018,
				Year2019 = 2019,
				Year2020 = 2020,
				Year2021 = 2021,
				Year2022 = 2022,
				Year2023 = 2023,
				Year2024 = 2024,
				Year2025 = 2025,
				//Year2026 = 2026,
				//Year2027 = 2027,
				//Year2028 = 2028,
				//Year2029 = 2029,
				//Year2030 = 2030,
			}

			public enum BalanceSheetDisplayResult
			{
				All,
				Assets,
				Liabilities
			}

			public enum IncomeStatementDisplayResult
			{
				All,
				Expenditures,
				Income
			}
		}
	}

	// ... handler implementations ...
	public static class DateHelper
	{
		public static DateTime? GetNullableDate(object editValue)
		{
			return DateTime.TryParse(editValue?.ToString(), out var date) ? date : (DateTime?)null;
		}
	}

	public static class ErrorHandler
	{
		//Error
		public static void ShowError(string message)
		{
			HelperApplication.SafeShowMessageBox(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		//Question
		public static void ShowQuestion(string message)
		{
			HelperApplication.SafeShowMessageBox(message, "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		//Exclamation
		public static void ShowExclamation(string message)
		{
			HelperApplication.SafeShowMessageBox(message, "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		//Information
		public static void ShowInformation(string message)
		{
			HelperApplication.SafeShowMessageBox(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	// Define extension method
	public static class StringExtensions
	{
		public static string LimitTo(this string text, int maxLength)
		{
			return text.Length > maxLength ? text.Substring(0, maxLength) : text;
		}
	}

}
