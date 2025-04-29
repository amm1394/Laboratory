namespace RASF.Main.Forms.Financial
{
    partial class FinancialMainTestDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialMainTestDetail));
            Janus.Windows.GridEX.GridEXLayout grdMainTest_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.grpOffices = new RASF.General.Controls.GroupBox();
            this.grdMainTest = new RASF.General.Controls.Grid();
            this.amountChartMainTestDetailList1 = new RASF.General.Lists.AmountChartMainTestDetailList(this.components);
            this.grpChart = new RASF.General.Controls.GroupBox();
            this.chartMsinTest = new RASF.General.Controls.Chart();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOffices)).BeginInit();
            this.grpOffices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChart)).BeginInit();
            this.grpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMsinTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 370);
            this.pnlButton.Size = new System.Drawing.Size(944, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpChart);
            this.pnlContent.Controls.Add(this.grpOffices);
            this.pnlContent.Size = new System.Drawing.Size(944, 370);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(737, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(822, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(884, 0);
            // 
            // grpOffices
            // 
            this.grpOffices.Controls.Add(this.grdMainTest);
            this.grpOffices.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOffices.Location = new System.Drawing.Point(713, 0);
            this.grpOffices.Name = "grpOffices";
            this.grpOffices.Size = new System.Drawing.Size(231, 370);
            this.grpOffices.TabIndex = 0;
            this.grpOffices.Text = "کارکرد دفاتر";
            this.grpOffices.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMainTest
            // 
            this.grdMainTest.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdMainTest.AlowRetrieveStructure = false;
            this.grdMainTest.AlternatingColors = true;
            this.grdMainTest.BuiltInTextsData = resources.GetString("grdMainTest.BuiltInTextsData");
            this.grdMainTest.DataSource = this.amountChartMainTestDetailList1;
            this.grdMainTest.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMainTest_DesignTimeLayout.LayoutString = resources.GetString("grdMainTest_DesignTimeLayout.LayoutString");
            this.grdMainTest.DesignTimeLayout = grdMainTest_DesignTimeLayout;
            this.grdMainTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMainTest.GroupByBoxVisible = false;
            this.grdMainTest.Location = new System.Drawing.Point(3, 17);
            this.grdMainTest.Name = "grdMainTest";
            this.grdMainTest.Size = new System.Drawing.Size(225, 350);
            this.grdMainTest.TabIndex = 1;
            this.grdMainTest.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMainTest.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdMainTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpChart
            // 
            this.grpChart.Controls.Add(this.chartMsinTest);
            this.grpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChart.Location = new System.Drawing.Point(0, 0);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(713, 370);
            this.grpChart.TabIndex = 1;
            this.grpChart.Text = "نمودار کارکرد روزانه";
            this.grpChart.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chartMsinTest
            // 
            this.chartMsinTest.AreaDesign = cartesianArea1;
            this.chartMsinTest.DataSource = this.amountChartMainTestDetailList1;
            this.chartMsinTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMsinTest.Location = new System.Drawing.Point(3, 17);
            this.chartMsinTest.Name = "chartMsinTest";
            this.chartMsinTest.ShowGrid = false;
            this.chartMsinTest.ShowTitle = true;
            this.chartMsinTest.Size = new System.Drawing.Size(707, 350);
            this.chartMsinTest.TabIndex = 2;
            this.chartMsinTest.Text = "chart2";
            this.chartMsinTest.ThemeName = "Office2013LightTheme";
            //// 
            // FinancialMainTestDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(944, 400);
            this.Name = "FinancialMainTestDetail";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.FinancialOfficesDetail_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpOffices)).EndInit();
            this.grpOffices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMainTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChart)).EndInit();
            this.grpChart.ResumeLayout(false);
           ((System.ComponentModel.ISupportInitialize)(this.chartMsinTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpChart;
        private General.Controls.GroupBox grpOffices;
        private General.Controls.Chart chartMsinTest;
        private General.Controls.Grid grdMainTest;
        private General.Lists.AmountChartMainTestDetailList amountChartMainTestDetailList1;
    }
}
