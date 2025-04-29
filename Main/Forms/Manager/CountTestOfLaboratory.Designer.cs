namespace RASF.Main.Forms.Manager
{
    partial class CountTestOfLaboratory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountTestOfLaboratory));
            Janus.Windows.GridEX.GridEXLayout grdCount_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpYear = new RASF.General.Controls.GroupBox();
            this.btnSearch = new RASF.General.Controls.Button();
            this.drpYear = new RASF.General.Controls.DropDown();
            this.label1 = new RASF.General.Controls.Label();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdCount = new RASF.General.Controls.Grid();
            this.countTestOfLaboratoryList1 = new RASF.General.Lists.CountTestOfLaboratoryList(this.components);
            this.changeYearList1 = new RASF.General.Lists.ChangeYearList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpYear)).BeginInit();
            this.grpYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 495);
            this.pnlButton.Size = new System.Drawing.Size(836, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.grpYear);
            this.pnlContent.Size = new System.Drawing.Size(836, 495);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(631, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(714, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(776, 0);
            // 
            // grpYear
            // 
            this.grpYear.Controls.Add(this.btnSearch);
            this.grpYear.Controls.Add(this.drpYear);
            this.grpYear.Controls.Add(this.label1);
            this.grpYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpYear.Location = new System.Drawing.Point(0, 0);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(836, 48);
            this.grpYear.TabIndex = 0;
            this.grpYear.Text = "انتخاب سال مالی";
            this.grpYear.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(548, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // drpYear
            // 
            this.drpYear.Dock = System.Windows.Forms.DockStyle.Right;
            this.drpYear.Location = new System.Drawing.Point(638, 17);
            this.drpYear.Name = "drpYear";
            this.drpYear.Size = new System.Drawing.Size(131, 28);
            this.drpYear.TabIndex = 1;
            this.drpYear.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(769, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "سال مالی";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdCount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 447);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "گزارش تعدادی آزمونهای آزمایشگاه ها";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCount
            // 
            this.grdCount.AlowRetrieveStructure = false;
            this.grdCount.AlternatingColors = true;
            this.grdCount.BuiltInTextsData = resources.GetString("grdCount.BuiltInTextsData");
            this.grdCount.DataSource = this.countTestOfLaboratoryList1;
            this.grdCount.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCount_DesignTimeLayout.LayoutString = resources.GetString("grdCount_DesignTimeLayout.LayoutString");
            this.grdCount.DesignTimeLayout = grdCount_DesignTimeLayout;
            this.grdCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCount.GroupByBoxVisible = false;
            this.grdCount.Location = new System.Drawing.Point(3, 17);
            this.grdCount.Name = "grdCount";
            this.grdCount.Size = new System.Drawing.Size(830, 427);
            this.grdCount.TabIndex = 0;
            this.grdCount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCount.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // CountTestOfLaboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(836, 525);
            this.Name = "CountTestOfLaboratory";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CountTestOfLaboratory_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpYear)).EndInit();
            this.grpYear.ResumeLayout(false);
            this.grpYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpYear;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdCount;
        private General.Lists.CountTestOfLaboratoryList countTestOfLaboratoryList1;
        private General.Controls.Button btnSearch;
        private General.Controls.DropDown drpYear;
        private General.Controls.Label label1;
        private General.Lists.ChangeYearList changeYearList1;

    }
}
