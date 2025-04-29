namespace RASF.Main.Forms.Marketing
{
    partial class POGCReport
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
            Janus.Windows.GridEX.GridEXLayout grdcompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POGCReport));
            Janus.Windows.GridEX.GridEXLayout grdTest_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpCompany = new RASF.General.Controls.GroupBox();
            this.grdcompany = new RASF.General.Controls.Grid();
            this.reportOfPOGCList1 = new RASF.General.Lists.ReportOfPOGCList(this.components);
            this.grpTest = new RASF.General.Controls.GroupBox();
            this.grdTest = new RASF.General.Controls.Grid();
            this.reportOfPOGCDetailList1 = new RASF.General.Lists.ReportOfPOGCDetailList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompany)).BeginInit();
            this.grpCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTest)).BeginInit();
            this.grpTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 673);
            this.pnlButton.Size = new System.Drawing.Size(1035, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpTest);
            this.pnlContent.Controls.Add(this.grpCompany);
            this.pnlContent.Size = new System.Drawing.Size(1035, 673);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(828, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(913, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(975, 0);
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.grdcompany);
            this.grpCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCompany.Location = new System.Drawing.Point(0, 0);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(1035, 351);
            this.grpCompany.TabIndex = 4;
            this.grpCompany.Text = "شرکت ها";
            this.grpCompany.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcompany
            // 
            this.grdcompany.AlowRetrieveStructure = false;
            this.grdcompany.AlternatingColors = true;
            this.grdcompany.BuiltInTextsData = resources.GetString("grdcompany.BuiltInTextsData");
            this.grdcompany.DataSource = this.reportOfPOGCList1;
            this.grdcompany.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcompany_DesignTimeLayout.LayoutString = resources.GetString("grdcompany_DesignTimeLayout.LayoutString");
            this.grdcompany.DesignTimeLayout = grdcompany_DesignTimeLayout;
            this.grdcompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcompany.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdcompany.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdcompany.GroupByBoxVisible = false;
            this.grdcompany.Location = new System.Drawing.Point(3, 17);
            this.grdcompany.Name = "grdcompany";
            this.grdcompany.Size = new System.Drawing.Size(1029, 331);
            this.grdcompany.TabIndex = 0;
            this.grdcompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcompany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdcompany.SelectionChanged += new System.EventHandler(this.grdcompany_SelectionChanged);
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.grdTest);
            this.grpTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTest.Location = new System.Drawing.Point(0, 351);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(1035, 322);
            this.grpTest.TabIndex = 5;
            this.grpTest.Text = "Test&NumberOfTest";
            this.grpTest.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdTest
            // 
            this.grdTest.AlowRetrieveStructure = false;
            this.grdTest.AlternatingColors = true;
            this.grdTest.BuiltInTextsData = resources.GetString("grdTest.BuiltInTextsData");
            this.grdTest.DataSource = this.reportOfPOGCDetailList1;
            this.grdTest.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTest_DesignTimeLayout.LayoutString = resources.GetString("grdTest_DesignTimeLayout.LayoutString");
            this.grdTest.DesignTimeLayout = grdTest_DesignTimeLayout;
            this.grdTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTest.GroupByBoxVisible = false;
            this.grdTest.Location = new System.Drawing.Point(3, 17);
            this.grdTest.Name = "grdTest";
            this.grdTest.Size = new System.Drawing.Size(1029, 302);
            this.grdTest.TabIndex = 0;
            this.grdTest.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // POGCReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1035, 703);
            this.Name = "POGCReport";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.POGCReport_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCompany)).EndInit();
            this.grpCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTest)).EndInit();
            this.grpTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpTest;
        private General.Controls.Grid grdTest;
        private General.Controls.GroupBox grpCompany;
        private General.Controls.Grid grdcompany;
        private General.Lists.ReportOfPOGCDetailList reportOfPOGCDetailList1;
        private General.Lists.ReportOfPOGCList reportOfPOGCList1;
    }
}
