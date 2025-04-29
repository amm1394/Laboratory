namespace RASF.Main.Forms.SEM
{
    partial class TimingSem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimingSem));
            Janus.Windows.GridEX.GridEXLayout grdHours_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new RASF.General.Controls.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new RASF.General.Controls.Button();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.timeOfSemList1 = new RASF.General.Lists.TimeOfSemList(this.components);
            this.labDate = new RASF.General.Controls.Label();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdHours = new RASF.General.Controls.Grid();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.textBox1 = new RASF.General.Controls.TextBox();
            this.cancelExitForEditReportList1 = new RASF.General.Lists.CancelExitForEditReportList(this.components);
            this.Report2 = new Stimulsoft.Report.StiReport();
            this.semContractList1 = new RASF.General.Lists.SEMContractList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 684);
            this.pnlButton.Size = new System.Drawing.Size(1481, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox3);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1481, 684);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Text = "گزارش";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1276, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1359, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1421, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.labDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1481, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "تعیین تاریخ";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 17);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.faDatePicker1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1475, 31);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "تاریخ :";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1213, 31);
            this.splitContainer2.SplitterDistance = 30;
            this.splitContainer2.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(1079, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 31);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.timeOfSemList1, "DateOfSem", true));
            this.faDatePicker1.Dock = System.Windows.Forms.DockStyle.Right;
            this.faDatePicker1.IsNull = false;
            this.faDatePicker1.Location = new System.Drawing.Point(1213, 0);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.SelectedDateTime = new System.DateTime(2018, 8, 13, 0, 0, 0, 0);
            this.faDatePicker1.Size = new System.Drawing.Size(192, 31);
            this.faDatePicker1.TabIndex = 14;
            this.faDatePicker1.Leave += new System.EventHandler(this.faDatePicker1_Leave);
            // 
            // labDate
            // 
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(1435, 17);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(57, 26);
            this.labDate.TabIndex = 11;
            this.labDate.Text = "تاریخ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdHours);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1481, 533);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.Text = "رزرو ساعت";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdHours
            // 
            this.grdHours.AlowRetrieveStructure = false;
            this.grdHours.AlternatingColors = true;
            this.grdHours.BuiltInTextsData = resources.GetString("grdHours.BuiltInTextsData");
            this.grdHours.DataSource = this.timeOfSemList1;
            this.grdHours.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdHours_DesignTimeLayout.LayoutString = resources.GetString("grdHours_DesignTimeLayout.LayoutString");
            this.grdHours.DesignTimeLayout = grdHours_DesignTimeLayout;
            this.grdHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHours.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdHours.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdHours.GroupByBoxVisible = false;
            this.grdHours.Location = new System.Drawing.Point(3, 17);
            this.grdHours.Name = "grdHours";
            this.grdHours.RecordNavigator = true;
            this.grdHours.Size = new System.Drawing.Size(1475, 513);
            this.grdHours.TabIndex = 0;
            this.grdHours.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdHours.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdHours.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdHours_FormattingRow);
            this.grdHours.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdHours_ColumnButtonClick);
            this.grdHours.SelectionChanged += new System.EventHandler(this.grdHours_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 584);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1481, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.Text = "توضیحات";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timeOfSemList1, "Description", true));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1475, 80);
            this.textBox1.TabIndex = 0;
            this.textBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // Report2
            // 
            this.Report2.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Report2.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.Report2.ReportAlias = "Report";
            this.Report2.ReportGuid = "3c51ffb0c7c24aa4b2589bfa7ab4d9e6";
            this.Report2.ReportName = "Report";
            this.Report2.ReportSource = null;
            this.Report2.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.Report2.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.Report2.UseProgressInThread = false;
            // 
            // TimingSem
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1481, 714);
            this.Name = "TimingSem";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.TimingSem_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Label labDate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private RASF.General.Controls.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private RASF.General.Controls.Button btnSearch;
        private RASF.General.Controls.GroupBox groupBox2;
        private RASF.General.Controls.Grid grdHours;
        private RASF.General.Lists.TimeOfSemList timeOfSemList1;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.TextBox textBox1;
        private General.Lists.CancelExitForEditReportList cancelExitForEditReportList1;
        private Stimulsoft.Report.StiReport Report2;
        private General.Lists.SEMContractList semContractList1;
        protected FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
    }
}
