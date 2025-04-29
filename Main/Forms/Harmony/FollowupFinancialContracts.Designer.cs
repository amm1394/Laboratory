namespace RASF.Main.Forms.Harmony
{
    partial class FollowupFinancialContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FollowupFinancialContracts));
            Janus.Windows.GridEX.GridEXLayout grdFinancial_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grdFinancial = new RASF.General.Controls.Grid();
            this.followupFinancialContractsList1 = new RASF.General.Lists.FollowupFinancialContractsList(this.components);
            this.grpText = new RASF.General.Controls.GroupBox();
            this.txtDesc = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).BeginInit();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancial)).BeginInit();
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 6);
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.Text = "اکسل";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.grpGrid.Controls.Add(this.grdFinancial);
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGrid.Location = new System.Drawing.Point(0, 0);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(971, 289);
            this.grpGrid.TabIndex = 0;
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdFinancial
            // 
            this.grdFinancial.AlowRetrieveStructure = false;
            this.grdFinancial.AlternatingColors = true;
            this.grdFinancial.BuiltInTextsData = resources.GetString("grdFinancial.BuiltInTextsData");
            this.grdFinancial.DataSource = this.followupFinancialContractsList1;
            this.grdFinancial.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdFinancial_DesignTimeLayout.LayoutString = resources.GetString("grdFinancial_DesignTimeLayout.LayoutString");
            this.grdFinancial.DesignTimeLayout = grdFinancial_DesignTimeLayout;
            this.grdFinancial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFinancial.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdFinancial.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdFinancial.GroupByBoxVisible = false;
            this.grdFinancial.Location = new System.Drawing.Point(3, 8);
            this.grdFinancial.Name = "grdFinancial";
            this.grdFinancial.RecordNavigator = true;
            this.grdFinancial.Size = new System.Drawing.Size(965, 278);
            this.grdFinancial.TabIndex = 0;
            this.grdFinancial.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdFinancial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdFinancial.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdFinancial_ColumnButtonClick);
            this.grdFinancial.SelectionChanged += new System.EventHandler(this.grdIsHold_SelectionChanged);
            // 
            // grpText
            // 
            this.grpText.Controls.Add(this.txtDesc);
            this.grpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpText.Location = new System.Drawing.Point(0, 289);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(971, 212);
            this.grpText.TabIndex = 1;
            this.grpText.Text = "توضیحات پیگیری";
            this.grpText.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.followupFinancialContractsList1, "Description", true));
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Location = new System.Drawing.Point(3, 17);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(965, 192);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // FollowupFinancialContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 531);
            this.Name = "FollowupFinancialContracts";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "پیگیری تایید مالی نشده ها";
            this.Load += new System.EventHandler(this.IsHoldForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).EndInit();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).EndInit();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpGrid;
        private General.Controls.GroupBox grpText;
        private General.Controls.TextBox txtDesc;
        private General.Controls.Grid grdFinancial;
        private General.Lists.FollowupFinancialContractsList followupFinancialContractsList1;
    }
}