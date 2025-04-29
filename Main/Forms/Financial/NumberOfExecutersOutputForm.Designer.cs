namespace RASF.Main.Forms.Financial
{
    partial class NumberOfExecutersOutputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberOfExecutersOutputForm));
            Janus.Windows.GridEX.GridEXLayout grdDetail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdTotal = new RASF.General.Controls.Grid();
            this.numberOfExecutersOutputList1 = new RASF.General.Lists.NumberOfExecutersOutputList(this.components);
            this.grpChart = new RASF.General.Controls.GroupBox();
            this.chartTotal = new RASF.General.Controls.Chart();
            this.panel1 = new RASF.General.Controls.Panel();
            this.panel2 = new RASF.General.Controls.Panel();
            this.panel3 = new RASF.General.Controls.Panel();
            this.panel7 = new RASF.General.Controls.Panel();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.ChartDetail = new RASF.General.Controls.Chart();
            this.numberOfExecutersOutputDetailList1 = new RASF.General.Lists.NumberOfExecutersOutputDetailList(this.components);
            this.panel6 = new RASF.General.Controls.Panel();
            this.panel5 = new RASF.General.Controls.Panel();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdDetail = new RASF.General.Controls.Grid();
            this.panel4 = new RASF.General.Controls.Panel();
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
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDetail)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 530);
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
            this.pnlContent.Size = new System.Drawing.Size(1220, 530);
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
            this.grdTotal.DataSource = this.numberOfExecutersOutputList1;
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
            this.grpChart.Text = "نمودار تعداد کارکرد آزمایشگاه ها";
            this.grpChart.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chartTotal
            // 
            this.chartTotal.AreaDesign = cartesianArea2;
            this.chartTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chartTotal.DataSource = this.numberOfExecutersOutputList1;
            this.chartTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTotal.Location = new System.Drawing.Point(3, 17);
            this.chartTotal.Name = "chartTotal";
            //// 
            //// 
            //// 
            this.chartTotal.RootElement.ControlBounds = new System.Drawing.Rectangle(3, 16, 480, 320);
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
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 230);
            this.panel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(873, 230);
            this.panel7.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChartDetail);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(873, 230);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.Text = "تعداد آزمون ها";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // ChartDetail
            // 
            this.ChartDetail.AreaDesign = cartesianArea1;
            this.ChartDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChartDetail.DataSource = this.numberOfExecutersOutputDetailList1;
            this.ChartDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartDetail.Location = new System.Drawing.Point(3, 17);
            this.ChartDetail.Name = "ChartDetail";
            // 
            // 
            // 
            this.ChartDetail.RootElement.ControlBounds = new System.Drawing.Rectangle(3, 16, 480, 320);
            this.ChartDetail.ShowGrid = false;
            this.ChartDetail.ShowTitle = true;
            this.ChartDetail.Size = new System.Drawing.Size(867, 210);
            this.ChartDetail.TabIndex = 2;
            this.ChartDetail.Text = "chart1";
            this.ChartDetail.ThemeName = "Office2013LightTheme";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(873, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 230);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(883, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 230);
            this.panel5.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 230);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDetail
            // 
            this.grdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDetail.AlowRetrieveStructure = false;
            this.grdDetail.AlternatingColors = true;
            this.grdDetail.BuiltInTextsData = resources.GetString("grdDetail.BuiltInTextsData");
            this.grdDetail.DataSource = this.numberOfExecutersOutputDetailList1;
            this.grdDetail.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDetail_DesignTimeLayout.LayoutString = resources.GetString("grdDetail_DesignTimeLayout.LayoutString");
            this.grdDetail.DesignTimeLayout = grdDetail_DesignTimeLayout;
            this.grdDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetail.GroupByBoxVisible = false;
            this.grdDetail.Location = new System.Drawing.Point(3, 8);
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.Size = new System.Drawing.Size(326, 219);
            this.grdDetail.TabIndex = 1;
            this.grdDetail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1215, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 230);
            this.panel4.TabIndex = 1;
            // 
            // NumberOfExecutersOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1220, 560);
            this.Name = "NumberOfExecutersOutputForm";
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
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDetail)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
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
        private General.Controls.Panel panel4;
        private General.Controls.Panel panel1;
        private General.Controls.Panel panel2;
        private General.Controls.Panel panel7;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.Chart ChartDetail;
        private General.Controls.Panel panel6;
        private General.Controls.Panel panel5;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdDetail;
        private General.Lists.NumberOfExecutersOutputList numberOfExecutersOutputList1;
        private General.Lists.NumberOfExecutersOutputDetailList numberOfExecutersOutputDetailList1;

    }
}
