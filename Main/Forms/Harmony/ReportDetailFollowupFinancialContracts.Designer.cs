namespace RASF.Main.Forms.Harmony
{
    partial class ReportDetailFollowupFinancialContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDetailFollowupFinancialContracts));
            Janus.Windows.GridEX.GridEXLayout grdReports_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdReports = new RASF.General.Controls.Grid();
            this.reportDetailFollowupFinancialContractsList1 = new RASF.General.Lists.ReportDetailFollowupFinancialContractsList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.txtdesc = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 569);
            this.pnlButton.Size = new System.Drawing.Size(993, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(993, 569);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(788, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(871, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(933, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdReports);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReports
            // 
            this.grdReports.AlowRetrieveStructure = false;
            this.grdReports.AlternatingColors = true;
            this.grdReports.BuiltInTextsData = resources.GetString("grdReports.BuiltInTextsData");
            this.grdReports.DataSource = this.reportDetailFollowupFinancialContractsList1;
            this.grdReports.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReports_DesignTimeLayout.LayoutString = resources.GetString("grdReports_DesignTimeLayout.LayoutString");
            this.grdReports.DesignTimeLayout = grdReports_DesignTimeLayout;
            this.grdReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReports.GroupByBoxVisible = false;
            this.grdReports.Location = new System.Drawing.Point(3, 17);
            this.grdReports.Name = "grdReports";
            this.grdReports.RecordNavigator = true;
            this.grdReports.Size = new System.Drawing.Size(987, 449);
            this.grdReports.TabIndex = 0;
            this.grdReports.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReports.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdReports.SelectionChanged += new System.EventHandler(this.grdReports_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdesc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(993, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "توضیحات";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtdesc
            // 
            this.txtdesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportDetailFollowupFinancialContractsList1, "Description", true));
            this.txtdesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdesc.Location = new System.Drawing.Point(3, 17);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(987, 80);
            this.txtdesc.TabIndex = 0;
            this.txtdesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // ReportDetailFollowupFinancialContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(993, 599);
            this.Name = "ReportDetailFollowupFinancialContracts";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ReportDetailFollowupFinancialContracts_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdReports;
        private General.Lists.ReportDetailFollowupFinancialContractsList reportDetailFollowupFinancialContractsList1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.TextBox txtdesc;
    }
}
