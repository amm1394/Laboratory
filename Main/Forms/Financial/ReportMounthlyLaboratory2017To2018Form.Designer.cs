namespace RASF.Main.Forms.Financial
{
    partial class ReportMounthlyLaboratory2017To2018Form
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
            Janus.Windows.GridEX.GridEXLayout grdkol_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdDarsad_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdCash_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMounthlyLaboratory2017To2018Form));
            Janus.Windows.GridEX.GridEXLayout grdCredit_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdReport = new RASF.General.Controls.Grid();
            this.reportMounthlyLaboratory2017To2018List1 = new RASF.General.Lists.ReportMounthlyLaboratory2017To2018List(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdkol = new RASF.General.Controls.Grid();
            this.monthlyReport2017To2018List1 = new RASF.General.Lists.MonthlyReport2017To2018List(this.components);
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.grdDarsad = new RASF.General.Controls.Grid();
            this.darsadAndRemindList1 = new RASF.General.Lists.DarsadAndRemindList(this.components);
            this.groupBox4 = new RASF.General.Controls.GroupBox();
            this.grdCash = new RASF.General.Controls.Grid();
            this.remindSeparatedbycustomerCashList1 = new RASF.General.Lists.RemindSeparatedbycustomerCashList(this.components);
            this.groupBox5 = new RASF.General.Controls.GroupBox();
            this.grdCredit = new RASF.General.Controls.Grid();
            this.remindSeparatedbycustomerCreditorList1 = new RASF.General.Lists.RemindSeparatedbycustomerCreditorList(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDarsad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 818);
            this.pnlButton.Size = new System.Drawing.Size(1151, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox5);
            this.pnlContent.Controls.Add(this.groupBox4);
            this.pnlContent.Controls.Add(this.groupBox3);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1151, 818);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(946, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1029, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1091, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoScroll = true;
            this.groupBox1.Controls.Add(this.grdReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 392);
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
            this.grdReport.DataSource = this.reportMounthlyLaboratory2017To2018List1;
            this.grdReport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReport_DesignTimeLayout.LayoutString = resources.GetString("grdReport_DesignTimeLayout.LayoutString");
            this.grdReport.DesignTimeLayout = grdReport_DesignTimeLayout;
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grdReport.GroupByBoxVisible = false;
            this.grdReport.Location = new System.Drawing.Point(3, 17);
            this.grdReport.Name = "grdReport";
            this.grdReport.Size = new System.Drawing.Size(1145, 372);
            this.grdReport.TabIndex = 1;
            this.grdReport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReport.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoScroll = true;
            this.groupBox2.Controls.Add(this.grdkol);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1151, 307);
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
            this.grdkol.DataSource = this.monthlyReport2017To2018List1;
            this.grdkol.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdkol_DesignTimeLayout.LayoutString = resources.GetString("grdkol_DesignTimeLayout.LayoutString");
            this.grdkol.DesignTimeLayout = grdkol_DesignTimeLayout;
            this.grdkol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdkol.GroupByBoxVisible = false;
            this.grdkol.Location = new System.Drawing.Point(3, 17);
            this.grdkol.Name = "grdkol";
            this.grdkol.Size = new System.Drawing.Size(1145, 287);
            this.grdkol.TabIndex = 1;
            this.grdkol.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdkol.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdkol.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdkol.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdkol_ColumnButtonClick);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoScroll = true;
            this.groupBox3.Controls.Add(this.grdDarsad);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 699);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1151, 66);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.Text = "گزارش درصد مانده ها";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDarsad
            // 
            this.grdDarsad.AlowRetrieveStructure = false;
            this.grdDarsad.AlternatingColors = true;
            this.grdDarsad.BuiltInTextsData = resources.GetString("grdDarsad.BuiltInTextsData");
            this.grdDarsad.DataSource = this.darsadAndRemindList1;
            this.grdDarsad.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDarsad_DesignTimeLayout.LayoutString = resources.GetString("grdDarsad_DesignTimeLayout.LayoutString");
            this.grdDarsad.DesignTimeLayout = grdDarsad_DesignTimeLayout;
            this.grdDarsad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDarsad.GroupByBoxVisible = false;
            this.grdDarsad.Location = new System.Drawing.Point(3, 17);
            this.grdDarsad.Name = "grdDarsad";
            this.grdDarsad.Size = new System.Drawing.Size(1145, 46);
            this.grdDarsad.TabIndex = 0;
            this.grdDarsad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDarsad.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdCash);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(580, 765);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 53);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.Text = "شرکت های نقدی";
            this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCash
            // 
            this.grdCash.AlowRetrieveStructure = false;
            this.grdCash.AlternatingColors = true;
            this.grdCash.BuiltInTextsData = resources.GetString("grdCash.BuiltInTextsData");
            this.grdCash.DataSource = this.remindSeparatedbycustomerCashList1;
            this.grdCash.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCash_DesignTimeLayout.LayoutString = resources.GetString("grdCash_DesignTimeLayout.LayoutString");
            this.grdCash.DesignTimeLayout = grdCash_DesignTimeLayout;
            this.grdCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCash.GroupByBoxVisible = false;
            this.grdCash.Location = new System.Drawing.Point(3, 17);
            this.grdCash.Name = "grdCash";
            this.grdCash.Size = new System.Drawing.Size(565, 33);
            this.grdCash.TabIndex = 0;
            this.grdCash.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCash.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grdCredit);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 765);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(580, 53);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.Text = "شرکت های اعتباری";
            this.groupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCredit
            // 
            this.grdCredit.AlowRetrieveStructure = false;
            this.grdCredit.AlternatingColors = true;
            this.grdCredit.BuiltInTextsData = resources.GetString("grdCredit.BuiltInTextsData");
            this.grdCredit.DataSource = this.remindSeparatedbycustomerCreditorList1;
            this.grdCredit.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCredit_DesignTimeLayout.LayoutString = resources.GetString("grdCredit_DesignTimeLayout.LayoutString");
            this.grdCredit.DesignTimeLayout = grdCredit_DesignTimeLayout;
            this.grdCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCredit.GroupByBoxVisible = false;
            this.grdCredit.Location = new System.Drawing.Point(3, 17);
            this.grdCredit.Name = "grdCredit";
            this.grdCredit.Size = new System.Drawing.Size(574, 33);
            this.grdCredit.TabIndex = 1;
            this.grdCredit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCredit.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCredit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ReportMounthlyLaboratory2017To2018Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1151, 848);
            this.Name = "ReportMounthlyLaboratory2017To2018Form";
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
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdkol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDarsad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCredit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox2;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdReport;
        private General.Controls.Grid grdkol;
        private General.Lists.MonthlyReport2017To2018List monthlyReport2017To2018List1;
        private General.Lists.ReportMounthlyLaboratory2017To2018List reportMounthlyLaboratory2017To2018List1;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.Grid grdDarsad;
        private General.Lists.DarsadAndRemindList darsadAndRemindList1;
        private General.Controls.GroupBox groupBox4;
        private General.Controls.Grid grdCash;
        private General.Controls.GroupBox groupBox5;
        private General.Controls.Grid grdCredit;
        private General.Lists.RemindSeparatedbycustomerCreditorList remindSeparatedbycustomerCreditorList1;
        private General.Lists.RemindSeparatedbycustomerCashList remindSeparatedbycustomerCashList1;
    }
}
