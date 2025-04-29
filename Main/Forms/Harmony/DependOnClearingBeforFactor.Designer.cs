namespace RASF.Main.Forms.Harmony
{
    partial class DependOnClearingBeforFactor
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
            Janus.Windows.GridEX.GridEXLayout grdCredit_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DependOnClearingBeforFactor));
            Janus.Windows.GridEX.GridEXLayout grdWorkFlow_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpCredit = new RASF.General.Controls.GroupBox();
            this.grdCredit = new RASF.General.Controls.Grid();
            this.creditreportingcompaniesList1 = new RASF.General.Lists.CreditreportingcompaniesList(this.components);
            this.grpWorkFlow = new RASF.General.Controls.GroupBox();
            this.grdWorkFlow = new RASF.General.Controls.Grid();
            this.creditCompanyWorkFlowList1 = new RASF.General.Lists.CreditCompanyWorkFlowList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCredit)).BeginInit();
            this.grpCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpWorkFlow)).BeginInit();
            this.grpWorkFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 523);
            this.pnlButton.Size = new System.Drawing.Size(1424, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpWorkFlow);
            this.pnlContent.Controls.Add(this.grpCredit);
            this.pnlContent.Size = new System.Drawing.Size(1424, 523);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(2167, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1302, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1364, 0);
            // 
            // grpCredit
            // 
            this.grpCredit.Controls.Add(this.grdCredit);
            this.grpCredit.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCredit.Location = new System.Drawing.Point(0, 0);
            this.grpCredit.Name = "grpCredit";
            this.grpCredit.Size = new System.Drawing.Size(1424, 251);
            this.grpCredit.TabIndex = 2;
            this.grpCredit.Text = "گزارش شرکت های اعتباری";
            this.grpCredit.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCredit
            // 
            this.grdCredit.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCredit.AlowRetrieveStructure = false;
            this.grdCredit.AlternatingColors = true;
            this.grdCredit.BuiltInTextsData = resources.GetString("grdCredit.BuiltInTextsData");
            this.grdCredit.DataSource = this.creditreportingcompaniesList1;
            this.grdCredit.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCredit_DesignTimeLayout.LayoutString = resources.GetString("grdCredit_DesignTimeLayout.LayoutString");
            this.grdCredit.DesignTimeLayout = grdCredit_DesignTimeLayout;
            this.grdCredit.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdCredit.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCredit.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCredit.GroupByBoxVisible = false;
            this.grdCredit.Location = new System.Drawing.Point(3, 17);
            this.grdCredit.Name = "grdCredit";
            this.grdCredit.Size = new System.Drawing.Size(1418, 235);
            this.grdCredit.TabIndex = 0;
            this.grdCredit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCredit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCredit.SelectionChanged += new System.EventHandler(this.grdCredit_SelectionChanged);
            // 
            // grpWorkFlow
            // 
            this.grpWorkFlow.Controls.Add(this.grdWorkFlow);
            this.grpWorkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpWorkFlow.Location = new System.Drawing.Point(0, 251);
            this.grpWorkFlow.Name = "grpWorkFlow";
            this.grpWorkFlow.Size = new System.Drawing.Size(1424, 272);
            this.grpWorkFlow.TabIndex = 0;
            this.grpWorkFlow.Text = "گردش مالی";
            this.grpWorkFlow.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdWorkFlow
            // 
            this.grdWorkFlow.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdWorkFlow.AlowRetrieveStructure = false;
            this.grdWorkFlow.AlternatingColors = true;
            this.grdWorkFlow.BuiltInTextsData = resources.GetString("grdWorkFlow.BuiltInTextsData");
            this.grdWorkFlow.DataSource = this.creditCompanyWorkFlowList1;
            this.grdWorkFlow.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdWorkFlow_DesignTimeLayout.LayoutString = resources.GetString("grdWorkFlow_DesignTimeLayout.LayoutString");
            this.grdWorkFlow.DesignTimeLayout = grdWorkFlow_DesignTimeLayout;
            this.grdWorkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWorkFlow.GroupByBoxVisible = false;
            this.grdWorkFlow.Location = new System.Drawing.Point(3, 17);
            this.grdWorkFlow.Name = "grdWorkFlow";
            this.grdWorkFlow.Size = new System.Drawing.Size(1418, 252);
            this.grdWorkFlow.TabIndex = 1;
            this.grdWorkFlow.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdWorkFlow.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdWorkFlow.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // DependOnClearingBeforFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1424, 553);
            this.Name = "DependOnClearingBeforFactor";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Creditreportingcompanies_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCredit)).EndInit();
            this.grpCredit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpWorkFlow)).EndInit();
            this.grpWorkFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkFlow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpCredit;
        private RASF.General.Controls.Grid grdCredit;
        private RASF.General.Lists.CreditreportingcompaniesList creditreportingcompaniesList1;
        private General.Controls.GroupBox grpWorkFlow;
        private General.Lists.CreditCompanyWorkFlowList creditCompanyWorkFlowList1;
        private General.Controls.Grid grdWorkFlow;
    }
}
