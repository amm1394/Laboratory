namespace RASF.Main.Forms.Harmony
{
    partial class ReturnForScience
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForScience));
            Janus.Windows.GridEX.GridEXLayout grdParts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpFind = new RASF.General.Controls.GroupBox();
            this.btnSearch = new RASF.General.Controls.Save_Button();
            this.txtSearch = new RASF.General.Controls.TextBox();
            this.grpMaster = new RASF.General.Controls.GroupBox();
            this.grdParts = new RASF.General.Controls.Grid();
            this.returnForScienceList1 = new RASF.General.Lists.ReturnForScienceList(this.components);
            this.findContractNoList1 = new RASF.General.Lists.FindContractNoList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).BeginInit();
            this.grpFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).BeginInit();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 502);
            this.pnlButton.Size = new System.Drawing.Size(1113, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpMaster);
            this.pnlContent.Controls.Add(this.grpFind);
            this.pnlContent.Size = new System.Drawing.Size(1113, 502);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(908, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(991, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1053, 0);
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.btnSearch);
            this.grpFind.Controls.Add(this.txtSearch);
            this.grpFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFind.Location = new System.Drawing.Point(0, 0);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(1113, 51);
            this.grpFind.TabIndex = 5;
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
            this.txtSearch.Size = new System.Drawing.Size(1020, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.grdParts);
            this.grpMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMaster.Location = new System.Drawing.Point(0, 51);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(1113, 451);
            this.grpMaster.TabIndex = 6;
            this.grpMaster.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdParts
            // 
            this.grdParts.AlowRetrieveStructure = false;
            this.grdParts.AlternatingColors = true;
            this.grdParts.BuiltInTextsData = resources.GetString("grdParts.BuiltInTextsData");
            this.grdParts.DataSource = this.returnForScienceList1;
            this.grdParts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdParts_DesignTimeLayout.LayoutString = resources.GetString("grdParts_DesignTimeLayout.LayoutString");
            this.grdParts.DesignTimeLayout = grdParts_DesignTimeLayout;
            this.grdParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdParts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdParts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdParts.GroupByBoxVisible = false;
            this.grdParts.Location = new System.Drawing.Point(3, 8);
            this.grdParts.Name = "grdParts";
            this.grdParts.Size = new System.Drawing.Size(1107, 440);
            this.grdParts.TabIndex = 0;
            this.grdParts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdParts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdParts.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdParts_ColumnButtonClick);
            // 
            // ReturnForScience
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 532);
            this.Name = "ReturnForScience";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ReturnForScience";
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
            ((System.ComponentModel.ISupportInitialize)(this.grdParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpFind;
        private General.Controls.Save_Button btnSearch;
        private General.Controls.TextBox txtSearch;
        private General.Controls.GroupBox grpMaster;
        private General.Controls.Grid grdParts;
        private General.Lists.FindContractNoList findContractNoList1;
        private General.Lists.ReturnForScienceList returnForScienceList1;
    }
}