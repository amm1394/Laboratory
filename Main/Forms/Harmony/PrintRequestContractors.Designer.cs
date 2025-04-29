namespace RASF.Main.Forms.Harmony
{
    partial class PrintRequestContractors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintRequestContractors));
            Janus.Windows.GridEX.GridEXLayout grdcontractors_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdcontractors = new RASF.General.Controls.Grid();
            this.printOfRequestContractorsList1 = new RASF.General.Lists.PrintOfRequestContractorsList(this.components);
            this.Report2 = new Stimulsoft.Report.StiReport();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcontractors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 547);
            this.pnlButton.Size = new System.Drawing.Size(1024, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(1024, 547);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(3513, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(902, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(964, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdcontractors);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "چاپ برگه تقاضای پیمانکار فرعی برای انجام آزمون";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcontractors
            // 
            this.grdcontractors.AlowRetrieveStructure = false;
            this.grdcontractors.AlternatingColors = true;
            this.grdcontractors.BuiltInTextsData = resources.GetString("grdcontractors.BuiltInTextsData");
            this.grdcontractors.DataSource = this.printOfRequestContractorsList1;
            this.grdcontractors.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcontractors_DesignTimeLayout.LayoutString = resources.GetString("grdcontractors_DesignTimeLayout.LayoutString");
            this.grdcontractors.DesignTimeLayout = grdcontractors_DesignTimeLayout;
            this.grdcontractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcontractors.GroupByBoxVisible = false;
            this.grdcontractors.Location = new System.Drawing.Point(3, 17);
            this.grdcontractors.Name = "grdcontractors";
            this.grdcontractors.Size = new System.Drawing.Size(1018, 470);
            this.grdcontractors.TabIndex = 0;
            this.grdcontractors.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcontractors.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdcontractors.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdcontractors_ColumnButtonClick);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchContract1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1024, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "شماره قرارداد";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(792, 17);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(229, 37);
            this.searchContract1.TabIndex = 1;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // PrintRequestContractors
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 577);
            this.Name = "PrintRequestContractors";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "PrintRequest";
            this.Load += new System.EventHandler(this.PrintRequestContractors_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcontractors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdcontractors;
        private General.Lists.PrintOfRequestContractorsList printOfRequestContractorsList1;
        protected Stimulsoft.Report.StiReport Report2;
        private General.Controls.GroupBox groupBox2;
        private Controls.SearchContract searchContract1;
    }
}