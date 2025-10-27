namespace MISLiveMed.UI.Forms.CRM.Customers
{
    partial class CustomerQuickAddForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
			this.txtCustomerId = new DevExpress.XtraEditors.TextEdit();
			this.cboSales = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblCityId = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblCustomerName = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblSales = new DevExpress.XtraLayout.LayoutControlItem();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustomerId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSales.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCityId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCustomerName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSales)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.09945F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.90055F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
			this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.05128F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.94872F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 264);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// layoutControl1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.layoutControl1, 3);
			this.layoutControl1.Controls.Add(this.txtCustomerName);
			this.layoutControl1.Controls.Add(this.txtCustomerId);
			this.layoutControl1.Controls.Add(this.cboSales);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(3, 4);
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(504, 208);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(128, 86);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(352, 22);
			this.txtCustomerName.StyleController = this.layoutControl1;
			this.txtCustomerName.TabIndex = 5;
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Location = new System.Drawing.Point(128, 50);
			this.txtCustomerId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Properties.ReadOnly = true;
			this.txtCustomerId.Size = new System.Drawing.Size(102, 22);
			this.txtCustomerId.StyleController = this.layoutControl1;
			this.txtCustomerId.TabIndex = 0;
			this.txtCustomerId.TabStop = false;
			// 
			// cboSales
			// 
			this.cboSales.Location = new System.Drawing.Point(128, 112);
			this.cboSales.Name = "cboSales";
			this.cboSales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboSales.Properties.DisplayMember = "UserName";
			this.cboSales.Properties.NullText = "";
			this.cboSales.Properties.PopupView = this.searchLookUpEdit1View;
			this.cboSales.Properties.ValueMember = "Id";
			this.cboSales.Size = new System.Drawing.Size(352, 22);
			this.cboSales.StyleController = this.layoutControl1;
			this.cboSales.TabIndex = 6;
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Id";
			this.gridColumn1.FieldName = "Id";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 127;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Name";
			this.gridColumn2.FieldName = "UserName";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 913;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(504, 208);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblCityId,
            this.emptySpaceItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.lblCustomerName,
            this.lblSales});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(484, 188);
			this.layoutControlGroup2.Text = "Add New Customer";
			// 
			// lblCityId
			// 
			this.lblCityId.Control = this.txtCustomerId;
			this.lblCityId.Location = new System.Drawing.Point(0, 0);
			this.lblCityId.Name = "lblCityId";
			this.lblCityId.Size = new System.Drawing.Size(210, 26);
			this.lblCityId.Text = "Customer Id";
			this.lblCityId.TextSize = new System.Drawing.Size(92, 16);
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.AllowHotTrack = false;
			this.emptySpaceItem4.Location = new System.Drawing.Point(210, 0);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(250, 26);
			this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 88);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(460, 50);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 26);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(460, 10);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.Control = this.txtCustomerName;
			this.lblCustomerName.Location = new System.Drawing.Point(0, 36);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(460, 26);
			this.lblCustomerName.Text = "Customer Name";
			this.lblCustomerName.TextSize = new System.Drawing.Size(92, 16);
			// 
			// lblSales
			// 
			this.lblSales.Control = this.cboSales;
			this.lblSales.Location = new System.Drawing.Point(0, 62);
			this.lblSales.Name = "lblSales";
			this.lblSales.Size = new System.Drawing.Size(460, 26);
			this.lblSales.Text = "Sales";
			this.lblSales.TextSize = new System.Drawing.Size(92, 16);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(297, 220);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(87, 28);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(411, 220);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(87, 28);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// AddCustomerForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(510, 264);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.Name = "AddCustomerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Quick Add New Customer";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustomerId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSales.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCityId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCustomerName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSales)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtCustomerId;
        private DevExpress.XtraEditors.SearchLookUpEdit cboSales;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lblCityId;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem lblCustomerName;
        private DevExpress.XtraLayout.LayoutControlItem lblSales;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}