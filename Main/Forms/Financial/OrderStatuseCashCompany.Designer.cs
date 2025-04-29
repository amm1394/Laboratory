namespace RASF.Main.Forms.Financial
{
    partial class OrderStatuseCashCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderStatuseCashCompany));
            Janus.Windows.GridEX.GridEXLayout grdcash_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdCredit_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdcash = new RASF.General.Controls.Grid();
            this.orderStatusCashCompanyList1 = new RASF.General.Lists.OrderStatusCashCompanyList(this.components);
            this.cashOrderStatusList1 = new RASF.General.Lists.CashOrderStatusList(this.components);
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdCredit = new RASF.General.Controls.Grid();
            this.orderStatusCreditCompanyList1 = new RASF.General.Lists.OrderStatusCreditCompanyList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 531);
            this.pnlButton.Size = new System.Drawing.Size(1002, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(1002, 531);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(797, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(880, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(942, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdcash);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "شرکت های نقدی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcash
            // 
            this.grdcash.AlowRetrieveStructure = false;
            this.grdcash.AlternatingColors = true;
            this.grdcash.BuiltInTextsData = resources.GetString("grdcash.BuiltInTextsData");
            this.grdcash.DataSource = this.orderStatusCashCompanyList1;
            this.grdcash.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcash_DesignTimeLayout.LayoutString = resources.GetString("grdcash_DesignTimeLayout.LayoutString");
            this.grdcash.DesignTimeLayout = grdcash_DesignTimeLayout;
            this.grdcash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcash.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdcash.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdcash.GroupByBoxVisible = false;
            this.grdcash.Location = new System.Drawing.Point(3, 17);
            this.grdcash.Name = "grdcash";
            this.grdcash.Size = new System.Drawing.Size(992, 487);
            this.grdcash.TabIndex = 0;
            this.grdcash.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcash.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdcash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1002, 531);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox1);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(998, 507);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "وضعیت مطالبات شرکت های نقدی";
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox2);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(998, 507);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "وضعیت مطالبات شرکت های اعتباری";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdCredit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 507);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "شرکت های اعتباری";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCredit
            // 
            this.grdCredit.AlowRetrieveStructure = false;
            this.grdCredit.AlternatingColors = true;
            this.grdCredit.BuiltInTextsData = resources.GetString("grdCredit.BuiltInTextsData");
            this.grdCredit.DataSource = this.orderStatusCreditCompanyList1;
            this.grdCredit.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCredit_DesignTimeLayout.LayoutString = resources.GetString("grdCredit_DesignTimeLayout.LayoutString");
            this.grdCredit.DesignTimeLayout = grdCredit_DesignTimeLayout;
            this.grdCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCredit.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCredit.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCredit.GroupByBoxVisible = false;
            this.grdCredit.Location = new System.Drawing.Point(3, 17);
            this.grdCredit.Name = "grdCredit";
            this.grdCredit.Size = new System.Drawing.Size(992, 487);
            this.grdCredit.TabIndex = 0;
            this.grdCredit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCredit.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCredit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // OrderStatuseCashCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1002, 561);
            this.Name = "OrderStatuseCashCompany";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.OrderStatuseCashCompany_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCredit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Grid grdcash;
        private RASF.General.Lists.CashOrderStatusList cashOrderStatusList1;
        private RASF.General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private RASF.General.Controls.GroupBox groupBox2;
        private RASF.General.Controls.Grid grdCredit;
        private RASF.General.Lists.OrderStatusCashCompanyList orderStatusCashCompanyList1;
        private RASF.General.Lists.OrderStatusCreditCompanyList orderStatusCreditCompanyList1;
    }
}
