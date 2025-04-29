namespace RASF.Main.Forms.Financial
{
    partial class DailyProcessReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyProcessReport));
            Janus.Windows.GridEX.GridEXLayout grdReportDaily_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdavg99_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdAvg98_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dailyProcessReportList1 = new RASF.General.Lists.DailyProcessReportList(this.components);
            this.grdReport = new RASF.General.Controls.Grid();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.grpgrid = new RASF.General.Controls.GroupBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new RASF.General.Controls.GridEXPrintDocument();
            this.grdReportDaily = new RASF.General.Controls.Grid();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate2 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.avg97List1 = new RASF.General.Lists.Avg97List(this.components);
            this.groupBox5 = new RASF.General.Controls.GroupBox();
            this.grdavg99 = new RASF.General.Controls.Grid();
            this.avg99List1 = new RASF.General.Lists.Avg99List(this.components);
            this.groupBox4 = new RASF.General.Controls.GroupBox();
            this.grdAvg98 = new RASF.General.Controls.Grid();
            this.avg98List1 = new RASF.General.Lists.Avg98List(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdavg99)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvg98)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 751);
            this.pnlButton.Size = new System.Drawing.Size(1284, 30);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(4, 7);
            this.btnExit.Text = "چاپ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 6);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1284, 751);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 9);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1079, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1162, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1224, 0);
            // 
            // grdReport
            // 
            this.grdReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdReport.AlowRetrieveStructure = false;
            this.grdReport.AlternatingColors = true;
            this.grdReport.BuiltInTextsData = resources.GetString("grdReport.BuiltInTextsData");
            this.grdReport.DataSource = this.dailyProcessReportList1;
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
            this.gridEXPrintDocument1.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument1.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // grdReportDaily
            // 
            this.grdReportDaily.AlowRetrieveStructure = false;
            this.grdReportDaily.AlternatingColors = true;
            this.grdReportDaily.BuiltInTextsData = resources.GetString("grdReportDaily.BuiltInTextsData");
            this.grdReportDaily.DataSource = this.dailyProcessReportList1;
            this.grdReportDaily.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReportDaily_DesignTimeLayout.LayoutString = resources.GetString("grdReportDaily_DesignTimeLayout.LayoutString");
            this.grdReportDaily.DesignTimeLayout = grdReportDaily_DesignTimeLayout;
            this.grdReportDaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReportDaily.GroupByBoxVisible = false;
            this.grdReportDaily.Location = new System.Drawing.Point(0, 0);
            this.grdReportDaily.Name = "grdReportDaily";
            this.grdReportDaily.Size = new System.Drawing.Size(1278, 561);
            this.grdReportDaily.TabIndex = 0;
            this.grdReportDaily.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReportDaily.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdReportDaily.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdReportDaily.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdReportDaily_FormattingRow);
            this.grdReportDaily.SizeChanged += new System.EventHandler(this.grdReportDaily_SizeChanged);
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
            this.groupBox1.Size = new System.Drawing.Size(1284, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "محدوده تاریخ ";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate2
            // 
            this.pickDate2.BackColor = System.Drawing.Color.Transparent;
            this.pickDate2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate2.Location = new System.Drawing.Point(857, 17);
            this.pickDate2.Name = "pickDate2";
            this.pickDate2.Size = new System.Drawing.Size(424, 32);
            this.pickDate2.TabIndex = 1;
            this.pickDate2.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate2_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1284, 699);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 8);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grdReportDaily);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1278, 688);
            this.splitContainer1.SplitterDistance = 561;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grdavg99);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 59);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1278, 64);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdavg99
            // 
            this.grdavg99.AlowRetrieveStructure = false;
            this.grdavg99.AlternatingColors = true;
            this.grdavg99.BuiltInTextsData = resources.GetString("grdavg99.BuiltInTextsData");
            this.grdavg99.DataSource = this.avg99List1;
            this.grdavg99.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdavg99_DesignTimeLayout.LayoutString = resources.GetString("grdavg99_DesignTimeLayout.LayoutString");
            this.grdavg99.DesignTimeLayout = grdavg99_DesignTimeLayout;
            this.grdavg99.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdavg99.GroupByBoxVisible = false;
            this.grdavg99.Location = new System.Drawing.Point(3, 8);
            this.grdavg99.Name = "grdavg99";
            this.grdavg99.Size = new System.Drawing.Size(1272, 53);
            this.grdavg99.TabIndex = 2;
            this.grdavg99.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdavg99.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdavg99.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdavg99_FormattingRow);
            this.grdavg99.SizeChanged += new System.EventHandler(this.grdavg99_SizeChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdAvg98);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1278, 59);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAvg98
            // 
            this.grdAvg98.AlowRetrieveStructure = false;
            this.grdAvg98.AlternatingColors = true;
            this.grdAvg98.BuiltInTextsData = resources.GetString("grdAvg98.BuiltInTextsData");
            this.grdAvg98.DataSource = this.avg98List1;
            this.grdAvg98.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAvg98_DesignTimeLayout.LayoutString = resources.GetString("grdAvg98_DesignTimeLayout.LayoutString");
            this.grdAvg98.DesignTimeLayout = grdAvg98_DesignTimeLayout;
            this.grdAvg98.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAvg98.GroupByBoxVisible = false;
            this.grdAvg98.Location = new System.Drawing.Point(3, 8);
            this.grdAvg98.Name = "grdAvg98";
            this.grdAvg98.Size = new System.Drawing.Size(1272, 48);
            this.grdAvg98.TabIndex = 1;
            this.grdAvg98.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAvg98.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdAvg98.SizeChanged += new System.EventHandler(this.grdAvg98_SizeChanged);
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
            // DailyProcessReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Name = "DailyProcessReport";
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdavg99)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAvg98)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.DailyProcessReportList dailyProcessReportList1;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Lists.Avg97List avg97List1;
        private General.Controls.GroupBox groupBox4;
        private General.Controls.Grid grdAvg98;
        private General.Lists.Avg98List avg98List1;
        private General.Controls.GroupBox groupBox5;
        private General.Controls.Grid grdavg99;
        private General.Lists.Avg99List avg99List1;
    }
}
