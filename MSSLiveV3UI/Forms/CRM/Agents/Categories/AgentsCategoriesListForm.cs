using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.CRM.Agents.Categories
{
    public partial class AgentsCategoriesListForm : RibbonForm, IFormWithRibbon
    {
	    private const string _formName = "AgentsCategoriesList";
	    private int _formId;
	    private bool _resetMenu;

	    private AgentCategoryModel _agentCategoryModel = new AgentCategoryModel();
	    private IEnumerable<AgentCategoryModel> _agentsCategories = new List<AgentCategoryModel>();

	    private AgentCategoryRepository _agentCategoryRepository = new AgentCategoryRepository();

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

		public RibbonControl MainRibbon => rcAgentsCategories;
        public RibbonPage DefaultPage => rpAgentsCategories;


        #endregion

        public AgentsCategoriesListForm()
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

				_agentsCategories = _agentCategoryRepository.SelectAgentCategories();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

        private void WireUpBindings()
        {
	        bsAgentsCategories.DataSource = _agentsCategories;

	        gcAgentsCategories.DataSource = null;
	        gcAgentsCategories.DataSource = bsAgentsCategories;
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
	        LayoutsStyle.LoadLayoutGrid(gvAgentsCategories, CurrentUser.UserName);
		}

		#region Buttons Events

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new AgentCategoryEditForm(new AgentCategoryModel());
            frm.SendUpdatedAgentCategory += RcvUpdatedAgentCategory;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_agentsCategories.Any()) return;

            int currentRowId = (int)gvAgentsCategories.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _agentCategoryModel = _agentsCategories.SingleOrDefault(x => x.Id == currentRowId);
            if (_agentCategoryModel == null) return;

            var frm = new AgentCategoryEditForm(_agentCategoryModel);
            frm.SendUpdatedAgentCategory += RcvUpdatedAgentCategory;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcAgentsCategories.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                int.TryParse(gvAgentsCategories.GetFocusedRowCellValue("Id").ToString(), out int id);
                string name = gvAgentsCategories.GetFocusedRowCellValue("Name").ToString();

                if (id > 0)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete Agent Category: `{name}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _agentCategoryModel = gvAgentsCategories.GetFocusedRow() as AgentCategoryModel;
                        if (_agentCategoryModel == null)
                        {
                            return;
                        }
                        _agentCategoryModel.Deleted = true;

                        //delete the record
                        if (!_agentCategoryRepository.DeleteAgentCategory(id))
                        {
                            throw new Exception(
                                "Error while deleting, please try again or contact your system administrator.");
                        }
                        RcvUpdatedAgentCategory(_agentCategoryModel, EventArgs.Empty);
                    }
                }

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsrAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new AboutForm();
            frm.ShowDialog();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private bool CanDelete()
        {
            AgentCategoryModel dataBoundItem = gvAgentsCategories.GetFocusedRow() as AgentCategoryModel;

            if (gvAgentsCategories == null || gvAgentsCategories.SelectedRowsCount == 0) return false;
            if (gvAgentsCategories.SelectedRowsCount > 1)
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

        private void RcvUpdatedAgentCategory(object sender, EventArgs e)
        {
            if (sender == null) return;
            _agentCategoryModel = sender as AgentCategoryModel;

            if (_agentCategoryModel.LastModifiedDate == null || _agentCategoryModel.Deleted)
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvAgentsCategories.UpdateCurrentRow();
            }
        }

        private void gvAgentsCategories_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool isActive = (bool)view.GetRowCellValue(e.RowHandle, "Active");
                bool isDefault = (bool)view.GetRowCellValue(e.RowHandle, "IsDefault");
                if (!isActive)
                {
                    e.Appearance.ForeColor = isActive ? Color.Black : Color.Gray;
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
                }
                if (isDefault)
                {
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
                }
            }
        }

        private void gcAgentsCategories_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (!_agentsCategories.Any()) return;

            int currentRowId = (int)gvAgentsCategories.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _agentCategoryModel = _agentsCategories.SingleOrDefault(x => x.Id == currentRowId);
            if (_agentCategoryModel == null) return;

            var frm = new AgentCategoryEditForm(_agentCategoryModel);
            frm.SendUpdatedAgentCategory += RcvUpdatedAgentCategory;
            frm.ShowDialog();
        }

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvAgentsCategories, CurrentUser.UserName);
			}
		}

		private void AgentsCategoriesListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvAgentsCategories, CurrentUser.UserName);
			}
		}
	}
}