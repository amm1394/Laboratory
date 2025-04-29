namespace RASF.Main.Forms.Harmony
{
    partial class SendEmailCostomerCostPDFForOffices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEmailCostomerCostPDFForOffices));
            Janus.Windows.GridEX.GridEXLayout grdCostomerCost_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdCostomerCost = new RASF.General.Controls.Grid();
            this.grpFind = new RASF.General.Controls.GroupBox();
            this.labEmail = new RASF.General.Controls.Label();
            this.txtEmail = new RASF.General.Controls.TextBox();
            this.btnSearch = new RASF.General.Controls.Save_Button();
            this.txtSearch = new RASF.General.Controls.TextBox();
            this.costomersCostGridList1 = new RASF.General.Lists.costomersCostGridList(this.components);
            this.Report2 = new Stimulsoft.Report.StiReport();
            this.costomerCostList1 = new RASF.General.Lists.CostomerCostList(this.components);
            this.findContractNoList1 = new RASF.General.Lists.FindContractNoList(this.components);
            this.partsMasterSendEmailWithSMS1 = new SendSMS.Classes.PartsMasterSendEmailWithSMS();
            this.sendEmailCostomerCostPDFForOfficesList1 = new RASF.General.Lists.SendEmailCostomerCostPDFForOfficesList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCostomerCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).BeginInit();
            this.grpFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 665);
            this.pnlButton.Size = new System.Drawing.Size(1088, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1088, 665);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(883, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(966, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1028, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCostomerCost);
            this.groupBox1.Controls.Add(this.grpFind);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 665);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCostomerCost
            // 
            this.grdCostomerCost.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCostomerCost.AlowRetrieveStructure = false;
            this.grdCostomerCost.AlternatingColors = true;
            this.grdCostomerCost.BuiltInTextsData = resources.GetString("grdCostomerCost.BuiltInTextsData");
            this.grdCostomerCost.ColumnAutoResize = true;
            this.grdCostomerCost.DataSource = this.sendEmailCostomerCostPDFForOfficesList1;
            this.grdCostomerCost.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCostomerCost_DesignTimeLayout.LayoutString = resources.GetString("grdCostomerCost_DesignTimeLayout.LayoutString");
            this.grdCostomerCost.DesignTimeLayout = grdCostomerCost_DesignTimeLayout;
            this.grdCostomerCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCostomerCost.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCostomerCost.GroupByBoxVisible = false;
            this.grdCostomerCost.Location = new System.Drawing.Point(3, 94);
            this.grdCostomerCost.Name = "grdCostomerCost";
            this.grdCostomerCost.Size = new System.Drawing.Size(1082, 568);
            this.grdCostomerCost.TabIndex = 6;
            this.grdCostomerCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCostomerCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCostomerCost.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCostomerCost_ColumnButtonClick);
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.labEmail);
            this.grpFind.Controls.Add(this.txtEmail);
            this.grpFind.Controls.Add(this.btnSearch);
            this.grpFind.Controls.Add(this.txtSearch);
            this.grpFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFind.Location = new System.Drawing.Point(3, 8);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(1082, 86);
            this.grpFind.TabIndex = 5;
            this.grpFind.Text = "جستجو";
            this.grpFind.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(1051, 50);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(36, 13);
            this.labEmail.TabIndex = 3;
            this.labEmail.Text = "ایمیل:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(958, 21);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(87, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(989, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // Report2
            // 
            this.Report2.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Report2.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.Report2.ReportAlias = "Report";
            this.Report2.ReportGuid = "3c51ffb0c7c24aa4b2589bfa7ab4d9e6";
            this.Report2.ReportName = "Report";
            this.Report2.ReportSource = null;
            this.Report2.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.Report2.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.Report2.UseProgressInThread = false;
            // 
            // SendEmailCostomerCostPDFForOffices
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1088, 695);
            this.Name = "SendEmailCostomerCostPDFForOffices";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCostomerCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).EndInit();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Lists.CostomerCostList costomerCostList1;
        private General.Lists.costomersCostGridList costomersCostGridList1;
        private Stimulsoft.Report.StiReport Report2;
        private General.Controls.GroupBox grpFind;
        private General.Controls.Label labEmail;
        private General.Controls.TextBox txtEmail;
        private General.Controls.Save_Button btnSearch;
        private General.Controls.TextBox txtSearch;
        private General.Lists.FindContractNoList findContractNoList1;
        private General.Controls.Grid grdCostomerCost;
        private SendSMS.Classes.PartsMasterSendEmailWithSMS partsMasterSendEmailWithSMS1;
        private General.Lists.SendEmailCostomerCostPDFForOfficesList sendEmailCostomerCostPDFForOfficesList1;
    }
}
