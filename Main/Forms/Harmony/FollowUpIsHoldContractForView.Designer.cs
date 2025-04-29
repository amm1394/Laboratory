namespace RASF.Main.Forms.Harmony
{
    partial class FollowUpIsHoldContractForView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FollowUpIsHoldContractForView));
            Janus.Windows.GridEX.GridEXLayout grdFollow_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdFollow = new RASF.General.Controls.Grid();
            this.followUpIsHoldContractForViewList1 = new RASF.General.Lists.FollowUpIsHoldContractForViewList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFollow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 510);
            this.pnlButton.Size = new System.Drawing.Size(782, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(782, 510);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(577, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(660, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(722, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdFollow);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdFollow
            // 
            this.grdFollow.AlowRetrieveStructure = false;
            this.grdFollow.AlternatingColors = true;
            this.grdFollow.BuiltInTextsData = resources.GetString("grdFollow.BuiltInTextsData");
            this.grdFollow.DataSource = this.followUpIsHoldContractForViewList1;
            this.grdFollow.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdFollow_DesignTimeLayout.LayoutString = resources.GetString("grdFollow_DesignTimeLayout.LayoutString");
            this.grdFollow.DesignTimeLayout = grdFollow_DesignTimeLayout;
            this.grdFollow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFollow.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdFollow.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdFollow.GroupByBoxVisible = false;
            this.grdFollow.Location = new System.Drawing.Point(3, 8);
            this.grdFollow.Name = "grdFollow";
            this.grdFollow.Size = new System.Drawing.Size(776, 499);
            this.grdFollow.TabIndex = 0;
            this.grdFollow.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdFollow.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // FollowUpIsHoldContractForView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(782, 540);
            this.Name = "FollowUpIsHoldContractForView";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.FollowUpIsHoldContractForView_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFollow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Grid grdFollow;
        private RASF.General.Lists.FollowUpIsHoldContractForViewList followUpIsHoldContractForViewList1;
    }
}
