namespace RASF.Main.Forms.Financial
{
    partial class ReceiveChequeForm
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
            Janus.Windows.GridEX.GridEXLayout grdCheque_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiveChequeForm));
            Janus.Windows.GridEX.GridEXLayout grdtransfer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.grdCheque = new RASF.General.Controls.Grid();
            this.receiveChequeList1 = new RASF.General.Lists.ReceiveChequeList(this.components);
            this.report = new Stimulsoft.Report.StiReport();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new RASF.General.Controls.GridEXPrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdtransfer = new RASF.General.Controls.Grid();
            this.receiveBankTransferList1 = new RASF.General.Lists.ReceiveBankTransferList(this.components);
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument2 = new RASF.General.Controls.GridEXPrintDocument();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.label1 = new RASF.General.Controls.Label();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdtransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.label1);
            this.pnlButton.Location = new System.Drawing.Point(0, 622);
            this.pnlButton.Size = new System.Drawing.Size(1276, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.label1, 0);
            // 
            // btnExit
            // 
            this.btnExit.Text = "ذخیره";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Text = "چاپ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.grpDate);
            this.pnlContent.Size = new System.Drawing.Size(1276, 622);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.grpDate.Text = "انتخاب محدوده زمانی";
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
            // grdCheque
            // 
            this.grdCheque.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCheque.AlowRetrieveStructure = false;
            this.grdCheque.AlternatingColors = true;
            this.grdCheque.BuiltInTextsData = resources.GetString("grdCheque.BuiltInTextsData");
            this.grdCheque.DataSource = this.receiveChequeList1;
            this.grdCheque.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCheque_DesignTimeLayout.LayoutString = resources.GetString("grdCheque_DesignTimeLayout.LayoutString");
            this.grdCheque.DesignTimeLayout = grdCheque_DesignTimeLayout;
            this.grdCheque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCheque.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCheque.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCheque.GroupByBoxVisible = false;
            this.grdCheque.Location = new System.Drawing.Point(3, 17);
            this.grdCheque.Name = "grdCheque";
            this.grdCheque.RecordNavigator = true;
            this.grdCheque.Size = new System.Drawing.Size(1270, 283);
            this.grdCheque.TabIndex = 7;
            this.grdCheque.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCheque.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCheque.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCheque.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdCheque_FormattingRow);
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
            this.gridEXPrintDocument1.GridEX = this.grdCheque;
            this.gridEXPrintDocument1.PageHeaderCenter = "چک های دریافتی";
            this.gridEXPrintDocument1.PageHeaderFormatStyle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument1.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument1.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.gridEXPrintDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCheque);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1276, 303);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.Text = "چک های دریافتی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdtransfer);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1276, 269);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.Text = "حواله های دریافتی";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdtransfer
            // 
            this.grdtransfer.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdtransfer.AlowRetrieveStructure = false;
            this.grdtransfer.AlternatingColors = true;
            this.grdtransfer.BuiltInTextsData = resources.GetString("grdtransfer.BuiltInTextsData");
            this.grdtransfer.DataSource = this.receiveBankTransferList1;
            this.grdtransfer.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdtransfer_DesignTimeLayout.LayoutString = resources.GetString("grdtransfer_DesignTimeLayout.LayoutString");
            this.grdtransfer.DesignTimeLayout = grdtransfer_DesignTimeLayout;
            this.grdtransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdtransfer.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdtransfer.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdtransfer.GroupByBoxVisible = false;
            this.grdtransfer.Location = new System.Drawing.Point(3, 17);
            this.grdtransfer.Name = "grdtransfer";
            this.grdtransfer.RecordNavigator = true;
            this.grdtransfer.Size = new System.Drawing.Size(1270, 249);
            this.grdtransfer.TabIndex = 8;
            this.grdtransfer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdtransfer.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdtransfer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdtransfer.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdtransfer_FormattingRow);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.gridEXPrintDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog1";
            this.printPreviewDialog2.ShowIcon = false;
            this.printPreviewDialog2.Visible = false;
            // 
            // gridEXPrintDocument2
            // 
            this.gridEXPrintDocument2.FitColumns = Janus.Windows.GridEX.FitColumnsMode.SizingColumns;
            this.gridEXPrintDocument2.GridEX = this.grdtransfer;
            this.gridEXPrintDocument2.PageHeaderCenter = "چک های دریافتی";
            this.gridEXPrintDocument2.PageHeaderFormatStyle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument2.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument2.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // printDialog2
            // 
            this.printDialog2.Document = this.gridEXPrintDocument2;
            this.printDialog2.UseEXDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "اعتباری";
            // 
            // ReceiveChequeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 652);
            this.Name = "ReceiveChequeForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ReceiveChequeForm";
            this.Load += new System.EventHandler(this.ReceiveChequeForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdtransfer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.Grid grdCheque;
        private General.Lists.ReceiveChequeList receiveChequeList1;
        private Stimulsoft.Report.StiReport report;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdtransfer;
        private General.Controls.GroupBox groupBox1;
        private General.Lists.ReceiveBankTransferList receiveBankTransferList1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument2;
        private System.Windows.Forms.PrintDialog printDialog2;
        private General.Controls.Label label1;
    }
}