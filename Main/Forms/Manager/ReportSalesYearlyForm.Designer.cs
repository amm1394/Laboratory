namespace RASF.Main.Forms.Manager
{
    partial class ReportSalesYearlyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSalesYearlyForm));
            Janus.Windows.GridEX.GridEXLayout grdLab_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpLab = new RASF.General.Controls.GroupBox();
            this.grdLab = new RASF.General.Controls.Grid();
            this.reportSalesYearlyList1 = new RASF.General.Lists.ReportSalesYearlyList(this.components);
            this.grpKol = new RASF.General.Controls.GroupBox();
            this.grdKol = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpLab)).BeginInit();
            this.grpLab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKol)).BeginInit();
            this.grpKol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKol)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 635);
            this.pnlButton.Size = new System.Drawing.Size(1219, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Size = new System.Drawing.Size(1219, 635);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1014, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1097, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1159, 0);
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
            this.splitContainer1.Panel1.Controls.Add(this.grpLab);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpKol);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1219, 635);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpLab
            // 
            this.grpLab.Controls.Add(this.grdLab);
            this.grpLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLab.Location = new System.Drawing.Point(0, 0);
            this.grpLab.Name = "grpLab";
            this.grpLab.Size = new System.Drawing.Size(1219, 308);
            this.grpLab.TabIndex = 0;
            this.grpLab.Text = "گزارش سالانه آزمایشگاه ها";
            this.grpLab.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdLab
            // 
            this.grdLab.AlowRetrieveStructure = false;
            this.grdLab.AlternatingColors = true;
            this.grdLab.BuiltInTextsData = resources.GetString("grdLab.BuiltInTextsData");
            this.grdLab.DataSource = this.reportSalesYearlyList1;
            this.grdLab.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdLab_DesignTimeLayout.LayoutString = resources.GetString("grdLab_DesignTimeLayout.LayoutString");
            this.grdLab.DesignTimeLayout = grdLab_DesignTimeLayout;
            this.grdLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLab.GroupByBoxVisible = false;
            this.grdLab.Location = new System.Drawing.Point(3, 17);
            this.grdLab.Name = "grdLab";
            this.grdLab.Size = new System.Drawing.Size(1213, 288);
            this.grdLab.TabIndex = 0;
            this.grdLab.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdLab.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdLab.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpKol
            // 
            this.grpKol.Controls.Add(this.grdKol);
            this.grpKol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKol.Location = new System.Drawing.Point(0, 0);
            this.grpKol.Name = "grpKol";
            this.grpKol.Size = new System.Drawing.Size(1219, 323);
            this.grpKol.TabIndex = 1;
            this.grpKol.Text = "گزارش سالانه کل";
            this.grpKol.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdKol
            // 
            this.grdKol.AlowRetrieveStructure = true;
            this.grdKol.AlternatingColors = true;
            this.grdKol.BuiltInTextsData = resources.GetString("grdKol.BuiltInTextsData");
            this.grdKol.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.grdKol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKol.GroupByBoxVisible = false;
            this.grdKol.Location = new System.Drawing.Point(3, 17);
            this.grdKol.Name = "grdKol";
            this.grdKol.Size = new System.Drawing.Size(1213, 303);
            this.grdKol.TabIndex = 1;
            this.grdKol.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdKol.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ReportSalesYearlyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1219, 665);
            this.Name = "ReportSalesYearlyForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ReportSalesYearlyForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpLab)).EndInit();
            this.grpLab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKol)).EndInit();
            this.grpKol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox grpLab;
        private General.Controls.GroupBox grpKol;
        private General.Controls.Grid grdLab;
        private General.Controls.Grid grdKol;
        private General.Lists.ReportSalesYearlyList reportSalesYearlyList1;
    }
}
