namespace RASF.Main.Forms.Financial
{
    partial class contactsiscompletednothasinvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contactsiscompletednothasinvoiceForm));
            Janus.Windows.GridEX.GridEXLayout grdContract_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.grdContract = new RASF.General.Controls.Grid();
            this.contactsiscompletednothasinvoiceList1 = new RASF.General.Lists.contactsiscompletednothasinvoiceList(this.components);
            this.report = new Stimulsoft.Report.StiReport();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new RASF.General.Controls.GridEXPrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 622);
            this.pnlButton.Size = new System.Drawing.Size(1276, 30);
            // 
            // btnExit
            // 
            this.btnExit.Text = "ذخیره";
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdContract);
            this.pnlContent.Controls.Add(this.grpDate);
            this.pnlContent.Size = new System.Drawing.Size(1276, 622);
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
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(1276, 50);
            this.grpDate.TabIndex = 6;
            this.grpDate.Text = "انتخاب محدوده زمانی پذیرش ";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(849, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // grdContract
            // 
            this.grdContract.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdContract.AlowRetrieveStructure = false;
            this.grdContract.AlternatingColors = true;
            this.grdContract.BuiltInTextsData = resources.GetString("grdContract.BuiltInTextsData");
            this.grdContract.DataSource = this.contactsiscompletednothasinvoiceList1;
            this.grdContract.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContract_DesignTimeLayout.LayoutString = resources.GetString("grdContract_DesignTimeLayout.LayoutString");
            this.grdContract.DesignTimeLayout = grdContract_DesignTimeLayout;
            this.grdContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContract.GroupByBoxVisible = false;
            this.grdContract.Location = new System.Drawing.Point(0, 50);
            this.grdContract.Name = "grdContract";
            this.grdContract.Size = new System.Drawing.Size(1276, 572);
            this.grdContract.TabIndex = 7;
            this.grdContract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
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
            this.gridEXPrintDocument1.GridEX = this.grdContract;
            this.gridEXPrintDocument1.PageHeaderCenter = "چک های دریافتی";
            this.gridEXPrintDocument1.PageHeaderFormatStyle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument1.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument1.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // contactsiscompletednothasinvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 652);
            this.Name = "contactsiscompletednothasinvoiceForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.TabText = "قراردادهایی که صورت حساب ندارند";
            this.Text = "قراردادهایی که صورت حساب ندارند";
            this.Load += new System.EventHandler(this.ReceiveChequeForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.Grid grdContract;
        private Stimulsoft.Report.StiReport report;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private General.Lists.contactsiscompletednothasinvoiceList contactsiscompletednothasinvoiceList1;
    }
}