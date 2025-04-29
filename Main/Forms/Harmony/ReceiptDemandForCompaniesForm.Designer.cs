namespace RASF.Main.Forms.Harmony
{
    partial class ReceiptDemandForCompaniesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptDemandForCompaniesForm));
            Janus.Windows.GridEX.GridEXLayout grdCompanies_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grdCompanies = new RASF.General.Controls.Grid();
            this.receiptDemandForCompaniesList1 = new RASF.General.Lists.ReceiptDemandForCompaniesList(this.components);
            this.debtorCreditorCompaniesWorkFlowList1 = new RASF.General.Lists.DebtorCreditorCompaniesWorkFlowList(this.components);
            this.grpText = new RASF.General.Controls.GroupBox();
            this.txtReason = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).BeginInit();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).BeginInit();
            this.grpText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 501);
            this.pnlButton.Size = new System.Drawing.Size(971, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpText);
            this.pnlContent.Controls.Add(this.grpGrid);
            this.pnlContent.Size = new System.Drawing.Size(971, 501);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(766, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(849, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(911, 0);
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.grdCompanies);
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGrid.Location = new System.Drawing.Point(0, 0);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(971, 289);
            this.grpGrid.TabIndex = 0;
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompanies
            // 
            this.grdCompanies.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCompanies.AlowRetrieveStructure = false;
            this.grdCompanies.AlternatingColors = true;
            this.grdCompanies.BuiltInTextsData = resources.GetString("grdCompanies.BuiltInTextsData");
            this.grdCompanies.DataSource = this.receiptDemandForCompaniesList1;
            this.grdCompanies.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompanies_DesignTimeLayout.LayoutString = resources.GetString("grdCompanies_DesignTimeLayout.LayoutString");
            this.grdCompanies.DesignTimeLayout = grdCompanies_DesignTimeLayout;
            this.grdCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompanies.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompanies.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompanies.GroupByBoxVisible = false;
            this.grdCompanies.Location = new System.Drawing.Point(3, 8);
            this.grdCompanies.Name = "grdCompanies";
            this.grdCompanies.Size = new System.Drawing.Size(965, 278);
            this.grdCompanies.TabIndex = 1;
            this.grdCompanies.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompanies.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpText
            // 
            this.grpText.Controls.Add(this.txtReason);
            this.grpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpText.Location = new System.Drawing.Point(0, 289);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(971, 212);
            this.grpText.TabIndex = 1;
            this.grpText.Text = "توضیحات";
            this.grpText.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtReason
            // 
            this.txtReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptDemandForCompaniesList1, "Description", true));
            this.txtReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReason.Location = new System.Drawing.Point(3, 17);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(965, 192);
            this.txtReason.TabIndex = 0;
            this.txtReason.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // ReceiptDemandForCompaniesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 531);
            this.Name = "ReceiptDemandForCompaniesForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ثبت توضیحات وصول مطالبات شرکت ها";
            this.Load += new System.EventHandler(this.IsHoldForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).EndInit();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).EndInit();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpGrid;
        private General.Controls.GroupBox grpText;
        private General.Controls.TextBox txtReason;
        private General.Controls.Grid grdCompanies;
        private General.Lists.DebtorCreditorCompaniesWorkFlowList debtorCreditorCompaniesWorkFlowList1;
        private General.Lists.ReceiptDemandForCompaniesList receiptDemandForCompaniesList1;
    }
}