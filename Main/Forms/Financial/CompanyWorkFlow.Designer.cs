namespace RASF.Main.Forms.Financial
{
    partial class CompanyWorkFlow
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
            Janus.Windows.GridEX.GridEXLayout grdCompanies_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyWorkFlow));
            Janus.Windows.GridEX.GridEXLayout grdWorkFlow_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpCompanies = new RASF.General.Controls.GroupBox();
            this.grdCompanies = new RASF.General.Controls.Grid();
            this.debtorCreditorCompaniesWorkFlowList1 = new RASF.General.Lists.DebtorCreditorCompaniesWorkFlowList(this.components);
            this.grpWorkFlow = new RASF.General.Controls.GroupBox();
            this.grdWorkFlow = new RASF.General.Controls.Grid();
            this.companyWorkFlowList1 = new RASF.General.Lists.CompanyWorkFlowList(this.components);
            this.btnPrint = new RASF.General.Controls.Button();
            this.Report2 = new Stimulsoft.Report.StiReport();
            this.pnlPrint = new RASF.General.Controls.Panel();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompanies)).BeginInit();
            this.grpCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpWorkFlow)).BeginInit();
            this.grpWorkFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkFlow)).BeginInit();
            this.pnlPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.pnlPrint);
            this.pnlButton.Location = new System.Drawing.Point(0, 585);
            this.pnlButton.Size = new System.Drawing.Size(1021, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlPrint, 0);
            // 
            // btnExit
            // 
            this.btnExit.Text = "بروزرسانی";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpWorkFlow);
            this.pnlContent.Controls.Add(this.grpCompanies);
            this.pnlContent.Size = new System.Drawing.Size(1021, 585);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(816, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(899, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(961, 0);
            // 
            // grpCompanies
            // 
            this.grpCompanies.Controls.Add(this.grdCompanies);
            this.grpCompanies.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCompanies.Location = new System.Drawing.Point(0, 0);
            this.grpCompanies.Name = "grpCompanies";
            this.grpCompanies.Size = new System.Drawing.Size(1021, 315);
            this.grpCompanies.TabIndex = 0;
            this.grpCompanies.Text = "شرکت";
            this.grpCompanies.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            this.grpCompanies.Click += new System.EventHandler(this.grpCompanies_Click);
            // 
            // grdCompanies
            // 
            this.grdCompanies.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCompanies.AlowRetrieveStructure = false;
            this.grdCompanies.AlternatingColors = true;
            this.grdCompanies.BuiltInTextsData = resources.GetString("grdCompanies.BuiltInTextsData");
            this.grdCompanies.DataSource = this.debtorCreditorCompaniesWorkFlowList1;
            this.grdCompanies.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompanies_DesignTimeLayout.LayoutString = resources.GetString("grdCompanies_DesignTimeLayout.LayoutString");
            this.grdCompanies.DesignTimeLayout = grdCompanies_DesignTimeLayout;
            this.grdCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompanies.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompanies.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompanies.GroupByBoxVisible = false;
            this.grdCompanies.Location = new System.Drawing.Point(3, 17);
            this.grdCompanies.Name = "grdCompanies";
            this.grdCompanies.Size = new System.Drawing.Size(1015, 295);
            this.grdCompanies.TabIndex = 0;
            this.grdCompanies.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompanies.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCompanies.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompanies.SelectionChanged += new System.EventHandler(this.grdCompanies_SelectionChanged);
            // 
            // grpWorkFlow
            // 
            this.grpWorkFlow.Controls.Add(this.grdWorkFlow);
            this.grpWorkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpWorkFlow.Location = new System.Drawing.Point(0, 315);
            this.grpWorkFlow.Name = "grpWorkFlow";
            this.grpWorkFlow.Size = new System.Drawing.Size(1021, 270);
            this.grpWorkFlow.TabIndex = 1;
            this.grpWorkFlow.Text = "گردش کار";
            this.grpWorkFlow.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdWorkFlow
            // 
            this.grdWorkFlow.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdWorkFlow.AlowRetrieveStructure = false;
            this.grdWorkFlow.AlternatingColors = true;
            this.grdWorkFlow.BuiltInTextsData = resources.GetString("grdWorkFlow.BuiltInTextsData");
            this.grdWorkFlow.DataSource = this.companyWorkFlowList1;
            this.grdWorkFlow.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdWorkFlow_DesignTimeLayout.LayoutString = resources.GetString("grdWorkFlow_DesignTimeLayout.LayoutString");
            this.grdWorkFlow.DesignTimeLayout = grdWorkFlow_DesignTimeLayout;
            this.grdWorkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWorkFlow.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdWorkFlow.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdWorkFlow.GroupByBoxVisible = false;
            this.grdWorkFlow.Location = new System.Drawing.Point(3, 17);
            this.grdWorkFlow.Name = "grdWorkFlow";
            this.grdWorkFlow.Size = new System.Drawing.Size(1015, 250);
            this.grdWorkFlow.TabIndex = 1;
            this.grdWorkFlow.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdWorkFlow.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdWorkFlow.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdWorkFlow.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdWorkFlow_FormattingRow);
            this.grdWorkFlow.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdWorkFlow_ColumnButtonClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(3, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 26);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // pnlPrint
            // 
            this.pnlPrint.Controls.Add(this.btnPrint);
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPrint.Location = new System.Drawing.Point(745, 0);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(71, 30);
            this.pnlPrint.TabIndex = 5;
            // 
            // CompanyWorkFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1021, 615);
            this.Name = "CompanyWorkFlow";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CompanyWorkFlow_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCompanies)).EndInit();
            this.grpCompanies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpWorkFlow)).EndInit();
            this.grpWorkFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkFlow)).EndInit();
            this.pnlPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpWorkFlow;
        private General.Controls.Grid grdWorkFlow;
        private General.Controls.GroupBox grpCompanies;
        private General.Controls.Grid grdCompanies;
        private General.Lists.DebtorCreditorCompaniesWorkFlowList debtorCreditorCompaniesWorkFlowList1;
        private General.Lists.CompanyWorkFlowList companyWorkFlowList1;
        private General.Controls.Button btnPrint;
        private General.Controls.Panel pnlPrint;
        private Stimulsoft.Report.StiReport Report2;
    }
}
