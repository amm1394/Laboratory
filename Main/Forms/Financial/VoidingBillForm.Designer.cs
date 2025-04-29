namespace RASF.Main.Forms.Financial
{
    partial class VoidingBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoidingBillForm));
            Janus.Windows.GridEX.GridEXLayout grdBill_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grdBill = new RASF.General.Controls.Grid();
            this.masterBillVoidList1 = new RASF.General.Lists.MasterBillVoidList(this.components);
            this.grpText = new RASF.General.Controls.GroupBox();
            this.txtReason = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).BeginInit();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).BeginInit();
            this.grpText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 562);
            this.pnlButton.Size = new System.Drawing.Size(811, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpText);
            this.pnlContent.Controls.Add(this.grpGrid);
            this.pnlContent.Size = new System.Drawing.Size(811, 562);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(606, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(689, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(751, 0);
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.grdBill);
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGrid.Location = new System.Drawing.Point(0, 0);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(811, 289);
            this.grpGrid.TabIndex = 1;
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdBill
            // 
            this.grdBill.AlowRetrieveStructure = false;
            this.grdBill.AlternatingColors = true;
            this.grdBill.BuiltInTextsData = resources.GetString("grdBill.BuiltInTextsData");
            this.grdBill.DataSource = this.masterBillVoidList1;
            this.grdBill.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBill_DesignTimeLayout.LayoutString = resources.GetString("grdBill_DesignTimeLayout.LayoutString");
            this.grdBill.DesignTimeLayout = grdBill_DesignTimeLayout;
            this.grdBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBill.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdBill.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdBill.GroupByBoxVisible = false;
            this.grdBill.Location = new System.Drawing.Point(3, 8);
            this.grdBill.Name = "grdBill";
            this.grdBill.Size = new System.Drawing.Size(805, 278);
            this.grdBill.TabIndex = 0;
            this.grdBill.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBill.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpText
            // 
            this.grpText.Controls.Add(this.txtReason);
            this.grpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpText.Location = new System.Drawing.Point(0, 289);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(811, 273);
            this.grpText.TabIndex = 2;
            this.grpText.Text = "علت ابطال صورت حساب";
            this.grpText.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtReason
            // 
            this.txtReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterBillVoidList1, "Description", true));
            this.txtReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReason.Location = new System.Drawing.Point(3, 17);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(805, 253);
            this.txtReason.TabIndex = 0;
            this.txtReason.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // VoidingBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(811, 592);
            this.Name = "VoidingBillForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.VoidingBillForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).EndInit();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).EndInit();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpGrid;
        private General.Controls.GroupBox grpText;
        private General.Controls.TextBox txtReason;
        private General.Controls.Grid grdBill;
        private General.Lists.MasterBillVoidList masterBillVoidList1;
    }
}
