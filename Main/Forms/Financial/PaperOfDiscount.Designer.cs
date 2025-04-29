namespace RASF.Main.Forms.Financial
{
    partial class PaperOfDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaperOfDiscount));
            Janus.Windows.GridEX.GridEXLayout grdReports_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdRe_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpdate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdReports = new RASF.General.Controls.Grid();
            this.paperOfDiscountList1 = new RASF.General.Lists.PaperOfDiscountList(this.components);
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdRe = new RASF.General.Controls.Grid();
            this.reportOfPaperDiscountList1 = new RASF.General.Lists.ReportOfPaperDiscountList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpdate)).BeginInit();
            this.grpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 530);
            this.pnlButton.Size = new System.Drawing.Size(954, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(954, 530);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(749, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(832, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(894, 0);
            // 
            // grpdate
            // 
            this.grpdate.Controls.Add(this.pickDate1);
            this.grpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpdate.Location = new System.Drawing.Point(0, 0);
            this.grpdate.Name = "grpdate";
            this.grpdate.Size = new System.Drawing.Size(950, 55);
            this.grpdate.TabIndex = 5;
            this.grpdate.Text = "تاریخ پذیرش";
            this.grpdate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(523, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 35);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdReports);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 451);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.Text = "ثبت برگه های تخفیف";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReports
            // 
            this.grdReports.AlowRetrieveStructure = false;
            this.grdReports.AlternatingColors = true;
            this.grdReports.BuiltInTextsData = resources.GetString("grdReports.BuiltInTextsData");
            this.grdReports.DataSource = this.paperOfDiscountList1;
            this.grdReports.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReports_DesignTimeLayout.LayoutString = resources.GetString("grdReports_DesignTimeLayout.LayoutString");
            this.grdReports.DesignTimeLayout = grdReports_DesignTimeLayout;
            this.grdReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReports.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReports.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReports.GroupByBoxVisible = false;
            this.grdReports.Location = new System.Drawing.Point(3, 17);
            this.grdReports.Name = "grdReports";
            this.grdReports.RecordNavigator = true;
            this.grdReports.Size = new System.Drawing.Size(944, 431);
            this.grdReports.TabIndex = 0;
            this.grdReports.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReports.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(954, 530);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox1);
            this.uiTabPage1.Controls.Add(this.grpdate);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(950, 506);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "ثبت بن تخفیف";
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox2);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(950, 506);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "گزارش بن تخفیف";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdRe);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(950, 506);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = " بن تخفیف های ثبت شده ";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdRe
            // 
            this.grdRe.AlowRetrieveStructure = false;
            this.grdRe.AlternatingColors = true;
            this.grdRe.BuiltInTextsData = resources.GetString("grdRe.BuiltInTextsData");
            this.grdRe.DataSource = this.reportOfPaperDiscountList1;
            this.grdRe.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdRe_DesignTimeLayout.LayoutString = resources.GetString("grdRe_DesignTimeLayout.LayoutString");
            this.grdRe.DesignTimeLayout = grdRe_DesignTimeLayout;
            this.grdRe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRe.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdRe.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdRe.GroupByBoxVisible = false;
            this.grdRe.Location = new System.Drawing.Point(3, 17);
            this.grdRe.Name = "grdRe";
            this.grdRe.RecordNavigator = true;
            this.grdRe.Size = new System.Drawing.Size(944, 486);
            this.grdRe.TabIndex = 1;
            this.grdRe.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdRe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // PaperOfDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 560);
            this.Name = "PaperOfDiscount";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "PaperOfDiscount";
            this.Load += new System.EventHandler(this.PaperOfDiscount_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpdate)).EndInit();
            this.grpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpdate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdReports;
        private General.Lists.PaperOfDiscountList paperOfDiscountList1;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdRe;
        private General.Lists.ReportOfPaperDiscountList reportOfPaperDiscountList1;
    }
}