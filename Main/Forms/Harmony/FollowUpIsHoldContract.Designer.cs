namespace RASF.Main.Forms.Harmony
{
    partial class FollowUpIsHoldContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FollowUpIsHoldContract));
            Janus.Windows.GridEX.GridEXLayout grdFlolow_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.followUpIsHoldContractList1 = new RASF.General.Lists.FollowUpIsHoldContractList(this.components);
            this.grpFollow = new RASF.General.Controls.GroupBox();
            this.grdFlolow = new RASF.General.Controls.Grid();
            this.grpDesc = new RASF.General.Controls.GroupBox();
            this.txtFollow = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFollow)).BeginInit();
            this.grpFollow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFlolow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDesc)).BeginInit();
            this.grpDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 616);
            this.pnlButton.Size = new System.Drawing.Size(850, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpDesc);
            this.pnlContent.Controls.Add(this.grpFollow);
            this.pnlContent.Size = new System.Drawing.Size(850, 616);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(645, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(728, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(790, 0);
            // 
            // grpFollow
            // 
            this.grpFollow.Controls.Add(this.grdFlolow);
            this.grpFollow.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFollow.Location = new System.Drawing.Point(0, 0);
            this.grpFollow.Name = "grpFollow";
            this.grpFollow.Size = new System.Drawing.Size(850, 380);
            this.grpFollow.TabIndex = 0;
            this.grpFollow.Text = "قراردادهای مسئله دار";
            this.grpFollow.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdFlolow
            // 
            this.grdFlolow.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdFlolow.AlowRetrieveStructure = false;
            this.grdFlolow.AlternatingColors = true;
            this.grdFlolow.BuiltInTextsData = resources.GetString("grdFlolow.BuiltInTextsData");
            this.grdFlolow.DataSource = this.followUpIsHoldContractList1;
            this.grdFlolow.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdFlolow_DesignTimeLayout.LayoutString = resources.GetString("grdFlolow_DesignTimeLayout.LayoutString");
            this.grdFlolow.DesignTimeLayout = grdFlolow_DesignTimeLayout;
            this.grdFlolow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFlolow.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdFlolow.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdFlolow.GroupByBoxVisible = false;
            this.grdFlolow.Location = new System.Drawing.Point(3, 17);
            this.grdFlolow.Name = "grdFlolow";
            this.grdFlolow.Size = new System.Drawing.Size(844, 360);
            this.grdFlolow.TabIndex = 0;
            this.grdFlolow.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdFlolow.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdFlolow.SelectionChanged += new System.EventHandler(this.grdFlolow_SelectionChanged);
            // 
            // grpDesc
            // 
            this.grpDesc.Controls.Add(this.txtFollow);
            this.grpDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDesc.Location = new System.Drawing.Point(0, 380);
            this.grpDesc.Name = "grpDesc";
            this.grpDesc.Size = new System.Drawing.Size(850, 236);
            this.grpDesc.TabIndex = 1;
            this.grpDesc.Text = "پیگیری";
            this.grpDesc.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtFollow
            // 
            this.txtFollow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.followUpIsHoldContractList1, "DescriptionForFollow", true));
            this.txtFollow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFollow.Location = new System.Drawing.Point(3, 17);
            this.txtFollow.Multiline = true;
            this.txtFollow.Name = "txtFollow";
            this.txtFollow.Size = new System.Drawing.Size(844, 216);
            this.txtFollow.TabIndex = 0;
            this.txtFollow.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // FollowUpIsHoldContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(850, 646);
            this.Name = "FollowUpIsHoldContract";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.FollowUpIsHoldContract_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpFollow)).EndInit();
            this.grpFollow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFlolow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDesc)).EndInit();
            this.grpDesc.ResumeLayout(false);
            this.grpDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.FollowUpIsHoldContractList followUpIsHoldContractList1;
        private General.Controls.GroupBox grpDesc;
        private General.Controls.TextBox txtFollow;
        private General.Controls.GroupBox grpFollow;
        private General.Controls.Grid grdFlolow;
    }
}
