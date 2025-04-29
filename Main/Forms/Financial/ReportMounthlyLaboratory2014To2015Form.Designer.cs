namespace RASF.Main.Forms.Financial
{
    partial class ReportMounthlyLaboratory2014To2015Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMounthlyLaboratory2014To2015Form));
            Janus.Windows.GridEX.GridEXLayout grdReport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdkol_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdReport = new RASF.General.Controls.Grid();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdkol = new RASF.General.Controls.Grid();
            this.reportMounthlyLaboratory2014To2015List1 = new RASF.General.Lists.ReportMounthlyLaboratory2014To2015List(this.components);
            this.monthlyReport2014To2015List1 = new RASF.General.Lists.MonthlyReport2014To2015List(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdkol)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 790);
            this.pnlButton.Size = new System.Drawing.Size(1215, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1215, 790);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1010, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1093, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1155, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1215, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "گزارش ماهانه آزمایشگاه ها";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReport
            // 
            this.grdReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdReport.AlowRetrieveStructure = false;
            this.grdReport.AlternatingColors = true;
            this.grdReport.BuiltInTextsData = resources.GetString("grdReport.BuiltInTextsData");
            this.grdReport.DataSource = this.reportMounthlyLaboratory2014To2015List1;
            this.grdReport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReport_DesignTimeLayout.LayoutString = resources.GetString("grdReport_DesignTimeLayout.LayoutString");
            this.grdReport.DesignTimeLayout = grdReport_DesignTimeLayout;
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grdReport.GroupByBoxVisible = false;
            this.grdReport.Location = new System.Drawing.Point(3, 17);
            this.grdReport.Name = "grdReport";
            this.grdReport.Size = new System.Drawing.Size(1209, 378);
            this.grdReport.TabIndex = 1;
            this.grdReport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReport.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdkol);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1215, 392);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.Text = "گزارش ماهانه کل";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdkol
            // 
            this.grdkol.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdkol.AlowRetrieveStructure = false;
            this.grdkol.AlternatingColors = true;
            this.grdkol.BuiltInTextsData = resources.GetString("grdkol.BuiltInTextsData");
            this.grdkol.DataSource = this.monthlyReport2014To2015List1;
            this.grdkol.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdkol_DesignTimeLayout.LayoutString = resources.GetString("grdkol_DesignTimeLayout.LayoutString");
            this.grdkol.DesignTimeLayout = grdkol_DesignTimeLayout;
            this.grdkol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdkol.GroupByBoxVisible = false;
            this.grdkol.Location = new System.Drawing.Point(3, 17);
            this.grdkol.Name = "grdkol";
            this.grdkol.Size = new System.Drawing.Size(1209, 372);
            this.grdkol.TabIndex = 1;
            this.grdkol.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdkol.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdkol.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdkol.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdkol_ColumnButtonClick);
            // 
            // ReportMounthlyLaboratory2014To2015Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1215, 820);
            this.Name = "ReportMounthlyLaboratory2014To2015Form";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "گزارش ماهانه سال 93";
            this.Load += new System.EventHandler(this.ReportMounthlyLaboratoryForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdkol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox2;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdReport;
        private General.Controls.Grid grdkol;
        private General.Lists.MonthlyReport2014To2015List monthlyReport2014To2015List1;
        private General.Lists.ReportMounthlyLaboratory2014To2015List reportMounthlyLaboratory2014To2015List1;
    }
}
