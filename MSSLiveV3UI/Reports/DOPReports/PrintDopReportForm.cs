using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Reports.DOPBalances;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Reports.DOPBalances;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.DOPReports;
using MISLiveMed.UI.Main;

namespace MISLiveMed.UI.Reports.DOPReports
{
    public partial class PrintDopReportForm : XtraForm
	{
		private const string _formName = "PrintDopReport";
		private int _formId;

        private UserRepository _userRepository = new UserRepository();
        private DopBalanceRepository _dopBalanceRepository = new DopBalanceRepository();

        /// <summary>
        /// User Permission Role
        /// </summary>
        private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

        private bool _canAccessProfit;
        private bool _isAdmin;
        private bool _isProtected;

		public PrintDopReportForm()
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

			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {

        }

        private void ApplyPermissions()
	    {
		    if (_userPermission == null) return;
		    if (_userPermission.Count <= 0) return;

		    var canAccessProfit = _userPermission.SingleOrDefault(x => x.ControlName == "CanAccessProfit")?.Value;
		    if (canAccessProfit != null) _canAccessProfit = (bool)canAccessProfit;

		    var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
		    if (isAdmin != null) _isAdmin = (bool)isAdmin;
		}

        private void ApplyDefaults()
        {
            rgSelection.SelectedIndex = 0;
            
            dtDateFrom.EditValue = DateTime.Parse("08/01/2016");
            dtDateTo.EditValue = DateTime.Now;

            chkSummary.EditValue = true;
            chkProvision.EditValue = true;
            chkByJob.EditValue = false;
        }

        #region Buttons Event

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            try
            {
                int pendingTime = 0; // the delay is 1 second (1000 ms)
                SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);

                IList<DopMemberModel> _dataReportModels = new List<DopMemberModel>();
                var previewForm = new DocumentViewerForm();

                bool provision = (bool)chkProvision.EditValue;
                bool displayByJob = (bool)chkByJob.EditValue;
                bool summary = (bool)chkSummary.EditValue;

                switch (rgSelection.SelectedIndex)
                {
                    case 0: //DOP Suppliers by name
                        if (chkByJob.CheckState == CheckState.Checked)
                        {

                        }
                        _dataReportModels = _dopBalanceRepository.DopSuppliersByName((DateTime?)dtDateFrom.EditValue,
                            (DateTime?)dtDateTo.EditValue, provision).ToList();
                        
                        var reportByNames = new DOPSuppliersbyNameSummary();
                        reportByNames.DataSource = _dataReportModels;

                        reportByNames.Parameters["pDateFrom"].Value = (DateTime?)dtDateFrom.EditValue;
                        reportByNames.Parameters["pDateTo"].Value = (DateTime?)dtDateTo.EditValue;

                        previewForm.Viewer.DocumentSource = reportByNames;
                        break;

                    case 1: //DOP Suppliers draft
                        _dataReportModels = _dopBalanceRepository.DopSuppliersByName((DateTime?)dtDateFrom.EditValue,
                            (DateTime?)dtDateTo.EditValue, provision).ToList();

                        var reportSuppliersDraft = new DOPSuppliersbyNameSummary();
                        reportSuppliersDraft.DataSource = _dataReportModels;

                        reportSuppliersDraft.Parameters["pDateFrom"].Value = (DateTime?)dtDateFrom.EditValue;
                        reportSuppliersDraft.Parameters["pDateTo"].Value = (DateTime?)dtDateTo.EditValue;
                        previewForm.Viewer.DocumentSource = reportSuppliersDraft;

                        break;

                    case 2: //DOP Suppliers profit
                        _dataReportModels = _dopBalanceRepository.DopSuppliersByName((DateTime?)dtDateFrom.EditValue,
                            (DateTime?)dtDateTo.EditValue, provision).ToList();

                        var reportSuppliersProfit = new DOPSuppliersbyNameSummary();
                        reportSuppliersProfit.DataSource = _dataReportModels;

                        //report.Parameters["isAdmin"].Value = _isAdmin && !chkOnlyNegative.Checked;
                        //report.Parameters["pShowReal"].Value = chkShowReal.Checked;
                        previewForm.Viewer.DocumentSource = reportSuppliersProfit;
                        break;

                    case 3: //DOP Customers by name
                        _dataReportModels = _dopBalanceRepository.DopCustomersByName((DateTime?)dtDateFrom.EditValue,
                            (DateTime?)dtDateTo.EditValue, provision).ToList();

                        var reportCustomersByName = new DOPSuppliersbyNameSummary();
                        reportCustomersByName.DataSource = _dataReportModels;

                        //report.Parameters["isAdmin"].Value = _isAdmin && !chkOnlyNegative.Checked;
                        //report.Parameters["pShowReal"].Value = chkShowReal.Checked;
                        previewForm.Viewer.DocumentSource = reportCustomersByName;
                        break;

                    case 4: //DOP Customers draft
                        _dataReportModels = _dopBalanceRepository.DopCustomersByName((DateTime?)dtDateFrom.EditValue,
                            (DateTime?)dtDateTo.EditValue, provision).ToList();

                        var reportCustomersDraft = new DOPSuppliersbyNameSummary();
                        reportCustomersDraft.DataSource = _dataReportModels;

                        //report.Parameters["isAdmin"].Value = _isAdmin && !chkOnlyNegative.Checked;
                        //report.Parameters["pShowReal"].Value = chkShowReal.Checked;
                        previewForm.Viewer.DocumentSource = reportCustomersDraft;
                        break;

                    case 5: //DOP Customers profit
                        _dataReportModels = _dopBalanceRepository.DopCustomersByName((DateTime?)dtDateFrom.EditValue,
                            (DateTime?)dtDateTo.EditValue, provision).ToList();

                        var reportCustomersProfit = new DOPSuppliersbyNameSummary();
                        reportCustomersProfit.DataSource = _dataReportModels;

                        //report.Parameters["isAdmin"].Value = _isAdmin && !chkOnlyNegative.Checked;
                        //report.Parameters["pShowReal"].Value = chkShowReal.Checked;
                        previewForm.Viewer.DocumentSource = reportCustomersProfit;
                        break;
                }
                
                previewForm.ShowDialog();

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Report Data Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion

    }
}