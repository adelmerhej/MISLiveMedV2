using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Accounting.CreditNotes
{
    public partial class CreditNotesEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private const string _formName = "CreditNotesEdit";
		private int _formId;
		private bool _resetMenu;

		DXMenuItem[] _menuItems;

		private DataEntityState _objState = DataEntityState.Unchanged;

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();
		private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

		//Init permissionvariables
		private bool _canAdd;
		private bool _canEdit;
		private bool _canDelete;
		private bool _canPrint;
		private bool _isAdmin;
		private bool _isProtected;

		public EventHandler SendUpdatedCreditNote;

		public CreditNotesEditForm()
		{
			InitializeComponent();

			try
			{
				//_continentModel = model;

				InitializeBindings();
				WireUpBindings();
				ApplyDefaults();
				ApplyPermissions();
				InitializeMenuItems();
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


			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			//bsContinent.DataSource = _continentModel;
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
			btnSave.Enabled = _isAdmin || _canEdit;
			btnSaveAndClose.Enabled = _isAdmin || _canEdit;
			btnRefresh.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;

			gvInvoiceDetails.OptionsView.NewItemRowPosition = _canAdd ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
			gvInvoiceDetails.OptionsBehavior.AllowAddRows = !_canAdd ? DefaultBoolean.True : DefaultBoolean.False; ;
			gvInvoiceDetails.OptionsBehavior.AllowDeleteRows = !_canDelete ? DefaultBoolean.True : DefaultBoolean.False;
		}

		private void ApplyDefaults()
		{

		}
		void InitializeMenuItems()
		{
			//DXMenuItem addNewBranch = new DXMenuItem("Edit", AddNewBranch_Click);
			//DXMenuItem editBranch = new DXMenuItem("Edit", EditBranch_Click);
			//DXMenuItem deleteBranch = new DXMenuItem("Delete", DeleteBranch_Click);
			//_menuItems = new[] { addNewBranch, editBranch, deleteBranch };
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}

		#endregion

	}
}