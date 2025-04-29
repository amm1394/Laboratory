namespace RASF.Main.Forms.Financial
{
    partial class ContractIsVoidSegregate
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
            Janus.Windows.GridEX.GridEXLayout grdReport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractIsVoidSegregate));
            Janus.Windows.GridEX.GridEXLayout grdReportDaily_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdReport = new RASF.General.Controls.Grid();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.grpgrid = new RASF.General.Controls.GroupBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new RASF.General.Controls.GridEXPrintDocument();
            this.grdReportDaily = new RASF.General.Controls.Grid();
            this.contractIsVoidSegregateList1 = new RASF.General.Lists.ContractIsVoidSegregateList(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate2 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpgrid)).BeginInit();
            this.grpgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 548);
            this.pnlButton.Size = new System.Drawing.Size(1285, 30);
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
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1285, 548);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(17485, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1163, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1225, 0);
            // 
            // grdReport
            // 
            this.grdReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdReport.AlowRetrieveStructure = false;
            this.grdReport.AlternatingColors = true;
            this.grdReport.BuiltInTextsData = resources.GetString("grdReport.BuiltInTextsData");
            this.grdReport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReport_DesignTimeLayout.LayoutString = resources.GetString("grdReport_DesignTimeLayout.LayoutString");
            this.grdReport.DesignTimeLayout = grdReport_DesignTimeLayout;
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReport.GroupByBoxVisible = false;
            this.grdReport.Location = new System.Drawing.Point(3, 16);
            this.grdReport.Name = "grdReport";
            this.grdReport.Size = new System.Drawing.Size(1279, 479);
            this.grdReport.TabIndex = 0;
            this.grdReport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReport.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            // 
            // grpDate
            // 
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(1285, 50);
            this.grpDate.TabIndex = 2;
            this.grpDate.Text = "محدوده زمانی";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grpgrid
            // 
            this.grpgrid.Controls.Add(this.grdReport);
            this.grpgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpgrid.Location = new System.Drawing.Point(0, 50);
            this.grpgrid.Name = "grpgrid";
            this.grpgrid.Size = new System.Drawing.Size(1285, 498);
            this.grpgrid.TabIndex = 3;
            this.grpgrid.Text = "گزارش";
            this.grpgrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
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
            this.gridEXPrintDocument1.GridEX = this.grdReportDaily;
            this.gridEXPrintDocument1.PageHeaderCenter = "عملکرد روزانه";
            this.gridEXPrintDocument1.PageHeaderFormatStyle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument1.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument1.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // grdReportDaily
            // 
            this.grdReportDaily.AlowRetrieveStructure = false;
            this.grdReportDaily.AlternatingColors = true;
            this.grdReportDaily.BuiltInTextsData = resources.GetString("grdReportDaily.BuiltInTextsData");
            this.grdReportDaily.DataSource = this.contractIsVoidSegregateList1;
            this.grdReportDaily.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReportDaily_DesignTimeLayout.LayoutString = resources.GetString("grdReportDaily_DesignTimeLayout.LayoutString");
            this.grdReportDaily.DesignTimeLayout = grdReportDaily_DesignTimeLayout;
            this.grdReportDaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReportDaily.GroupByBoxVisible = false;
            this.grdReportDaily.Location = new System.Drawing.Point(3, 8);
            this.grdReportDaily.Name = "grdReportDaily";
            this.grdReportDaily.Size = new System.Drawing.Size(1279, 485);
            this.grdReportDaily.TabIndex = 0;
            this.grdReportDaily.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReportDaily.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdReportDaily.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1285, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "محدوده تاریخ ";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate2
            // 
            this.pickDate2.BackColor = System.Drawing.Color.Transparent;
            this.pickDate2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate2.Location = new System.Drawing.Point(858, 17);
            this.pickDate2.Name = "pickDate2";
            this.pickDate2.Size = new System.Drawing.Size(424, 32);
            this.pickDate2.TabIndex = 1;
            this.pickDate2.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate2_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdReportDaily);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1285, 496);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(858, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // ContractIsVoidSegregate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1285, 578);
            this.Name = "ContractIsVoidSegregate";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.DailyProcessReport_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpgrid)).EndInit();
            this.grpgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdReport;
        private General.Controls.GroupBox grpgrid;
        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private General.Controls.Grid grdReportDaily;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.GroupBox groupBox2;
        private Controls.PickDate.PickDate pickDate2;
        private General.Lists.ContractIsVoidSegregateList contractIsVoidSegregateList1;
    }
}
