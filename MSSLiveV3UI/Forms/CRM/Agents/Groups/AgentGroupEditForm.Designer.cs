using MISLiveMed.Models.Models.Members.Agents;

namespace MISLiveMed.UI.Forms.CRM.Agents.Groups
{
    partial class AgentGroupEditForm
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
			this.txtId = new DevExpress.XtraEditors.TextEdit();
			this.bsAgentsGroup = new System.Windows.Forms.BindingSource(this.components);
			this.chkActive = new DevExpress.XtraEditors.CheckEdit();
			this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.txtName = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.grpNoted = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.grpAgentGroup = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblName = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblId = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAgentsGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpNoted)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpAgentGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			this.SuspendLayout();
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.txtId);
			this.mainLayout.Controls.Add(this.chkActive);
			this.mainLayout.Controls.Add(this.txtNotes);
			this.mainLayout.Controls.Add(this.btnCancel);
			this.mainLayout.Controls.Add(this.btnSave);
			this.mainLayout.Controls.Add(this.txtName);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 0);
			this.mainLayout.Margin = new System.Windows.Forms.Padding(4);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(738, 385, 450, 350);
			this.mainLayout.Root = this.layoutControlGroup1;
			this.mainLayout.Size = new System.Drawing.Size(598, 401);
			this.mainLayout.TabIndex = 8;
			this.mainLayout.Text = "layoutControl1";
			// 
			// txtId
			// 
			this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAgentsGroup, "Id", true));
			this.txtId.Location = new System.Drawing.Point(69, 60);
			this.txtId.Name = "txtId";
			this.txtId.Properties.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(228, 22);
			this.txtId.StyleController = this.mainLayout;
			this.txtId.TabIndex = 0;
			this.txtId.TabStop = false;
			// 
			// bsAgentsGroup
			// 
			this.bsAgentsGroup.DataSource = typeof(AgentGroupModel);
			// 
			// chkActive
			// 
			this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAgentsGroup, "Active", true));
			this.chkActive.Enabled = false;
			this.chkActive.Location = new System.Drawing.Point(71, 112);
			this.chkActive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.chkActive.Name = "chkActive";
			this.chkActive.Properties.Caption = "Active";
			this.chkActive.Size = new System.Drawing.Size(503, 24);
			this.chkActive.StyleController = this.mainLayout;
			this.chkActive.TabIndex = 2;
			// 
			// txtNotes
			// 
			this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAgentsGroup, "Notes", true));
			this.txtNotes.Location = new System.Drawing.Point(24, 190);
			this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.ReadOnly = true;
			this.txtNotes.Size = new System.Drawing.Size(550, 140);
			this.txtNotes.StyleController = this.mainLayout;
			this.txtNotes.TabIndex = 3;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(463, 362);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(123, 27);
			this.btnCancel.StyleController = this.mainLayout;
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(352, 362);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(107, 27);
			this.btnSave.StyleController = this.mainLayout;
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAgentsGroup, "Description", true));
			this.txtName.Location = new System.Drawing.Point(69, 86);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Properties.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(505, 22);
			this.txtName.StyleController = this.mainLayout;
			this.txtName.TabIndex = 1;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.grpNoted,
            this.grpAgentGroup});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(598, 401);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 334);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(578, 16);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 350);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(340, 31);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnSave;
			this.layoutControlItem4.Location = new System.Drawing.Point(340, 350);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(111, 31);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.btnCancel;
			this.layoutControlItem5.Location = new System.Drawing.Point(451, 350);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(127, 31);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// grpNoted
			// 
			this.grpNoted.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpNoted.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
			this.grpNoted.Location = new System.Drawing.Point(0, 140);
			this.grpNoted.Name = "grpNoted";
			this.grpNoted.Size = new System.Drawing.Size(578, 194);
			this.grpNoted.Text = "Notes";
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.txtNotes;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(554, 144);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// grpAgentGroup
			// 
			this.grpAgentGroup.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpAgentGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblName,
            this.emptySpaceItem3,
            this.lblId,
            this.layoutControlItem1,
            this.emptySpaceItem4,
            this.emptySpaceItem5});
			this.grpAgentGroup.Location = new System.Drawing.Point(0, 0);
			this.grpAgentGroup.Name = "grpAgentGroup";
			this.grpAgentGroup.Size = new System.Drawing.Size(578, 140);
			this.grpAgentGroup.Text = "Agent Group Info";
			// 
			// lblName
			// 
			this.lblName.Control = this.txtName;
			this.lblName.CustomizationFormText = "Group Name:";
			this.lblName.Location = new System.Drawing.Point(0, 36);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(554, 26);
			this.lblName.Text = "Name";
			this.lblName.TextSize = new System.Drawing.Size(33, 16);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(554, 10);
			this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
			// 
			// lblId
			// 
			this.lblId.Control = this.txtId;
			this.lblId.Location = new System.Drawing.Point(0, 10);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(277, 26);
			this.lblId.Text = "Id";
			this.lblId.TextSize = new System.Drawing.Size(33, 16);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.chkActive;
			this.layoutControlItem1.Location = new System.Drawing.Point(47, 62);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(507, 28);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.AllowHotTrack = false;
			this.emptySpaceItem4.Location = new System.Drawing.Point(0, 62);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(47, 28);
			this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.AllowHotTrack = false;
			this.emptySpaceItem5.Location = new System.Drawing.Point(277, 10);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(277, 26);
			this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
			// 
			// AgentGroupEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 401);
			this.Controls.Add(this.mainLayout);
			this.MaximizeBox = false;
			this.Name = "AgentGroupEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Agent Group";
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAgentsGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpNoted)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpAgentGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.MemoEdit txtNotes;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup grpNoted;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup grpAgentGroup;
        private DevExpress.XtraLayout.LayoutControlItem lblName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem lblId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private System.Windows.Forms.BindingSource bsAgentsGroup;
    }
}