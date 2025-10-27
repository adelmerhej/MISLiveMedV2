using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Common.Countries
{
    public partial class RegionEditForm : XtraForm
    {
	    private const string _formName = "RegionEdit";
	    private int _formId;

	    private DataEntityState _objState = DataEntityState.Unchanged;

	    private RegionModel _regionModel = new RegionModel();
	    private ContinentModel _continentModel = new ContinentModel();
	    private IList<ContinentModel> _continents = new List<ContinentModel>();

	    private readonly RegionRepository _regionRepository = new RegionRepository();
	    private readonly ContinentRepository _continentRepository = new ContinentRepository();

	    /// <summary>
	    /// User Permission Role
	    /// </summary>
	    private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
	    private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
	    private readonly FormRepository _formRepository = new FormRepository();
	    private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

	    private bool _canEdit;
	    private bool _isAdmin;
	    private bool _isProtected;

		public EventHandler SendUpdatedRegion;

        public RegionEditForm(RegionModel model)
        {
            InitializeComponent();

            try
            {
	            _regionModel = model;

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

				_continents = _continentRepository.SelectContinents();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

        private void WireUpBindings()
        {
	        bsRegion.DataSource = _regionModel;

	        cboContinents.Properties.DataSource = null;
	        cboContinents.Properties.DataSource = _continents;
	        cboContinents.EditValue = _regionModel.ContinentId;
        }

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
	        if (canEdit != null) _canEdit = (bool)canEdit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

	        txtName.ReadOnly = !_isAdmin || !_canEdit;
	        txtNotes.ReadOnly = !_isAdmin || !_canEdit;

	        chkActive.Enabled = _isAdmin || _canEdit;
	        btnSave.Enabled = _isAdmin || _canEdit;
	        cboContinents.ReadOnly = !_isAdmin || !_canEdit;
		}
        private void ApplyDefaults()
        {
	        txtName.Focus();
        }

		#region Buttons Event
		 
		private void btnSave_Click(object sender, System.EventArgs e)
        {
	        if (!ValidateData()) return;

	        try
	        {
		        BindingContext[bsRegion].EndCurrentEdit();
		        _regionModel = bsRegion.Current as RegionModel;

		        if (_regionModel == null) return;

		        if (cboContinents.EditValue != null) _regionModel.ContinentId = (int)cboContinents.EditValue;

		        if (_regionModel.Id == 0)
		        {
			        _logInfoRepository.CreateLogInfo(_regionModel);
			        var newCityId = _regionRepository.AddNewRegion(_regionModel);
			        txtId.Text = newCityId.ToString();
		        }
		        else
		        {
			        _logInfoRepository.UpdateLogInfo(_regionModel);
			        _regionRepository.UpdateRegion(_regionModel);
		        }

		        SendUpdatedRegion(_regionModel, EventArgs.Empty);

		        _objState = DataEntityState.Unchanged;
		        Close();
	        }
	        catch (Exception exception)
	        {
		        XtraMessageBox.Show(exception.Message,
			        $"On Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion
        private bool ValidateData()
        {
            var validateReturnValue = true;
            var messageNumber = 0;
            var validateMessage = new StringBuilder();

            if (txtName.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Name cannot be empty.");
                validateReturnValue = false;
                txtName.Focus();
            }

            if (cboContinents.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Continent cannot be empty.");
                validateReturnValue = false;
                cboContinents.Focus();
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

        private void cboContinents_AddNewValue(object sender, AddNewValueEventArgs e)
        {
            ContinentEditForm frm = new ContinentEditForm(new ContinentModel());
            frm.SendUpdatedContinent += RcvUpdatedContinent;
            frm.ShowDialog();
        }

        private void RcvUpdatedContinent(object sender, EventArgs e)
        {
            if (sender == null) return;
            _continentModel = sender as ContinentModel;

            _continents.Add(_continentModel);

            cboContinents.Properties.DataSource = null;
            cboContinents.Properties.DataSource = _continents;
            if (_continentModel != null) cboContinents.EditValue = _continentModel.Id;
        }

		private void RegionEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}