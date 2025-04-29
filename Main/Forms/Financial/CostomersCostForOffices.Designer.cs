namespace RASF.Main.Forms.Reception
{
    partial class CostomersCostForOffices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostomersCostForOffices));
            Janus.Windows.GridEX.GridEXLayout grdCostomerCost_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdCostomerCost = new RASF.General.Controls.Grid();
            this.costomersCostGridForOfficesList1 = new RASF.General.Lists.CostomersCostGridForOfficesList(this.components);
            this.Report2 = new Stimulsoft.Report.StiReport();
            this.chkParts = new RASF.General.Controls.CheckBox();
            this.costomerCostList1 = new RASF.General.Lists.CostomerCostList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCostomerCost)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.chkParts);
            this.pnlButton.Location = new System.Drawing.Point(0, 665);
            this.pnlButton.Size = new System.Drawing.Size(1088, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.chkParts, 0);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1088, 665);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 6);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUpdate.Location = new System.Drawing.Point(883, 0);
            this.pnlUpdate.Size = new System.Drawing.Size(83, 30);
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
            this.grdCostomerCost.DataSource = this.costomersCostGridForOfficesList1;
            this.grdCostomerCost.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCostomerCost_DesignTimeLayout.LayoutString = resources.GetString("grdCostomerCost_DesignTimeLayout.LayoutString");
            this.grdCostomerCost.DesignTimeLayout = grdCostomerCost_DesignTimeLayout;
            this.grdCostomerCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCostomerCost.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCostomerCost.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCostomerCost.GroupByBoxVisible = false;
            this.grdCostomerCost.Location = new System.Drawing.Point(3, 8);
            this.grdCostomerCost.Name = "grdCostomerCost";
            this.grdCostomerCost.Size = new System.Drawing.Size(1082, 654);
            this.grdCostomerCost.TabIndex = 0;
            this.grdCostomerCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCostomerCost.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCostomerCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCostomerCost.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCostomerCost_ColumnButtonClick);
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
            // chkParts
            // 
            this.chkParts.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkParts.Location = new System.Drawing.Point(796, 0);
            this.chkParts.Name = "chkParts";
            this.chkParts.Size = new System.Drawing.Size(87, 30);
            this.chkParts.TabIndex = 4;
            this.chkParts.Text = "چاپ ریز آزمون";
            this.chkParts.Visible = false;
            this.chkParts.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // CostomersCostForOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1088, 695);
            this.Name = "CostomersCostForOffices";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CostomersCost_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCostomerCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdCostomerCost;
        protected Stimulsoft.Report.StiReport Report2;
        private General.Controls.CheckBox chkParts;
        private General.Lists.CostomerCostList costomerCostList1;
        private General.Lists.CostomersCostGridForOfficesList costomersCostGridForOfficesList1;
    }
}
