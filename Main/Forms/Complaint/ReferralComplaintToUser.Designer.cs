namespace RASF.Main.Forms.Complaint
{
    partial class ReferralComplaintToUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferralComplaintToUser));
            Janus.Windows.GridEX.GridEXLayout grdReferral_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdReferral = new RASF.General.Controls.Grid();
            this.referralComplaintToUserList1 = new RASF.General.Lists.ReferralComplaintToUserList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.textBox1 = new RASF.General.Controls.TextBox();
            this.sabtCompanyUserList1 = new RASF.General.Lists.SabtCompanyUserList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReferral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 536);
            this.pnlButton.Size = new System.Drawing.Size(811, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(811, 536);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(606, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(689, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(751, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdReferral);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReferral
            // 
            this.grdReferral.AlowRetrieveStructure = false;
            this.grdReferral.AlternatingColors = true;
            this.grdReferral.BuiltInTextsData = resources.GetString("grdReferral.BuiltInTextsData");
            this.grdReferral.DataSource = this.referralComplaintToUserList1;
            this.grdReferral.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReferral_DesignTimeLayout.LayoutString = resources.GetString("grdReferral_DesignTimeLayout.LayoutString");
            this.grdReferral.DesignTimeLayout = grdReferral_DesignTimeLayout;
            this.grdReferral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReferral.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReferral.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReferral.GroupByBoxVisible = false;
            this.grdReferral.Location = new System.Drawing.Point(3, 8);
            this.grdReferral.Name = "grdReferral";
            this.grdReferral.RecordNavigator = true;
            this.grdReferral.Size = new System.Drawing.Size(805, 376);
            this.grdReferral.TabIndex = 0;
            this.grdReferral.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReferral.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "توضیحات";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.referralComplaintToUserList1, "Description", true));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(805, 129);
            this.textBox1.TabIndex = 0;
            this.textBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // ReferralComplaintToUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 566);
            this.Name = "ReferralComplaintToUser";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ReferralComplaintToUser";
            this.Load += new System.EventHandler(this.ReferralComplaintToUser_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReferral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Grid grdReferral;
        private General.Lists.ReferralComplaintToUserList referralComplaintToUserList1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.TextBox textBox1;
        private General.Lists.SabtCompanyUserList sabtCompanyUserList1;
    }
}