namespace RASF.Main.Forms.Harmony
{
    partial class EmptyDateOfPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmptyDateOfPrint));
            Janus.Windows.GridEX.GridEXLayout grdMaster_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdContracts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpFind = new RASF.General.Controls.GroupBox();
            this.btnFind = new RASF.General.Controls.Save_Button();
            this.txtFind = new RASF.General.Controls.TextBox();
            this.grpMaster = new RASF.General.Controls.GroupBox();
            this.grdMaster = new RASF.General.Controls.Grid();
            this.partsMasterEmptyPrintReportList1 = new RASF.General.Lists.PartsMasterEmptyPrintReportList(this.components);
            this.grpTemp = new RASF.General.Controls.GroupBox();
            this.findContractNoList1 = new RASF.General.Lists.FindContractNoList(this.components);
            this.getDocumentForPrintList1 = new RASF.General.Lists.GetDocumentForPrintList(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpcontracts = new RASF.General.Controls.GroupBox();
            this.grdContracts = new RASF.General.Controls.Grid();
            this.contractsEmptyPrintReportList1 = new RASF.General.Lists.ContractsEmptyPrintReportList(this.components);
            this.grpSearch = new RASF.General.Controls.GroupBox();
            this.btnSearch = new RASF.General.Controls.Save_Button();
            this.txtSearch = new RASF.General.Controls.TextBox();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpcontracts)).BeginInit();
            this.grpcontracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).BeginInit();
            this.grpSearch.SuspendLayout();
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
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Controls.Add(this.grpTemp);
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
            this.grpFind.Controls.Add(this.btnFind);
            this.grpFind.Controls.Add(this.txtFind);
            this.grpFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFind.Location = new System.Drawing.Point(3, 3);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(1073, 51);
            this.grpFind.TabIndex = 4;
            this.grpFind.Text = "جستجو";
            this.grpFind.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(6, 16);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "جستجو";
            this.btnFind.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Location = new System.Drawing.Point(87, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(980, 21);
            this.txtFind.TabIndex = 0;
            this.txtFind.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.grdMaster);
            this.grpMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMaster.Location = new System.Drawing.Point(3, 54);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(1073, 523);
            this.grpMaster.TabIndex = 5;
            this.grpMaster.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMaster
            // 
            this.grdMaster.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdMaster.AlowRetrieveStructure = false;
            this.grdMaster.AlternatingColors = true;
            this.grdMaster.BuiltInTextsData = resources.GetString("grdMaster.BuiltInTextsData");
            this.grdMaster.DataSource = this.partsMasterEmptyPrintReportList1;
            this.grdMaster.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMaster_DesignTimeLayout.LayoutString = resources.GetString("grdMaster_DesignTimeLayout.LayoutString");
            this.grdMaster.DesignTimeLayout = grdMaster_DesignTimeLayout;
            this.grdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaster.GroupByBoxVisible = false;
            this.grdMaster.Hierarchical = true;
            this.grdMaster.HierarchicalExpandBoxStyle = Janus.Windows.GridEX.ExpandBoxStyle.Arrows;
            this.grdMaster.Location = new System.Drawing.Point(3, 8);
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.RecordNavigator = true;
            this.grdMaster.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild;
            this.grdMaster.Size = new System.Drawing.Size(1067, 512);
            this.grdMaster.TabIndex = 2;
            this.grdMaster.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMaster.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdMaster.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdMaster_ColumnButtonClick);
            // 
            // grpTemp
            // 
            this.grpTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTemp.Location = new System.Drawing.Point(0, 0);
            this.grpTemp.Name = "grpTemp";
            this.grpTemp.Size = new System.Drawing.Size(1087, 606);
            this.grpTemp.TabIndex = 6;
            this.grpTemp.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 606);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpMaster);
            this.tabPage1.Controls.Add(this.grpFind);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1079, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "بر حسب تنوع";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpcontracts);
            this.tabPage2.Controls.Add(this.grpSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "بر حسب قرارداد";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpcontracts
            // 
            this.grpcontracts.Controls.Add(this.grdContracts);
            this.grpcontracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpcontracts.Location = new System.Drawing.Point(3, 54);
            this.grpcontracts.Name = "grpcontracts";
            this.grpcontracts.Size = new System.Drawing.Size(1073, 523);
            this.grpcontracts.TabIndex = 6;
            this.grpcontracts.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContracts
            // 
            this.grdContracts.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdContracts.AlowRetrieveStructure = false;
            this.grdContracts.AlternatingColors = true;
            this.grdContracts.BuiltInTextsData = resources.GetString("grdContracts.BuiltInTextsData");
            this.grdContracts.DataSource = this.contractsEmptyPrintReportList1;
            this.grdContracts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContracts_DesignTimeLayout.LayoutString = resources.GetString("grdContracts_DesignTimeLayout.LayoutString");
            this.grdContracts.DesignTimeLayout = grdContracts_DesignTimeLayout;
            this.grdContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContracts.GroupByBoxVisible = false;
            this.grdContracts.Hierarchical = true;
            this.grdContracts.HierarchicalExpandBoxStyle = Janus.Windows.GridEX.ExpandBoxStyle.Arrows;
            this.grdContracts.Location = new System.Drawing.Point(3, 8);
            this.grdContracts.Name = "grdContracts";
            this.grdContracts.RecordNavigator = true;
            this.grdContracts.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild;
            this.grdContracts.Size = new System.Drawing.Size(1067, 512);
            this.grdContracts.TabIndex = 2;
            this.grdContracts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContracts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdContracts.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdContracts_ColumnButtonClick);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(3, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1073, 51);
            this.grpSearch.TabIndex = 5;
            this.grpSearch.Text = "جستجو";
            this.grpSearch.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(87, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(980, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // EmptyDateOfPrint
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1087, 630);
            this.Name = "EmptyDateOfPrint";
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpcontracts)).EndInit();
            this.grpcontracts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpFind;
        private RASF.General.Controls.Save_Button btnFind;
        private RASF.General.Controls.TextBox txtFind;
        private RASF.General.Controls.GroupBox grpMaster;
        private RASF.General.Controls.GroupBox grpTemp;
        private RASF.General.Lists.FindContractNoList findContractNoList1;
        private General.Lists.GetDocumentForPrintList getDocumentForPrintList1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private General.Lists.PartsMasterEmptyPrintReportList partsMasterEmptyPrintReportList1;
        private General.Controls.Grid grdMaster;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private General.Controls.GroupBox grpcontracts;
        private General.Controls.Grid grdContracts;
        private General.Controls.GroupBox grpSearch;
        private General.Controls.Save_Button btnSearch;
        private General.Controls.TextBox txtSearch;
        private General.Lists.ContractsEmptyPrintReportList contractsEmptyPrintReportList1;
    }
}
