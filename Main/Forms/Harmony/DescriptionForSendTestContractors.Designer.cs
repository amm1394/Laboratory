namespace RASF.Main.Forms.Harmony
{
    partial class DescriptionForSendTestContractors
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
            Janus.Windows.GridEX.GridEXLayout grdcontractors_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout GrdEdit_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescriptionForSendTestContractors));
            Janus.Windows.GridEX.GridEXLayout grdrecieve_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpContractors = new RASF.General.Controls.GroupBox();
            this.grdcontractors = new RASF.General.Controls.Grid();
            this.descriptionForSendTestContractorsList1 = new RASF.General.Lists.DescriptionForSendTestContractorsList(this.components);
            this.recieveExperimentFromContractorList1 = new RASF.General.Lists.RecieveExperimentFromContractorList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.GrdEdit = new RASF.General.Controls.Grid();
            this.editContractorsForLabList1 = new RASF.General.Lists.EditContractorsForLabList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdrecieve = new RASF.General.Controls.Grid();
            this.notRecieveFromContractorsList1 = new RASF.General.Lists.NotRecieveFromContractorsList(this.components);
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContractors)).BeginInit();
            this.grpContractors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcontractors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdrecieve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 654);
            this.pnlButton.Size = new System.Drawing.Size(1194, 30);
            // 
            // btnExit
            // 
            this.btnExit.Text = "اکسل";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox3);
            this.pnlContent.Controls.Add(this.grpContractors);
            this.pnlContent.Size = new System.Drawing.Size(1194, 654);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(989, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1072, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1134, 0);
            // 
            // grpContractors
            // 
            this.grpContractors.Controls.Add(this.grdcontractors);
            this.grpContractors.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContractors.Location = new System.Drawing.Point(0, 0);
            this.grpContractors.Name = "grpContractors";
            this.grpContractors.Size = new System.Drawing.Size(1194, 203);
            this.grpContractors.TabIndex = 1;
            this.grpContractors.Text = "درج توضیحات";
            this.grpContractors.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcontractors
            // 
            this.grdcontractors.AlowRetrieveStructure = false;
            this.grdcontractors.AlternatingColors = true;
            this.grdcontractors.BuiltInTextsData = resources.GetString("grdcontractors.BuiltInTextsData");
            this.grdcontractors.DataSource = this.descriptionForSendTestContractorsList1;
            this.grdcontractors.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcontractors_DesignTimeLayout.LayoutString = resources.GetString("grdcontractors_DesignTimeLayout.LayoutString");
            this.grdcontractors.DesignTimeLayout = grdcontractors_DesignTimeLayout;
            this.grdcontractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcontractors.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdcontractors.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdcontractors.GroupByBoxVisible = false;
            this.grdcontractors.Location = new System.Drawing.Point(3, 17);
            this.grdcontractors.Name = "grdcontractors";
            this.grdcontractors.Size = new System.Drawing.Size(1188, 183);
            this.grdcontractors.TabIndex = 0;
            this.grdcontractors.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcontractors.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdcontractors.SelectionChanged += new System.EventHandler(this.grdcontractors_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GrdEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1194, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "مشاهده";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // GrdEdit
            // 
            this.GrdEdit.AlowRetrieveStructure = false;
            this.GrdEdit.AlternatingColors = true;
            this.GrdEdit.BuiltInTextsData = resources.GetString("GrdEdit.BuiltInTextsData");
            this.GrdEdit.DataSource = this.editContractorsForLabList1;
            this.GrdEdit.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GrdEdit_DesignTimeLayout.LayoutString = resources.GetString("GrdEdit_DesignTimeLayout.LayoutString");
            this.GrdEdit.DesignTimeLayout = GrdEdit_DesignTimeLayout;
            this.GrdEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdEdit.GroupByBoxVisible = false;
            this.GrdEdit.Location = new System.Drawing.Point(3, 17);
            this.GrdEdit.Name = "GrdEdit";
            this.GrdEdit.Size = new System.Drawing.Size(1188, 90);
            this.GrdEdit.TabIndex = 1;
            this.GrdEdit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GrdEdit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdrecieve);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1194, 285);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.Text = "دریافت از پیمانکار فرعی";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdrecieve
            // 
            this.grdrecieve.AlowRetrieveStructure = false;
            this.grdrecieve.AlternatingColors = true;
            this.grdrecieve.BuiltInTextsData = resources.GetString("grdrecieve.BuiltInTextsData");
            this.grdrecieve.DataSource = this.notRecieveFromContractorsList1;
            this.grdrecieve.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdrecieve_DesignTimeLayout.LayoutString = resources.GetString("grdrecieve_DesignTimeLayout.LayoutString");
            this.grdrecieve.DesignTimeLayout = grdrecieve_DesignTimeLayout;
            this.grdrecieve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdrecieve.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdrecieve.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdrecieve.GroupByBoxVisible = false;
            this.grdrecieve.Hierarchical = true;
            this.grdrecieve.Location = new System.Drawing.Point(3, 17);
            this.grdrecieve.Name = "grdrecieve";
            this.grdrecieve.Size = new System.Drawing.Size(1188, 265);
            this.grdrecieve.TabIndex = 0;
            this.grdrecieve.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdrecieve.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.faDatePicker1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1194, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.Text = "تاریخ پیش بینی شده برای دریافت";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.IsNull = false;
            this.faDatePicker1.Location = new System.Drawing.Point(472, 18);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.SelectedDateTime = new System.DateTime(2018, 6, 9, 0, 0, 0, 0);
            this.faDatePicker1.Size = new System.Drawing.Size(250, 20);
            this.faDatePicker1.TabIndex = 12;
            // 
            // DescriptionForSendTestContractors
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 684);
            this.Name = "DescriptionForSendTestContractors";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Tag = "کارهای ارسالی به پیمانکار فرعی";
            this.Text = "کارهای ارسالی به پیمانکار فرعی";
            this.Load += new System.EventHandler(this.RequestOfConstractors_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpContractors)).EndInit();
            this.grpContractors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcontractors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdrecieve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpContractors;
        private General.Controls.Grid grdcontractors;
        private General.Lists.DescriptionForSendTestContractorsList descriptionForSendTestContractorsList1;
        private General.Lists.RecieveExperimentFromContractorList recieveExperimentFromContractorList1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdrecieve;
        private General.Controls.GroupBox groupBox1;
        private General.Lists.EditContractorsForLabList editContractorsForLabList1;
        private General.Controls.Grid GrdEdit;
        private General.Lists.NotRecieveFromContractorsList notRecieveFromContractorsList1;
        private General.Controls.GroupBox groupBox3;
        protected FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
    }
}