namespace RASF.Main.Forms.Financial
{
    partial class ChartLaboratoryofFinancialConditionReportMasterTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartLaboratoryofFinancialConditionReportMasterTest));
            Janus.Windows.GridEX.GridEXLayout grdTotal_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdTotal = new RASF.General.Controls.Grid();
            this.chartLaboratoryofFinancialConditionReportMasterTestList1 = new RASF.General.Lists.ChartLaboratoryofFinancialConditionReportMasterTestList(this.components);
            this.grpChart = new RASF.General.Controls.GroupBox();
            this.chartTotal = new RASF.General.Controls.Chart();
            this.panel1 = new RASF.General.Controls.Panel();
            this.panel2 = new RASF.General.Controls.Panel();
            this.panel3 = new RASF.General.Controls.Panel();
            this.pnlContent.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChart)).BeginInit();
            this.grpChart.SuspendLayout();
           ((System.ComponentModel.ISupportInitialize)(this.chartTotal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.panel3);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Size = new System.Drawing.Size(1220, 529);
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 529);
            this.pnlButton.Size = new System.Drawing.Size(1220, 30);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(4455, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdTotal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(880, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 529);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdTotal
            // 
            this.grdTotal.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdTotal.AlowRetrieveStructure = false;
            this.grdTotal.AlternatingColors = true;
            this.grdTotal.BuiltInTextsData = resources.GetString("grdTotal.BuiltInTextsData");
            this.grdTotal.DataSource = this.chartLaboratoryofFinancialConditionReportMasterTestList1;
            this.grdTotal.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTotal_DesignTimeLayout.LayoutString = resources.GetString("grdTotal_DesignTimeLayout.LayoutString");
            this.grdTotal.DesignTimeLayout = grdTotal_DesignTimeLayout;
            this.grdTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTotal.GroupByBoxVisible = false;
            this.grdTotal.Location = new System.Drawing.Point(3, 8);
            this.grdTotal.Name = "grdTotal";
            this.grdTotal.Size = new System.Drawing.Size(334, 518);
            this.grdTotal.TabIndex = 0;
            this.grdTotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpChart
            // 
            this.grpChart.Controls.Add(this.chartTotal);
            this.grpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChart.Location = new System.Drawing.Point(0, 0);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(875, 529);
            this.grpChart.TabIndex = 4;
            this.grpChart.Text = "نمودار کارکرد آزمایش ها";
            this.grpChart.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chartTotal
            // 
            this.chartTotal.AreaDesign = cartesianArea1;
            this.chartTotal.DataSource = this.chartLaboratoryofFinancialConditionReportMasterTestList1;
            this.chartTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTotal.Location = new System.Drawing.Point(3, 17);
            this.chartTotal.Name = "chartTotal";
            this.chartTotal.ShowGrid = false;
            this.chartTotal.ShowTitle = true;
            this.chartTotal.Size = new System.Drawing.Size(869, 509);
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 529);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(875, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 529);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 529);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 0);
            this.panel3.TabIndex = 2;
            // 
            // ChartLaboratoryofFinancialConditionReportMasterTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1220, 559);
            this.Name = "ChartLaboratoryofFinancialConditionReportMasterTest";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.Load += new System.EventHandler(this.FinancialOffices_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChart)).EndInit();
            this.grpChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdTotal;
        private General.Controls.GroupBox grpChart;
        private General.Controls.Chart chartTotal;
        private General.Controls.Panel panel3;
        private General.Controls.Panel panel1;
        private General.Controls.Panel panel2;
        private General.Lists.ChartLaboratoryofFinancialConditionReportMasterTestList chartLaboratoryofFinancialConditionReportMasterTestList1;

    }
}
