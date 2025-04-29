namespace RASF.Main.Forms.Financial
{
    partial class FinancialLaboratory
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
            Janus.Windows.GridEX.GridEXLayout grdTotal_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialLaboratory));
            Janus.Windows.GridEX.GridEXLayout grdMainTest_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdTotal = new RASF.General.Controls.Grid();
            this.financialLaboratoryList1 = new RASF.General.Lists.FinancialLaboratoryList(this.components);
            this.grpChart = new RASF.General.Controls.GroupBox();
            this.chartTotal = new RASF.General.Controls.Chart();
            this.panel1 = new RASF.General.Controls.Panel();
            this.panel2 = new RASF.General.Controls.Panel();
            this.panel3 = new RASF.General.Controls.Panel();
            this.grpChartOffice = new RASF.General.Controls.GroupBox();
            this.chartMainTest = new RASF.General.Controls.Chart();
            this.financialMainTestList1 = new RASF.General.Lists.FinancialMainTestList(this.components);
            this.panel4 = new RASF.General.Controls.Panel();
            this.grpOffice = new RASF.General.Controls.GroupBox();
            this.grdMainTest = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChart)).BeginInit();
            this.grpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpChartOffice)).BeginInit();
            this.grpChartOffice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMainTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOffice)).BeginInit();
            this.grpOffice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 608);
            this.pnlButton.Size = new System.Drawing.Size(1220, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.panel3);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Controls.Add(this.grpDate);
            this.pnlContent.Size = new System.Drawing.Size(1220, 608);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1013, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1098, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1160, 0);
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(1220, 50);
            this.grpDate.TabIndex = 1;
            this.grpDate.Text = "محدوده زمانی";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(793, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdTotal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(880, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdTotal
            // 
            this.grdTotal.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdTotal.AlowRetrieveStructure = false;
            this.grdTotal.AlternatingColors = true;
            this.grdTotal.BuiltInTextsData = resources.GetString("grdTotal.BuiltInTextsData");
            this.grdTotal.DataSource = this.financialLaboratoryList1;
            this.grdTotal.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTotal_DesignTimeLayout.LayoutString = resources.GetString("grdTotal_DesignTimeLayout.LayoutString");
            this.grdTotal.DesignTimeLayout = grdTotal_DesignTimeLayout;
            this.grdTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTotal.GroupByBoxVisible = false;
            this.grdTotal.Location = new System.Drawing.Point(3, 8);
            this.grdTotal.Name = "grdTotal";
            this.grdTotal.Size = new System.Drawing.Size(334, 239);
            this.grdTotal.TabIndex = 0;
            this.grdTotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdTotal.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdTotal_ColumnButtonClick);
            this.grdTotal.SelectionChanged += new System.EventHandler(this.grdTotal_SelectionChanged);
            // 
            // grpChart
            // 
            this.grpChart.Controls.Add(this.chartTotal);
            this.grpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChart.Location = new System.Drawing.Point(0, 0);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(875, 250);
            this.grpChart.TabIndex = 4;
            this.grpChart.Text = "نمودار کارکرد آزمایشگاه ها";
            this.grpChart.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chartTotal
            // 
            this.chartTotal.AreaDesign = cartesianArea2;
            this.chartTotal.DataSource = this.financialLaboratoryList1;
            this.chartTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTotal.Location = new System.Drawing.Point(3, 17);
            this.chartTotal.Name = "chartTotal";
            this.chartTotal.ShowGrid = false;
            this.chartTotal.ShowTitle = true;
            this.chartTotal.Size = new System.Drawing.Size(869, 230);
            this.chartTotal.TabIndex = 1;
            this.chartTotal.Text = "chart1";
            this.chartTotal.ThemeName = "Office2013LightTheme";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpChart);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 250);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(875, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 250);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpChartOffice);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.grpOffice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 308);
            this.panel3.TabIndex = 2;
            // 
            // grpChartOffice
            // 
            this.grpChartOffice.Controls.Add(this.chartMainTest);
            this.grpChartOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChartOffice.Location = new System.Drawing.Point(0, 0);
            this.grpChartOffice.Name = "grpChartOffice";
            this.grpChartOffice.Size = new System.Drawing.Size(875, 308);
            this.grpChartOffice.TabIndex = 4;
            this.grpChartOffice.Text = "نمودار کارکرد روزانه";
            this.grpChartOffice.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chartMainTest
            // 
            this.chartMainTest.AreaDesign = cartesianArea1;
            this.chartMainTest.DataSource = this.financialMainTestList1;
            this.chartMainTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMainTest.Location = new System.Drawing.Point(3, 17);
            this.chartMainTest.Name = "chartMainTest";
            this.chartMainTest.ShowGrid = false;
            this.chartMainTest.ShowTitle = true;
            this.chartMainTest.Size = new System.Drawing.Size(869, 288);
            this.chartMainTest.TabIndex = 1;
            this.chartMainTest.Text = "chart2";
            this.chartMainTest.ThemeName = "Office2013LightTheme";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(875, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 308);
            this.panel4.TabIndex = 1;
            // 
            // grpOffice
            // 
            this.grpOffice.Controls.Add(this.grdMainTest);
            this.grpOffice.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOffice.Location = new System.Drawing.Point(880, 0);
            this.grpOffice.Name = "grpOffice";
            this.grpOffice.Size = new System.Drawing.Size(340, 308);
            this.grpOffice.TabIndex = 3;
            this.grpOffice.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMainTest
            // 
            this.grdMainTest.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdMainTest.AlowRetrieveStructure = false;
            this.grdMainTest.AlternatingColors = true;
            this.grdMainTest.BuiltInTextsData = resources.GetString("grdMainTest.BuiltInTextsData");
            this.grdMainTest.DataSource = this.financialMainTestList1;
            this.grdMainTest.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMainTest_DesignTimeLayout.LayoutString = resources.GetString("grdMainTest_DesignTimeLayout.LayoutString");
            this.grdMainTest.DesignTimeLayout = grdMainTest_DesignTimeLayout;
            this.grdMainTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMainTest.GroupByBoxVisible = false;
            this.grdMainTest.Location = new System.Drawing.Point(3, 8);
            this.grdMainTest.Name = "grdMainTest";
            this.grdMainTest.Size = new System.Drawing.Size(334, 297);
            this.grdMainTest.TabIndex = 0;
            this.grdMainTest.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMainTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdMainTest.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdMainTest_ColumnButtonClick);
            // 
            // FinancialLaboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1220, 638);
            this.Name = "FinancialLaboratory";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.FinancialOffices_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChart)).EndInit();
            this.grpChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpChartOffice)).EndInit();
            this.grpChartOffice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMainTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOffice)).EndInit();
            this.grpOffice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMainTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdTotal;
        private General.Controls.GroupBox grpDate;
        private General.Controls.GroupBox grpChart;
        private General.Controls.Chart chartTotal;
        private General.Controls.Panel panel3;
        private General.Controls.GroupBox grpChartOffice;
        private General.Controls.Chart chartMainTest;
        private General.Controls.Panel panel4;
        private General.Controls.GroupBox grpOffice;
        private General.Controls.Grid grdMainTest;
        private General.Controls.Panel panel1;
        private General.Controls.Panel panel2;
        private General.Lists.FinancialLaboratoryList financialLaboratoryList1;
        private General.Lists.FinancialMainTestList financialMainTestList1;

    }
}
