namespace MISLiveMed.UI.Accounting.Currencies
{
	partial class ExchangeRateForm
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
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
			this.gcCrossExchangeRate = new DevExpress.XtraGrid.GridControl();
			this.gvCrossExchangeRate = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcCrossExchangeRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCrossExchangeRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.btnClose);
			this.mainLayout.Controls.Add(this.btnPrint);
			this.mainLayout.Controls.Add(this.gcCrossExchangeRate);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 0);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1266, 681);
			this.mainLayout.TabIndex = 0;
			this.mainLayout.Text = "layoutControl1";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(1131, 642);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(123, 27);
			this.btnClose.StyleController = this.mainLayout;
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(1004, 642);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(123, 27);
			this.btnPrint.StyleController = this.mainLayout;
			this.btnPrint.TabIndex = 5;
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// gcCrossExchangeRate
			// 
			this.gcCrossExchangeRate.Location = new System.Drawing.Point(12, 12);
			this.gcCrossExchangeRate.MainView = this.gvCrossExchangeRate;
			this.gcCrossExchangeRate.Name = "gcCrossExchangeRate";
			this.gcCrossExchangeRate.Size = new System.Drawing.Size(1242, 575);
			this.gcCrossExchangeRate.TabIndex = 4;
			this.gcCrossExchangeRate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCrossExchangeRate});
			// 
			// gvCrossExchangeRate
			// 
			this.gvCrossExchangeRate.GridControl = this.gcCrossExchangeRate;
			this.gvCrossExchangeRate.Name = "gvCrossExchangeRate";
			this.gvCrossExchangeRate.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvCrossExchangeRate.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvCrossExchangeRate.OptionsBehavior.Editable = false;
			this.gvCrossExchangeRate.OptionsBehavior.ReadOnly = true;
			this.gvCrossExchangeRate.OptionsView.ShowGroupPanel = false;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1266, 681);
			this.Root.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 630);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(992, 31);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 579);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(1246, 51);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcCrossExchangeRate;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1246, 579);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.btnClose;
			this.layoutControlItem3.Location = new System.Drawing.Point(1119, 630);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(127, 31);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.btnPrint;
			this.layoutControlItem2.Location = new System.Drawing.Point(992, 630);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(127, 31);
			this.layoutControlItem2.TextVisible = false;
			// 
			// ExchangeRateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1266, 681);
			this.Controls.Add(this.mainLayout);
			this.Name = "ExchangeRateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cross Exchange Rate";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExchangeRateForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcCrossExchangeRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCrossExchangeRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraGrid.GridControl gcCrossExchangeRate;
		private DevExpress.XtraGrid.Views.Grid.GridView gvCrossExchangeRate;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraEditors.SimpleButton btnClose;
		private DevExpress.XtraEditors.SimpleButton btnPrint;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
	}
}