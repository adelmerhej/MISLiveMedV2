namespace MISLiveMed.UI.Reports.DOPReports
{
    partial class PrintSalesCommissionReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintSalesCommissionReportForm));
            this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
            this.rgPaymentoption = new DevExpress.XtraEditors.RadioGroup();
            this.rgSalesReportOption = new DevExpress.XtraEditors.RadioGroup();
            this.cboSales = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.rgSelection = new DevExpress.XtraEditors.RadioGroup();
            this.dtDateTo = new DevExpress.XtraEditors.DateEdit();
            this.dtDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lgDateFilter = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblDateFrom = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblDateTo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lgSelection = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lgReportOption = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lgSalesSelection = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblSelectSales = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lgPaymentOption = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colSalesId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkFullPaid = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgPaymentoption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSalesReportOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgDateFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgReportOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgSalesSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSelectSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgPaymentOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFullPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.Controls.Add(this.chkFullPaid);
            this.mainLayout.Controls.Add(this.rgPaymentoption);
            this.mainLayout.Controls.Add(this.rgSalesReportOption);
            this.mainLayout.Controls.Add(this.cboSales);
            this.mainLayout.Controls.Add(this.btnClose);
            this.mainLayout.Controls.Add(this.btnPrint);
            this.mainLayout.Controls.Add(this.rgSelection);
            this.mainLayout.Controls.Add(this.dtDateTo);
            this.mainLayout.Controls.Add(this.dtDateFrom);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Root = this.Root;
            this.mainLayout.Size = new System.Drawing.Size(646, 624);
            this.mainLayout.TabIndex = 2;
            this.mainLayout.Text = "layoutControl1";
            // 
            // rgPaymentoption
            // 
            this.rgPaymentoption.EditValue = 0;
            this.rgPaymentoption.Location = new System.Drawing.Point(24, 465);
            this.rgPaymentoption.Name = "rgPaymentoption";
            this.rgPaymentoption.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgPaymentoption.Properties.Appearance.Options.UseBackColor = true;
            this.rgPaymentoption.Properties.Columns = 3;
            this.rgPaymentoption.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "All"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Paid"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Not Paid")});
            this.rgPaymentoption.Size = new System.Drawing.Size(598, 42);
            this.rgPaymentoption.StyleController = this.mainLayout;
            this.rgPaymentoption.TabIndex = 17;
            // 
            // rgSalesReportOption
            // 
            this.rgSalesReportOption.EditValue = 0;
            this.rgSalesReportOption.Location = new System.Drawing.Point(24, 369);
            this.rgSalesReportOption.Name = "rgSalesReportOption";
            this.rgSalesReportOption.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgSalesReportOption.Properties.Appearance.Options.UseBackColor = true;
            this.rgSalesReportOption.Properties.Columns = 3;
            this.rgSalesReportOption.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "All"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "with Wejrim"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Without Tejrim")});
            this.rgSalesReportOption.Size = new System.Drawing.Size(598, 42);
            this.rgSalesReportOption.StyleController = this.mainLayout;
            this.rgSalesReportOption.TabIndex = 16;
            // 
            // cboSales
            // 
            this.cboSales.Location = new System.Drawing.Point(106, 137);
            this.cboSales.Name = "cboSales";
            this.cboSales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSales.Properties.DisplayMember = "UserName";
            this.cboSales.Properties.NullText = "";
            this.cboSales.Properties.PopupView = this.searchLookUpEdit1View;
            this.cboSales.Properties.ValueMember = "Id";
            this.cboSales.Size = new System.Drawing.Size(516, 22);
            this.cboSales.StyleController = this.mainLayout;
            this.cboSales.TabIndex = 15;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesId,
            this.colSalesName});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(476, 585);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 27);
            this.btnClose.StyleController = this.mainLayout;
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(334, 585);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(138, 27);
            this.btnPrint.StyleController = this.mainLayout;
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rgSelection
            // 
            this.rgSelection.EditValue = "SalesCommissionReport";
            this.rgSelection.Location = new System.Drawing.Point(24, 213);
            this.rgSelection.Name = "rgSelection";
            this.rgSelection.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgSelection.Properties.Appearance.Options.UseBackColor = true;
            this.rgSelection.Properties.Columns = 1;
            this.rgSelection.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SalesCommissionReport", "Sales Commission Report"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SalesReport", "Sales Report", false),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SalesProvisionReport", "Sales Provision Report", false)});
            this.rgSelection.Properties.ReadOnly = true;
            this.rgSelection.Size = new System.Drawing.Size(598, 102);
            this.rgSelection.StyleController = this.mainLayout;
            this.rgSelection.TabIndex = 6;
            // 
            // dtDateTo
            // 
            this.dtDateTo.EditValue = null;
            this.dtDateTo.Location = new System.Drawing.Point(376, 50);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateTo.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtDateTo.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtDateTo.Properties.UseMaskAsDisplayFormat = true;
            this.dtDateTo.Size = new System.Drawing.Size(246, 22);
            this.dtDateTo.StyleController = this.mainLayout;
            this.dtDateTo.TabIndex = 5;
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.EditValue = null;
            this.dtDateFrom.Location = new System.Drawing.Point(106, 50);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateFrom.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtDateFrom.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
            this.dtDateFrom.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtDateFrom.Properties.UseMaskAsDisplayFormat = true;
            this.dtDateFrom.Size = new System.Drawing.Size(184, 22);
            this.dtDateFrom.StyleController = this.mainLayout;
            this.dtDateFrom.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.lgDateFilter,
            this.lgSelection,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem4,
            this.lgReportOption,
            this.lgSalesSelection,
            this.emptySpaceItem5,
            this.lgPaymentOption});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(646, 624);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 539);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(626, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lgDateFilter
            // 
            this.lgDateFilter.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.lgDateFilter.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblDateFrom,
            this.lblDateTo});
            this.lgDateFilter.Location = new System.Drawing.Point(0, 0);
            this.lgDateFilter.Name = "lgDateFilter";
            this.lgDateFilter.Size = new System.Drawing.Size(626, 76);
            this.lgDateFilter.Text = "Date Range";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Control = this.dtDateFrom;
            this.lblDateFrom.Location = new System.Drawing.Point(0, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(270, 26);
            this.lblDateFrom.Text = "Date From";
            this.lblDateFrom.TextSize = new System.Drawing.Size(70, 16);
            // 
            // lblDateTo
            // 
            this.lblDateTo.Control = this.dtDateTo;
            this.lblDateTo.Location = new System.Drawing.Point(270, 0);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(332, 26);
            this.lblDateTo.Text = "Date To";
            this.lblDateTo.TextSize = new System.Drawing.Size(70, 16);
            // 
            // lgSelection
            // 
            this.lgSelection.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.lgSelection.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgSelection.Location = new System.Drawing.Point(0, 163);
            this.lgSelection.Name = "lgSelection";
            this.lgSelection.Size = new System.Drawing.Size(626, 156);
            this.lgSelection.Text = "Report Selection";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rgSelection;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(602, 106);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnPrint;
            this.layoutControlItem7.Location = new System.Drawing.Point(322, 573);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(142, 31);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnClose;
            this.layoutControlItem8.Location = new System.Drawing.Point(464, 573);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(162, 31);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 573);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(322, 31);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lgReportOption
            // 
            this.lgReportOption.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.lgReportOption.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.lgReportOption.Location = new System.Drawing.Point(0, 319);
            this.lgReportOption.Name = "lgReportOption";
            this.lgReportOption.Size = new System.Drawing.Size(626, 96);
            this.lgReportOption.Text = "Report Option";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.rgSalesReportOption;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(602, 46);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lgSalesSelection
            // 
            this.lgSalesSelection.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.lgSalesSelection.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblSelectSales});
            this.lgSalesSelection.Location = new System.Drawing.Point(0, 87);
            this.lgSalesSelection.Name = "lgSalesSelection";
            this.lgSalesSelection.Size = new System.Drawing.Size(626, 76);
            this.lgSalesSelection.Text = "Sales";
            // 
            // lblSelectSales
            // 
            this.lblSelectSales.Control = this.cboSales;
            this.lblSelectSales.Location = new System.Drawing.Point(0, 0);
            this.lblSelectSales.Name = "lblSelectSales";
            this.lblSelectSales.Size = new System.Drawing.Size(602, 26);
            this.lblSelectSales.Text = "Select Sales";
            this.lblSelectSales.TextSize = new System.Drawing.Size(70, 16);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 76);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(626, 11);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lgPaymentOption
            // 
            this.lgPaymentOption.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.lgPaymentOption.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.lgPaymentOption.Location = new System.Drawing.Point(0, 415);
            this.lgPaymentOption.Name = "lgPaymentOption";
            this.lgPaymentOption.Size = new System.Drawing.Size(626, 124);
            this.lgPaymentOption.Text = "Payment Option";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rgPaymentoption;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(602, 46);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // colSalesId
            // 
            this.colSalesId.Caption = "Id";
            this.colSalesId.FieldName = "Id";
            this.colSalesId.Name = "colSalesId";
            this.colSalesId.Visible = true;
            this.colSalesId.VisibleIndex = 0;
            this.colSalesId.Width = 111;
            // 
            // colSalesName
            // 
            this.colSalesName.Caption = "Name";
            this.colSalesName.FieldName = "UserName";
            this.colSalesName.Name = "colSalesName";
            this.colSalesName.Visible = true;
            this.colSalesName.VisibleIndex = 1;
            this.colSalesName.Width = 1164;
            // 
            // chkFullPaid
            // 
            this.chkFullPaid.Location = new System.Drawing.Point(24, 511);
            this.chkFullPaid.Name = "chkFullPaid";
            this.chkFullPaid.Properties.Caption = "All Full Paid Invoices";
            this.chkFullPaid.Size = new System.Drawing.Size(598, 24);
            this.chkFullPaid.StyleController = this.mainLayout;
            this.chkFullPaid.TabIndex = 18;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkFullPaid;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(602, 28);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // ReportSalesCommissionForm
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(646, 624);
            this.Controls.Add(this.mainLayout);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ReportSalesCommissionForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "ReportSalesCommissionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Sales Commission";
            ((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
            this.mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgPaymentoption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSalesReportOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgDateFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgReportOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgSalesSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSelectSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgPaymentOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFullPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraEditors.RadioGroup rgPaymentoption;
        private DevExpress.XtraEditors.RadioGroup rgSalesReportOption;
        private DevExpress.XtraEditors.SearchLookUpEdit cboSales;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesId;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesName;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.RadioGroup rgSelection;
        private DevExpress.XtraEditors.DateEdit dtDateTo;
        private DevExpress.XtraEditors.DateEdit dtDateFrom;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup lgDateFilter;
        private DevExpress.XtraLayout.LayoutControlItem lblDateFrom;
        private DevExpress.XtraLayout.LayoutControlItem lblDateTo;
        private DevExpress.XtraLayout.LayoutControlGroup lgSelection;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlGroup lgReportOption;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup lgSalesSelection;
        private DevExpress.XtraLayout.LayoutControlItem lblSelectSales;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlGroup lgPaymentOption;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CheckEdit chkFullPaid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}