namespace MISLiveMed.UI.Accounting.Journals
{
	partial class MigrateChartsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.lblCount = new DevExpress.XtraEditors.LabelControl();
			this.cboWorkingYear = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
			this.gcCharts = new DevExpress.XtraGrid.GridControl();
			this.bsCharts = new System.Windows.Forms.BindingSource(this.components);
			this.gvCharts = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colParentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSerial = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colChartType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.gvJournalDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDetailLine = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailChartId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailValueDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailDbCr = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailLAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailFAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailPosted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailDocumentRef = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnImport = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.grpInfo = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblSelectYear = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboWorkingYear.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcCharts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCharts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCharts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvJournalDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSelectYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.lblCount);
			this.mainLayout.Controls.Add(this.cboWorkingYear);
			this.mainLayout.Controls.Add(this.progressBarControl1);
			this.mainLayout.Controls.Add(this.gcCharts);
			this.mainLayout.Controls.Add(this.btnCancel);
			this.mainLayout.Controls.Add(this.btnImport);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 0);
			this.mainLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(738, 385, 450, 350);
			this.mainLayout.Root = this.layoutControlGroup1;
			this.mainLayout.Size = new System.Drawing.Size(1056, 579);
			this.mainLayout.TabIndex = 12;
			this.mainLayout.Text = "layoutControl1";
			// 
			// lblCount
			// 
			this.lblCount.Location = new System.Drawing.Point(558, 50);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(7, 16);
			this.lblCount.StyleController = this.mainLayout;
			this.lblCount.TabIndex = 23;
			this.lblCount.Text = "0";
			// 
			// cboWorkingYear
			// 
			this.cboWorkingYear.Location = new System.Drawing.Point(101, 50);
			this.cboWorkingYear.Name = "cboWorkingYear";
			this.cboWorkingYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboWorkingYear.Properties.NullText = "";
			this.cboWorkingYear.Properties.PopupView = this.searchLookUpEdit1View;
			this.cboWorkingYear.Size = new System.Drawing.Size(424, 22);
			this.cboWorkingYear.StyleController = this.mainLayout;
			this.cboWorkingYear.TabIndex = 22;
			this.cboWorkingYear.EditValueChanged += new System.EventHandler(this.cboWorkingYear_EditValueChanged);
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// progressBarControl1
			// 
			this.progressBarControl1.Location = new System.Drawing.Point(24, 506);
			this.progressBarControl1.Name = "progressBarControl1";
			this.progressBarControl1.Properties.ShowTitle = true;
			this.progressBarControl1.Size = new System.Drawing.Size(1008, 18);
			this.progressBarControl1.StyleController = this.mainLayout;
			this.progressBarControl1.TabIndex = 21;
			this.progressBarControl1.Visible = false;
			// 
			// gcCharts
			// 
			this.gcCharts.DataSource = this.bsCharts;
			this.gcCharts.Location = new System.Drawing.Point(24, 100);
			this.gcCharts.MainView = this.gvCharts;
			this.gcCharts.Name = "gcCharts";
			this.gcCharts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
			this.gcCharts.Size = new System.Drawing.Size(1008, 402);
			this.gcCharts.TabIndex = 20;
			this.gcCharts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCharts,
            this.gvJournalDetails});
			// 
			// gvCharts
			// 
			this.gvCharts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colParentId,
            this.colNumber,
            this.colSerial,
            this.colAccountName,
            this.colChartType});
			this.gvCharts.GridControl = this.gcCharts;
			this.gvCharts.Name = "gvCharts";
			this.gvCharts.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvCharts.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvCharts.OptionsBehavior.Editable = false;
			this.gvCharts.OptionsBehavior.ReadOnly = true;
			this.gvCharts.OptionsView.ColumnAutoWidth = false;
			this.gvCharts.OptionsView.ShowGroupPanel = false;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 84;
			// 
			// colParentId
			// 
			this.colParentId.FieldName = "ParentId";
			this.colParentId.MinWidth = 25;
			this.colParentId.Name = "colParentId";
			this.colParentId.Visible = true;
			this.colParentId.VisibleIndex = 1;
			this.colParentId.Width = 104;
			// 
			// colNumber
			// 
			this.colNumber.FieldName = "Number";
			this.colNumber.MinWidth = 25;
			this.colNumber.Name = "colNumber";
			this.colNumber.Visible = true;
			this.colNumber.VisibleIndex = 2;
			this.colNumber.Width = 127;
			// 
			// colSerial
			// 
			this.colSerial.FieldName = "Serial";
			this.colSerial.MinWidth = 25;
			this.colSerial.Name = "colSerial";
			this.colSerial.Visible = true;
			this.colSerial.VisibleIndex = 3;
			this.colSerial.Width = 137;
			// 
			// colAccountName
			// 
			this.colAccountName.FieldName = "AccountName";
			this.colAccountName.MinWidth = 25;
			this.colAccountName.Name = "colAccountName";
			this.colAccountName.Visible = true;
			this.colAccountName.VisibleIndex = 4;
			this.colAccountName.Width = 383;
			// 
			// colChartType
			// 
			this.colChartType.FieldName = "ChartType";
			this.colChartType.MinWidth = 25;
			this.colChartType.Name = "colChartType";
			this.colChartType.Visible = true;
			this.colChartType.VisibleIndex = 5;
			this.colChartType.Width = 105;
			// 
			// repositoryItemCheckEdit1
			// 
			this.repositoryItemCheckEdit1.AutoHeight = false;
			this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
			// 
			// gvJournalDetails
			// 
			this.gvJournalDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetailLine,
            this.colDetailChartId,
            this.colDetailAccountName,
            this.colDetailValueDate,
            this.colDetailCurrencyId,
            this.colDetailRate,
            this.colDetailDescription,
            this.colDetailDbCr,
            this.colDetailAmount,
            this.colDetailLAmount,
            this.colDetailFAmount,
            this.colDetailPosted,
            this.colDetailDocumentRef});
			this.gvJournalDetails.GridControl = this.gcCharts;
			this.gvJournalDetails.Name = "gvJournalDetails";
			this.gvJournalDetails.OptionsBehavior.Editable = false;
			this.gvJournalDetails.OptionsBehavior.ReadOnly = true;
			this.gvJournalDetails.OptionsView.ColumnAutoWidth = false;
			this.gvJournalDetails.OptionsView.ShowGroupPanel = false;
			// 
			// colDetailLine
			// 
			this.colDetailLine.Caption = "Line";
			this.colDetailLine.FieldName = "Line";
			this.colDetailLine.MinWidth = 25;
			this.colDetailLine.Name = "colDetailLine";
			this.colDetailLine.Visible = true;
			this.colDetailLine.VisibleIndex = 0;
			this.colDetailLine.Width = 86;
			// 
			// colDetailChartId
			// 
			this.colDetailChartId.Caption = "Account";
			this.colDetailChartId.FieldName = "ChartId";
			this.colDetailChartId.MinWidth = 25;
			this.colDetailChartId.Name = "colDetailChartId";
			this.colDetailChartId.Visible = true;
			this.colDetailChartId.VisibleIndex = 1;
			this.colDetailChartId.Width = 119;
			// 
			// colDetailAccountName
			// 
			this.colDetailAccountName.Caption = "Account Name";
			this.colDetailAccountName.FieldName = "ChartId";
			this.colDetailAccountName.MinWidth = 25;
			this.colDetailAccountName.Name = "colDetailAccountName";
			this.colDetailAccountName.Visible = true;
			this.colDetailAccountName.VisibleIndex = 2;
			this.colDetailAccountName.Width = 219;
			// 
			// colDetailValueDate
			// 
			this.colDetailValueDate.Caption = "Value Date";
			this.colDetailValueDate.FieldName = "ValueDate";
			this.colDetailValueDate.MinWidth = 25;
			this.colDetailValueDate.Name = "colDetailValueDate";
			this.colDetailValueDate.Visible = true;
			this.colDetailValueDate.VisibleIndex = 3;
			this.colDetailValueDate.Width = 133;
			// 
			// colDetailCurrencyId
			// 
			this.colDetailCurrencyId.Caption = "Currency";
			this.colDetailCurrencyId.FieldName = "CurrencyId";
			this.colDetailCurrencyId.MinWidth = 25;
			this.colDetailCurrencyId.Name = "colDetailCurrencyId";
			this.colDetailCurrencyId.Visible = true;
			this.colDetailCurrencyId.VisibleIndex = 4;
			this.colDetailCurrencyId.Width = 105;
			// 
			// colDetailRate
			// 
			this.colDetailRate.Caption = "Rate";
			this.colDetailRate.DisplayFormat.FormatString = "{0:n}";
			this.colDetailRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDetailRate.FieldName = "Rate";
			this.colDetailRate.MinWidth = 25;
			this.colDetailRate.Name = "colDetailRate";
			this.colDetailRate.Visible = true;
			this.colDetailRate.VisibleIndex = 5;
			this.colDetailRate.Width = 63;
			// 
			// colDetailDescription
			// 
			this.colDetailDescription.Caption = "Description";
			this.colDetailDescription.FieldName = "Description";
			this.colDetailDescription.MinWidth = 25;
			this.colDetailDescription.Name = "colDetailDescription";
			this.colDetailDescription.Visible = true;
			this.colDetailDescription.VisibleIndex = 6;
			this.colDetailDescription.Width = 306;
			// 
			// colDetailDbCr
			// 
			this.colDetailDbCr.Caption = "D/C";
			this.colDetailDbCr.FieldName = "DbCr";
			this.colDetailDbCr.MinWidth = 25;
			this.colDetailDbCr.Name = "colDetailDbCr";
			this.colDetailDbCr.Visible = true;
			this.colDetailDbCr.VisibleIndex = 7;
			this.colDetailDbCr.Width = 63;
			// 
			// colDetailAmount
			// 
			this.colDetailAmount.Caption = "Amount";
			this.colDetailAmount.DisplayFormat.FormatString = "{0:n}";
			this.colDetailAmount.FieldName = "Amount";
			this.colDetailAmount.MinWidth = 25;
			this.colDetailAmount.Name = "colDetailAmount";
			this.colDetailAmount.Visible = true;
			this.colDetailAmount.VisibleIndex = 8;
			this.colDetailAmount.Width = 103;
			// 
			// colDetailLAmount
			// 
			this.colDetailLAmount.Caption = "Amount LL";
			this.colDetailLAmount.DisplayFormat.FormatString = "{0:n}";
			this.colDetailLAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDetailLAmount.FieldName = "LAmount";
			this.colDetailLAmount.MinWidth = 25;
			this.colDetailLAmount.Name = "colDetailLAmount";
			this.colDetailLAmount.Visible = true;
			this.colDetailLAmount.VisibleIndex = 9;
			this.colDetailLAmount.Width = 116;
			// 
			// colDetailFAmount
			// 
			this.colDetailFAmount.Caption = "Amount USD";
			this.colDetailFAmount.DisplayFormat.FormatString = "{0:n}";
			this.colDetailFAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDetailFAmount.FieldName = "FAmount";
			this.colDetailFAmount.MinWidth = 25;
			this.colDetailFAmount.Name = "colDetailFAmount";
			this.colDetailFAmount.Visible = true;
			this.colDetailFAmount.VisibleIndex = 10;
			this.colDetailFAmount.Width = 106;
			// 
			// colDetailPosted
			// 
			this.colDetailPosted.Caption = "Posted";
			this.colDetailPosted.FieldName = "Posted";
			this.colDetailPosted.MinWidth = 25;
			this.colDetailPosted.Name = "colDetailPosted";
			this.colDetailPosted.Visible = true;
			this.colDetailPosted.VisibleIndex = 11;
			this.colDetailPosted.Width = 77;
			// 
			// colDetailDocumentRef
			// 
			this.colDetailDocumentRef.Caption = "Document#";
			this.colDetailDocumentRef.FieldName = "DocumentRef";
			this.colDetailDocumentRef.MinWidth = 25;
			this.colDetailDocumentRef.Name = "colDetailDocumentRef";
			this.colDetailDocumentRef.Visible = true;
			this.colDetailDocumentRef.VisibleIndex = 12;
			this.colDetailDocumentRef.Width = 114;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(865, 540);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(179, 27);
			this.btnCancel.StyleController = this.mainLayout;
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnImport
			// 
			this.btnImport.Enabled = false;
			this.btnImport.Location = new System.Drawing.Point(700, 540);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(161, 27);
			this.btnImport.StyleController = this.mainLayout;
			this.btnImport.TabIndex = 7;
			this.btnImport.Text = "Import";
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.grpInfo});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(1056, 579);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 528);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(688, 31);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnImport;
			this.layoutControlItem4.Location = new System.Drawing.Point(688, 528);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(165, 31);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.btnCancel;
			this.layoutControlItem5.Location = new System.Drawing.Point(853, 528);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(183, 31);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// grpInfo
			// 
			this.grpInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.lblSelectYear,
            this.emptySpaceItem4,
            this.layoutControlItem1,
            this.emptySpaceItem3});
			this.grpInfo.Location = new System.Drawing.Point(0, 0);
			this.grpInfo.Name = "grpInfo";
			this.grpInfo.Size = new System.Drawing.Size(1036, 528);
			this.grpInfo.Text = "Path Info";
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(1012, 24);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.gcCharts;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 50);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1012, 406);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.progressBarControl1;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 456);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(1012, 22);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// lblSelectYear
			// 
			this.lblSelectYear.Control = this.cboWorkingYear;
			this.lblSelectYear.Location = new System.Drawing.Point(0, 0);
			this.lblSelectYear.Name = "lblSelectYear";
			this.lblSelectYear.Size = new System.Drawing.Size(505, 26);
			this.lblSelectYear.Text = "Select Year";
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.Location = new System.Drawing.Point(545, 0);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(467, 26);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.lblCount;
			this.layoutControlItem1.Location = new System.Drawing.Point(534, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(11, 26);
			this.layoutControlItem1.TextVisible = false;
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.Location = new System.Drawing.Point(505, 0);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(29, 26);
			// 
			// MigrateChartsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1056, 579);
			this.Controls.Add(this.mainLayout);
			this.MaximizeBox = false;
			this.Name = "MigrateChartsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Migrate Charts";
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cboWorkingYear.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcCharts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCharts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCharts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvJournalDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSelectYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraEditors.LabelControl lblCount;
		private DevExpress.XtraEditors.SearchLookUpEdit cboWorkingYear;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
		private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
		private DevExpress.XtraGrid.GridControl gcCharts;
		private DevExpress.XtraGrid.Views.Grid.GridView gvJournalDetails;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailLine;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailChartId;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailAccountName;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailValueDate;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailCurrencyId;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailRate;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailDbCr;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailLAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailFAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailPosted;
		private DevExpress.XtraGrid.Columns.GridColumn colDetailDocumentRef;
		private DevExpress.XtraGrid.Views.Grid.GridView gvCharts;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
		private DevExpress.XtraEditors.SimpleButton btnImport;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlGroup grpInfo;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem lblSelectYear;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private System.Windows.Forms.BindingSource bsCharts;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colParentId;
		private DevExpress.XtraGrid.Columns.GridColumn colNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colSerial;
		private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
		private DevExpress.XtraGrid.Columns.GridColumn colChartType;
	}
}