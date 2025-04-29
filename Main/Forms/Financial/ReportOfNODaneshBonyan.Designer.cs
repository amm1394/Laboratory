namespace RASF.Main.Forms.Financial
{
    partial class ReportOfNODaneshBonyan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOfNODaneshBonyan));
            Janus.Windows.GridEX.GridEXLayout grdLab_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpOfficesName = new RASF.General.Controls.GroupBox();
            this.laboratoryName1 = new RASF.Main.Controls.Laboratory.LaboratoryName();
            this.grpReport = new RASF.General.Controls.GroupBox();
            this.grdLab = new RASF.General.Controls.Grid();
            this.reportOfDaneshBonyanList1 = new RASF.General.Lists.ReportOfDaneshBonyanList(this.components);
            this.panel1 = new RASF.General.Controls.Panel();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.panel2 = new RASF.General.Controls.Panel();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOfficesName)).BeginInit();
            this.grpOfficesName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpReport)).BeginInit();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLab)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 634);
            this.pnlButton.Size = new System.Drawing.Size(1276, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpReport);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Size = new System.Drawing.Size(1276, 634);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1071, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1154, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1216, 0);
            // 
            // grpOfficesName
            // 
            this.grpOfficesName.Controls.Add(this.laboratoryName1);
            this.grpOfficesName.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOfficesName.Location = new System.Drawing.Point(1001, 0);
            this.grpOfficesName.Name = "grpOfficesName";
            this.grpOfficesName.Size = new System.Drawing.Size(275, 50);
            this.grpOfficesName.TabIndex = 2;
            this.grpOfficesName.Text = "انتخاب نام آزمایشگاه";
            this.grpOfficesName.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // laboratoryName1
            // 
            this.laboratoryName1.BackColor = System.Drawing.Color.Transparent;
            this.laboratoryName1.Location = new System.Drawing.Point(6, 15);
            this.laboratoryName1.Name = "laboratoryName1";
            this.laboratoryName1.Size = new System.Drawing.Size(271, 29);
            this.laboratoryName1.TabIndex = 0;
            this.laboratoryName1.SelectedValueChanged += new System.EventHandler(this.laboratoryName1_SelectedValueChanged);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.grdLab);
            this.grpReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReport.Location = new System.Drawing.Point(0, 50);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(1276, 584);
            this.grpReport.TabIndex = 0;
            this.grpReport.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdLab
            // 
            this.grdLab.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdLab.AlowRetrieveStructure = false;
            this.grdLab.AlternatingColors = true;
            this.grdLab.BuiltInTextsData = resources.GetString("grdLab.BuiltInTextsData");
            this.grdLab.DataSource = this.reportOfDaneshBonyanList1;
            this.grdLab.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdLab_DesignTimeLayout.LayoutString = resources.GetString("grdLab_DesignTimeLayout.LayoutString");
            this.grdLab.DesignTimeLayout = grdLab_DesignTimeLayout;
            this.grdLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLab.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdLab.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdLab.GroupByBoxVisible = false;
            this.grdLab.Location = new System.Drawing.Point(3, 8);
            this.grdLab.Name = "grdLab";
            this.grdLab.RecordNavigator = true;
            this.grdLab.Size = new System.Drawing.Size(1270, 573);
            this.grdLab.TabIndex = 0;
            this.grdLab.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdLab.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdLab.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdLab.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdLab_ColumnButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpDate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grpOfficesName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 50);
            this.panel1.TabIndex = 1;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(991, 50);
            this.grpDate.TabIndex = 4;
            this.grpDate.Text = "انتخاب محدوده زمانی";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(564, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(991, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 50);
            this.panel2.TabIndex = 3;
            // 
            // ReportOfNODaneshBonyan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1276, 664);
            this.Name = "ReportOfNODaneshBonyan";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpOfficesName)).EndInit();
            this.grpOfficesName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpReport)).EndInit();
            this.grpReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLab)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpOfficesName;
        private General.Controls.GroupBox grpReport;
        private General.Controls.Grid grdLab;
        private General.Controls.Panel panel1;
        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.Panel panel2;
        private Controls.Laboratory.LaboratoryName laboratoryName1;
        private General.Lists.ReportOfDaneshBonyanList reportOfDaneshBonyanList1;
    }
}
