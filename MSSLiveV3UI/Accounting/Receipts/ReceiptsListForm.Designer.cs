using MISLiveMed.Models.Models.Accounting.Receipts;

namespace MISLiveMed.UI.Accounting.Receipts
{
    partial class ReceiptsListForm
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
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptsListForm));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges2 = new DevExpress.Skins.SkinPaddingEdges();
			this.gvReceiptsDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDetId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetReceiptId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceiptDetailDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetReferenceId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetValueDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCurrencies = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colDetRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldetAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetLAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetFAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetApproved = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colDetApprovedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetApprovedBy = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repApprovedBy = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colDetPaid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetPaidDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetPaidBy = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repPaidBy = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.gcReceipts = new DevExpress.XtraGrid.GridControl();
			this.bsReceipts = new System.Windows.Forms.BindingSource(this.components);
			this.gvReceipts = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colImgSelection = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repDepartments = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colReferenceNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReferenceId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceiptDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPostingDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValueDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceiptTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repReceiptsType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colMemberTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repMembersType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colMemberId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repMembers = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceiptAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceiptLAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceiptFAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRemainingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRemainingLAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRemainingFAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colApproved = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colApprovedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colApprovedBy = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaidDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaidBy = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPosted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repypeId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.rcReceipts = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.rgFilterReports = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
			this.barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem4 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
			this.barCheckItem5 = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem6 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
			this.barCheckItem7 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
			this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.cboDepartments = new DevExpress.XtraBars.BarEditItem();
			this.cboSalesList = new DevExpress.XtraBars.BarEditItem();
			this.cboStatus = new DevExpress.XtraBars.BarEditItem();
			this.chkSortByBookedDate = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem8 = new DevExpress.XtraBars.BarCheckItem();
			this.btnPrintFilter = new DevExpress.XtraBars.BarButtonItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpReceipts = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.gvReceiptsDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateEdit.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repApprovedBy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repPaidBy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcReceipts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsReceipts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvReceipts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDepartments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repReceiptsType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMembersType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMembers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repypeId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rcReceipts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// gvReceiptsDetails
			// 
			this.gvReceiptsDetails.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gvReceiptsDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetId,
            this.colDetReceiptId,
            this.colReceiptDetailDate,
            this.colTypeId,
            this.colDetReferenceId,
            this.colDetValueDate,
            this.colDetCurrencyId,
            this.colDetRate,
            this.coldetAmount,
            this.colDetLAmount,
            this.colDetFAmount,
            this.colDetDiscount,
            this.colDetApproved,
            this.colDetApprovedDate,
            this.colDetApprovedBy,
            this.colDetPaid,
            this.colDetPaidDate,
            this.colDetPaidBy});
			this.gvReceiptsDetails.DetailHeight = 431;
			this.gvReceiptsDetails.GridControl = this.gcReceipts;
			this.gvReceiptsDetails.Name = "gvReceiptsDetails";
			this.gvReceiptsDetails.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvReceiptsDetails.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvReceiptsDetails.OptionsBehavior.Editable = false;
			this.gvReceiptsDetails.OptionsBehavior.ReadOnly = true;
			this.gvReceiptsDetails.OptionsEditForm.PopupEditFormWidth = 933;
			this.gvReceiptsDetails.OptionsView.ColumnAutoWidth = false;
			this.gvReceiptsDetails.OptionsView.ShowFooter = true;
			this.gvReceiptsDetails.OptionsView.ShowGroupPanel = false;
			this.gvReceiptsDetails.OptionsView.ShowIndicator = false;
			this.gvReceiptsDetails.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			// 
			// colDetId
			// 
			this.colDetId.Caption = "Id";
			this.colDetId.FieldName = "Id";
			this.colDetId.MinWidth = 25;
			this.colDetId.Name = "colDetId";
			this.colDetId.Visible = true;
			this.colDetId.VisibleIndex = 0;
			this.colDetId.Width = 51;
			// 
			// colDetReceiptId
			// 
			this.colDetReceiptId.Caption = "Receipt Id";
			this.colDetReceiptId.FieldName = "ReceiptId";
			this.colDetReceiptId.MinWidth = 25;
			this.colDetReceiptId.Name = "colDetReceiptId";
			this.colDetReceiptId.Visible = true;
			this.colDetReceiptId.VisibleIndex = 1;
			this.colDetReceiptId.Width = 89;
			// 
			// colReceiptDetailDate
			// 
			this.colReceiptDetailDate.Caption = "Receipt Date";
			this.colReceiptDetailDate.ColumnEdit = this.repDateEdit;
			this.colReceiptDetailDate.FieldName = "ReceiptDetailDate";
			this.colReceiptDetailDate.MinWidth = 25;
			this.colReceiptDetailDate.Name = "colReceiptDetailDate";
			this.colReceiptDetailDate.Visible = true;
			this.colReceiptDetailDate.VisibleIndex = 2;
			this.colReceiptDetailDate.Width = 103;
			// 
			// repDateEdit
			// 
			this.repDateEdit.AutoHeight = false;
			this.repDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repDateEdit.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repDateEdit.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.repDateEdit.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repDateEdit.Name = "repDateEdit";
			this.repDateEdit.UseMaskAsDisplayFormat = true;
			// 
			// colTypeId
			// 
			this.colTypeId.Caption = "Type";
			this.colTypeId.MinWidth = 25;
			this.colTypeId.Name = "colTypeId";
			this.colTypeId.Visible = true;
			this.colTypeId.VisibleIndex = 3;
			this.colTypeId.Width = 78;
			// 
			// colDetReferenceId
			// 
			this.colDetReferenceId.Caption = "Reference";
			this.colDetReferenceId.FieldName = "ReferenceId";
			this.colDetReferenceId.MinWidth = 25;
			this.colDetReferenceId.Name = "colDetReferenceId";
			this.colDetReferenceId.Visible = true;
			this.colDetReferenceId.VisibleIndex = 4;
			this.colDetReferenceId.Width = 98;
			// 
			// colDetValueDate
			// 
			this.colDetValueDate.Caption = "Value Date";
			this.colDetValueDate.ColumnEdit = this.repDateEdit;
			this.colDetValueDate.FieldName = "ValueDate";
			this.colDetValueDate.MinWidth = 25;
			this.colDetValueDate.Name = "colDetValueDate";
			this.colDetValueDate.Visible = true;
			this.colDetValueDate.VisibleIndex = 5;
			this.colDetValueDate.Width = 80;
			// 
			// colDetCurrencyId
			// 
			this.colDetCurrencyId.Caption = "Currency";
			this.colDetCurrencyId.ColumnEdit = this.repCurrencies;
			this.colDetCurrencyId.FieldName = "CurrencyId";
			this.colDetCurrencyId.MinWidth = 25;
			this.colDetCurrencyId.Name = "colDetCurrencyId";
			this.colDetCurrencyId.Visible = true;
			this.colDetCurrencyId.VisibleIndex = 6;
			this.colDetCurrencyId.Width = 72;
			// 
			// repCurrencies
			// 
			this.repCurrencies.AutoHeight = false;
			this.repCurrencies.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCurrencies.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCode", "Currency", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCurrencies.DisplayMember = "CurrencyCode";
			this.repCurrencies.Name = "repCurrencies";
			this.repCurrencies.NullText = "";
			this.repCurrencies.ValueMember = "Id";
			// 
			// colDetRate
			// 
			this.colDetRate.Caption = "Rate";
			this.colDetRate.DisplayFormat.FormatString = "{0:n2}";
			this.colDetRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDetRate.FieldName = "Rate";
			this.colDetRate.MinWidth = 25;
			this.colDetRate.Name = "colDetRate";
			this.colDetRate.Visible = true;
			this.colDetRate.VisibleIndex = 7;
			this.colDetRate.Width = 66;
			// 
			// coldetAmount
			// 
			this.coldetAmount.Caption = "Amount";
			this.coldetAmount.DisplayFormat.FormatString = "{0:n2}";
			this.coldetAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coldetAmount.FieldName = "Amount";
			this.coldetAmount.MinWidth = 25;
			this.coldetAmount.Name = "coldetAmount";
			this.coldetAmount.Visible = true;
			this.coldetAmount.VisibleIndex = 8;
			this.coldetAmount.Width = 95;
			// 
			// colDetLAmount
			// 
			this.colDetLAmount.Caption = "L.L.";
			this.colDetLAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colDetLAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDetLAmount.FieldName = "LAmount";
			this.colDetLAmount.MinWidth = 25;
			this.colDetLAmount.Name = "colDetLAmount";
			this.colDetLAmount.Visible = true;
			this.colDetLAmount.VisibleIndex = 9;
			this.colDetLAmount.Width = 93;
			// 
			// colDetFAmount
			// 
			this.colDetFAmount.Caption = "USD";
			this.colDetFAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colDetFAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDetFAmount.FieldName = "FAmount";
			this.colDetFAmount.MinWidth = 25;
			this.colDetFAmount.Name = "colDetFAmount";
			this.colDetFAmount.Visible = true;
			this.colDetFAmount.VisibleIndex = 10;
			this.colDetFAmount.Width = 91;
			// 
			// colDetDiscount
			// 
			this.colDetDiscount.Caption = "Discount";
			this.colDetDiscount.DisplayFormat.FormatString = "{0:n2}";
			this.colDetDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDetDiscount.FieldName = "Discount";
			this.colDetDiscount.MinWidth = 25;
			this.colDetDiscount.Name = "colDetDiscount";
			this.colDetDiscount.Visible = true;
			this.colDetDiscount.VisibleIndex = 11;
			this.colDetDiscount.Width = 76;
			// 
			// colDetApproved
			// 
			this.colDetApproved.Caption = "Approved";
			this.colDetApproved.ColumnEdit = this.repCheckBox;
			this.colDetApproved.FieldName = "Approved";
			this.colDetApproved.MinWidth = 25;
			this.colDetApproved.Name = "colDetApproved";
			this.colDetApproved.Visible = true;
			this.colDetApproved.VisibleIndex = 12;
			this.colDetApproved.Width = 67;
			// 
			// repCheckBox
			// 
			this.repCheckBox.AutoHeight = false;
			this.repCheckBox.Name = "repCheckBox";
			// 
			// colDetApprovedDate
			// 
			this.colDetApprovedDate.ColumnEdit = this.repDateEdit;
			this.colDetApprovedDate.FieldName = "ApprovedDate";
			this.colDetApprovedDate.MinWidth = 25;
			this.colDetApprovedDate.Name = "colDetApprovedDate";
			this.colDetApprovedDate.Visible = true;
			this.colDetApprovedDate.VisibleIndex = 13;
			this.colDetApprovedDate.Width = 115;
			// 
			// colDetApprovedBy
			// 
			this.colDetApprovedBy.Caption = "Approved By";
			this.colDetApprovedBy.ColumnEdit = this.repApprovedBy;
			this.colDetApprovedBy.FieldName = "ApprovedBy";
			this.colDetApprovedBy.MinWidth = 25;
			this.colDetApprovedBy.Name = "colDetApprovedBy";
			this.colDetApprovedBy.Visible = true;
			this.colDetApprovedBy.VisibleIndex = 14;
			this.colDetApprovedBy.Width = 95;
			// 
			// repApprovedBy
			// 
			this.repApprovedBy.AutoHeight = false;
			this.repApprovedBy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repApprovedBy.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Approved By", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repApprovedBy.DisplayMember = "UserName";
			this.repApprovedBy.Name = "repApprovedBy";
			this.repApprovedBy.NullText = "";
			this.repApprovedBy.ValueMember = "Id";
			// 
			// colDetPaid
			// 
			this.colDetPaid.Caption = "Paid";
			this.colDetPaid.ColumnEdit = this.repCheckBox;
			this.colDetPaid.FieldName = "Paid";
			this.colDetPaid.MinWidth = 25;
			this.colDetPaid.Name = "colDetPaid";
			this.colDetPaid.Visible = true;
			this.colDetPaid.VisibleIndex = 15;
			this.colDetPaid.Width = 55;
			// 
			// colDetPaidDate
			// 
			this.colDetPaidDate.Caption = "Paid Date";
			this.colDetPaidDate.ColumnEdit = this.repDateEdit;
			this.colDetPaidDate.FieldName = "PaidDate";
			this.colDetPaidDate.MinWidth = 25;
			this.colDetPaidDate.Name = "colDetPaidDate";
			this.colDetPaidDate.Visible = true;
			this.colDetPaidDate.VisibleIndex = 16;
			this.colDetPaidDate.Width = 74;
			// 
			// colDetPaidBy
			// 
			this.colDetPaidBy.Caption = "Paid By";
			this.colDetPaidBy.ColumnEdit = this.repPaidBy;
			this.colDetPaidBy.FieldName = "PaidBy";
			this.colDetPaidBy.MinWidth = 25;
			this.colDetPaidBy.Name = "colDetPaidBy";
			this.colDetPaidBy.Visible = true;
			this.colDetPaidBy.VisibleIndex = 17;
			this.colDetPaidBy.Width = 91;
			// 
			// repPaidBy
			// 
			this.repPaidBy.AutoHeight = false;
			this.repPaidBy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repPaidBy.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("userName", "Paid By", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repPaidBy.DisplayMember = "UserName";
			this.repPaidBy.Name = "repPaidBy";
			this.repPaidBy.NullText = "";
			this.repPaidBy.ValueMember = "Id";
			// 
			// gcReceipts
			// 
			this.gcReceipts.DataSource = this.bsReceipts;
			this.gcReceipts.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcReceipts.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcReceipts.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcReceipts.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcReceipts.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcReceipts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
			gridLevelNode1.LevelTemplate = this.gvReceiptsDetails;
			gridLevelNode1.RelationName = "ReceiptsDetails";
			this.gcReceipts.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.gcReceipts.Location = new System.Drawing.Point(12, 12);
			this.gcReceipts.MainView = this.gvReceipts;
			this.gcReceipts.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
			this.gcReceipts.Name = "gcReceipts";
			this.gcReceipts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDateEdit,
            this.repCheckBox,
            this.repReceiptsType,
            this.repDepartments,
            this.repMembersType,
            this.repMembers,
            this.repCustomers,
            this.repCurrencies,
            this.repApprovedBy,
            this.repPaidBy,
            this.repypeId});
			this.gcReceipts.ShowOnlyPredefinedDetails = true;
			this.gcReceipts.Size = new System.Drawing.Size(1390, 524);
			this.gcReceipts.TabIndex = 4;
			this.gcReceipts.UseEmbeddedNavigator = true;
			this.gcReceipts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReceipts,
            this.gvReceiptsDetails});
			this.gcReceipts.DoubleClick += new System.EventHandler(this.gcReceipts_DoubleClick);
			// 
			// bsReceipts
			// 
			this.bsReceipts.DataSource = typeof(ReceiptModel);
			// 
			// gvReceipts
			// 
			this.gvReceipts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImgSelection,
            this.colId,
            this.colJobId,
            this.colDepartmentId,
            this.colReferenceNo,
            this.colReferenceId,
            this.colReceiptDate,
            this.colPostingDate,
            this.colValueDate,
            this.colReceiptTypeId,
            this.colMemberTypeId,
            this.colMemberId,
            this.colCustomerId,
            this.colCurrencyId,
            this.colRate,
            this.colAmount,
            this.colLAmount,
            this.colFAmount,
            this.colReceiptAmount,
            this.colReceiptLAmount,
            this.colReceiptFAmount,
            this.colRemainingAmount,
            this.colRemainingLAmount,
            this.colRemainingFAmount,
            this.colDiscount,
            this.colApproved,
            this.colApprovedDate,
            this.colApprovedBy,
            this.colPaid,
            this.colPaidDate,
            this.colPaidBy,
            this.colPosted,
            this.colNotes});
			this.gvReceipts.DetailHeight = 431;
			this.gvReceipts.DetailVerticalIndent = 12;
			this.gvReceipts.GridControl = this.gcReceipts;
			this.gvReceipts.Name = "gvReceipts";
			this.gvReceipts.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.False;
			this.gvReceipts.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvReceipts.OptionsBehavior.Editable = false;
			this.gvReceipts.OptionsBehavior.ReadOnly = true;
			this.gvReceipts.OptionsDetail.AllowZoomDetail = false;
			this.gvReceipts.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
			this.gvReceipts.OptionsDetail.SmartDetailHeight = true;
			this.gvReceipts.OptionsEditForm.PopupEditFormWidth = 933;
			this.gvReceipts.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Excel;
			this.gvReceipts.OptionsFind.AlwaysVisible = true;
			this.gvReceipts.OptionsFind.FindNullPrompt = "Search Receipts (Ctrl + F)";
			this.gvReceipts.OptionsSelection.MultiSelect = true;
			this.gvReceipts.OptionsView.ColumnAutoWidth = false;
			this.gvReceipts.OptionsView.ShowIndicator = false;
			this.gvReceipts.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			// 
			// colImgSelection
			// 
			this.colImgSelection.Caption = "Img";
			this.colImgSelection.FieldName = "Image";
			this.colImgSelection.ImageOptions.Image = global::MISLiveMed.UI.Properties.Resources.icon_brand_16;
			this.colImgSelection.MinWidth = 25;
			this.colImgSelection.Name = "colImgSelection";
			this.colImgSelection.OptionsColumn.AllowFocus = false;
			this.colImgSelection.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
			this.colImgSelection.OptionsColumn.AllowSize = false;
			this.colImgSelection.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
			this.colImgSelection.OptionsColumn.FixedWidth = true;
			this.colImgSelection.OptionsColumn.ShowCaption = false;
			this.colImgSelection.OptionsFilter.AllowFilter = false;
			this.colImgSelection.Visible = true;
			this.colImgSelection.VisibleIndex = 0;
			this.colImgSelection.Width = 39;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 1;
			this.colId.Width = 45;
			// 
			// colJobId
			// 
			this.colJobId.Caption = "Job#";
			this.colJobId.FieldName = "JobId";
			this.colJobId.MinWidth = 25;
			this.colJobId.Name = "colJobId";
			this.colJobId.Visible = true;
			this.colJobId.VisibleIndex = 2;
			this.colJobId.Width = 56;
			// 
			// colDepartmentId
			// 
			this.colDepartmentId.Caption = "Department";
			this.colDepartmentId.ColumnEdit = this.repDepartments;
			this.colDepartmentId.FieldName = "DepartmentId";
			this.colDepartmentId.MinWidth = 25;
			this.colDepartmentId.Name = "colDepartmentId";
			this.colDepartmentId.Visible = true;
			this.colDepartmentId.VisibleIndex = 3;
			this.colDepartmentId.Width = 119;
			// 
			// repDepartments
			// 
			this.repDepartments.AutoHeight = false;
			this.repDepartments.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repDepartments.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "Department", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repDepartments.DisplayMember = "DepartmentName";
			this.repDepartments.Name = "repDepartments";
			this.repDepartments.NullText = "";
			this.repDepartments.ValueMember = "Id";
			// 
			// colReferenceNo
			// 
			this.colReferenceNo.Caption = "XONO";
			this.colReferenceNo.FieldName = "ReferenceNo";
			this.colReferenceNo.MinWidth = 25;
			this.colReferenceNo.Name = "colReferenceNo";
			this.colReferenceNo.Visible = true;
			this.colReferenceNo.VisibleIndex = 4;
			this.colReferenceNo.Width = 92;
			// 
			// colReferenceId
			// 
			this.colReferenceId.Caption = "Reference";
			this.colReferenceId.FieldName = "ReferenceId";
			this.colReferenceId.MinWidth = 25;
			this.colReferenceId.Name = "colReferenceId";
			this.colReferenceId.Visible = true;
			this.colReferenceId.VisibleIndex = 5;
			this.colReferenceId.Width = 94;
			// 
			// colReceiptDate
			// 
			this.colReceiptDate.ColumnEdit = this.repDateEdit;
			this.colReceiptDate.FieldName = "ReceiptDate";
			this.colReceiptDate.MinWidth = 25;
			this.colReceiptDate.Name = "colReceiptDate";
			this.colReceiptDate.Visible = true;
			this.colReceiptDate.VisibleIndex = 6;
			this.colReceiptDate.Width = 106;
			// 
			// colPostingDate
			// 
			this.colPostingDate.ColumnEdit = this.repDateEdit;
			this.colPostingDate.FieldName = "PostingDate";
			this.colPostingDate.MinWidth = 25;
			this.colPostingDate.Name = "colPostingDate";
			this.colPostingDate.Visible = true;
			this.colPostingDate.VisibleIndex = 7;
			this.colPostingDate.Width = 105;
			// 
			// colValueDate
			// 
			this.colValueDate.ColumnEdit = this.repDateEdit;
			this.colValueDate.FieldName = "ValueDate";
			this.colValueDate.MinWidth = 25;
			this.colValueDate.Name = "colValueDate";
			this.colValueDate.Visible = true;
			this.colValueDate.VisibleIndex = 8;
			this.colValueDate.Width = 101;
			// 
			// colReceiptTypeId
			// 
			this.colReceiptTypeId.Caption = "Receipt Type";
			this.colReceiptTypeId.ColumnEdit = this.repReceiptsType;
			this.colReceiptTypeId.FieldName = "ReceiptTypeId";
			this.colReceiptTypeId.MinWidth = 25;
			this.colReceiptTypeId.Name = "colReceiptTypeId";
			this.colReceiptTypeId.Width = 94;
			// 
			// repReceiptsType
			// 
			this.repReceiptsType.AutoHeight = false;
			this.repReceiptsType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repReceiptsType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentType", "Payment Type", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repReceiptsType.DisplayMember = "PaymentType";
			this.repReceiptsType.Name = "repReceiptsType";
			this.repReceiptsType.NullText = "";
			this.repReceiptsType.ValueMember = "Id";
			// 
			// colMemberTypeId
			// 
			this.colMemberTypeId.Caption = "Member Type";
			this.colMemberTypeId.ColumnEdit = this.repMembersType;
			this.colMemberTypeId.FieldName = "MemberTypeId";
			this.colMemberTypeId.MinWidth = 25;
			this.colMemberTypeId.Name = "colMemberTypeId";
			this.colMemberTypeId.Width = 112;
			// 
			// repMembersType
			// 
			this.repMembersType.AutoHeight = false;
			this.repMembersType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repMembersType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Member Type", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repMembersType.DisplayMember = "Name";
			this.repMembersType.Name = "repMembersType";
			this.repMembersType.NullText = "";
			this.repMembersType.ValueMember = "Id";
			// 
			// colMemberId
			// 
			this.colMemberId.Caption = "Member";
			this.colMemberId.ColumnEdit = this.repMembers;
			this.colMemberId.FieldName = "MemberId";
			this.colMemberId.MinWidth = 25;
			this.colMemberId.Name = "colMemberId";
			this.colMemberId.Width = 94;
			// 
			// repMembers
			// 
			this.repMembers.AutoHeight = false;
			this.repMembers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repMembers.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AgentName", "Member", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repMembers.DisplayMember = "AgentName";
			this.repMembers.Name = "repMembers";
			this.repMembers.NullText = "";
			this.repMembers.ValueMember = "Id";
			// 
			// colCustomerId
			// 
			this.colCustomerId.Caption = "Customer";
			this.colCustomerId.ColumnEdit = this.repCustomers;
			this.colCustomerId.FieldName = "CustomerId";
			this.colCustomerId.MinWidth = 25;
			this.colCustomerId.Name = "colCustomerId";
			this.colCustomerId.Visible = true;
			this.colCustomerId.VisibleIndex = 9;
			this.colCustomerId.Width = 222;
			// 
			// repCustomers
			// 
			this.repCustomers.AutoHeight = false;
			this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCustomers.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCustomers.DisplayMember = "CustomerName";
			this.repCustomers.Name = "repCustomers";
			this.repCustomers.NullText = "";
			this.repCustomers.ValueMember = "Id";
			// 
			// colCurrencyId
			// 
			this.colCurrencyId.Caption = "Currency";
			this.colCurrencyId.ColumnEdit = this.repCurrencies;
			this.colCurrencyId.FieldName = "CurrencyId";
			this.colCurrencyId.MinWidth = 25;
			this.colCurrencyId.Name = "colCurrencyId";
			this.colCurrencyId.Visible = true;
			this.colCurrencyId.VisibleIndex = 10;
			this.colCurrencyId.Width = 94;
			// 
			// colRate
			// 
			this.colRate.DisplayFormat.FormatString = "{0:n2}";
			this.colRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colRate.FieldName = "Rate";
			this.colRate.MinWidth = 25;
			this.colRate.Name = "colRate";
			this.colRate.Visible = true;
			this.colRate.VisibleIndex = 11;
			this.colRate.Width = 82;
			// 
			// colAmount
			// 
			this.colAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colAmount.FieldName = "Amount";
			this.colAmount.MinWidth = 25;
			this.colAmount.Name = "colAmount";
			this.colAmount.Visible = true;
			this.colAmount.VisibleIndex = 12;
			this.colAmount.Width = 115;
			// 
			// colLAmount
			// 
			this.colLAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colLAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colLAmount.FieldName = "LAmount";
			this.colLAmount.MinWidth = 25;
			this.colLAmount.Name = "colLAmount";
			this.colLAmount.Visible = true;
			this.colLAmount.VisibleIndex = 13;
			this.colLAmount.Width = 115;
			// 
			// colFAmount
			// 
			this.colFAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colFAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colFAmount.FieldName = "FAmount";
			this.colFAmount.MinWidth = 25;
			this.colFAmount.Name = "colFAmount";
			this.colFAmount.Visible = true;
			this.colFAmount.VisibleIndex = 14;
			this.colFAmount.Width = 115;
			// 
			// colReceiptAmount
			// 
			this.colReceiptAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colReceiptAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colReceiptAmount.FieldName = "ReceiptAmount";
			this.colReceiptAmount.MinWidth = 25;
			this.colReceiptAmount.Name = "colReceiptAmount";
			this.colReceiptAmount.Visible = true;
			this.colReceiptAmount.VisibleIndex = 15;
			this.colReceiptAmount.Width = 115;
			// 
			// colReceiptLAmount
			// 
			this.colReceiptLAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colReceiptLAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colReceiptLAmount.FieldName = "ReceiptLAmount";
			this.colReceiptLAmount.MinWidth = 25;
			this.colReceiptLAmount.Name = "colReceiptLAmount";
			this.colReceiptLAmount.Visible = true;
			this.colReceiptLAmount.VisibleIndex = 16;
			this.colReceiptLAmount.Width = 115;
			// 
			// colReceiptFAmount
			// 
			this.colReceiptFAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colReceiptFAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colReceiptFAmount.FieldName = "ReceiptFAmount";
			this.colReceiptFAmount.MinWidth = 25;
			this.colReceiptFAmount.Name = "colReceiptFAmount";
			this.colReceiptFAmount.Visible = true;
			this.colReceiptFAmount.VisibleIndex = 17;
			this.colReceiptFAmount.Width = 115;
			// 
			// colRemainingAmount
			// 
			this.colRemainingAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colRemainingAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colRemainingAmount.FieldName = "RemainingAmount";
			this.colRemainingAmount.MinWidth = 25;
			this.colRemainingAmount.Name = "colRemainingAmount";
			this.colRemainingAmount.Visible = true;
			this.colRemainingAmount.VisibleIndex = 18;
			this.colRemainingAmount.Width = 115;
			// 
			// colRemainingLAmount
			// 
			this.colRemainingLAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colRemainingLAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colRemainingLAmount.FieldName = "RemainingLAmount";
			this.colRemainingLAmount.MinWidth = 25;
			this.colRemainingLAmount.Name = "colRemainingLAmount";
			this.colRemainingLAmount.Visible = true;
			this.colRemainingLAmount.VisibleIndex = 19;
			this.colRemainingLAmount.Width = 115;
			// 
			// colRemainingFAmount
			// 
			this.colRemainingFAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colRemainingFAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colRemainingFAmount.FieldName = "RemainingFAmount";
			this.colRemainingFAmount.MinWidth = 25;
			this.colRemainingFAmount.Name = "colRemainingFAmount";
			this.colRemainingFAmount.Visible = true;
			this.colRemainingFAmount.VisibleIndex = 20;
			this.colRemainingFAmount.Width = 115;
			// 
			// colDiscount
			// 
			this.colDiscount.DisplayFormat.FormatString = "{0:n2}";
			this.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDiscount.FieldName = "Discount";
			this.colDiscount.MinWidth = 25;
			this.colDiscount.Name = "colDiscount";
			this.colDiscount.Visible = true;
			this.colDiscount.VisibleIndex = 21;
			this.colDiscount.Width = 94;
			// 
			// colApproved
			// 
			this.colApproved.ColumnEdit = this.repCheckBox;
			this.colApproved.FieldName = "Approved";
			this.colApproved.MinWidth = 25;
			this.colApproved.Name = "colApproved";
			this.colApproved.Visible = true;
			this.colApproved.VisibleIndex = 22;
			this.colApproved.Width = 94;
			// 
			// colApprovedDate
			// 
			this.colApprovedDate.ColumnEdit = this.repDateEdit;
			this.colApprovedDate.FieldName = "ApprovedDate";
			this.colApprovedDate.MinWidth = 25;
			this.colApprovedDate.Name = "colApprovedDate";
			this.colApprovedDate.Visible = true;
			this.colApprovedDate.VisibleIndex = 23;
			this.colApprovedDate.Width = 94;
			// 
			// colApprovedBy
			// 
			this.colApprovedBy.ColumnEdit = this.repApprovedBy;
			this.colApprovedBy.FieldName = "ApprovedBy";
			this.colApprovedBy.MinWidth = 25;
			this.colApprovedBy.Name = "colApprovedBy";
			this.colApprovedBy.Visible = true;
			this.colApprovedBy.VisibleIndex = 24;
			this.colApprovedBy.Width = 94;
			// 
			// colPaid
			// 
			this.colPaid.ColumnEdit = this.repCheckBox;
			this.colPaid.FieldName = "Paid";
			this.colPaid.MinWidth = 25;
			this.colPaid.Name = "colPaid";
			this.colPaid.Visible = true;
			this.colPaid.VisibleIndex = 25;
			this.colPaid.Width = 94;
			// 
			// colPaidDate
			// 
			this.colPaidDate.ColumnEdit = this.repDateEdit;
			this.colPaidDate.FieldName = "PaidDate";
			this.colPaidDate.MinWidth = 25;
			this.colPaidDate.Name = "colPaidDate";
			this.colPaidDate.Visible = true;
			this.colPaidDate.VisibleIndex = 26;
			this.colPaidDate.Width = 94;
			// 
			// colPaidBy
			// 
			this.colPaidBy.ColumnEdit = this.repPaidBy;
			this.colPaidBy.FieldName = "PaidBy";
			this.colPaidBy.MinWidth = 25;
			this.colPaidBy.Name = "colPaidBy";
			this.colPaidBy.Visible = true;
			this.colPaidBy.VisibleIndex = 27;
			this.colPaidBy.Width = 94;
			// 
			// colPosted
			// 
			this.colPosted.ColumnEdit = this.repCheckBox;
			this.colPosted.FieldName = "Posted";
			this.colPosted.MinWidth = 25;
			this.colPosted.Name = "colPosted";
			this.colPosted.Visible = true;
			this.colPosted.VisibleIndex = 28;
			this.colPosted.Width = 94;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 29;
			this.colNotes.Width = 94;
			// 
			// repypeId
			// 
			this.repypeId.AutoHeight = false;
			this.repypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repypeId.Name = "repypeId";
			// 
			// rcReceipts
			// 
			this.rcReceipts.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcReceipts.ExpandCollapseItem.Id = 0;
			this.rcReceipts.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcReceipts.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btnEdit,
            this.btnPrint,
            this.rgFilterReports,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barSubItem2,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barSubItem3,
            this.barCheckItem5,
            this.barCheckItem6,
            this.barButtonItem13,
            this.barCheckItem7,
            this.barButtonItem14,
            this.barCheckItem4,
            this.barCheckItem3,
            this.barButtonItem15,
            this.barHeaderItem1,
            this.btnRefresh,
            this.btnClose,
            this.cboDepartments,
            this.cboSalesList,
            this.cboStatus,
            this.chkSortByBookedDate,
            this.barCheckItem8,
            this.btnPrintFilter,
            this.btnResetGridStyle});
			this.rcReceipts.Location = new System.Drawing.Point(0, 0);
			this.rcReceipts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcReceipts.MaxItemId = 61;
			this.rcReceipts.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcReceipts.Name = "rcReceipts";
			this.rcReceipts.OptionsMenuMinWidth = 385;
			this.rcReceipts.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpReceipts,
            this.rpViewSettings});
			this.rcReceipts.Size = new System.Drawing.Size(1414, 193);
			this.rcReceipts.StatusBar = this.ribbonStatusBar1;
			// 
			// btnNew
			// 
			this.btnNew.Caption = "Add New";
			this.btnNew.Enabled = false;
			this.btnNew.Id = 1;
			this.btnNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnNew.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg";
			this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
			this.btnNew.Name = "btnNew";
			this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Caption = "Cancel";
			this.btnDelete.Enabled = false;
			this.btnDelete.Id = 3;
			this.btnDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg";
			this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Caption = "New Member Type";
			this.barButtonItem5.Id = 11;
			this.barButtonItem5.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg?Size=16x16";
			this.barButtonItem5.Name = "barButtonItem5";
			// 
			// barButtonItem6
			// 
			this.barButtonItem6.Caption = "New Group";
			this.barButtonItem6.Id = 12;
			this.barButtonItem6.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewGroup.svg?Size=16x16";
			this.barButtonItem6.Name = "barButtonItem6";
			// 
			// btnEdit
			// 
			this.btnEdit.Caption = "Edit";
			this.btnEdit.Enabled = false;
			this.btnEdit.Id = 13;
			this.btnEdit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnEdit.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Edit.svg";
			this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
			// 
			// btnPrint
			// 
			this.btnPrint.Caption = "Print View";
			this.btnPrint.Enabled = false;
			this.btnPrint.Id = 16;
			this.btnPrint.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnPrint.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesAnalysis.svg";
			this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
			// 
			// rgFilterReports
			// 
			this.rgFilterReports.Caption = "Quick Reports";
			// 
			// 
			// 
			this.rgFilterReports.Gallery.ColumnCount = 2;
			this.rgFilterReports.Gallery.DrawImageBackground = false;
			galleryItemGroup1.Caption = "FilterGroup";
			galleryItem1.Caption = "Pending Receipts";
			galleryItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
			galleryItem1.Value = "showPendingReceipts";
			galleryItem2.Caption = "Paid Receipts";
			galleryItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
			galleryItem2.Value = "showPaidReceipts";
			galleryItem3.Caption = "All";
			galleryItem3.Checked = true;
			galleryItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
			galleryItem3.Value = "showAll";
			galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3});
			this.rgFilterReports.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
			this.rgFilterReports.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
			this.rgFilterReports.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			skinPaddingEdges1.Bottom = -4;
			skinPaddingEdges1.Top = -4;
			this.rgFilterReports.Gallery.ItemImagePadding = skinPaddingEdges1;
			skinPaddingEdges2.Bottom = -1;
			skinPaddingEdges2.Top = -1;
			this.rgFilterReports.Gallery.ItemTextPadding = skinPaddingEdges2;
			this.rgFilterReports.Gallery.ShowItemText = true;
			this.rgFilterReports.Id = 17;
			this.rgFilterReports.Name = "rgFilterReports";
			// 
			// barButtonItem8
			// 
			this.barButtonItem8.Caption = "Sales Summary";
			this.barButtonItem8.Id = 18;
			this.barButtonItem8.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem8.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesSummary2.svg?Size=16x16";
			this.barButtonItem8.Name = "barButtonItem8";
			// 
			// barButtonItem9
			// 
			this.barButtonItem9.Caption = "Member Type Profile";
			this.barButtonItem9.Id = 19;
			this.barButtonItem9.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem9.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ProfileReport.svg?Size=16x16";
			this.barButtonItem9.Name = "barButtonItem9";
			// 
			// barButtonItem10
			// 
			this.barButtonItem10.Caption = "Employees";
			this.barButtonItem10.Id = 20;
			this.barButtonItem10.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem10.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.EmployeeCard.svg?Size=16x16";
			this.barButtonItem10.Name = "barButtonItem10";
			// 
			// barSubItem2
			// 
			this.barSubItem2.Caption = "Change View";
			this.barSubItem2.Id = 21;
			this.barSubItem2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barSubItem2.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ChangeView.svg";
			this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem4)});
			this.barSubItem2.Name = "barSubItem2";
			this.barSubItem2.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
			// 
			// barCheckItem3
			// 
			this.barCheckItem3.Caption = "List";
			this.barCheckItem3.Id = 33;
			this.barCheckItem3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem3.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.List.svg?Size=32x32";
			this.barCheckItem3.Name = "barCheckItem3";
			// 
			// barCheckItem4
			// 
			this.barCheckItem4.Caption = "Card";
			this.barCheckItem4.Id = 32;
			this.barCheckItem4.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem4.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Card.svg";
			this.barCheckItem4.Name = "barCheckItem4";
			// 
			// barButtonItem11
			// 
			this.barButtonItem11.Caption = "View Settings";
			this.barButtonItem11.Id = 22;
			this.barButtonItem11.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem11.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ViewSetting.svg";
			this.barButtonItem11.Name = "barButtonItem11";
			// 
			// barButtonItem12
			// 
			this.barButtonItem12.Caption = "Reset View";
			this.barButtonItem12.Id = 23;
			this.barButtonItem12.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem12.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ResetView.svg";
			this.barButtonItem12.Name = "barButtonItem12";
			// 
			// barSubItem3
			// 
			this.barSubItem3.Caption = "Data Pane";
			this.barSubItem3.Id = 24;
			this.barSubItem3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barSubItem3.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.DataPanel.svg";
			this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem6)});
			this.barSubItem3.Name = "barSubItem3";
			this.barSubItem3.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
			// 
			// barCheckItem5
			// 
			this.barCheckItem5.Caption = "Right";
			this.barCheckItem5.Id = 25;
			this.barCheckItem5.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem5.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelRight.svg?Size=16x16";
			this.barCheckItem5.Name = "barCheckItem5";
			// 
			// barCheckItem6
			// 
			this.barCheckItem6.Caption = "Off";
			this.barCheckItem6.Id = 27;
			this.barCheckItem6.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem6.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelOff.svg?Size=16x16";
			this.barCheckItem6.Name = "barCheckItem6";
			// 
			// barButtonItem13
			// 
			this.barButtonItem13.Caption = "Reverse Sort";
			this.barButtonItem13.Id = 28;
			this.barButtonItem13.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem13.ImageOptions.ImageUri.Uri = "outlook%20inspired/reverssort;Size16x16";
			this.barButtonItem13.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			this.barButtonItem13.Name = "barButtonItem13";
			// 
			// barCheckItem7
			// 
			this.barCheckItem7.Caption = "Add Columns";
			this.barCheckItem7.Id = 30;
			this.barCheckItem7.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem7.ImageOptions.ImageUri.Uri = "outlook%20inspired/addcolumn;Size16x16";
			this.barCheckItem7.Name = "barCheckItem7";
			// 
			// barButtonItem14
			// 
			this.barButtonItem14.Caption = "Expand/Collapse";
			this.barButtonItem14.Id = 31;
			this.barButtonItem14.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem14.ImageOptions.ImageUri.Uri = "outlook%20inspired/expandcollapse;Size16x16";
			this.barButtonItem14.Name = "barButtonItem14";
			// 
			// barButtonItem15
			// 
			this.barButtonItem15.Caption = "Sales Detail";
			this.barButtonItem15.Id = 34;
			this.barButtonItem15.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem15.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesInvoise2.svg?Size=16x16";
			this.barButtonItem15.Name = "barButtonItem15";
			// 
			// barHeaderItem1
			// 
			this.barHeaderItem1.Caption = "RECORDS: 0";
			this.barHeaderItem1.Id = 35;
			this.barHeaderItem1.Name = "barHeaderItem1";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Caption = "Refresh";
			this.btnRefresh.Id = 37;
			this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
			// 
			// btnClose
			// 
			this.btnClose.Caption = "Close";
			this.btnClose.Id = 38;
			this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
			this.btnClose.Name = "btnClose";
			this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
			// 
			// cboDepartments
			// 
			this.cboDepartments.Caption = "By Departments";
			this.cboDepartments.CaptionToEditorIndent = 6;
			this.cboDepartments.Edit = null;
			this.cboDepartments.EditWidth = 150;
			this.cboDepartments.Id = 39;
			this.cboDepartments.Name = "cboDepartments";
			// 
			// cboSalesList
			// 
			this.cboSalesList.Caption = "By Sales";
			this.cboSalesList.CaptionToEditorIndent = 40;
			this.cboSalesList.Edit = null;
			this.cboSalesList.EditWidth = 150;
			this.cboSalesList.Id = 40;
			this.cboSalesList.Name = "cboSalesList";
			// 
			// cboStatus
			// 
			this.cboStatus.Caption = "By Status";
			this.cboStatus.CaptionToEditorIndent = 37;
			this.cboStatus.Edit = null;
			this.cboStatus.EditWidth = 150;
			this.cboStatus.Id = 44;
			this.cboStatus.Name = "cboStatus";
			// 
			// chkSortByBookedDate
			// 
			this.chkSortByBookedDate.Caption = "Sort By Booked Date";
			this.chkSortByBookedDate.Id = 51;
			this.chkSortByBookedDate.Name = "chkSortByBookedDate";
			// 
			// barCheckItem8
			// 
			this.barCheckItem8.Caption = "Sort By Followup Date";
			this.barCheckItem8.Id = 52;
			this.barCheckItem8.Name = "barCheckItem8";
			// 
			// btnPrintFilter
			// 
			this.btnPrintFilter.Caption = "Print Filter";
			this.btnPrintFilter.Enabled = false;
			this.btnPrintFilter.Id = 58;
			this.btnPrintFilter.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintFilter.ImageOptions.SvgImage")));
			this.btnPrintFilter.Name = "btnPrintFilter";
			this.btnPrintFilter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintFilter_ItemClick);
			// 
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 60;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// rpReceipts
			// 
			this.rpReceipts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup2});
			this.rpReceipts.Name = "rpReceipts";
			this.rpReceipts.Text = "RECEIPTS";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.AllowTextClipping = false;
			this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "New";
			// 
			// ribbonPageGroup6
			// 
			this.ribbonPageGroup6.AllowTextClipping = false;
			this.ribbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup6.ItemLinks.Add(this.btnEdit);
			this.ribbonPageGroup6.ItemLinks.Add(this.btnRefresh);
			this.ribbonPageGroup6.ItemLinks.Add(this.btnPrint);
			this.ribbonPageGroup6.ItemLinks.Add(this.btnPrintFilter, true);
			this.ribbonPageGroup6.Name = "ribbonPageGroup6";
			this.ribbonPageGroup6.Text = "Actions";
			// 
			// ribbonPageGroup8
			// 
			this.ribbonPageGroup8.AllowTextClipping = false;
			this.ribbonPageGroup8.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup8.ItemLinks.Add(this.btnDelete);
			this.ribbonPageGroup8.Name = "ribbonPageGroup8";
			this.ribbonPageGroup8.Text = "Delete";
			// 
			// ribbonPageGroup9
			// 
			this.ribbonPageGroup9.AllowTextClipping = false;
			this.ribbonPageGroup9.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup9.ItemLinks.Add(this.rgFilterReports);
			this.ribbonPageGroup9.Name = "ribbonPageGroup9";
			this.ribbonPageGroup9.Text = "Filter Reports";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
			this.ribbonPageGroup2.ItemLinks.Add(this.btnClose);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Close View";
			// 
			// rpViewSettings
			// 
			this.rpViewSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
			this.rpViewSettings.Name = "rpViewSettings";
			this.rpViewSettings.Text = "VIEW SETTINGS";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.btnResetGridStyle);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Grid Settings";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 741);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcReceipts;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1414, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcReceipts);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1414, 548);
			this.mainLayout.TabIndex = 5;
			this.mainLayout.Text = "layoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1414, 548);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcReceipts;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1394, 528);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// ReceiptsListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1414, 771);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcReceipts);
			this.Name = "ReceiptsListForm";
			this.Ribbon = this.rcReceipts;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Receipts List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceiptsListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.gvReceiptsDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateEdit.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repApprovedBy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repPaidBy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcReceipts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsReceipts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvReceipts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDepartments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repReceiptsType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMembersType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMembers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repypeId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rcReceipts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraBars.Ribbon.RibbonControl rcReceipts;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgFilterReports;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarCheckItem barCheckItem3;
        private DevExpress.XtraBars.BarCheckItem barCheckItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarCheckItem barCheckItem5;
        private DevExpress.XtraBars.BarCheckItem barCheckItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarCheckItem barCheckItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarEditItem cboDepartments;
        private DevExpress.XtraBars.BarEditItem cboSalesList;
        private DevExpress.XtraBars.BarEditItem cboStatus;
        private DevExpress.XtraBars.BarCheckItem chkSortByBookedDate;
        private DevExpress.XtraBars.BarCheckItem barCheckItem8;
        private DevExpress.XtraBars.BarButtonItem btnPrintFilter;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReceipts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.BindingSource bsReceipts;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraGrid.GridControl gcReceipts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReceiptsDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReceipts;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colPostingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colValueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colJobId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceId;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn colRate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptLAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptFAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingLAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingFAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colApproved;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidBy;
        private DevExpress.XtraGrid.Columns.GridColumn colPosted;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repReceiptsType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repDepartments;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMembersType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMembers;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCustomers;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCurrencies;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repApprovedBy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPaidBy;
        private DevExpress.XtraGrid.Columns.GridColumn colDetId;
        private DevExpress.XtraGrid.Columns.GridColumn colDetReceiptId;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptDetailDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDetReferenceId;
        private DevExpress.XtraGrid.Columns.GridColumn colDetValueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn colDetRate;
        private DevExpress.XtraGrid.Columns.GridColumn coldetAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDetLAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDetFAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDetDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colDetApproved;
        private DevExpress.XtraGrid.Columns.GridColumn colDetApprovedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDetApprovedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colDetPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colDetPaidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDetPaidBy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colImgSelection;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
	}
}