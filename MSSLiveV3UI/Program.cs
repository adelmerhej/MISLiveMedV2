using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils.Taskbar;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MISLiveMed.UI.Forms.Users;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Properties;
using MISLiveMed.UI.Utilities;

namespace MISLiveMed.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set up global exception handlers before any UI operations
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            switch (SystemInformation.TerminalServerSession)
            {
                case false when Screen.AllScreens.Length > 1:
                    WindowsFormsSettings.SetPerMonitorDpiAware();
                    break;
                default:
                    WindowsFormsSettings.SetDPIAware();
                    break;
            }

            // check if another instance is running
            string appGuid =
	            ((GuidAttribute)
		            Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0))
	            .Value;


            Mutex mutex = new Mutex(true, $"{{{appGuid}}}");
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
	            DevExpress.UserSkins.BonusSkins.Register();
	            TaskbarAssistant.Default.Initialize();
	            //HelperApplication.InitDefaultStyle();
	            Application.EnableVisualStyles();
	            Application.SetCompatibleTextRenderingDefault(false);

				try
                {
                    if (LoadingProcess())
                    {
                        using (LoginForm usr = new LoginForm())
                        {
                            if (usr.ShowDialog() == DialogResult.No)
                            {
                                //throw new Exception("User action - Exit from main program");
                                Application.Exit();
                                return;
                            }
                        }
                        Thread.CurrentThread.Name = "ThreadMain";
                        Application.Run(new MainForm());
                    }
                }
                catch (Exception ex)
                {
                    SafeShowMessageBox(string.Concat("Program Main Error: ", ex.Message,
                        Environment.NewLine, "StackTrace: ",
                        ex.StackTrace), "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                SafeShowMessageBox("Another process is already running." + Environment.NewLine + "Exiting...",
                    "MultiProcesses off.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private static bool LoadingProcess()
        {
            int varSleep = 0;
            var returnValue = false;
			try
            {
                // Show a splashScreen.
                FluentSplashScreenOptions op = new FluentSplashScreenOptions();
                op.Title = "When Only The Best Will Do";
                op.Subtitle = Settings.Default.ApplicationName; //"Exceptional Operations Logistics SAL";
                op.RightFooter = "Starting...";
                op.LeftFooter = "Copyright © " + DateTime.Now.Year.ToString() + " " + Settings.Default.CompanyName +

								Environment.NewLine + " All Rights reserved.";
                op.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
                op.OpacityColor = Color.FromArgb(16, 110, 190);
                op.Opacity = 130;

                SplashScreenManager.ShowFluentSplashScreen(op, useFadeIn: true, useFadeOut: true);

                //Check Database connection
                op.RightFooter = "Check Database Connection...";
                SplashScreenManager.Default.SendCommand(FluentSplashScreenCommand.UpdateOptions, op);
                if (HelperApplication.CheckDatabaseConnection()) returnValue = true;
                Thread.Sleep(varSleep);

                //Apply default configuration
                op.RightFooter = "Apply default settings...";
                SplashScreenManager.Default.SendCommand(FluentSplashScreenCommand.UpdateOptions, op);
                HelperApplication.ApplyDefaultSettings();
                Thread.Sleep(varSleep);

                //Apply default Style
                op.RightFooter = "Load Init Default Style...";
                SplashScreenManager.Default.SendCommand(FluentSplashScreenCommand.UpdateOptions, op);
                //HelperApplication.InitDefaultStyle();
                Thread.Sleep(varSleep);

				//Check Database structure and Database connection
				op.RightFooter = "Finishing...";
                SplashScreenManager.Default.SendCommand(FluentSplashScreenCommand.UpdateOptions, op);
                //HelperApplication.LoadDefaultSettings();
                Thread.Sleep(varSleep);
            }
			catch (Exception e)
            {
                SafeShowMessageBox(@"Initialize Data Error", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NotificationException(e);
                returnValue = false;
			}
            finally
            {
                //_logger.Info("Application started.");
                //Close the splashScreen
                try
                {
                    SplashScreenManager.CloseForm();
                }
                catch (Exception ex)
                {
                    // Ignore splash screen close errors to prevent cascading exceptions
                    System.Diagnostics.Debug.WriteLine($"Error closing splash screen: {ex.Message}");
                }
            }

            return returnValue;
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            SafeShowMessageBox(e.Exception.Message, @"Unhandled Thread Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            NotificationException(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = e.ExceptionObject as Exception;
            SafeShowMessageBox(exception?.Message ?? "Unknown error occurred", @"Unhandled UI Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            NotificationException(exception);
        }

        private static void NotificationException(Exception e)
        {
            if (e == null) return;

            (new Thread(() =>
            {
                try
                {
                    //_logger.Error(string.Concat("Program Main Error: ", e.Message, 
                    //    Environment.NewLine, "StackTrace: ", e.StackTrace));
                }
                catch (Exception)
                {
                    // ignored
                }
            })).Start();
        }

        /// <summary>
        /// Thread-safe method to show message boxes that can be called from any thread
        /// </summary>
        private static void SafeShowMessageBox(string message, string caption = "Error", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            try
            {
                if (Application.OpenForms.Count > 0 && Application.OpenForms[0] != null)
                {
                    var mainForm = Application.OpenForms[0];
                    if (mainForm.InvokeRequired)
                    {
                        mainForm.Invoke(new Action(() =>
                        {
                            XtraMessageBox.Show(message, caption, buttons, icon);
                        }));
                    }
                    else
                    {
                        XtraMessageBox.Show(message, caption, buttons, icon);
                    }
                }
                else
                {
                    // Fallback to standard MessageBox if no forms are available
                    MessageBox.Show(message, caption, buttons, icon);
                }
            }
            catch (Exception ex)
            {
                // Last resort: use standard MessageBox
                try
                {
                    MessageBox.Show($@"Error displaying message: {ex.Message}
										Original message: {message}", 
                        @"Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    // If even this fails, write to debug output
                    System.Diagnostics.Debug.WriteLine($"Critical error: {ex.Message}, Original: {message}");
                }
            }
        }
    }
}
