namespace RASF.Main.Forms.WorkFlow
{
    partial class WorkFlowForLaboratoryScience
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
            Janus.Windows.GridEX.GridEXLayout grdContract_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdpart_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkFlowForLaboratoryScience));
            Janus.Windows.GridEX.GridEXLayout grdpart_test_master_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdDesc_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpcontract = new RASF.General.Controls.GroupBox();
            this.grdContract = new RASF.General.Controls.Grid();
            this.contractsForWorkFlowList1 = new RASF.General.Lists.ContractsForWorkFlowList(this.components);
            this.grpparts = new RASF.General.Controls.GroupBox();
            this.grdpart = new RASF.General.Controls.Grid();
            this.partsMasterForWorkFlowList1 = new RASF.General.Lists.PartsMasterForWorkFlowList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grpparttestmaster = new RASF.General.Controls.GroupBox();
            this.grdpart_test_master = new RASF.General.Controls.Grid();
            this.parts_Tests_MasterForWorkFlowList1 = new RASF.General.Lists.Parts_Tests_MasterForWorkFlowList(this.components);
            this.groupBox8 = new RASF.General.Controls.GroupBox();
            this.grdDesc = new RASF.General.Controls.Grid();
            this.workFlowDescriptionList1 = new RASF.General.Lists.WorkFlowDescriptionList(this.components);
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.getDocumentForPrintList1 = new RASF.General.Lists.GetDocumentForPrintList(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpcontract)).BeginInit();
            this.grpcontract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpparts)).BeginInit();
            this.grpparts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdpart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpparttestmaster)).BeginInit();
            this.grpparttestmaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdpart_test_master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox8)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 660);
            this.pnlButton.Size = new System.Drawing.Size(1339, 30);
            // 
            // btnExit
            // 
            this.btnExit.Text = "رد";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Text = "تایید";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1339, 660);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1134, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1217, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1279, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1339, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 8);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpcontract);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpparts);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1333, 267);
            this.splitContainer1.SplitterDistance = 651;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpcontract
            // 
            this.grpcontract.Controls.Add(this.grdContract);
            this.grpcontract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpcontract.Location = new System.Drawing.Point(0, 0);
            this.grpcontract.Name = "grpcontract";
            this.grpcontract.Size = new System.Drawing.Size(651, 267);
            this.grpcontract.TabIndex = 0;
            this.grpcontract.Text = "قرارداد";
            this.grpcontract.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContract
            // 
            this.grdContract.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdContract.AlowRetrieveStructure = false;
            this.grdContract.AlternatingColors = true;
            this.grdContract.BuiltInTextsData = resources.GetString("grdContract.BuiltInTextsData");
            this.grdContract.DataSource = this.contractsForWorkFlowList1;
            this.grdContract.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContract_DesignTimeLayout.LayoutString = resources.GetString("grdContract_DesignTimeLayout.LayoutString");
            this.grdContract.DesignTimeLayout = grdContract_DesignTimeLayout;
            this.grdContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContract.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContract.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContract.GroupByBoxVisible = false;
            this.grdContract.Location = new System.Drawing.Point(3, 17);
            this.grdContract.Name = "grdContract";
            this.grdContract.RecordNavigator = true;
            this.grdContract.Size = new System.Drawing.Size(645, 247);
            this.grdContract.TabIndex = 0;
            this.grdContract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdContract.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdContract_ColumnButtonClick);
            // 
            // grpparts
            // 
            this.grpparts.Controls.Add(this.grdpart);
            this.grpparts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpparts.Location = new System.Drawing.Point(0, 0);
            this.grpparts.Name = "grpparts";
            this.grpparts.Size = new System.Drawing.Size(678, 267);
            this.grpparts.TabIndex = 1;
            this.grpparts.Text = "تنوع";
            this.grpparts.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdpart
            // 
            this.grdpart.AlowRetrieveStructure = false;
            this.grdpart.AlternatingColors = true;
            this.grdpart.BuiltInTextsData = resources.GetString("grdpart.BuiltInTextsData");
            this.grdpart.DataSource = this.partsMasterForWorkFlowList1;
            this.grdpart.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdpart_DesignTimeLayout.LayoutString = resources.GetString("grdpart_DesignTimeLayout.LayoutString");
            this.grdpart.DesignTimeLayout = grdpart_DesignTimeLayout;
            this.grdpart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdpart.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdpart.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdpart.GroupByBoxVisible = false;
            this.grdpart.Location = new System.Drawing.Point(3, 17);
            this.grdpart.Name = "grdpart";
            this.grdpart.RecordNavigator = true;
            this.grdpart.Size = new System.Drawing.Size(672, 247);
            this.grdpart.TabIndex = 1;
            this.grdpart.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdpart.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdpart.EditingCell += new Janus.Windows.GridEX.EditingCellEventHandler(this.grdpart_EditingCell);
            this.grdpart.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdpart_ColumnButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1339, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 8);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpparttestmaster);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox8);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1333, 371);
            this.splitContainer2.SplitterDistance = 651;
            this.splitContainer2.TabIndex = 1;
            // 
            // grpparttestmaster
            // 
            this.grpparttestmaster.Controls.Add(this.grdpart_test_master);
            this.grpparttestmaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpparttestmaster.Location = new System.Drawing.Point(0, 0);
            this.grpparttestmaster.Name = "grpparttestmaster";
            this.grpparttestmaster.Size = new System.Drawing.Size(651, 371);
            this.grpparttestmaster.TabIndex = 1;
            this.grpparttestmaster.Text = "گزارشات";
            this.grpparttestmaster.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdpart_test_master
            // 
            this.grdpart_test_master.AlowRetrieveStructure = false;
            this.grdpart_test_master.AlternatingColors = true;
            this.grdpart_test_master.BuiltInTextsData = resources.GetString("grdpart_test_master.BuiltInTextsData");
            this.grdpart_test_master.DataSource = this.parts_Tests_MasterForWorkFlowList1;
            this.grdpart_test_master.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdpart_test_master_DesignTimeLayout.LayoutString = resources.GetString("grdpart_test_master_DesignTimeLayout.LayoutString");
            this.grdpart_test_master.DesignTimeLayout = grdpart_test_master_DesignTimeLayout;
            this.grdpart_test_master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdpart_test_master.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdpart_test_master.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdpart_test_master.GroupByBoxVisible = false;
            this.grdpart_test_master.Location = new System.Drawing.Point(3, 17);
            this.grdpart_test_master.Name = "grdpart_test_master";
            this.grdpart_test_master.RecordNavigator = true;
            this.grdpart_test_master.Size = new System.Drawing.Size(645, 351);
            this.grdpart_test_master.TabIndex = 2;
            this.grdpart_test_master.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdpart_test_master.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdpart_test_master.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdpart_test_master_ColumnButtonClick);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.grdDesc);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(678, 232);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.Text = "توضیحات";
            this.groupBox8.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDesc
            // 
            this.grdDesc.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDesc.AlowRetrieveStructure = false;
            this.grdDesc.AlternatingColors = true;
            this.grdDesc.BuiltInTextsData = resources.GetString("grdDesc.BuiltInTextsData");
            this.grdDesc.DataSource = this.workFlowDescriptionList1;
            this.grdDesc.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDesc_DesignTimeLayout.LayoutString = resources.GetString("grdDesc_DesignTimeLayout.LayoutString");
            this.grdDesc.DesignTimeLayout = grdDesc_DesignTimeLayout;
            this.grdDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDesc.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDesc.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDesc.GroupByBoxVisible = false;
            this.grdDesc.Location = new System.Drawing.Point(3, 17);
            this.grdDesc.Name = "grdDesc";
            this.grdDesc.RecordNavigator = true;
            this.grdDesc.Size = new System.Drawing.Size(672, 212);
            this.grdDesc.TabIndex = 3;
            this.grdDesc.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDesc);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.Text = "توضیحات";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtDesc
            // 
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Location = new System.Drawing.Point(3, 17);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(672, 119);
            this.txtDesc.TabIndex = 0;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // WorkFlowForLaboratoryScience
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1339, 690);
            this.Name = "WorkFlowForLaboratoryScience";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.WorkFlowForLaboratory_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpcontract)).EndInit();
            this.grpcontract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpparts)).EndInit();
            this.grpparts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdpart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpparttestmaster)).EndInit();
            this.grpparttestmaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdpart_test_master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox8)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private General.Controls.GroupBox grpparttestmaster;
        private General.Controls.GroupBox groupBox8;
        private General.Controls.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox grpcontract;
        private General.Controls.Grid grdContract;
        private General.Controls.GroupBox grpparts;
        private General.Controls.Grid grdpart;
        private General.Lists.ContractsForWorkFlowList contractsForWorkFlowList1;
        private General.Lists.PartsMasterForWorkFlowList partsMasterForWorkFlowList1;
        private General.Lists.Parts_Tests_MasterForWorkFlowList parts_Tests_MasterForWorkFlowList1;
        private General.Controls.Grid grdDesc;
        private General.Lists.WorkFlowDescriptionList workFlowDescriptionList1;
        public General.Controls.Grid grdpart_test_master;
        private General.Controls.GroupBox groupBox3;
        private General.Lists.GetDocumentForPrintList getDocumentForPrintList1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox txtDesc;
    }
}
