using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.DataAccess;
using MISLiveMed.Models.Models.Administration.Connections;

namespace MISLiveMed.UI.Main.Administration.Configuration
{
	public partial class SuperAdminConnectionForm : XtraForm
	{
		ConnectionModel _connectionModel = new ConnectionModel();

		public SuperAdminConnectionForm()
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

		}

		private void WireUpBindings()
		{
			txtProjectId.Text = _connectionModel.FirebaseProjectId;
			txtFirebaseConnectionString.Text = _connectionModel.FirebaseConfigString;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateCanSave()) return;

			try
			{
				_connectionModel.FirebaseProjectId = txtProjectId.Text;
				_connectionModel.FirebaseConfigString = txtFirebaseConnectionString.Text;

				DatabaseFactory.ConnectionParamsSet(_connectionModel);

				//if (!ValidateConnection()) return;

				MessageBox.Show(@"Please restart your application to apply the new settings.",
					@"DB Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);

				DialogResult = DialogResult.OK;
			}
			catch (Exception exception)
			{
				DialogResult = DialogResult.No;
			}
			Application.Exit();
		}

		private bool ValidateCanSave()
		{

			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (txtProjectId.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Project Id cannot be empty.");
				validateReturnValue = false;
				txtProjectId.Focus();
			}

			if (txtFirebaseConnectionString.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Firebase Connection String cannot be empty.");
				validateReturnValue = false;
				txtFirebaseConnectionString.Focus();
			}

			if (!validateReturnValue)
			{
				validateMessage.Insert(0, "The following need your attention:");
				if (messageNumber > 1) validateMessage.Replace("following", "followings");
				MessageBox.Show(validateMessage + " \nPlease try again.",
					@"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return validateReturnValue;
		}

		//private bool ValidateConnection()
		//{
		//	try
		//	{
		//		FireStoreHelper.SetEnvironmentVariable();
		//		var db = FireStoreHelper.Database;

		//		return true;
		//	}
		//	catch (Exception e)
		//	{
		//		MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//		return false;
		//	}
		//}

	}
}