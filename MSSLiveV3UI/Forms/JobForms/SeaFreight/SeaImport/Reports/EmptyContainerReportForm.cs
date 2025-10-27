using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MISLiveMed.DataLayers.Common.Colors;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.JobData.SeaImport.Reports;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Common.Colors;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Reports;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Jobs.Jobs.SeaFreight.SeaImport;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Properties;
using MISLiveMed.UI.Reports;
using MISLiveMed.UI.Utilities;

namespace MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaImport.Reports
{
    public partial class EmptyContainerReportForm : XtraForm
	{
		private const string _formName = "EmptyContainerReport";
		private const string _filterName = "EmptyContainerReportForm";
		private int _formId;

        private IList<DepartmentModel> _departments = new List<DepartmentModel>();
        private IList<ColorModel> _colors = new List<ColorModel>();

        private readonly UserRepository _userRepository = new UserRepository();
        private readonly EmptyContainerReportRepository _emptyContainerReportRepository = new EmptyContainerReportRepository();
        private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
        private readonly ColorRepository _colorRepository = new ColorRepository();

        /// <summary>
        /// User Permission Role
        /// </summary>
        private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

        private bool _isAdmin;
        private bool _isProtected;

		public EmptyContainerReportForm()
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
				if (_userPermission is { Count: > 0 })
				{
					var isProtected = _userPermission.SingleOrDefault(x => x.ControlName == "IsProtected")?.Value;
					if (isProtected != null) _isProtected = (bool)isProtected;
				}
				//

				_departments = _departmentRepository.SelectDepartments();
				_colors = _colorRepository.SelectColors();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            chkDepartmentsList.DisplayMember = "DepartmentName";
            chkDepartmentsList.ValueMember = "Id";
            chkDepartmentsList.DataSource = _departments;
            
            cboColorPicker.Properties.DataSource = null;
            cboColorPicker.Properties.DisplayMember = "Name";
            cboColorPicker.Properties.ValueMember = "Id";
            cboColorPicker.Properties.DataSource = _colors;
            cboColorPicker.EditValue = Settings.Default.EmptyContainerColorId;
        }

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        //_isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin").Value;
	        //btnPrint.Enabled = _isAdmin;
		}

        private void ApplyDefaults()
        {
            chkContainerToCnee.CheckState = CheckState.Unchecked;
            chkEmptyContainer.CheckState = CheckState.Unchecked;

            dtDateFrom.EditValue = new DateTime(2016, 10, 1); ;
            dtDateTo.EditValue = DateTime.Now;
            ReadFilter();
		}

        private void ReadFilter()
        {
	        if (!chkSaveFilter.Checked) return;

	        string filePath = Path.Combine(Path.GetTempPath(), _filterName) + ".json";
	        if (!File.Exists(filePath)) return;

	        chkSaveFilter.Checked = File.Exists(filePath);

	        using (var sr = new StreamReader(filePath))
	        {
		        string json = sr.ReadToEnd();
		        var defaultFilterList = HelperApplication.ReadJsonFilterList(json);

		        if (defaultFilterList == null) return;
		        foreach (var filter in defaultFilterList)
		        {
			        switch (filter.Name)
			        {
				        case "DateFrom":
					        dtDateFrom.EditValue = DateTime.Parse(filter.Value);
					        break;

				        case "DateTo":
					        dtDateTo.EditValue = DateTime.Parse(filter.Value);
					        break;
			        }
		        }
	        }
        }

		#region Buttons Event

		private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                bool containerToCnee = (bool)chkContainerToCnee.EditValue;
                bool emptyContainer = (bool)chkEmptyContainer.EditValue;
                bool showOnlyEmpty = (bool)chkOnlyEmptyContainers.EditValue;
                _ = int.TryParse(txtJobNo.Text, out int jobNo);

                string departmentsSelected = FillDepartmentsList();

                int pendingTime = 0;
                SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);

                IList<EmptyContainerReportModel> dataReportModels = _emptyContainerReportRepository.EmptyContainerList((DateTime?)dtDateFrom.EditValue,
	                (DateTime?)dtDateTo.EditValue, containerToCnee, emptyContainer, jobNo, departmentsSelected, showOnlyEmpty).ToList();

                var previewForm = new DocumentViewerForm();
                var reportByNames = new EmptyContainerReport();

                reportByNames.DataSource = dataReportModels;

                reportByNames.Parameters["pDateFrom"].Value = (DateTime?)dtDateFrom.EditValue;
                reportByNames.Parameters["pDateTo"].Value = (DateTime?)dtDateTo.EditValue;
                reportByNames.Parameters["HighlightColor"].Value = cboColorPicker.Text == string.Empty ? "'Transparent'" : cboColorPicker.Text.Trim();

                previewForm.Viewer.DocumentSource = reportByNames;
                previewForm.ShowDialog();

                Settings.Default.EmptyContainerColorId = (int)cboColorPicker.EditValue;
                Settings.Default.Save();

                SaveFilter();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string FillDepartmentsList()
        {
            StringBuilder departmentsList = new StringBuilder();

            foreach (var department in chkDepartmentsList.CheckedItems)
            {
                var departmentModel = (DepartmentModel)department;
                departmentsList.Append(departmentModel.Id);
                departmentsList.Append(",");
            }
            if (departmentsList.Length> 0) departmentsList.Length -= 1;

            return departmentsList.ToString();
        }

		#endregion

		private void SaveFilter()
		{
			if (!chkSaveFilter.Checked) return;

			try
			{
				// INIT
				List<InitDataModelExtended> initDataList = new List<InitDataModelExtended>();

				//SEED
				if (dtDateFrom.EditValue != null)
					initDataList.Add(new InitDataModelExtended { Name = "DateFrom", Value = dtDateFrom.EditValue.ToString() });

				if (dtDateTo.EditValue != null)
					initDataList.Add(new InitDataModelExtended { Name = "DateTo", Value = dtDateTo.EditValue.ToString() });

				var jSonToString = HelperApplication.SaveJsonFilterList(initDataList);

				HelperApplication.SaveCustomFilter(_filterName, jSonToString);
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message,
					"Save filter error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}