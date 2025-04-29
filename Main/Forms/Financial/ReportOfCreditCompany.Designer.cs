namespace RASF.Main.Forms.Financial
{
    partial class ReportOfCreditCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOfCreditCompany));
            Janus.Windows.GridEX.GridEXLayout grdCredit_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.reportOfCreditCompanyList1 = new RASF.General.Lists.ReportOfCreditCompanyList(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new RASF.General.Controls.GridEXPrintDocument();
            this.grdCredit = new RASF.General.Controls.Grid();
            this.report = new Stimulsoft.Report.StiReport();
            this.panel1 = new RASF.General.Controls.Panel();
            this.btnKol = new RASF.General.Controls.Button();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCredit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.panel1);
            this.pnlButton.Location = new System.Drawing.Point(0, 567);
            this.pnlButton.Size = new System.Drawing.Size(1214, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.panel1, 0);
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
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1214, 567);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1009, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1092, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1154, 0);
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
            this.gridEXPrintDocument1.GridEX = this.grdCredit;
            this.gridEXPrintDocument1.PageHeaderCenter = "گزارش شرکت های اعتباری";
            this.gridEXPrintDocument1.PageHeaderFormatStyle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument1.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument1.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // grdCredit
            // 
            this.grdCredit.AlowRetrieveStructure = false;
            this.grdCredit.AlternatingColors = true;
            this.grdCredit.BuiltInTextsData = resources.GetString("grdCredit.BuiltInTextsData");
            this.grdCredit.DataSource = this.reportOfCreditCompanyList1;
            this.grdCredit.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCredit_DesignTimeLayout.LayoutString = resources.GetString("grdCredit_DesignTimeLayout.LayoutString");
            this.grdCredit.DesignTimeLayout = grdCredit_DesignTimeLayout;
            this.grdCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCredit.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCredit.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCredit.GroupByBoxVisible = false;
            this.grdCredit.Location = new System.Drawing.Point(3, 17);
            this.grdCredit.Name = "grdCredit";
            this.grdCredit.RecordNavigator = true;
            this.grdCredit.Size = new System.Drawing.Size(1208, 547);
            this.grdCredit.TabIndex = 0;
            this.grdCredit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCredit.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCredit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCredit.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdCredit_FormattingRow);
            this.grdCredit.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCredit_ColumnButtonClick);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnKol);
            this.panel1.Location = new System.Drawing.Point(920, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 30);
            this.panel1.TabIndex = 5;
            // 
            // btnKol
            // 
            this.btnKol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKol.Location = new System.Drawing.Point(0, 0);
            this.btnKol.Name = "btnKol";
            this.btnKol.Size = new System.Drawing.Size(83, 30);
            this.btnKol.TabIndex = 0;
            this.btnKol.Text = "مشاهده کل";
            this.btnKol.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnKol.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCredit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1214, 567);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "گزارش شرکت های اعتباری";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // ReportOfCreditCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1214, 597);
            this.Name = "ReportOfCreditCompany";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ReportOfCreditCompany_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCredit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Lists.ReportOfCreditCompanyList reportOfCreditCompanyList1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument1;
        private Stimulsoft.Report.StiReport report;
        private General.Controls.Panel panel1;
        private General.Controls.Button btnKol;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdCredit;
    }
}
