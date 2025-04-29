namespace RASF.Main.Forms.Financial
{
    partial class ReportOfWarrantyCheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOfWarrantyCheque));
            Janus.Windows.GridEX.GridEXLayout grdCash_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdCash = new RASF.General.Controls.Grid();
            this.reportOfCreditCompanyList1 = new RASF.General.Lists.ReportOfCreditCompanyList(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new RASF.General.Controls.GridEXPrintDocument();
            this.report = new Stimulsoft.Report.StiReport();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCash)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Size = new System.Drawing.Size(1140, 30);
            // 
            // btnExit
            // 
            this.btnExit.Text = "چاپ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdCash);
            this.pnlContent.Size = new System.Drawing.Size(1140, 434);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(935, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1018, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1080, 0);
            // 
            // grdCash
            // 
            this.grdCash.AlowRetrieveStructure = false;
            this.grdCash.AlternatingColors = true;
            this.grdCash.BuiltInTextsData = resources.GetString("grdCash.BuiltInTextsData");
            this.grdCash.DataSource = this.reportOfCreditCompanyList1;
            this.grdCash.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCash_DesignTimeLayout.LayoutString = resources.GetString("grdCash_DesignTimeLayout.LayoutString");
            this.grdCash.DesignTimeLayout = grdCash_DesignTimeLayout;
            this.grdCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCash.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCash.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCash.GroupByBoxVisible = false;
            this.grdCash.Location = new System.Drawing.Point(0, 0);
            this.grdCash.Name = "grdCash";
            this.grdCash.RecordNavigator = true;
            this.grdCash.Size = new System.Drawing.Size(1140, 434);
            this.grdCash.TabIndex = 0;
            this.grdCash.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCash.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCash.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCash_ColumnButtonClick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.gridEXPrintDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            // 
            // gridEXPrintDocument1
            // 
            this.gridEXPrintDocument1.FitColumns = Janus.Windows.GridEX.FitColumnsMode.SizingColumns;
            this.gridEXPrintDocument1.GridEX = this.grdCash;
            this.gridEXPrintDocument1.PageHeaderCenter = "گزارش شرکت های اعتباری";
            this.gridEXPrintDocument1.PageHeaderFormatStyle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument1.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument1.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // report
            // 
            this.report.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.report.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.report.ReportAlias = "Report";
            this.report.ReportGuid = "3c51ffb0c7c24aa4b2589bfa7ab4d9e6";
            this.report.ReportName = "Report";
            this.report.ReportSource = null;
            this.report.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.report.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.report.UseProgressInThread = false;
            // 
            // ReportOfWarrantyCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1140, 464);
            this.Name = "ReportOfWarrantyCheque";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.TabText = "منوط به چک تضمین";
            this.Text = "منوط به چک تضمین";
            this.Load += new System.EventHandler(this.ReportOfCreditCompany_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grdCash;
        private RASF.General.Lists.ReportOfCreditCompanyList reportOfCreditCompanyList1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument1;
        private Stimulsoft.Report.StiReport report;
    }
}
