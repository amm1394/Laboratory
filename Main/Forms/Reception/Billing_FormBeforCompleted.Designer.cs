namespace RASF.Main.Forms.Reception
{
    partial class Billing_FormBeforCompleted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Form));
            Janus.Windows.GridEX.GridEXLayout grdContract_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdBiill_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.panel1 = new RASF.General.Controls.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpContracts = new RASF.General.Controls.GroupBox();
            this.grdContract = new RASF.General.Controls.Grid();
            this.contractsBillingList1 = new RASF.General.Lists.ContractsBillingList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdBiill = new RASF.General.Controls.Grid();
            this.masterBillDetailBillList1 = new RASF.General.Lists.MasterBillDetailBillList(this.components);
            this.partsTestMasterList1 = new RASF.General.Lists.PartsTestMasterList(this.components);
            this.Report2 = new Stimulsoft.Report.StiReport();
            this.partsMasterSendEmailList1 = new RASF.General.Lists.PartsMasterSendEmailList(this.components);
            this.findContractNoList1 = new RASF.General.Lists.FindContractNoList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContracts)).BeginInit();
            this.grpContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBiill)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 603);
            this.pnlButton.Size = new System.Drawing.Size(899, 30);
            // 
            // btnExit
            // 
            this.btnExit.Size = new System.Drawing.Size(64, 23);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 4);
            this.btnSave.Size = new System.Drawing.Size(57, 23);
            this.btnSave.Text = "صدور ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Size = new System.Drawing.Size(899, 603);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(678, 0);
            this.pnlUpdate.Size = new System.Drawing.Size(80, 30);
            this.pnlUpdate.Visible = true;
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(758, 0);
            this.pnlExit.Size = new System.Drawing.Size(74, 30);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(832, 0);
            this.pnlSave.Size = new System.Drawing.Size(67, 30);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 603);
            this.panel1.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.grpContracts);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(899, 603);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpContracts
            // 
            this.grpContracts.Controls.Add(this.grdContract);
            this.grpContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContracts.Location = new System.Drawing.Point(0, 0);
            this.grpContracts.Name = "grpContracts";
            this.grpContracts.Size = new System.Drawing.Size(899, 293);
            this.grpContracts.TabIndex = 2;
            this.grpContracts.Text = "قرارداد";
            this.grpContracts.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContract
            // 
            this.grdContract.AlowRetrieveStructure = false;
            this.grdContract.AlternatingColors = true;
            this.grdContract.BuiltInTextsData = resources.GetString("grdContract.BuiltInTextsData");
            this.grdContract.DataSource = this.contractsBillingList1;
            this.grdContract.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContract_DesignTimeLayout.LayoutString = resources.GetString("grdContract_DesignTimeLayout.LayoutString");
            this.grdContract.DesignTimeLayout = grdContract_DesignTimeLayout;
            this.grdContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContract.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContract.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContract.GroupByBoxVisible = false;
            this.grdContract.Location = new System.Drawing.Point(3, 17);
            this.grdContract.Name = "grdContract";
            this.grdContract.Size = new System.Drawing.Size(893, 273);
            this.grdContract.TabIndex = 1;
            this.grdContract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdContract.SelectionChanged += new System.EventHandler(this.grdContract_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdBiill);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 306);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdBiill
            // 
            this.grdBiill.AlowRetrieveStructure = false;
            this.grdBiill.AlternatingColors = true;
            this.grdBiill.BuiltInTextsData = resources.GetString("grdBiill.BuiltInTextsData");
            this.grdBiill.DataSource = this.masterBillDetailBillList1;
            this.grdBiill.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBiill_DesignTimeLayout.LayoutString = resources.GetString("grdBiill_DesignTimeLayout.LayoutString");
            this.grdBiill.DesignTimeLayout = grdBiill_DesignTimeLayout;
            this.grdBiill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBiill.GroupByBoxVisible = false;
            this.grdBiill.Location = new System.Drawing.Point(3, 8);
            this.grdBiill.Name = "grdBiill";
            this.grdBiill.Size = new System.Drawing.Size(893, 295);
            this.grdBiill.TabIndex = 1;
            this.grdBiill.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBiill.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdBiill.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdBiill.CurrentCellChanged += new System.EventHandler(this.grdBiill_CurrentCellChanged);
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
            // Bill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 633);
            this.Name = "Bill_Form";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "BillsForm";
            this.Load += new System.EventHandler(this.DisCount_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpContracts)).EndInit();
            this.grpContracts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBiill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox groupBox1;
        private General.Lists.MasterBillDetailBillList masterBillDetailBillList1;
        private General.Controls.Grid grdBiill;
        private General.Controls.Grid grdContract;
        private General.Lists.ContractsBillingList contractsBillingList1;
        private General.Lists.PartsTestMasterList partsTestMasterList1;
        protected Stimulsoft.Report.StiReport Report2;
        private General.Controls.GroupBox grpContracts;
        private General.Lists.PartsMasterSendEmailList partsMasterSendEmailList1;
        private General.Lists.FindContractNoList findContractNoList1;
    }
}