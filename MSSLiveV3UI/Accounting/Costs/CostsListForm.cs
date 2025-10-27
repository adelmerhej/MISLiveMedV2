using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Accounting.Costs;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.CostSheets;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Costs
{
    public partial class CostsListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "CostsList";
		private int _formId;
		private bool _resetMenu;

		private CostModel _costModel = new CostModel();
		private IList<CostModel> _costs = new List<CostModel>();

		private readonly CostRepository _costRepository = new CostRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();

		//Init permission variables
		private bool _canAdd;
		private bool _canEdit;
		private bool _canDelete;
		private bool _canPrint;
		private bool _isAdmin;
		private bool _isProtected;

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcCosts;
        public RibbonPage DefaultPage => rpCosts;


		#endregion

		public CostsListForm()
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

				_costs = _costRepository.SelectCosts();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			gcCosts.DataSource = null;
			gcCosts.DataSource = _costs;
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
			LayoutsStyle.LoadLayoutGrid(gvCosts, CurrentUser.UserName);
		}
		

		#region Buttons Event

		private void btnNew_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void btnEdit_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPrint_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void btnClose_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Close();
        }

		#endregion


		#region Grid Events
		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvCosts, CurrentUser.UserName);
			}
		}

		private void CostsListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvCosts, CurrentUser.UserName);
			}
		}

		#endregion

		private void gcCosts_DoubleClick(object sender, EventArgs e)
		{
			if (!_isAdmin && !_canEdit) return;


		}
	}
}