namespace MISLiveMed.UI.Reports.DOPReports
{
    partial class PrintDopReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintDopReportForm));
            this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
            this.chkOnlyDue = new DevExpress.XtraEditors.CheckEdit();
            this.chkByJob = new DevExpress.XtraEditors.CheckEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.chkProvision = new DevExpress.XtraEditors.CheckEdit();
            this.chkSummary = new DevExpress.XtraEditors.CheckEdit();
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
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lgFilterOption = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkOnlyDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkByJob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProvision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSummary.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgFilterOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.Controls.Add(this.chkOnlyDue);
            this.mainLayout.Controls.Add(this.chkByJob);
            this.mainLayout.Controls.Add(this.btnClose);
            this.mainLayout.Controls.Add(this.btnPrint);
            this.mainLayout.Controls.Add(this.chkProvision);
            this.mainLayout.Controls.Add(this.chkSummary);
            this.mainLayout.Controls.Add(this.rgSelection);
            this.mainLayout.Controls.Add(this.dtDateTo);
            this.mainLayout.Controls.Add(this.dtDateFrom);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Root = this.Root;
            this.mainLayout.Size = new System.Drawing.Size(595, 496);
            this.mainLayout.TabIndex = 1;
            this.mainLayout.Text = "layoutControl1";
            // 
            // chkOnlyDue
            // 
            this.chkOnlyDue.Location = new System.Drawing.Point(24, 334);
            this.chkOnlyDue.Name = "chkOnlyDue";
            this.chkOnlyDue.Properties.Caption = "Only Due";
            this.chkOnlyDue.Size = new System.Drawing.Size(547, 24);
            this.chkOnlyDue.StyleController = this.mainLayout;
            this.chkOnlyDue.TabIndex = 15;
            // 
            // chkByJob
            // 
            this.chkByJob.Location = new System.Drawing.Point(436, 306);
            this.chkByJob.Name = "chkByJob";
            this.chkByJob.Properties.Caption = "Display By Job";
            this.chkByJob.Size = new System.Drawing.Size(135, 24);
            this.chkByJob.StyleController = this.mainLayout;
            this.chkByJob.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(438, 457);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 27);
            this.btnClose.StyleController = this.mainLayout;
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(308, 457);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(126, 27);
            this.btnPrint.StyleController = this.mainLayout;
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // chkProvision
            // 
            this.chkProvision.Location = new System.Drawing.Point(178, 306);
            this.chkProvision.Name = "chkProvision";
            this.chkProvision.Properties.Caption = "With Provision";
            this.chkProvision.Size = new System.Drawing.Size(254, 24);
            this.chkProvision.StyleController = this.mainLayout;
            this.chkProvision.TabIndex = 8;
            // 
            // chkSummary
            // 
            this.chkSummary.Location = new System.Drawing.Point(24, 306);
            this.chkSummary.Name = "chkSummary";
            this.chkSummary.Properties.Caption = "Summary";
            this.chkSummary.Size = new System.Drawing.Size(150, 24);
            this.chkSummary.StyleController = this.mainLayout;
            this.chkSummary.TabIndex = 7;
            // 
            // rgSelection
            // 
            this.rgSelection.EditValue = 0;
            this.rgSelection.Location = new System.Drawing.Point(24, 140);
            this.rgSelection.Name = "rgSelection";
            this.rgSelection.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgSelection.Properties.Appearance.Options.UseBackColor = true;
            this.rgSelection.Properties.Columns = 2;
            this.rgSelection.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "DOP Suppliers by name"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "DOP Suppliers draft"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "DOP Suppliers profit"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "DOP Customers by name"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "DOP Customers draft"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(5, "DOP Customers profit")});
            this.rgSelection.Size = new System.Drawing.Size(547, 102);
            this.rgSelection.StyleController = this.mainLayout;
            this.rgSelection.TabIndex = 6;
            // 
            // dtDateTo
            // 
            this.dtDateTo.EditValue = null;
            this.dtDateTo.Location = new System.Drawing.Point(337, 50);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateTo.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtDateTo.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtDateTo.Properties.UseMaskAsDisplayFormat = true;
            this.dtDateTo.Size = new System.Drawing.Size(234, 22);
            this.dtDateTo.StyleController = this.mainLayout;
            this.dtDateTo.TabIndex = 5;
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.EditValue = null;
            this.dtDateFrom.Location = new System.Drawing.Point(96, 50);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateFrom.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtDateFrom.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
            this.dtDateFrom.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtDateFrom.Properties.UseMaskAsDisplayFormat = true;
            this.dtDateFrom.Size = new System.Drawing.Size(165, 22);
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
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem4,
            this.lgFilterOption});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(595, 496);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 362);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(575, 83);
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
            this.lgDateFilter.Size = new System.Drawing.Size(575, 76);
            this.lgDateFilter.Text = "Date Range";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Control = this.dtDateFrom;
            this.lblDateFrom.Location = new System.Drawing.Point(0, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(241, 26);
            this.lblDateFrom.Text = "Date From";
            this.lblDateFrom.TextSize = new System.Drawing.Size(60, 16);
            // 
            // lblDateTo
            // 
            this.lblDateTo.Control = this.dtDateTo;
            this.lblDateTo.Location = new System.Drawing.Point(241, 0);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(310, 26);
            this.lblDateTo.Text = "Date To";
            this.lblDateTo.TextSize = new System.Drawing.Size(60, 16);
            // 
            // lgSelection
            // 
            this.lgSelection.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.lgSelection.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgSelection.Location = new System.Drawing.Point(0, 90);
            this.lgSelection.Name = "lgSelection";
            this.lgSelection.Size = new System.Drawing.Size(575, 156);
            this.lgSelection.Text = "Report Selection";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rgSelection;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(551, 106);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 76);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(575, 14);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 246);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(575, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnPrint;
            this.layoutControlItem7.Location = new System.Drawing.Point(296, 445);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(130, 31);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnClose;
            this.layoutControlItem8.Location = new System.Drawing.Point(426, 445);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(149, 31);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 445);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(296, 31);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lgFilterOption
            // 
            this.lgFilterOption.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.lgFilterOption.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.lgFilterOption.Location = new System.Drawing.Point(0, 256);
            this.lgFilterOption.Name = "lgFilterOption";
            this.lgFilterOption.Size = new System.Drawing.Size(575, 106);
            this.lgFilterOption.Text = "Filter Option";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkSummary;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(154, 28);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkProvision;
            this.layoutControlItem3.Location = new System.Drawing.Point(154, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(258, 28);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkByJob;
            this.layoutControlItem5.Location = new System.Drawing.Point(412, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(139, 28);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkOnlyDue;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(551, 28);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // ReportDopForm
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(595, 496);
            this.Controls.Add(this.mainLayout);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ReportDopForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "ReportDopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print DOP";
            ((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
            this.mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkOnlyDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkByJob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProvision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSummary.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgFilterOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraEditors.CheckEdit chkByJob;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.CheckEdit chkProvision;
        private DevExpress.XtraEditors.CheckEdit chkSummary;
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlGroup lgFilterOption;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.CheckEdit chkOnlyDue;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}