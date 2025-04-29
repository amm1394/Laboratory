namespace RASF.Main.Forms.Financial
{
    partial class FinancialOfficesDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialOfficesDetail));
            Janus.Windows.GridEX.GridEXLayout grdOffice_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.grpOffices = new RASF.General.Controls.GroupBox();
            this.grdOffice = new RASF.General.Controls.Grid();
            this.amountChartDetailList1 = new RASF.General.Lists.AmountChartDetailList(this.components);
            this.grpChart = new RASF.General.Controls.GroupBox();
            this.chartOffice = new RASF.General.Controls.Chart();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOffices)).BeginInit();
            this.grpOffices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChart)).BeginInit();
            this.grpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOffice)).BeginInit();
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
            this.grpOffices.Controls.Add(this.grdOffice);
            this.grpOffices.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOffices.Location = new System.Drawing.Point(713, 0);
            this.grpOffices.Name = "grpOffices";
            this.grpOffices.Size = new System.Drawing.Size(231, 370);
            this.grpOffices.TabIndex = 0;
            this.grpOffices.Text = "کارکرد دفاتر";
            this.grpOffices.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdOffice
            // 
            this.grdOffice.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdOffice.AlowRetrieveStructure = false;
            this.grdOffice.AlternatingColors = true;
            this.grdOffice.BuiltInTextsData = resources.GetString("grdOffice.BuiltInTextsData");
            this.grdOffice.DataSource = this.amountChartDetailList1;
            this.grdOffice.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdOffice_DesignTimeLayout.LayoutString = resources.GetString("grdOffice_DesignTimeLayout.LayoutString");
            this.grdOffice.DesignTimeLayout = grdOffice_DesignTimeLayout;
            this.grdOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOffice.GroupByBoxVisible = false;
            this.grdOffice.Location = new System.Drawing.Point(3, 17);
            this.grdOffice.Name = "grdOffice";
            this.grdOffice.Size = new System.Drawing.Size(225, 350);
            this.grdOffice.TabIndex = 1;
            this.grdOffice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdOffice.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdOffice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpChart
            // 
            this.grpChart.Controls.Add(this.chartOffice);
            this.grpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChart.Location = new System.Drawing.Point(0, 0);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(713, 370);
            this.grpChart.TabIndex = 1;
            this.grpChart.Text = "نمودار کارکرد روزانه";
            this.grpChart.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chartOffice
            // 
            this.chartOffice.AreaDesign = cartesianArea1;
            this.chartOffice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chartOffice.DataSource = this.amountChartDetailList1;
            this.chartOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartOffice.Location = new System.Drawing.Point(3, 17);
            this.chartOffice.Name = "chartOffice";
            //// 
            //// 
            //// 
            this.chartOffice.RootElement.ControlBounds = new System.Drawing.Rectangle(3, 16, 480, 320);
            this.chartOffice.ShowGrid = false;
            this.chartOffice.ShowTitle = true;
            this.chartOffice.Size = new System.Drawing.Size(707, 350);
            this.chartOffice.TabIndex = 2;
            this.chartOffice.Text = "chart2";
            this.chartOffice.ThemeName = "Office2013LightTheme";
            this.chartOffice.Click += new System.EventHandler(this.chartOffice_Click);
            // 
            // FinancialOfficesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(944, 400);
            this.Name = "FinancialOfficesDetail";
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
            ((System.ComponentModel.ISupportInitialize)(this.grdOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChart)).EndInit();
            this.grpChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOffice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpChart;
        private General.Controls.GroupBox grpOffices;
        private General.Controls.Chart chartOffice;
        private General.Controls.Grid grdOffice;
        private General.Lists.AmountChartDetailList amountChartDetailList1;
    }
}
