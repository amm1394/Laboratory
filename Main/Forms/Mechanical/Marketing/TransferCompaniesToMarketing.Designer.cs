namespace RASF.Main.Forms.Marketing
{
    partial class TransferCompaniesToMarketing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferCompaniesToMarketing));
            Janus.Windows.GridEX.GridEXLayout grdCimpany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpcompany = new RASF.General.Controls.GroupBox();
            this.grdCimpany = new RASF.General.Controls.Grid();
            this.transferCompaniesToMarketingList1 = new RASF.General.Lists.TransferCompaniesToMarketingList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpcompany)).BeginInit();
            this.grpcompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCimpany)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 658);
            this.pnlButton.Size = new System.Drawing.Size(928, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpcompany);
            this.pnlContent.Size = new System.Drawing.Size(928, 658);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(723, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(806, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(868, 0);
            // 
            // grpcompany
            // 
            this.grpcompany.Controls.Add(this.grdCimpany);
            this.grpcompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpcompany.Location = new System.Drawing.Point(0, 0);
            this.grpcompany.Name = "grpcompany";
            this.grpcompany.Size = new System.Drawing.Size(928, 658);
            this.grpcompany.TabIndex = 0;
            this.grpcompany.Text = "groupBox1";
            this.grpcompany.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCimpany
            // 
            this.grdCimpany.AlowRetrieveStructure = false;
            this.grdCimpany.AlternatingColors = true;
            this.grdCimpany.BuiltInTextsData = resources.GetString("grdCimpany.BuiltInTextsData");
            this.grdCimpany.DataSource = this.transferCompaniesToMarketingList1;
            this.grdCimpany.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCimpany_DesignTimeLayout.LayoutString = resources.GetString("grdCimpany_DesignTimeLayout.LayoutString");
            this.grdCimpany.DesignTimeLayout = grdCimpany_DesignTimeLayout;
            this.grdCimpany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCimpany.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCimpany.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCimpany.GroupByBoxVisible = false;
            this.grdCimpany.Location = new System.Drawing.Point(3, 17);
            this.grdCimpany.Name = "grdCimpany";
            this.grdCimpany.Size = new System.Drawing.Size(922, 638);
            this.grdCimpany.TabIndex = 0;
            this.grdCimpany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCimpany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCimpany.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCimpany_ColumnButtonClick);
            this.grdCimpany.SelectionChanged += new System.EventHandler(this.grdCimpany_SelectionChanged);
            // 
            // TransferCompaniesToMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 688);
            this.Name = "TransferCompaniesToMarketing";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.TransferCompaniesToMarketing_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpcompany)).EndInit();
            this.grpcompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCimpany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpcompany;
        private RASF.General.Controls.Grid grdCimpany;
        private RASF.General.Lists.TransferCompaniesToMarketingList transferCompaniesToMarketingList1;
    }
}
