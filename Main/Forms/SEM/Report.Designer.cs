namespace RASF.Main.Forms.SEM
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            Janus.Windows.GridEX.GridEXLayout grdCancel_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdNoCustomer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdCancel = new RASF.General.Controls.Grid();
            this.timingSEMCanceledList1 = new RASF.General.Lists.TimingSEMCanceledList(this.components);
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdNoCustomer = new RASF.General.Controls.Grid();
            this.timingSEMNoCustomerPresenceList1 = new RASF.General.Lists.TimingSEMNoCustomerPresenceList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCancel)).BeginInit();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNoCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 604);
            this.pnlButton.Size = new System.Drawing.Size(855, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(855, 604);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(650, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(733, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(795, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(855, 604);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox2);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(851, 580);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "کنسل شده ها";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdCancel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 580);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCancel
            // 
            this.grdCancel.AlowRetrieveStructure = false;
            this.grdCancel.AlternatingColors = true;
            this.grdCancel.BuiltInTextsData = resources.GetString("grdCancel.BuiltInTextsData");
            this.grdCancel.DataSource = this.timingSEMCanceledList1;
            this.grdCancel.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCancel_DesignTimeLayout.LayoutString = resources.GetString("grdCancel_DesignTimeLayout.LayoutString");
            this.grdCancel.DesignTimeLayout = grdCancel_DesignTimeLayout;
            this.grdCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCancel.GroupByBoxVisible = false;
            this.grdCancel.Location = new System.Drawing.Point(3, 8);
            this.grdCancel.Name = "grdCancel";
            this.grdCancel.Size = new System.Drawing.Size(845, 569);
            this.grdCancel.TabIndex = 1;
            this.grdCancel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCancel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox1);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(851, 580);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "عدم حضور مشتری";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdNoCustomer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 580);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdNoCustomer
            // 
            this.grdNoCustomer.AlowRetrieveStructure = false;
            this.grdNoCustomer.AlternatingColors = true;
            this.grdNoCustomer.BuiltInTextsData = resources.GetString("grdNoCustomer.BuiltInTextsData");
            this.grdNoCustomer.DataSource = this.timingSEMNoCustomerPresenceList1;
            this.grdNoCustomer.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdNoCustomer_DesignTimeLayout.LayoutString = resources.GetString("grdNoCustomer_DesignTimeLayout.LayoutString");
            this.grdNoCustomer.DesignTimeLayout = grdNoCustomer_DesignTimeLayout;
            this.grdNoCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNoCustomer.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdNoCustomer.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdNoCustomer.GroupByBoxVisible = false;
            this.grdNoCustomer.Location = new System.Drawing.Point(3, 8);
            this.grdNoCustomer.Name = "grdNoCustomer";
            this.grdNoCustomer.Size = new System.Drawing.Size(845, 569);
            this.grdNoCustomer.TabIndex = 0;
            this.grdNoCustomer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdNoCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(855, 634);
            this.Name = "Report";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Report_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCancel)).EndInit();
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNoCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private General.Controls.GroupBox groupBox2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdCancel;
        private General.Controls.Grid grdNoCustomer;
        private General.Lists.TimingSEMNoCustomerPresenceList timingSEMNoCustomerPresenceList1;
        private General.Lists.TimingSEMCanceledList timingSEMCanceledList1;
    }
}
