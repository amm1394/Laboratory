namespace RASF.Main.Forms.Marketing
{
    partial class ShowMarketingActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMarketingActivity));
            Janus.Windows.GridEX.GridEXLayout grdShow_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdShow = new RASF.General.Controls.Grid();
            this.showMarketingActivityList1 = new RASF.General.Lists.ShowMarketingActivityList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 667);
            this.pnlButton.Size = new System.Drawing.Size(1199, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1199, 667);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(994, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1077, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1139, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdShow);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1199, 667);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdShow
            // 
            this.grdShow.AlowRetrieveStructure = false;
            this.grdShow.AlternatingColors = true;
            this.grdShow.BuiltInTextsData = resources.GetString("grdShow.BuiltInTextsData");
            this.grdShow.DataSource = this.showMarketingActivityList1;
            this.grdShow.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdShow_DesignTimeLayout.LayoutString = resources.GetString("grdShow_DesignTimeLayout.LayoutString");
            this.grdShow.DesignTimeLayout = grdShow_DesignTimeLayout;
            this.grdShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdShow.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdShow.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdShow.GroupByBoxVisible = false;
            this.grdShow.Location = new System.Drawing.Point(3, 8);
            this.grdShow.Name = "grdShow";
            this.grdShow.Size = new System.Drawing.Size(1193, 656);
            this.grdShow.TabIndex = 0;
            this.grdShow.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdShow.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdShow.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdShow_ColumnButtonClick);
            // 
            // ShowMarketingActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1199, 697);
            this.Name = "ShowMarketingActivity";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ShowMarketingActivity_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdShow;
        private General.Lists.ShowMarketingActivityList showMarketingActivityList1;
    }
}
