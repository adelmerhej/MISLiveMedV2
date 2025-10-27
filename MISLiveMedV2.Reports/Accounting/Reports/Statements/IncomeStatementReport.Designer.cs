using MISLiveMed.Models.Models.Accounting.Reports.Statements;

namespace MISLiveMed.Reports.Accounting.Reports.Statements
{
    partial class IncomeStatementReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
			this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
			this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
			this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
			this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
			this.TotalCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.TotalData1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.TotalBackground1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.GrandTotalCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.GrandTotalData1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.GrandTotalBackground1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
			this.OutputCurrency = new DevExpress.XtraReports.Parameters.Parameter();
			this.label1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.table3 = new DevExpress.XtraReports.UI.XRTable();
			this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// DateFrom
			// 
			this.DateFrom.AllowNull = true;
			this.DateFrom.Description = "DateFrom";
			this.DateFrom.Name = "DateFrom";
			this.DateFrom.Type = typeof(System.DateTime);
			this.DateFrom.ValueInfo = "2024-07-10";
			this.DateFrom.Visible = false;
			// 
			// DateTo
			// 
			this.DateTo.AllowNull = true;
			this.DateTo.Description = "DateTo";
			this.DateTo.Name = "DateTo";
			this.DateTo.Type = typeof(System.DateTime);
			this.DateTo.ValueInfo = "2024-07-10";
			this.DateTo.Visible = false;
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 28.33F;
			this.TopMargin.Name = "TopMargin";
			// 
			// BottomMargin
			// 
			this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo2});
			this.BottomMargin.HeightF = 39.62F;
			this.BottomMargin.Name = "BottomMargin";
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel5,
            this.xrLabel3,
            this.xrLabel1,
            this.xrPageInfo2,
            this.label1});
			this.ReportHeader.HeightF = 123.6943F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// GroupHeader2
			// 
			this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
			this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
			this.GroupHeader2.HeightF = 28F;
			this.GroupHeader2.Name = "GroupHeader2";
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
			this.Detail.HeightF = 25F;
			this.Detail.Name = "Detail";
			// 
			// ReportFooter
			// 
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel2,
            this.xrLine3});
			this.ReportFooter.HeightF = 54.63786F;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// xrLine3
			// 
			this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrLine3.Name = "xrLine3";
			this.xrLine3.SizeF = new System.Drawing.SizeF(719F, 2.000041F);
			// 
			// Title
			// 
			this.Title.BackColor = System.Drawing.Color.Transparent;
			this.Title.BorderColor = System.Drawing.Color.Black;
			this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.Title.BorderWidth = 1F;
			this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
			this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.Title.Name = "Title";
			this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			// 
			// GroupCaption1
			// 
			this.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.GroupCaption1.BorderColor = System.Drawing.Color.White;
			this.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.GroupCaption1.BorderWidth = 2F;
			this.GroupCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
			this.GroupCaption1.Name = "GroupCaption1";
			this.GroupCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
			this.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// GroupData1
			// 
			this.GroupData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.GroupData1.BorderColor = System.Drawing.Color.White;
			this.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.GroupData1.BorderWidth = 2F;
			this.GroupData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.GroupData1.ForeColor = System.Drawing.Color.White;
			this.GroupData1.Name = "GroupData1";
			this.GroupData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
			this.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailCaption1
			// 
			this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.DetailCaption1.BorderColor = System.Drawing.Color.White;
			this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
			this.DetailCaption1.BorderWidth = 2F;
			this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.DetailCaption1.ForeColor = System.Drawing.Color.White;
			this.DetailCaption1.Name = "DetailCaption1";
			this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData1
			// 
			this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
			this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
			this.DetailData1.BorderWidth = 2F;
			this.DetailData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
			this.DetailData1.ForeColor = System.Drawing.Color.Black;
			this.DetailData1.Name = "DetailData1";
			this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// GroupFooterBackground3
			// 
			this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
			this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
			this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.GroupFooterBackground3.BorderWidth = 2F;
			this.GroupFooterBackground3.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
			this.GroupFooterBackground3.Name = "GroupFooterBackground3";
			this.GroupFooterBackground3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
			this.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData3_Odd
			// 
			this.DetailData3_Odd.BackColor = System.Drawing.Color.Transparent;
			this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
			this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.DetailData3_Odd.BorderWidth = 1F;
			this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
			this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
			this.DetailData3_Odd.Name = "DetailData3_Odd";
			this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// TotalCaption1
			// 
			this.TotalCaption1.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.TotalCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.TotalCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
			this.TotalCaption1.Name = "TotalCaption1";
			this.TotalCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
			this.TotalCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// TotalData1
			// 
			this.TotalData1.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.TotalData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.TotalData1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.TotalData1.Name = "TotalData1";
			this.TotalData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F);
			this.TotalData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// TotalBackground1
			// 
			this.TotalBackground1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
			this.TotalBackground1.BorderColor = System.Drawing.Color.White;
			this.TotalBackground1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.TotalBackground1.BorderWidth = 2F;
			this.TotalBackground1.Name = "TotalBackground1";
			// 
			// GrandTotalCaption1
			// 
			this.GrandTotalCaption1.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.GrandTotalCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.GrandTotalCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
			this.GrandTotalCaption1.Name = "GrandTotalCaption1";
			this.GrandTotalCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
			this.GrandTotalCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// GrandTotalData1
			// 
			this.GrandTotalData1.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.GrandTotalData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.GrandTotalData1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.GrandTotalData1.Name = "GrandTotalData1";
			this.GrandTotalData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F);
			this.GrandTotalData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// GrandTotalBackground1
			// 
			this.GrandTotalBackground1.BackColor = System.Drawing.Color.White;
			this.GrandTotalBackground1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.GrandTotalBackground1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.GrandTotalBackground1.BorderWidth = 2F;
			this.GrandTotalBackground1.Name = "GrandTotalBackground1";
			// 
			// PageInfo
			// 
			this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.PageInfo.Name = "PageInfo";
			this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			// 
			// OutputCurrency
			// 
			this.OutputCurrency.AllowNull = true;
			this.OutputCurrency.Description = "Parameter1";
			this.OutputCurrency.Name = "OutputCurrency";
			this.OutputCurrency.Visible = false;
			// 
			// label1
			// 
			this.label1.Font = new DevExpress.Drawing.DXFont("Arial", 14F, DevExpress.Drawing.DXFontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.label1.LocationFloat = new DevExpress.Utils.PointFloat(237.5F, 0F);
			this.label1.Name = "label1";
			this.label1.SizeF = new System.Drawing.SizeF(254F, 24.19433F);
			this.label1.StyleName = "Title";
			this.label1.StylePriority.UseFont = false;
			this.label1.StylePriority.UseForeColor = false;
			this.label1.Text = "Income Statement Report";
			// 
			// xrPageInfo2
			// 
			this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(359.9695F, 41.69434F);
			this.xrPageInfo2.Name = "xrPageInfo2";
			this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.xrPageInfo2.SizeF = new System.Drawing.SizeF(369.0305F, 23F);
			this.xrPageInfo2.StyleName = "PageInfo";
			this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.xrPageInfo2.TextFormatString = "Print Date: {0:dddd, d MMMM, yyyy hh:mm:ss tt}";
			// 
			// xrLabel8
			// 
			this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNull(?DateTo)")});
			this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0.5000305F, 100.6943F);
			this.xrLabel8.Multiline = true;
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(46.86483F, 23F);
			this.xrLabel8.StylePriority.UseFont = false;
			this.xrLabel8.StylePriority.UseTextAlignment = false;
			this.xrLabel8.Text = "To:";
			this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel8.Visible = false;
			// 
			// xrLabel5
			// 
			this.xrLabel5.CanGrow = false;
			this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNull(?DateFrom)")});
			this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0.5000305F, 77.69434F);
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(46.99994F, 23F);
			this.xrLabel5.StylePriority.UseFont = false;
			this.xrLabel5.StylePriority.UseTextAlignment = false;
			this.xrLabel5.Text = "From:";
			this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel5.Visible = false;
			this.xrLabel5.WordWrap = false;
			// 
			// xrLabel3
			// 
			this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?DateTo")});
			this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(142.6982F, 100.6943F);
			this.xrLabel3.Multiline = true;
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(100.1351F, 23F);
			this.xrLabel3.StylePriority.UseFont = false;
			this.xrLabel3.StylePriority.UseForeColor = false;
			this.xrLabel3.StylePriority.UseTextAlignment = false;
			this.xrLabel3.Text = "xrLabel3";
			this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrLabel3.TextFormatString = "{0:dd/MM/yyyy}";
			// 
			// xrLabel1
			// 
			this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?DateFrom")});
			this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(142.8333F, 77.69434F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23.00001F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseForeColor = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "xrLabel1";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrLabel1.TextFormatString = "{0:dd/MM/yyyy}";
			// 
			// xrTable1
			// 
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(729.0001F, 28F);
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 1D;
			// 
			// xrTableCell6
			// 
			this.xrTableCell6.BackColor = System.Drawing.Color.Transparent;
			this.xrTableCell6.BorderColor = System.Drawing.Color.Black;
			this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell6.BorderWidth = 1F;
			this.xrTableCell6.ForeColor = System.Drawing.Color.Black;
			this.xrTableCell6.Multiline = true;
			this.xrTableCell6.Name = "xrTableCell6";
			this.xrTableCell6.StyleName = "DetailCaption1";
			this.xrTableCell6.StylePriority.UseBackColor = false;
			this.xrTableCell6.StylePriority.UseBorderColor = false;
			this.xrTableCell6.StylePriority.UseBorders = false;
			this.xrTableCell6.StylePriority.UseBorderWidth = false;
			this.xrTableCell6.StylePriority.UseForeColor = false;
			this.xrTableCell6.Weight = 0.099587479387892086D;
			// 
			// tableCell3
			// 
			this.tableCell3.BackColor = System.Drawing.Color.Transparent;
			this.tableCell3.BorderColor = System.Drawing.Color.Black;
			this.tableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.tableCell3.BorderWidth = 1F;
			this.tableCell3.ForeColor = System.Drawing.Color.Black;
			this.tableCell3.Name = "tableCell3";
			this.tableCell3.StyleName = "DetailCaption1";
			this.tableCell3.StylePriority.UseBackColor = false;
			this.tableCell3.StylePriority.UseBorderColor = false;
			this.tableCell3.StylePriority.UseBorders = false;
			this.tableCell3.StylePriority.UseBorderWidth = false;
			this.tableCell3.StylePriority.UseForeColor = false;
			this.tableCell3.Text = "Description";
			this.tableCell3.Weight = 0.73175289331100557D;
			// 
			// tableCell4
			// 
			this.tableCell4.BackColor = System.Drawing.Color.Transparent;
			this.tableCell4.BorderColor = System.Drawing.Color.Black;
			this.tableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.tableCell4.BorderWidth = 1F;
			this.tableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Currency\' + \' \' + ?OutputCurrency")});
			this.tableCell4.ForeColor = System.Drawing.Color.Black;
			this.tableCell4.Name = "tableCell4";
			this.tableCell4.StyleName = "DetailCaption1";
			this.tableCell4.StylePriority.UseBackColor = false;
			this.tableCell4.StylePriority.UseBorderColor = false;
			this.tableCell4.StylePriority.UseBorders = false;
			this.tableCell4.StylePriority.UseBorderWidth = false;
			this.tableCell4.StylePriority.UseForeColor = false;
			this.tableCell4.StylePriority.UseTextAlignment = false;
			this.tableCell4.Text = "Currency";
			this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.tableCell4.Weight = 0.23484079001037594D;
			// 
			// tableCell5
			// 
			this.tableCell5.BackColor = System.Drawing.Color.Transparent;
			this.tableCell5.BorderColor = System.Drawing.Color.Black;
			this.tableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.tableCell5.BorderWidth = 1F;
			this.tableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Expenses\' + \' \' + ?OutputCurrency")});
			this.tableCell5.ForeColor = System.Drawing.Color.Black;
			this.tableCell5.Name = "tableCell5";
			this.tableCell5.StyleName = "DetailCaption1";
			this.tableCell5.StylePriority.UseBackColor = false;
			this.tableCell5.StylePriority.UseBorderColor = false;
			this.tableCell5.StylePriority.UseBorders = false;
			this.tableCell5.StylePriority.UseBorderWidth = false;
			this.tableCell5.StylePriority.UseForeColor = false;
			this.tableCell5.StylePriority.UseTextAlignment = false;
			this.tableCell5.Text = "Expenses";
			this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.tableCell5.Weight = 0.23610738648750751D;
			// 
			// tableCell6
			// 
			this.tableCell6.BackColor = System.Drawing.Color.Transparent;
			this.tableCell6.BorderColor = System.Drawing.Color.Black;
			this.tableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.tableCell6.BorderWidth = 1F;
			this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Revenues\' + \' \' + ?OutputCurrency\n")});
			this.tableCell6.ForeColor = System.Drawing.Color.Black;
			this.tableCell6.Name = "tableCell6";
			this.tableCell6.StyleName = "DetailCaption1";
			this.tableCell6.StylePriority.UseBackColor = false;
			this.tableCell6.StylePriority.UseBorderColor = false;
			this.tableCell6.StylePriority.UseBorders = false;
			this.tableCell6.StylePriority.UseBorderWidth = false;
			this.tableCell6.StylePriority.UseForeColor = false;
			this.tableCell6.StylePriority.UseTextAlignment = false;
			this.tableCell6.Text = "Revenues";
			this.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.tableCell6.Weight = 0.22611831816377817D;
			// 
			// table3
			// 
			this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.table3.Name = "table3";
			this.table3.OddStyleName = "DetailData3_Odd";
			this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
			this.table3.SizeF = new System.Drawing.SizeF(729F, 25F);
			// 
			// tableRow3
			// 
			this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.tableCell7,
            this.xrTableCell1,
            this.tableCell8,
            this.tableCell9,
            this.tableCell10});
			this.tableRow3.Name = "tableRow3";
			this.tableRow3.Weight = 11.5D;
			// 
			// xrTableCell5
			// 
			this.xrTableCell5.BorderColor = System.Drawing.Color.Black;
			this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
			this.xrTableCell5.BorderWidth = 1F;
			this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([IsTotal], \'\', [AccountNumber])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([IsTotal], True, False)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([IsTotal] and [ColumnList] = 4,\'Left,Bottom,Right\', \'Left,Right\')\n")});
			this.xrTableCell5.Multiline = true;
			this.xrTableCell5.Name = "xrTableCell5";
			this.xrTableCell5.StyleName = "DetailData1";
			this.xrTableCell5.StylePriority.UseBorderColor = false;
			this.xrTableCell5.StylePriority.UseBorders = false;
			this.xrTableCell5.StylePriority.UseBorderWidth = false;
			this.xrTableCell5.StylePriority.UseFont = false;
			this.xrTableCell5.Text = "xrTableCell5";
			this.xrTableCell5.Weight = 0.11262449467979388D;
			// 
			// tableCell7
			// 
			this.tableCell7.BorderColor = System.Drawing.Color.Black;
			this.tableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
			this.tableCell7.BorderWidth = 1F;
			this.tableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([IsTotal], True, False)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([IsTotal] and [ColumnList] in (1,4),\'Bottom\', \'\')\n")});
			this.tableCell7.Name = "tableCell7";
			this.tableCell7.StyleName = "DetailData1";
			this.tableCell7.StylePriority.UseBorderColor = false;
			this.tableCell7.StylePriority.UseBorders = false;
			this.tableCell7.StylePriority.UseBorderWidth = false;
			this.tableCell7.StylePriority.UseFont = false;
			this.tableCell7.Weight = 0.62521388494665509D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.BorderColor = System.Drawing.Color.Black;
			this.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrTableCell1.BorderWidth = 1F;
			this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([IsTotal], True, False)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([IsTotal] and [ColumnList] = 4,\'Bottom,Right\', Iif([IsTotal] and [ColumnList]" +
                    " = 1,\'Bottom,Right\', \'Right\'))\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([ColumnList] = 1, [Amount1], \'\')\n")});
			this.xrTableCell1.Multiline = true;
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.StyleName = "DetailData1";
			this.xrTableCell1.StylePriority.UseBorderColor = false;
			this.xrTableCell1.StylePriority.UseBorders = false;
			this.xrTableCell1.StylePriority.UseBorderWidth = false;
			this.xrTableCell1.StylePriority.UseFont = false;
			this.xrTableCell1.Text = "xrTableCell1";
			this.xrTableCell1.TextFormatString = "{0:N0}";
			this.xrTableCell1.Weight = 0.20501464110190948D;
			// 
			// tableCell8
			// 
			this.tableCell8.BorderColor = System.Drawing.Color.Black;
			this.tableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.tableCell8.BorderWidth = 1F;
			this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([IsTotal], True, False)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([IsTotal] and [ColumnList] = 4,\'Bottom,Right\', \'Right\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([ColumnList] = 2, [Amount2], \'\')")});
			this.tableCell8.Name = "tableCell8";
			this.tableCell8.StyleName = "DetailData1";
			this.tableCell8.StylePriority.UseBorderColor = false;
			this.tableCell8.StylePriority.UseBorders = false;
			this.tableCell8.StylePriority.UseBorderWidth = false;
			this.tableCell8.StylePriority.UseFont = false;
			this.tableCell8.StylePriority.UseTextAlignment = false;
			this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell8.TextFormatString = "{0:N0}";
			this.tableCell8.Weight = 0.26634163718678616D;
			// 
			// tableCell9
			// 
			this.tableCell9.BorderColor = System.Drawing.Color.Black;
			this.tableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.tableCell9.BorderWidth = 1F;
			this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([IsTotal], True, False)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([IsTotal] and [ColumnList] = 4,\'Bottom,Right\', \'Right\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([ColumnList] =3, [Amount3], \'\')\n")});
			this.tableCell9.Name = "tableCell9";
			this.tableCell9.StyleName = "DetailData1";
			this.tableCell9.StylePriority.UseBorderColor = false;
			this.tableCell9.StylePriority.UseBorders = false;
			this.tableCell9.StylePriority.UseBorderWidth = false;
			this.tableCell9.StylePriority.UseFont = false;
			this.tableCell9.StylePriority.UseTextAlignment = false;
			this.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell9.TextFormatString = "{0:N0}";
			this.tableCell9.Weight = 0.2677778323902798D;
			// 
			// tableCell10
			// 
			this.tableCell10.BorderColor = System.Drawing.Color.Black;
			this.tableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.tableCell10.BorderWidth = 1F;
			this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([IsTotal], True, False)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([IsTotal] and [ColumnList] = 4,\'Bottom,Right\', \'Right\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([ColumnList] = 4, [Amount4], \'\')\n")});
			this.tableCell10.Name = "tableCell10";
			this.tableCell10.StyleName = "DetailData1";
			this.tableCell10.StylePriority.UseBorderColor = false;
			this.tableCell10.StylePriority.UseBorders = false;
			this.tableCell10.StylePriority.UseBorderWidth = false;
			this.tableCell10.StylePriority.UseFont = false;
			this.tableCell10.StylePriority.UseTextAlignment = false;
			this.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell10.TextFormatString = "{0:N0}";
			this.tableCell10.Weight = 0.25644858790829916D;
			// 
			// xrLabel4
			// 
			this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([ColumnList] = 3 AND [IsTotal], sum([Amount3]), 0)\n")});
			this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(621.149F, 2.00002F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(107.851F, 23F);
			this.xrLabel4.StylePriority.UseFont = false;
			this.xrLabel4.Text = "xrLabel4";
			this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.xrLabel4.TextFormatString = "{0:N0}";
			// 
			// xrLabel2
			// 
			this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([ColumnList] = 3 AND [IsTotal], sum([Amount3]), 0)")});
			this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(508.5334F, 2.00002F);
			this.xrLabel2.Multiline = true;
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(112.6155F, 23F);
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.Text = "xrLabel2";
			this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.xrLabel2.TextFormatString = "{0:N0}";
			// 
			// pageInfo2
			// 
			this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(590.3982F, 0F);
			this.pageInfo2.Name = "pageInfo2";
			this.pageInfo2.SizeF = new System.Drawing.SizeF(138.6018F, 23F);
			this.pageInfo2.StyleName = "PageInfo";
			this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.pageInfo2.TextFormatString = "Page {0} of {1}";
			// 
			// objectDataSource1
			// 
			this.objectDataSource1.DataSource = typeof(IncomeStatementModel);
			this.objectDataSource1.Name = "objectDataSource1";
			// 
			// IncomeStatementReport
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader2,
            this.Detail,
            this.ReportFooter});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
			this.DataSource = this.objectDataSource1;
			this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
			this.Margins = new DevExpress.Drawing.DXMargins(48F, 50F, 28.33F, 39.62F);
			this.PageHeight = 1169;
			this.PageWidth = 827;
			this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
			this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.OutputCurrency, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.DateFrom,
            this.DateTo,
            this.OutputCurrency});
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption1,
            this.GroupData1,
            this.DetailCaption1,
            this.DetailData1,
            this.GroupFooterBackground3,
            this.DetailData3_Odd,
            this.TotalCaption1,
            this.TotalData1,
            this.TotalBackground1,
            this.GrandTotalCaption1,
            this.GrandTotalData1,
            this.GrandTotalBackground1,
            this.PageInfo});
			this.Version = "24.2";
			xrWatermark1.Id = "Watermark1";
			this.Watermarks.AddRange(new DevExpress.XtraPrinting.Drawing.Watermark[] {
            xrWatermark1});
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle TotalCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle TotalData1;
        private DevExpress.XtraReports.UI.XRControlStyle TotalBackground1;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalData1;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalBackground1;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.Parameters.Parameter OutputCurrency;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
		private DevExpress.XtraReports.UI.XRLabel label1;
		private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel8;
		private DevExpress.XtraReports.UI.XRLabel xrLabel5;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.XRTable xrTable1;
		private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
		private DevExpress.XtraReports.UI.XRTableCell tableCell3;
		private DevExpress.XtraReports.UI.XRTableCell tableCell4;
		private DevExpress.XtraReports.UI.XRTableCell tableCell5;
		private DevExpress.XtraReports.UI.XRTableCell tableCell6;
		private DevExpress.XtraReports.UI.XRTable table3;
		private DevExpress.XtraReports.UI.XRTableRow tableRow3;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
		private DevExpress.XtraReports.UI.XRTableCell tableCell7;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
		private DevExpress.XtraReports.UI.XRTableCell tableCell8;
		private DevExpress.XtraReports.UI.XRTableCell tableCell9;
		private DevExpress.XtraReports.UI.XRTableCell tableCell10;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
	}
}
