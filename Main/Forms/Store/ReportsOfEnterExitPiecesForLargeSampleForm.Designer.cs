namespace RASF.Main.Forms.Store
{
    partial class ReportsOfEnterExitPiecesForLargeSampleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsOfEnterExitPiecesForLargeSampleForm));
            Janus.Windows.GridEX.GridEXLayout grdParts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpSearch = new RASF.General.Controls.GroupBox();
            this.searchContractcsForAll1 = new RASF.Main.Controls.SearchContractcsForAll();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdParts = new RASF.General.Controls.Grid();
            this.reportsOfEnterExitPiecesForLargeSampleList1 = new RASF.General.Lists.ReportsOfEnterExitPiecesForLargeSampleList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).BeginInit();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 509);
            this.pnlButton.Size = new System.Drawing.Size(1257, 27);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 0);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.grpSearch);
            this.pnlContent.Size = new System.Drawing.Size(1257, 509);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 3);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1052, 0);
            this.pnlUpdate.Size = new System.Drawing.Size(83, 27);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1135, 0);
            this.pnlExit.Size = new System.Drawing.Size(62, 27);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1197, 0);
            this.pnlSave.Size = new System.Drawing.Size(60, 27);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.searchContractcsForAll1);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1257, 54);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.Text = "جستجو";
            this.grpSearch.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContractcsForAll1
            // 
            this.searchContractcsForAll1.BackColor = System.Drawing.Color.Transparent;
            this.searchContractcsForAll1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContractcsForAll1.Location = new System.Drawing.Point(1028, 17);
            this.searchContractcsForAll1.Name = "searchContractcsForAll1";
            this.searchContractcsForAll1.Size = new System.Drawing.Size(226, 34);
            this.searchContractcsForAll1.TabIndex = 0;
            this.searchContractcsForAll1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContractcsForAll1_ReturnContractsCode);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdParts);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1257, 455);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdParts
            // 
            this.grdParts.AlowRetrieveStructure = false;
            this.grdParts.AlternatingColors = true;
            this.grdParts.BuiltInTextsData = resources.GetString("grdParts.BuiltInTextsData");
            this.grdParts.DataSource = this.reportsOfEnterExitPiecesForLargeSampleList1;
            this.grdParts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdParts_DesignTimeLayout.LayoutString = resources.GetString("grdParts_DesignTimeLayout.LayoutString");
            this.grdParts.DesignTimeLayout = grdParts_DesignTimeLayout;
            this.grdParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdParts.GroupByBoxVisible = false;
            this.grdParts.Hierarchical = true;
            this.grdParts.Location = new System.Drawing.Point(3, 8);
            this.grdParts.Name = "grdParts";
            this.grdParts.Size = new System.Drawing.Size(1251, 444);
            this.grdParts.TabIndex = 0;
            this.grdParts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdParts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ReportsOfEnterExitPiecesForLargeSampleForm
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1257, 536);
            this.Name = "ReportsOfEnterExitPiecesForLargeSampleForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpSearch;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdParts;
        private General.Lists.ReportsOfEnterExitPiecesForLargeSampleList reportsOfEnterExitPiecesForLargeSampleList1;
        private Controls.SearchContractcsForAll searchContractcsForAll1;

    }
}
