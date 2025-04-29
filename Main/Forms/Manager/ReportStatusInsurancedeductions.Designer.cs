namespace RASF.Main.Forms.Manager
{
    partial class ReportStatusInsurancedeductions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportStatusInsurancedeductions));
            Janus.Windows.GridEX.GridEXLayout grdTypeDeductions_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdKol_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.companiesCooperationTypeList1 = new RASF.General.Lists.CompaniesCooperationTypeList(this.components);
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.grp2 = new RASF.General.Controls.GroupBox();
            this.grdTypeDeductions = new RASF.General.Controls.Grid();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.grdKol = new RASF.General.Controls.Grid();
            this.companiesCooperationTypeList2 = new RASF.General.Lists.CompaniesCooperationTypeList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp2)).BeginInit();
            this.grp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTypeDeductions)).BeginInit();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKol)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 701);
            this.pnlButton.Size = new System.Drawing.Size(1225, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(1225, 701);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1020, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1103, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1165, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.Size = new System.Drawing.Size(1225, 701);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.grp2);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1221, 677);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "گزارش وضعیت کسور بیمه مشتریان";
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.grdTypeDeductions);
            this.grp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp2.Location = new System.Drawing.Point(0, 0);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(1221, 677);
            this.grp2.TabIndex = 4;
            this.grp2.Text = "گزارش وضعیت کسور بیمه مشتریان";
            this.grp2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdTypeDeductions
            // 
            this.grdTypeDeductions.AlowRetrieveStructure = false;
            this.grdTypeDeductions.AlternatingColors = true;
            this.grdTypeDeductions.BuiltInTextsData = resources.GetString("grdTypeDeductions.BuiltInTextsData");
            this.grdTypeDeductions.DataSource = this.companiesCooperationTypeList1;
            this.grdTypeDeductions.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTypeDeductions_DesignTimeLayout.LayoutString = resources.GetString("grdTypeDeductions_DesignTimeLayout.LayoutString");
            this.grdTypeDeductions.DesignTimeLayout = grdTypeDeductions_DesignTimeLayout;
            this.grdTypeDeductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTypeDeductions.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdTypeDeductions.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdTypeDeductions.GroupByBoxVisible = false;
            this.grdTypeDeductions.Location = new System.Drawing.Point(3, 17);
            this.grdTypeDeductions.Name = "grdTypeDeductions";
            this.grdTypeDeductions.RecordNavigator = true;
            this.grdTypeDeductions.Size = new System.Drawing.Size(1215, 657);
            this.grdTypeDeductions.TabIndex = 0;
            this.grdTypeDeductions.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTypeDeductions.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdTypeDeductions.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdTypeDeductions_ColumnButtonClick);
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.grdKol);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(826, 639);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "گزارش وضعیت کسور بیمه مشتریان2";
            // 
            // grdKol
            // 
            this.grdKol.AlowRetrieveStructure = false;
            this.grdKol.AlternatingColors = true;
            this.grdKol.BuiltInTextsData = resources.GetString("grdKol.BuiltInTextsData");
            this.grdKol.DataSource = this.companiesCooperationTypeList2;
            this.grdKol.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdKol_DesignTimeLayout.LayoutString = resources.GetString("grdKol_DesignTimeLayout.LayoutString");
            this.grdKol.DesignTimeLayout = grdKol_DesignTimeLayout;
            this.grdKol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKol.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdKol.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdKol.GroupByBoxVisible = false;
            this.grdKol.Location = new System.Drawing.Point(0, 0);
            this.grdKol.Name = "grdKol";
            this.grdKol.RecordNavigator = true;
            this.grdKol.Size = new System.Drawing.Size(826, 639);
            this.grdKol.TabIndex = 1;
            this.grdKol.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdKol.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdKol.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdKol.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdKol_ColumnButtonClick);
            // 
            // ReportStatusInsurancedeductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 731);
            this.Name = "ReportStatusInsurancedeductions";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ReportStatusInsurancedeductions";
            this.Load += new System.EventHandler(this.ReportStatusInsurancedeductions_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp2)).EndInit();
            this.grp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTypeDeductions)).EndInit();
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.CompaniesCooperationTypeList companiesCooperationTypeList1;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private General.Controls.GroupBox grp2;
        private General.Controls.Grid grdTypeDeductions;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Controls.Grid grdKol;
        private General.Lists.CompaniesCooperationTypeList companiesCooperationTypeList2;
    }
}