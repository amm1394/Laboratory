namespace RASF.Main.Forms.Financial
{
    partial class FinancialLaboratoryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialLaboratoryDetail));
            Janus.Windows.GridEX.GridEXLayout grdLaboratory_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.grpOffices = new RASF.General.Controls.GroupBox();
            this.grdLaboratory = new RASF.General.Controls.Grid();
            this.amountChartLaboratoryDetailList1 = new RASF.General.Lists.AmountChartLaboratoryDetailList(this.components);
            this.grpChart = new RASF.General.Controls.GroupBox();
            this.chartLaboratory = new RASF.General.Controls.Chart();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOffices)).BeginInit();
            this.grpOffices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLaboratory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChart)).BeginInit();
            this.grpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLaboratory)).BeginInit();
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
            this.grpOffices.Controls.Add(this.grdLaboratory);
            this.grpOffices.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOffices.Location = new System.Drawing.Point(713, 0);
            this.grpOffices.Name = "grpOffices";
            this.grpOffices.Size = new System.Drawing.Size(231, 370);
            this.grpOffices.TabIndex = 0;
            this.grpOffices.Text = "کارکرد دفاتر";
            this.grpOffices.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdLaboratory
            // 
            this.grdLaboratory.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdLaboratory.AlowRetrieveStructure = false;
            this.grdLaboratory.AlternatingColors = true;
            this.grdLaboratory.BuiltInTextsData = resources.GetString("grdLaboratory.BuiltInTextsData");
            this.grdLaboratory.DataSource = this.amountChartLaboratoryDetailList1;
            this.grdLaboratory.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdLaboratory_DesignTimeLayout.LayoutString = resources.GetString("grdLaboratory_DesignTimeLayout.LayoutString");
            this.grdLaboratory.DesignTimeLayout = grdLaboratory_DesignTimeLayout;
            this.grdLaboratory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLaboratory.GroupByBoxVisible = false;
            this.grdLaboratory.Location = new System.Drawing.Point(3, 17);
            this.grdLaboratory.Name = "grdLaboratory";
            this.grdLaboratory.Size = new System.Drawing.Size(225, 350);
            this.grdLaboratory.TabIndex = 1;
            this.grdLaboratory.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdLaboratory.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdLaboratory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpChart
            // 
            this.grpChart.Controls.Add(this.chartLaboratory);
            this.grpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChart.Location = new System.Drawing.Point(0, 0);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(713, 370);
            this.grpChart.TabIndex = 1;
            this.grpChart.Text = "نمودار کارکرد روزانه";
            this.grpChart.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chartLaboratory
            // 
            this.chartLaboratory.AreaDesign = cartesianArea1;
            this.chartLaboratory.DataSource = this.amountChartLaboratoryDetailList1;
            this.chartLaboratory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartLaboratory.Location = new System.Drawing.Point(3, 17);
            this.chartLaboratory.Name = "chartLaboratory";
            this.chartLaboratory.ShowGrid = false;
            this.chartLaboratory.ShowTitle = true;
            this.chartLaboratory.Size = new System.Drawing.Size(707, 350);
            this.chartLaboratory.TabIndex = 2;
            this.chartLaboratory.Text = "chart2";
            this.chartLaboratory.ThemeName = "Office2013LightTheme";
            // 
            // FinancialLaboratoryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(944, 400);
            this.Name = "FinancialLaboratoryDetail";
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
            ((System.ComponentModel.ISupportInitialize)(this.grdLaboratory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChart)).EndInit();
            this.grpChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLaboratory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpChart;
        private General.Controls.GroupBox grpOffices;
        private General.Controls.Chart chartLaboratory;
        private General.Controls.Grid grdLaboratory;
        private General.Lists.AmountChartLaboratoryDetailList amountChartLaboratoryDetailList1;
    }
}
