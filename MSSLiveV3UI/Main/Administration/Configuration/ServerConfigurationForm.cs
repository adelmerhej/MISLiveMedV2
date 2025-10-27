using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.Logging;
using MISLiveMed.DataLayers.DataAccess;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Administration.Connections;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Properties;
using MISLiveMed.Utils.Common;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Main.Administration.Configuration
{
    public partial class ServerConfigurationForm : XtraForm
	{
		private const string _formName = "ServerConfiguration";
		private int _formId;

		private IList<UserModel> _users = new List<UserModel>();
		private ConnectionModel _connectionModel = new ConnectionModel();

		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly UserRepository _userRepository = new UserRepository();

		public ServerConfigurationForm()
        {
            InitializeComponent();

            ConnectionParams();
            InitializeBindings();
            WireUpBindings();
        }
        private void ConnectionParams()
        {
            _connectionModel = DatabaseFactory.ConnectionParamsGet();
        }

        private void InitializeBindings()
        {
	        try
	        {
		        _users = _userRepository.SelectUsers();
			}
			catch (Exception e)
	        {
		        Console.WriteLine(e);
	        }

			List<InitDataObjectModel> initDataObjectModelList1 = new List<InitDataObjectModel>();
            initDataObjectModelList1.Add(new InitDataObjectModel
            {
                Name = "Fatal",
                Value = LogLevel.Critical.ToString()
            });
            initDataObjectModelList1.Add(new InitDataObjectModel()
            {
                Name = "Error",
                Value = LogLevel.Error.ToString()
            });
            initDataObjectModelList1.Add(new InitDataObjectModel()
            {
                Name = "Warning",
                Value = LogLevel.Warning.ToString()
            });
            initDataObjectModelList1.Add(new InitDataObjectModel()
            {
                Name = "Info",
                Value = LogLevel.Information.ToString()
            });
            initDataObjectModelList1.Add(new InitDataObjectModel()
            {
                Name = "Debug",
                Value = LogLevel.Debug.ToString()
            });
            initDataObjectModelList1.Add(new InitDataObjectModel()
            {
                Name = "Trace",
                Value = LogLevel.Trace.ToString()
            });
            initDataObjectModelList1.Add(new InitDataObjectModel()
            {
                Name = "Off",
                Value = LogLevel.None.ToString()
            });
            cboLevelFile.Properties.DataSource = initDataObjectModelList1;
            cboLevelFile.Properties.DisplayMember = "Name";
            cboLevelFile.Properties.ValueMember = "Value";
            //cboLevelFile.EditValue = Settings.Default.LevelAppLog;

            cboLevelNHibernate.Properties.DataSource = initDataObjectModelList1;
            cboLevelNHibernate.Properties.DisplayMember = "Name";
            cboLevelNHibernate.Properties.ValueMember = "Value";
            //cboLevelNHibernate.EditValue = Settings.Default.LevelNHibernateLog;

            //Get Database Type info
            List<InitDataObjectModel> initDataObjectModelList2 = new List<InitDataObjectModel>();
            initDataObjectModelList2.Add(new InitDataObjectModel()
            {
                Name = "MySql",
                Value = DatabaseTypes.MySql
			});
            initDataObjectModelList2.Add(new InitDataObjectModel()
            {
                Name = "SqlServer",
                Value = DatabaseTypes.SqlServer
			});
            initDataObjectModelList2.Add(new InitDataObjectModel()
            {
                Name = "SqLite",
                Value = DatabaseTypes.SqLite
			});
            cboDatabaseType.Properties.DisplayMember = "Name";
            cboDatabaseType.Properties.ValueMember = "Name";
            cboDatabaseType.Properties.DataSource = initDataObjectModelList2;
            //cboDatabaseType.EditValue = Settings.Default.DatabaseType;
        }

        private void WireUpBindings()
        {
            cboDatabaseType.EditValue = _connectionModel.DatabaseType;
            txtDatabaseHost.Text = _connectionModel.DatabaseHost;
            txtDatabasePort.Text = _connectionModel.DatabasePort.ToString();
            txtDatabaseName.Text = _connectionModel.DatabaseName;
            txtUserName.Text = _connectionModel.DatabaseUser;
            txtPassword.Text = _connectionModel.DatabasePassword;
		}
        private void btnLogConfiguration_Click(object sender, EventArgs e)
		{
			try
			{
				if (CurrentUser.UserName.ToLower() == "admin")
				{
					var result = XtraInputBox.Show("Enter your password:", "Change Settings", "Default");
					var superAdminPassword = _userRepository.AuthenticateSuperAdmin(CurrentUser.UserName.ToLower());

					if (superAdminPassword != null)
					{

						SystemUtilities.PasswordHasher = new PasswordHasher();
						var passwordVerificationResult =
							SystemUtilities.PasswordHasher.VerifyHashedPassword(superAdminPassword.PasswordHash, result);

						switch (passwordVerificationResult)
						{
							case PasswordVerificationResult.Failed:
								MessageBox.Show(@"Username or Password are incorrect! Please try again.", @"Error",
									MessageBoxButtons.OK, MessageBoxIcon.Error);

								break;

							case PasswordVerificationResult.Success:
								SuperAdminConnectionForm frm = new SuperAdminConnectionForm();
								frm.ShowDialog();

								return;

							case PasswordVerificationResult.SuccessRehashNeeded:

								break;
						}
					}
				}

				if (!infoPanel.Visible)
				{
					databasePanel.Visible = false;
					infoPanel.Visible = true;
					btnLogConfiguration.Image = Resources.left_arrow_16_light;
				}
				else
				{
					infoPanel.Visible = false;
					databasePanel.Visible = true;
					btnLogConfiguration.Image = Resources.file_16_light;
				}
			}
			catch (Exception exception)
			{
				switch (exception.Message)
				{
					case "EmptyString":
						if (XtraMessageBox.Show("Error in configuration." + "\nWould you like to open configuration settings?",
						@"Error", MessageBoxButtons.YesNo,
								MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

						SuperAdminConnectionForm frm = new SuperAdminConnectionForm();
						frm.ShowDialog();
						break;

					default:
						XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _connectionModel.DatabaseType = (string)cboDatabaseType.EditValue;
                _connectionModel.DatabaseHost = txtDatabaseHost.Text.Trim();
                int.TryParse(txtDatabasePort.Text, out var result);
                _connectionModel.DatabasePort = result;
                _connectionModel.DatabaseName = txtDatabaseName.Text.Trim();
                _connectionModel.DatabaseUser = txtUserName.Text;
                _connectionModel.DatabasePassword = txtPassword.Text;

                _connectionModel.LevelAppLog = (string)cboLevelFile.EditValue;
                _connectionModel.LevelSqlLog = (string)cboLevelNHibernate.EditValue;

                DatabaseFactory.ConnectionParamsSet(_connectionModel);

                XtraMessageBox.Show("Please restart your application to apply the new settings.",
                    "DB Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                DialogResult = DialogResult.Cancel;
            }
		}
	}
}