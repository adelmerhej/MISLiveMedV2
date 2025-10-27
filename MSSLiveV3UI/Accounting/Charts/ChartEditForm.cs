using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Accounting.Charts;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Charts;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Accounting.Charts
{
    public partial class ChartEditForm : XtraForm
    {
	    private const string _formName = "ChartEdit";
	    private int _formId;

	    private DataEntityState _objState = DataEntityState.Unchanged;

	    private ChartModel _chartModel = new ChartModel();
	    private IList<ChartDetailModel> _chartDetails = new List<ChartDetailModel>();
		private IList<TypeDataModel> _typeModel = new List<TypeDataModel>();
		private IList<CurrencyModel> _currencies = new List<CurrencyModel>();

	    private readonly ChartRepository _chartRepository = new ChartRepository();
	    private readonly ChartDetailRepository _chartDetailRepository = new ChartDetailRepository();
	    private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
	    private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
	    private readonly FormRepository _formRepository = new FormRepository();
	    private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

	    //init permission variables
	    private bool _canEdit;
	    private bool _isAdmin;
	    private bool _isProtected;

		public EventHandler SendUpdatedChartAccount;

		public ChartEditForm(ChartModel model)
        {
	        InitializeComponent();

	        try
	        {
		        _chartModel = model;

		        InitializeBindings();
		        WireUpBindings();
		        ApplyDefaults();
		        ApplyPermissions();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}
        private void InitializeBindings()
        {
	        try
			{
				//
				_formId = _formRepository.SelectFormByName(_formName);
				_userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId);
				if (_userPermission != null && _userPermission.Count > 0)
				{
					var isProtected = _userPermission.SingleOrDefault(x => x.ControlName == "IsProtected")?.Value;
					if (isProtected != null) _isProtected = (bool)isProtected;
				}
				//


				_chartDetails = _chartDetailRepository.SelectChartDetails(_chartModel.Id);
				_currencies = _currencyRepository.SelectCurrencies();

				foreach (var item in Enum.GetValues(typeof(ChartType)))
		        {
			        _typeModel.Add(new TypeDataModel{Id = item.GetHashCode(), Type = item.ToString() });
		        }
			}
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
	        bsChart.DataSource = _chartModel;
	        bsChartDetail.DataSource = _chartDetails;

	        cboAccountType.Properties.DataSource = null;
	        cboAccountType.Properties.DataSource = _typeModel;

	        repCurrencies.DataSource = null;
	        repCurrencies.DataSource = _currencies;

	        if (_chartModel != null) cboAccountType.Text = _chartModel.ChartType;
		}

        private void ApplyDefaults()
        {
	        txtNumber.Focus();
	        if (_chartModel.Id == 0) cboAccountType.ItemIndex = 1;
        }

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
	        if (canEdit != null) _canEdit = (bool)canEdit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

			txtNumber.ReadOnly = !_isAdmin || !_canEdit;
	        txtSerial.ReadOnly = !_isAdmin || !_canEdit;
	        txtAccountName.ReadOnly = !_isAdmin || !_canEdit;
	        cboAccountType.ReadOnly = !_isAdmin || !_canEdit;
	        txtNotes.ReadOnly = !_isAdmin || !_canEdit;

	        chkProtected.Enabled = _isAdmin;
	        chkProtected.Visible = _isAdmin;
	        chkLocked.Enabled = _isAdmin || _canEdit;
	        chkActive.Enabled = _isAdmin || _canEdit;
	        btnSave.Enabled = _isAdmin || _canEdit;
		}

        #region Buttons Event

        private void btnCancel_Click(object sender, EventArgs e)
        {
	        Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
	        if (!ValidateData()) return;

	        try
	        {
		        BindingContext[bsChart].EndCurrentEdit();
		        _chartModel = bsChart.Current as ChartModel;
		        if (_chartModel == null) return;

		        _chartModel.Serial = txtSerial.Text.PadLeft(5, '0');
		        if (_chartModel.Id == 0)
		        {
			        _logInfoRepository.CreateLogInfo(_chartModel);
			        txtId.Text = _chartRepository.AddNewChart(_chartModel).ToString();
		        }
		        else
		        {
			        _logInfoRepository.UpdateLogInfo(_chartModel);
			        _chartRepository.UpdateChart(_chartModel);
		        }

		        SendUpdatedChartAccount(_chartModel, EventArgs.Empty);

		        _objState = DataEntityState.Unchanged;
		        Close();
	        }
	        catch (Exception exception)
	        {
		        XtraMessageBox.Show(exception.Message,
			        "On Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

		#endregion
		private bool ValidateData()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (txtNumber.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Number cannot be empty.");
				validateReturnValue = false;
				txtNumber.Focus();
			}

			if (txtAccountName.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Account Name cannot be empty.");
				validateReturnValue = false;
				txtAccountName.Focus();
			}

			if (cboAccountType.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Account Type cannot be empty.");
				validateReturnValue = false;
				cboAccountType.Focus();
			}

			if (_chartRepository.ValidateAccountNumber(txtNumber.Text, txtSerial.Text) && _chartModel.Id == 0)
			{
				validateMessage.Append("\n- Account Number Already Exists.");
				validateReturnValue = false;
				txtAccountNumber.Focus();
			}

			ChartModel model = _chartRepository.ValidateAccountName(txtAccountName.Text);
			if (model != null && model.Serial != _chartModel.Serial)
			{
				validateMessage.Append($"\n- Account Name Exists under ` {model.Number} {model.Serial} ` Are you sure you want to continue?");

				if (XtraMessageBox.Show($"Account Name Exists under ` {model.Number} {model.Serial} ` Are you sure you want to continue?",
					    "Name exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					    MessageBoxDefaultButton.Button2) == DialogResult.No)

					validateReturnValue = false;
				txtAccountName.Focus();
			}

			if (!validateReturnValue)
			{
				validateMessage.Insert(0, "The following need your attention:");
				if (messageNumber > 1) validateMessage.Replace("following", "followings");
				XtraMessageBox.Show(validateMessage + " \nPlease try again.",
					"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return validateReturnValue;
		}

		private void ChartEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				if (XtraMessageBox.Show("There is unsaved data, are you sure you want to close and discard changes?",
					    "Unsaved data", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					    MessageBoxDefaultButton.Button2) == DialogResult.No)
					e.Cancel = true;
			}
		}

		private void cboAccountType_EditValueChanged(object sender, EventArgs e)
		{
			if(txtNumber.Text == "") return;

			if(cboAccountType.Text == "T")
			{
				txtSerial.Text = "";
				return;
			}

			if (_chartModel.Id == 0) NewSerial();
		}

		private void NewSerial()
		{
			if (txtNumber.Text.Trim().Length < 4 )
			{
				txtSerial.Text = "";
				return;
			}

			txtSerial.Text = _chartRepository.SelectChartsByNumber(txtNumber.Text);
		}

		private void txtNumber_Validated(object sender, EventArgs e)
		{
			if(_chartModel.Id == 0) NewSerial();
		}

		private void txtSerial_Validated(object sender, EventArgs e)
		{
			if (txtSerial.Text != "") txtSerial.Text = txtSerial.Text.PadLeft(5, '0');
		}
	}
}