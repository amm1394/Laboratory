namespace RASF.Main.Forms.Reception
{
    partial class Print_Test_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_Test_Form));
            Janus.Windows.GridEX.GridEXLayout grdEditContract_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.Report2 = new Stimulsoft.Report.StiReport();
            this.print_TestList1 = new RASF.General.Lists.Print_TestList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdEditContract = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEditContract)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 396);
            this.pnlButton.Size = new System.Drawing.Size(546, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(546, 396);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(341, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(424, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(486, 0);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdEditContract);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "چاپ برگه های آزمون";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdEditContract
            // 
            this.grdEditContract.AlowRetrieveStructure = false;
            this.grdEditContract.AlternatingColors = true;
            this.grdEditContract.BuiltInTextsData = resources.GetString("grdEditContract.BuiltInTextsData");
            this.grdEditContract.DataSource = this.print_TestList1;
            this.grdEditContract.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdEditContract_DesignTimeLayout.LayoutString = resources.GetString("grdEditContract_DesignTimeLayout.LayoutString");
            this.grdEditContract.DesignTimeLayout = grdEditContract_DesignTimeLayout;
            this.grdEditContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEditContract.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdEditContract.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdEditContract.GroupByBoxVisible = false;
            this.grdEditContract.Location = new System.Drawing.Point(3, 17);
            this.grdEditContract.Name = "grdEditContract";
            this.grdEditContract.Size = new System.Drawing.Size(540, 376);
            this.grdEditContract.TabIndex = 0;
            this.grdEditContract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdEditContract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdEditContract.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdEditContract_ColumnButtonClick_1);
            // 
            // Print_Test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Name = "Print_Test_Form";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "Print_Test_Form";
            this.Load += new System.EventHandler(this.Print_Test_Form_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEditContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.Print_TestList print_TestList1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdEditContract;
        private Stimulsoft.Report.StiReport Report2;
    }
}