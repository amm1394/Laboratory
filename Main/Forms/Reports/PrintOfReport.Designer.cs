namespace RASF.Main.Forms.Reports
{
    partial class PrintOfReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintOfReport));
            Janus.Windows.GridEX.GridEXLayout grdMaster_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpFind = new RASF.General.Controls.GroupBox();
            this.btnSearch = new RASF.General.Controls.Save_Button();
            this.txtSearch = new RASF.General.Controls.TextBox();
            this.grpMaster = new RASF.General.Controls.GroupBox();
            this.grdMaster = new RASF.General.Controls.Grid();
            this.partsMasterPrintReportList1 = new RASF.General.Lists.PartsMasterPrintReportList(this.components);
            this.grpTemp = new RASF.General.Controls.GroupBox();
            this.findContractNoList1 = new RASF.General.Lists.FindContractNoList(this.components);
            this.getDocumentForPrintList1 = new RASF.General.Lists.GetDocumentForPrintList(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.letter_Scan1 = new RASF.Main.Controls.Letter_Scan();
            this.showSaveCostPaperList1 = new RASF.General.Lists.ShowSaveCostPaperList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).BeginInit();
            this.grpFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).BeginInit();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTemp)).BeginInit();
            this.grpTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 606);
            this.pnlButton.Size = new System.Drawing.Size(1087, 24);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, -3);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, -3);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpMaster);
            this.pnlContent.Controls.Add(this.grpFind);
            this.pnlContent.Size = new System.Drawing.Size(1087, 606);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 0);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(882, 0);
            this.pnlUpdate.Size = new System.Drawing.Size(83, 24);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(965, 0);
            this.pnlExit.Size = new System.Drawing.Size(62, 24);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1027, 0);
            this.pnlSave.Size = new System.Drawing.Size(60, 24);
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.btnSearch);
            this.grpFind.Controls.Add(this.txtSearch);
            this.grpFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFind.Location = new System.Drawing.Point(0, 0);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(1087, 51);
            this.grpFind.TabIndex = 4;
            this.grpFind.Text = "جستجو";
            this.grpFind.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(87, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(994, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.splitContainer1);
            this.grpMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMaster.Location = new System.Drawing.Point(0, 51);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(1087, 555);
            this.grpMaster.TabIndex = 5;
            this.grpMaster.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMaster
            // 
            this.grdMaster.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdMaster.AlowRetrieveStructure = false;
            this.grdMaster.AlternatingColors = true;
            this.grdMaster.BuiltInTextsData = resources.GetString("grdMaster.BuiltInTextsData");
            this.grdMaster.DataSource = this.partsMasterPrintReportList1;
            this.grdMaster.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMaster_DesignTimeLayout.LayoutString = resources.GetString("grdMaster_DesignTimeLayout.LayoutString");
            this.grdMaster.DesignTimeLayout = grdMaster_DesignTimeLayout;
            this.grdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaster.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdMaster.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdMaster.GroupByBoxVisible = false;
            this.grdMaster.Hierarchical = true;
            this.grdMaster.HierarchicalExpandBoxStyle = Janus.Windows.GridEX.ExpandBoxStyle.Arrows;
            this.grdMaster.Location = new System.Drawing.Point(3, 8);
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.RecordNavigator = true;
            this.grdMaster.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild;
            this.grdMaster.Size = new System.Drawing.Size(544, 533);
            this.grdMaster.TabIndex = 1;
            this.grdMaster.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMaster.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdMaster.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdMaster_ColumnButtonClick);
            // 
            // grpTemp
            // 
            this.grpTemp.Controls.Add(this.grdMaster);
            this.grpTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTemp.Location = new System.Drawing.Point(0, 0);
            this.grpTemp.Name = "grpTemp";
            this.grpTemp.Size = new System.Drawing.Size(550, 544);
            this.grpTemp.TabIndex = 6;
            this.grpTemp.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 8);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpTemp);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.letter_Scan1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1081, 544);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 2;
            // 
            // letter_Scan1
            // 
            this.letter_Scan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letter_Scan1.Document = null;
            this.letter_Scan1.Location = new System.Drawing.Point(0, 0);
            this.letter_Scan1.Name = "letter_Scan1";
            this.letter_Scan1.Size = new System.Drawing.Size(527, 544);
            this.letter_Scan1.TabIndex = 4;
            // 
            // PrintOfReport
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1087, 630);
            this.Name = "PrintOfReport";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).EndInit();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).EndInit();
            this.grpMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTemp)).EndInit();
            this.grpTemp.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpFind;
        private RASF.General.Controls.Save_Button btnSearch;
        private RASF.General.Controls.TextBox txtSearch;
        private RASF.General.Controls.GroupBox grpMaster;
        private RASF.General.Controls.GroupBox grpTemp;
        private RASF.General.Lists.FindContractNoList findContractNoList1;
        private General.Lists.PartsMasterPrintReportList partsMasterPrintReportList1;
        private General.Lists.GetDocumentForPrintList getDocumentForPrintList1;
        private System.Windows.Forms.PrintDialog printDialog1;
        public General.Controls.Grid grdMaster;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.Letter_Scan letter_Scan1;
        private General.Lists.ShowSaveCostPaperList showSaveCostPaperList1;
    }
}
