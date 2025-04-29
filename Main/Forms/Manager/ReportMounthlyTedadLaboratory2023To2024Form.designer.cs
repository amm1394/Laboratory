namespace RASF.Main.Forms.Financial
{
    partial class ReportMounthlyTedadLaboratory2023To2024Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMounthlyTedadLaboratory2023To2024Form));
            Janus.Windows.GridEX.GridEXLayout grdReport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.reportMounthlyLaboratory2017To2018List1 = new RASF.General.Lists.ReportMounthlyLaboratory2017To2018List(this.components);
            this.darsad98List1 = new RASF.General.Lists.Darsad98List(this.components);
            this.monthlyReport2017To2018List1 = new RASF.General.Lists.MonthlyReport2017To2018List(this.components);
            this.darsadAndRemindList1 = new RASF.General.Lists.DarsadAndRemindList(this.components);
            this.remindSeparatedbycustomerCashList1 = new RASF.General.Lists.RemindSeparatedbycustomerCashList(this.components);
            this.remindSeparatedbycustomerCreditorList1 = new RASF.General.Lists.RemindSeparatedbycustomerCreditorList(this.components);
            this.remindDebtorYearToYearList1 = new RASF.General.Lists.RemindDebtorYearToYearList(this.components);
            this.remindSeparatedbycustomerMarketingList1 = new RASF.General.Lists.RemindSeparatedbycustomerMarketingList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdReport = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 719);
            this.pnlButton.Size = new System.Drawing.Size(1284, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1284, 719);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // groupBox1
            // 
            this.groupBox1.AutoScroll = true;
            this.groupBox1.Controls.Add(this.grdReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 719);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "گزارش ماهانه تعدادی آزمایشگاه ها";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReport
            // 
            this.grdReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdReport.AlowRetrieveStructure = false;
            this.grdReport.AlternatingColors = true;
            this.grdReport.BuiltInTextsData = resources.GetString("grdReport.BuiltInTextsData");
            this.grdReport.DataSource = this.reportMounthlyLaboratory2017To2018List1;
            this.grdReport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReport_DesignTimeLayout.LayoutString = resources.GetString("grdReport_DesignTimeLayout.LayoutString");
            this.grdReport.DesignTimeLayout = grdReport_DesignTimeLayout;
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReport.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grdReport.GroupByBoxVisible = false;
            this.grdReport.Location = new System.Drawing.Point(3, 17);
            this.grdReport.Name = "grdReport";
            this.grdReport.Size = new System.Drawing.Size(1278, 699);
            this.grdReport.TabIndex = 2;
            this.grdReport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReport.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdReport.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdReport_FormattingRow);
            // 
            // ReportMounthlyTedadLaboratory2023To2024Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Name = "ReportMounthlyTedadLaboratory2023To2024Form";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "گزارش ماهانه سال 96";
            this.Load += new System.EventHandler(this.ReportMounthlyLaboratoryForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.MonthlyReport2017To2018List monthlyReport2017To2018List1;
        private General.Lists.ReportMounthlyLaboratory2017To2018List reportMounthlyLaboratory2017To2018List1;
        private General.Lists.DarsadAndRemindList darsadAndRemindList1;
        private General.Lists.RemindSeparatedbycustomerCreditorList remindSeparatedbycustomerCreditorList1;
        private General.Lists.RemindSeparatedbycustomerCashList remindSeparatedbycustomerCashList1;
        private General.Lists.RemindDebtorYearToYearList remindDebtorYearToYearList1;
        private General.Lists.RemindSeparatedbycustomerMarketingList remindSeparatedbycustomerMarketingList1;
        private General.Lists.Darsad98List darsad98List1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdReport;
    }
}
