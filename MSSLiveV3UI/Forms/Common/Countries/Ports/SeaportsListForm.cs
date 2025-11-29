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
using MISLiveMed.DataLayers.Common.Countries.Ports;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.Common.Countries.Ports
{
    public partial class SeaportsListForm : RibbonForm, IFormWithRibbon
    {
	    private const string _formName = "SeaportsList";
	    private int _formId;
	    private bool _resetMenu;

		private PortModel _seaportModel = new PortModel();
	    private IList<PortModel> _seaports = new List<PortModel>();
	    private IList<CityModel> _cities = new List<CityModel>();
	    private IList<CountryModel> _countries = new List<CountryModel>();

	    private SeaportRepository _seaportRepository = new SeaportRepository();
	    private CityRepository _citiesRepository = new CityRepository();
	    private CountryRepository _countryRepository = new CountryRepository();

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

		public RibbonControl MainRibbon => rcSeaports;
        public RibbonPage DefaultPage => rpSeaports;


        #endregion

        public SeaportsListForm()
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

				_seaports = _seaportRepository.SelectSeaports();
		        _cities = _citiesRepository.SelectCities();
		        _countries = _countryRepository.SelectCountries();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

        private void WireUpBindings()
        {
	        bsSeaports.DataSource = _seaports;
	        gcSeaports.DataSource = null;
	        gcSeaports.DataSource = bsSeaports;

	        repCities.DataSource = null;
	        repCities.DataSource = _cities;

	        repCountries.DataSource = null;
	        repCountries.DataSource = _countries;

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
	        LayoutsStyle.LoadLayoutGrid(gvSeaports, CurrentUser.UserName, CurrentUser.CompanyName);
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            SeaportEditForm frm = new SeaportEditForm(new PortModel());
            frm.SendUpdatedSeaport += RcvUpdatedSeaport;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_seaports.Any()) return;

            int currentRowId = (int)gvSeaports.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _seaportModel = _seaports.SingleOrDefault(x => x.Id == currentRowId);
            if (_seaportModel == null) return;

            var frm = new SeaportEditForm(_seaportModel);
            frm.SendUpdatedSeaport += RcvUpdatedSeaport;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcSeaports.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                int.TryParse(gvSeaports.GetFocusedRowCellValue("Id").ToString(), out int id);
                string name = gvSeaports.GetFocusedRowCellValue("Name").ToString();

                if (id > 0)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete Seaport: `{name}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _seaportModel = gvSeaports.GetFocusedRow() as PortModel;
                        if (_seaportModel == null)
                        {
                            return;
                        }
                        _seaportModel.Deleted = true;

                        //delete the record
                        _seaportRepository.DeleteSeaport(_seaportModel.Id);
                        RcvUpdatedSeaport(_seaportModel, EventArgs.Empty);
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
        private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
        {
	        if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
		            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
	            DialogResult.Yes)
	        {
		        _resetMenu = true;
		        LayoutsStyle.ResetLayoutGrid(gvSeaports, CurrentUser.UserName, CurrentUser.CompanyName);
	        }
		}
        private void SeaportsListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
	        if (!_resetMenu)
	        {
		        LayoutsStyle.SaveLayoutGrid(gvSeaports, CurrentUser.UserName, CurrentUser.CompanyName);
	        }
        }

		#endregion

		private void RcvUpdatedSeaport(object sender, EventArgs e)
        {
            if (sender == null) return;
            _seaportModel = sender as PortModel;

            if (_seaportModel.LastModifiedDate == null || _seaportModel.Deleted)
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvSeaports.UpdateCurrentRow();
            }
        }

        private bool CanDelete()
        {
            PortModel dataBoundItem = gvSeaports.GetFocusedRow() as PortModel;

            if (gvSeaports == null || gvSeaports.SelectedRowsCount == 0) return false;
            if (gvSeaports.SelectedRowsCount > 1)
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

        private void gvSeaports_RowCellStyle(object sender, RowCellStyleEventArgs e)
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

		private void gcSeaports_DoubleClick(object sender, EventArgs e)
		{
			if (!_isAdmin && !_canEdit) return;

			if (!_seaports.Any()) return;

			int currentRowId = (int)gvSeaports.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_seaportModel = _seaports.SingleOrDefault(x => x.Id == currentRowId);
			if (_seaportModel == null) return;

			var frm = new SeaportEditForm(_seaportModel);
			frm.SendUpdatedSeaport += RcvUpdatedSeaport;
			frm.ShowDialog();
		}
	}
}