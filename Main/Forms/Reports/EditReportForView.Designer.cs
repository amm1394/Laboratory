namespace RASF.Main.Forms.Reports
{
    partial class EditReportForView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReportForView));
            Janus.Windows.GridEX.GridEXLayout grdMaster_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpFind = new RASF.General.Controls.GroupBox();
            this.btnSearch = new RASF.General.Controls.Save_Button();
            this.txtSearch = new RASF.General.Controls.TextBox();
            this.grpMaster = new RASF.General.Controls.GroupBox();
            this.grdMaster = new RASF.General.Controls.Grid();
            this.addReportList1 = new RASF.General.Lists.AddReportList(this.components);
            this.definitionTemplateList1 = new RASF.General.Lists.DefinitionPersianTemplateList(this.components);
            this.findContractNoList1 = new RASF.General.Lists.FindContractNoList(this.components);
            this.observationReportWordList1 = new RASF.General.Lists.ObservationReportWordList(this.components);
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
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 555);
            this.pnlButton.Size = new System.Drawing.Size(1284, 24);
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
            this.pnlContent.Size = new System.Drawing.Size(1284, 555);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 0);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1079, 0);
            this.pnlUpdate.Size = new System.Drawing.Size(83, 24);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1162, 0);
            this.pnlExit.Size = new System.Drawing.Size(62, 24);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1224, 0);
            this.pnlSave.Size = new System.Drawing.Size(60, 24);
            // 
            // grpFind
            // 
            this.grpFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFind.Controls.Add(this.btnSearch);
            this.grpFind.Controls.Add(this.txtSearch);
            this.grpFind.Location = new System.Drawing.Point(0, 0);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(1284, 115);
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
            this.txtSearch.Size = new System.Drawing.Size(1160, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // grpMaster
            // 
            this.grpMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMaster.Controls.Add(this.grdMaster);
            this.grpMaster.Location = new System.Drawing.Point(0, 51);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(1284, 504);
            this.grpMaster.TabIndex = 5;
            this.grpMaster.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMaster
            // 
            this.grdMaster.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdMaster.AlowRetrieveStructure = false;
            this.grdMaster.AlternatingColors = true;
            this.grdMaster.BuiltInTextsData = resources.GetString("grdMaster.BuiltInTextsData");
            this.grdMaster.DataSource = this.observationReportWordList1;
            this.grdMaster.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMaster_DesignTimeLayout.LayoutString = resources.GetString("grdMaster_DesignTimeLayout.LayoutString");
            this.grdMaster.DesignTimeLayout = grdMaster_DesignTimeLayout;
            this.grdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaster.GroupByBoxVisible = false;
            this.grdMaster.Location = new System.Drawing.Point(3, 8);
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.Size = new System.Drawing.Size(1278, 493);
            this.grdMaster.TabIndex = 0;
            this.grdMaster.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMaster.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdMaster.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdMaster_ColumnButtonClick);
            // 
            // EditReportForView
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 579);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "EditReportForView";
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
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpFind;
        private RASF.General.Controls.Save_Button btnSearch;
        private RASF.General.Controls.TextBox txtSearch;
        private RASF.General.Controls.GroupBox grpMaster;
        private RASF.General.Controls.Grid grdMaster;
        private RASF.General.Lists.DefinitionPersianTemplateList definitionTemplateList1;
        private RASF.General.Lists.AddReportList addReportList1;
        private RASF.General.Lists.FindContractNoList findContractNoList1;
        private General.Lists.ObservationReportWordList observationReportWordList1;
    }
}
