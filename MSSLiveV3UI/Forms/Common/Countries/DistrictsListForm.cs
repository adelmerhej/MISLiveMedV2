using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.Common.Countries
{
    public partial class DistrictsListForm : RibbonForm, IFormWithRibbon
    {
	    private const string _formName = "DistrictsList";
	    private int _formId;
	    private bool _resetMenu;

		private DistrictModel _districtModel = new DistrictModel();
	    private IList<DistrictModel> _districts = new List<DistrictModel>();

	    private ProvinceModel _provinceModel = new ProvinceModel();
	    private IList<ProvinceModel> _provinces = new List<ProvinceModel>();
	    private IList<CountryModel> _countries = new List<CountryModel>();

	    private readonly DistrictRepository _districtRepository = new DistrictRepository();
	    private readonly ProvinceRepository _provinceRepository = new ProvinceRepository();
	    private readonly CountryRepository _countryRepository = new CountryRepository();

	    /// <summary>
	    /// User Permission Role
	    /// </summary>
	    private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
	    private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
	    private readonly FormRepository _formRepository = new FormRepository();

	    //Init permissionvariables
	    private bool _canAdd;
	    private bool _canEdit;
	    private bool _canDelete;
	    private bool _canPrint;
	    private bool _isAdmin;
	    private bool _isProtected;

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcDistricts;
        public RibbonPage DefaultPage => rpDistricts;


        #endregion

        public DistrictsListForm()
        {
            InitializeComponent();

            try
            {
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

				_districts = _districtRepository.SelectDistricts();
		        _provinces = _provinceRepository.SelectProvinces();
		        _countries = _countryRepository.SelectCountries();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }

        }

        private void WireUpBindings()
        {
	        bsDistricts.DataSource = _districts;

	        gcDistricts.DataSource = null;
	        gcDistricts.DataSource = bsDistricts;

	        repCountries.DataSource = null;
	        repCountries.DataSource = _countries;

	        repProvinces.DataSource = null;
	        repProvinces.DataSource = _provinces;
        }

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canAdd = _userPermission.SingleOrDefault(x => x.ControlName == "CanAdd")?.Value;
	        if (canAdd != null) _canAdd = (bool)canAdd;

	        var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
	        if (canEdit != null) _canEdit = (bool)canEdit;

	        var canDelete = _userPermission.SingleOrDefault(x => x.ControlName == "CanDelete")?.Value;
	        if (canDelete != null) _canDelete = (bool)canDelete;

	        var canPrint = _userPermission.SingleOrDefault(x => x.ControlName == "CanPrint")?.Value;
	        if (canPrint != null) _canPrint = (bool)canPrint;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

	        btnNew.Enabled = _isAdmin || _canAdd;
	        btnEdit.Enabled = _isAdmin || _canEdit;
	        btnPrint.Enabled = _isAdmin || _canPrint;
	        btnDelete.Enabled = _isAdmin || _canDelete;
		}

        private void ApplyDefaults()
        {
	        LayoutsStyle.LoadLayoutGrid(gvDistricts, CurrentUser.UserName, CurrentUser.CompanyName);
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DistrictEditForm frm = new DistrictEditForm(new DistrictModel());
            frm.SendUpdatedDistrict += RcvUpdatedDistrict;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_districts.Any()) return;

            int currentRowId = (int)gvDistricts.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _districtModel = _districts.SingleOrDefault(x => x.Id == currentRowId);
            if (_districtModel == null) return;

            var frm = new DistrictEditForm(_districtModel);
            frm.SendUpdatedDistrict += RcvUpdatedDistrict;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcDistricts.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                int.TryParse(gvDistricts.GetFocusedRowCellValue("Id").ToString(), out int id);
                string name = gvDistricts.GetFocusedRowCellValue("Name").ToString();

                if (id > 0)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete Districts: `{name}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _provinceModel = gvDistricts.GetFocusedRow() as ProvinceModel;
                        if (_provinceModel == null)
                        {
                            return;
                        }
                        _provinceModel.Deleted = true;

                        //delete the record
                        _provinceRepository.DeleteProvince(_provinceModel.Id);
                        RcvUpdatedDistrict(_provinceModel, EventArgs.Empty);
                    }
                }

            }
            catch (Exception exception)
            {
                switch (exception.Message)
                {
                    case "-2146233088":
                        XtraMessageBox.Show("This record is linked to one or more transactions, delete all links first.",
                            "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    default:
                        XtraMessageBox.Show(exception.Message,
                            "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion
        private void RcvUpdatedDistrict(object sender, EventArgs e)
        {
            if (sender == null) return;
            _districtModel = sender as DistrictModel;

            if (_districtModel != null && (_districtModel.LastModifiedDate == null || _districtModel.Deleted))
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvDistricts.UpdateCurrentRow();
            }
        }
        private bool CanDelete()
        {
            DistrictModel dataBoundItem = gvDistricts.GetFocusedRow() as DistrictModel;

            if (gvDistricts == null || gvDistricts.SelectedRowsCount == 0) return false;
            if (gvDistricts.SelectedRowsCount > 1)
            {
                XtraMessageBox.Show("Only one record can be selected at a time, please try again",
                    "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dataBoundItem != null && dataBoundItem.IsDefault)
            {
                XtraMessageBox.Show("Cannot delete system record!",
                    "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void gcDistricts_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

	        if (!_districts.Any()) return;

	        int currentRowId = (int)gvDistricts.GetFocusedRowCellValue("Id");
	        if (currentRowId == 0) return;

	        _districtModel = _districts.SingleOrDefault(x => x.Id == currentRowId);
	        if (_districtModel == null) return;

	        var frm = new DistrictEditForm(_districtModel);
	        frm.SendUpdatedDistrict += RcvUpdatedDistrict;
	        frm.ShowDialog();
        }

		private void gvDistricts_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool isActive = view != null && (bool)view.GetRowCellValue(e.RowHandle, "Active");
                bool isDefault = view != null && (bool)view.GetRowCellValue(e.RowHandle, "IsDefault");
                if (isDefault)
                {
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
                }
                if (!isActive)
                {
                    e.Appearance.ForeColor = Color.Gray;
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
                }
            }
        }

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvDistricts, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void DistrictsListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvDistricts, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}
	}
}