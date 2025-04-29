namespace RASF.Main.Forms.Base
{
    partial class Companies_Base_CellNum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Companies_Base_CellNum));
            Janus.Windows.GridEX.GridEXLayout grdCompanyBase_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdTelegram_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdWhatsapp_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdPassword_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdReport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpCompanies = new RASF.General.Controls.GroupBox();
            this.grdCompanyBase = new RASF.General.Controls.Grid();
            this.companiesBaseList1 = new RASF.General.Lists.CompaniesBaseList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grbMobile = new RASF.General.Controls.GroupBox();
            this.grdTelegram = new RASF.General.Controls.Grid();
            this.companies_MobileNumList1 = new RASF.General.Lists.Companies_MobileNumList(this.components);
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdWhatsapp = new RASF.General.Controls.Grid();
            this.companies_MobileNumList2 = new RASF.General.Lists.Companies_MobileNumList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdPassword = new RASF.General.Controls.Grid();
            this.companies_MobileNumList3 = new RASF.General.Lists.Companies_MobileNumList(this.components);
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.grdReport = new RASF.General.Controls.Grid();
            this.companies_MobileNumList4 = new RASF.General.Lists.Companies_MobileNumList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompanies)).BeginInit();
            this.grpCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanyBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbMobile)).BeginInit();
            this.grbMobile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTelegram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWhatsapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 725);
            this.pnlButton.Size = new System.Drawing.Size(1497, 30);
            // 
            // btnExit
            // 
            this.btnExit.Text = "EXCEL";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(1497, 725);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1292, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1375, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1437, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpCompanies);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1493, 701);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpCompanies
            // 
            this.grpCompanies.Controls.Add(this.grdCompanyBase);
            this.grpCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompanies.Location = new System.Drawing.Point(0, 0);
            this.grpCompanies.Name = "grpCompanies";
            this.grpCompanies.Size = new System.Drawing.Size(1493, 458);
            this.grpCompanies.TabIndex = 2;
            this.grpCompanies.Text = "نام شرکت";
            this.grpCompanies.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompanyBase
            // 
            this.grdCompanyBase.AlowRetrieveStructure = false;
            this.grdCompanyBase.AlternatingColors = true;
            this.grdCompanyBase.BuiltInTextsData = resources.GetString("grdCompanyBase.BuiltInTextsData");
            this.grdCompanyBase.DataSource = this.companiesBaseList1;
            this.grdCompanyBase.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompanyBase_DesignTimeLayout.LayoutString = resources.GetString("grdCompanyBase_DesignTimeLayout.LayoutString");
            this.grdCompanyBase.DesignTimeLayout = grdCompanyBase_DesignTimeLayout;
            this.grdCompanyBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompanyBase.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompanyBase.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompanyBase.GroupByBoxVisible = false;
            this.grdCompanyBase.Location = new System.Drawing.Point(3, 17);
            this.grdCompanyBase.Name = "grdCompanyBase";
            this.grdCompanyBase.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToAddedRow;
            this.grdCompanyBase.RecordNavigator = true;
            this.grdCompanyBase.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical;
            this.grdCompanyBase.Size = new System.Drawing.Size(1487, 438);
            this.grdCompanyBase.TabIndex = 0;
            this.grdCompanyBase.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompanyBase.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompanyBase.SelectionChanged += new System.EventHandler(this.grdCompanyBase_SelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grbMobile);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1493, 239);
            this.splitContainer2.SplitterDistance = 495;
            this.splitContainer2.TabIndex = 0;
            // 
            // grbMobile
            // 
            this.grbMobile.Controls.Add(this.grdTelegram);
            this.grbMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMobile.Location = new System.Drawing.Point(0, 0);
            this.grbMobile.Name = "grbMobile";
            this.grbMobile.Size = new System.Drawing.Size(495, 239);
            this.grbMobile.TabIndex = 4;
            this.grbMobile.Text = "تلگرام";
            this.grbMobile.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdTelegram
            // 
            this.grdTelegram.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdTelegram.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdTelegram.AlowRetrieveStructure = false;
            this.grdTelegram.AlternatingColors = true;
            this.grdTelegram.BuiltInTextsData = resources.GetString("grdTelegram.BuiltInTextsData");
            this.grdTelegram.DataSource = this.companies_MobileNumList1;
            this.grdTelegram.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTelegram_DesignTimeLayout.LayoutString = resources.GetString("grdTelegram_DesignTimeLayout.LayoutString");
            this.grdTelegram.DesignTimeLayout = grdTelegram_DesignTimeLayout;
            this.grdTelegram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTelegram.GroupByBoxVisible = false;
            this.grdTelegram.Location = new System.Drawing.Point(3, 17);
            this.grdTelegram.Name = "grdTelegram";
            this.grdTelegram.Size = new System.Drawing.Size(489, 219);
            this.grdTelegram.TabIndex = 7;
            this.grdTelegram.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTelegram.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(994, 239);
            this.splitContainer3.SplitterDistance = 524;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdWhatsapp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 239);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.Text = "واتساپ";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdWhatsapp
            // 
            this.grdWhatsapp.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdWhatsapp.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdWhatsapp.AlowRetrieveStructure = false;
            this.grdWhatsapp.AlternatingColors = true;
            this.grdWhatsapp.BuiltInTextsData = resources.GetString("grdWhatsapp.BuiltInTextsData");
            this.grdWhatsapp.DataSource = this.companies_MobileNumList2;
            this.grdWhatsapp.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdWhatsapp_DesignTimeLayout.LayoutString = resources.GetString("grdWhatsapp_DesignTimeLayout.LayoutString");
            this.grdWhatsapp.DesignTimeLayout = grdWhatsapp_DesignTimeLayout;
            this.grdWhatsapp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWhatsapp.GroupByBoxVisible = false;
            this.grdWhatsapp.Location = new System.Drawing.Point(3, 17);
            this.grdWhatsapp.Name = "grdWhatsapp";
            this.grdWhatsapp.Size = new System.Drawing.Size(518, 219);
            this.grdWhatsapp.TabIndex = 7;
            this.grdWhatsapp.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdWhatsapp.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdPassword);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 239);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.Text = "پسورد یک بار مصرف";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdPassword
            // 
            this.grdPassword.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdPassword.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdPassword.AlowRetrieveStructure = false;
            this.grdPassword.AlternatingColors = true;
            this.grdPassword.BuiltInTextsData = resources.GetString("grdPassword.BuiltInTextsData");
            this.grdPassword.DataSource = this.companies_MobileNumList3;
            this.grdPassword.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdPassword_DesignTimeLayout.LayoutString = resources.GetString("grdPassword_DesignTimeLayout.LayoutString");
            this.grdPassword.DesignTimeLayout = grdPassword_DesignTimeLayout;
            this.grdPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPassword.GroupByBoxVisible = false;
            this.grdPassword.Location = new System.Drawing.Point(3, 17);
            this.grdPassword.Name = "grdPassword";
            this.grdPassword.Size = new System.Drawing.Size(460, 219);
            this.grdPassword.TabIndex = 7;
            this.grdPassword.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdPassword.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1497, 725);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.splitContainer1);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1493, 701);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "ثبت اطلاعات";
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.grdReport);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(1493, 701);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "گزارش";
            // 
            // grdReport
            // 
            this.grdReport.AlowRetrieveStructure = false;
            this.grdReport.AlternatingColors = true;
            this.grdReport.BuiltInTextsData = resources.GetString("grdReport.BuiltInTextsData");
            this.grdReport.DataSource = this.companies_MobileNumList4;
            this.grdReport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReport_DesignTimeLayout.LayoutString = resources.GetString("grdReport_DesignTimeLayout.LayoutString");
            this.grdReport.DesignTimeLayout = grdReport_DesignTimeLayout;
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReport.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReport.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReport.GroupByBoxVisible = false;
            this.grdReport.Location = new System.Drawing.Point(0, 0);
            this.grdReport.Name = "grdReport";
            this.grdReport.RecordNavigator = true;
            this.grdReport.Size = new System.Drawing.Size(1493, 701);
            this.grdReport.TabIndex = 0;
            this.grdReport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Companies_Base_CellNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 755);
            this.Name = "Companies_Base_CellNum";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "Companies_Base_CellNum";
            this.Load += new System.EventHandler(this.Companies_Base_CellNum_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCompanies)).EndInit();
            this.grpCompanies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanyBase)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbMobile)).EndInit();
            this.grbMobile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTelegram)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWhatsapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox grpCompanies;
        private General.Controls.Grid grdCompanyBase;
        private General.Lists.CompaniesBaseList companiesBaseList1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private General.Controls.GroupBox grbMobile;
        private General.Controls.Grid grdTelegram;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdWhatsapp;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdPassword;
        private General.Lists.Companies_MobileNumList companies_MobileNumList1;
        private General.Lists.Companies_MobileNumList companies_MobileNumList2;
        private General.Lists.Companies_MobileNumList companies_MobileNumList3;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Controls.Grid grdReport;
        private General.Lists.Companies_MobileNumList companies_MobileNumList4;
    }
}