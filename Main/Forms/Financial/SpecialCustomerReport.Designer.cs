namespace RASF.Main.Forms.Harmony
{
    partial class SpecialCustomerReport
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
            Janus.Windows.GridEX.GridEXLayout grdBills_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialCustomerReport));
            Janus.Windows.GridEX.GridEXLayout grdcompanies_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grdBills = new RASF.General.Controls.Grid();
            this.licensingdeliveryreportList1 = new RASF.General.Lists.LicensingdeliveryreportList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdcompanies = new RASF.General.Controls.Grid();
            this.companiesBaseList1 = new RASF.General.Lists.CompaniesBaseList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).BeginInit();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 501);
            this.pnlButton.Size = new System.Drawing.Size(971, 30);
            // 
            // btnExit
            // 
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(971, 501);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(766, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(849, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(911, 0);
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.grdBills);
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGrid.Location = new System.Drawing.Point(0, 46);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(967, 431);
            this.grpGrid.TabIndex = 0;
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdBills
            // 
            this.grdBills.AlowRetrieveStructure = false;
            this.grdBills.AlternatingColors = true;
            this.grdBills.BuiltInTextsData = resources.GetString("grdBills.BuiltInTextsData");
            this.grdBills.DataSource = this.licensingdeliveryreportList1;
            this.grdBills.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBills_DesignTimeLayout.LayoutString = resources.GetString("grdBills_DesignTimeLayout.LayoutString");
            this.grdBills.DesignTimeLayout = grdBills_DesignTimeLayout;
            this.grdBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBills.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdBills.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdBills.GroupByBoxVisible = false;
            this.grdBills.Location = new System.Drawing.Point(3, 8);
            this.grdBills.Name = "grdBills";
            this.grdBills.Size = new System.Drawing.Size(961, 420);
            this.grdBills.TabIndex = 1;
            this.grdBills.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBills.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdBills.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "صورت حساب های صادر شده";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(540, 16);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 27);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(971, 501);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2});
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox2);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(967, 477);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "شرکت های ویژه";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdcompanies);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 477);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "شرکت ها";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcompanies
            // 
            this.grdcompanies.AlowRetrieveStructure = false;
            this.grdcompanies.AlternatingColors = true;
            this.grdcompanies.BuiltInTextsData = resources.GetString("grdcompanies.BuiltInTextsData");
            this.grdcompanies.DataSource = this.companiesBaseList1;
            this.grdcompanies.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcompanies_DesignTimeLayout.LayoutString = resources.GetString("grdcompanies_DesignTimeLayout.LayoutString");
            this.grdcompanies.DesignTimeLayout = grdcompanies_DesignTimeLayout;
            this.grdcompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcompanies.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdcompanies.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdcompanies.GroupByBoxVisible = false;
            this.grdcompanies.Location = new System.Drawing.Point(3, 17);
            this.grdcompanies.Name = "grdcompanies";
            this.grdcompanies.RecordNavigator = true;
            this.grdcompanies.Size = new System.Drawing.Size(961, 457);
            this.grdcompanies.TabIndex = 0;
            this.grdcompanies.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcompanies.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // SpecialCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 531);
            this.Name = "SpecialCustomerReport";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "IsHoldForm";
            this.Load += new System.EventHandler(this.IsHoldForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).EndInit();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpGrid;
        private General.Lists.LicensingdeliveryreportList licensingdeliveryreportList1;
        private General.Controls.Grid grdBills;
        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Controls.Grid grdcompanies;
        private General.Lists.CompaniesBaseList companiesBaseList1;
        private General.Controls.GroupBox groupBox2;
    }
}