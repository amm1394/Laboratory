namespace RASF.Main.Forms.Manager
{
    partial class PrePaidAmountForContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrePaidAmountForContract));
            Janus.Windows.GridEX.GridEXLayout grdReports_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdAgency_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdReports = new RASF.General.Controls.Grid();
            this.prePaidAmountForContractList1 = new RASF.General.Lists.PrePaidAmountForContractList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdAgency = new RASF.General.Controls.Grid();
            this.officesFinancialList1 = new RASF.General.Lists.OfficesFinancialList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgency)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 668);
            this.pnlButton.Size = new System.Drawing.Size(1424, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Size = new System.Drawing.Size(1424, 668);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1219, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1302, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1364, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdReports);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 668);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "مبالغ از پیش دریافت شده";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReports
            // 
            this.grdReports.AlowRetrieveStructure = false;
            this.grdReports.AlternatingColors = true;
            this.grdReports.BuiltInTextsData = resources.GetString("grdReports.BuiltInTextsData");
            this.grdReports.DataSource = this.prePaidAmountForContractList1;
            this.grdReports.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReports_DesignTimeLayout.LayoutString = resources.GetString("grdReports_DesignTimeLayout.LayoutString");
            this.grdReports.DesignTimeLayout = grdReports_DesignTimeLayout;
            this.grdReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReports.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReports.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReports.GroupByBoxVisible = false;
            this.grdReports.Location = new System.Drawing.Point(3, 17);
            this.grdReports.Name = "grdReports";
            this.grdReports.RecordNavigator = true;
            this.grdReports.Size = new System.Drawing.Size(1094, 648);
            this.grdReports.TabIndex = 0;
            this.grdReports.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReports.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdReports.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdReports.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdReports_ColumnButtonClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1424, 668);
            this.splitContainer1.SplitterDistance = 1100;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdAgency);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 668);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = "کارمزد دفاتر";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAgency
            // 
            this.grdAgency.AlowRetrieveStructure = false;
            this.grdAgency.AlternatingColors = true;
            this.grdAgency.BuiltInTextsData = resources.GetString("grdAgency.BuiltInTextsData");
            this.grdAgency.DataSource = this.officesFinancialList1;
            this.grdAgency.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAgency_DesignTimeLayout.LayoutString = resources.GetString("grdAgency_DesignTimeLayout.LayoutString");
            this.grdAgency.DesignTimeLayout = grdAgency_DesignTimeLayout;
            this.grdAgency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAgency.GroupByBoxVisible = false;
            this.grdAgency.Location = new System.Drawing.Point(3, 17);
            this.grdAgency.Name = "grdAgency";
            this.grdAgency.RecordNavigator = true;
            this.grdAgency.Size = new System.Drawing.Size(314, 648);
            this.grdAgency.TabIndex = 0;
            this.grdAgency.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAgency.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgency.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // PrePaidAmountForContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 698);
            this.Name = "PrePaidAmountForContract";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "PrePaidAmountForContract";
            this.Load += new System.EventHandler(this.PrePaidAmountForContract_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdReports;
        private General.Lists.PrePaidAmountForContractList prePaidAmountForContractList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdAgency;
        private General.Lists.OfficesFinancialList officesFinancialList1;
    }
}