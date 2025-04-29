namespace RASF.Main.Forms.Harmony
{
    partial class CancelFinacialSupportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelFinacialSupportForm));
            Janus.Windows.GridEX.GridEXLayout grdIsHold_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grdIsHold = new RASF.General.Controls.Grid();
            this.grpText = new RASF.General.Controls.GroupBox();
            this.txtReason = new RASF.General.Controls.TextBox();
            this.cancelFinacialSupportList1 = new RASF.General.Lists.CancelFinacialSupportList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).BeginInit();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIsHold)).BeginInit();
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
            this.grpGrid.Controls.Add(this.grdIsHold);
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGrid.Location = new System.Drawing.Point(0, 0);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(971, 289);
            this.grpGrid.TabIndex = 0;
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdIsHold
            // 
            this.grdIsHold.AlowRetrieveStructure = false;
            this.grdIsHold.AlternatingColors = true;
            this.grdIsHold.BuiltInTextsData = resources.GetString("grdIsHold.BuiltInTextsData");
            this.grdIsHold.DataSource = this.cancelFinacialSupportList1;
            this.grdIsHold.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdIsHold_DesignTimeLayout.LayoutString = resources.GetString("grdIsHold_DesignTimeLayout.LayoutString");
            this.grdIsHold.DesignTimeLayout = grdIsHold_DesignTimeLayout;
            this.grdIsHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIsHold.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdIsHold.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdIsHold.GroupByBoxVisible = false;
            this.grdIsHold.Location = new System.Drawing.Point(3, 8);
            this.grdIsHold.Name = "grdIsHold";
            this.grdIsHold.Size = new System.Drawing.Size(965, 278);
            this.grdIsHold.TabIndex = 0;
            this.grdIsHold.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdIsHold.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdIsHold.SelectionChanged += new System.EventHandler(this.grdIsHold_SelectionChanged);
            // 
            // grpText
            // 
            this.grpText.Controls.Add(this.txtReason);
            this.grpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpText.Location = new System.Drawing.Point(0, 289);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(971, 212);
            this.grpText.TabIndex = 1;
            this.grpText.Text = "علت لغو تایید مالی";
            this.grpText.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtReason
            // 
            this.txtReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cancelFinacialSupportList1, "Description", true));
            this.txtReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReason.Location = new System.Drawing.Point(3, 17);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(965, 192);
            this.txtReason.TabIndex = 0;
            this.txtReason.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // CancelFinacialSupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 531);
            this.Name = "CancelFinacialSupportForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "لغو تایید مالی";
            this.Load += new System.EventHandler(this.IsHoldForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).EndInit();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIsHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).EndInit();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpGrid;
        private General.Controls.GroupBox grpText;
        private General.Controls.TextBox txtReason;
        private General.Controls.Grid grdIsHold;
        private General.Lists.CancelFinacialSupportList cancelFinacialSupportList1;
    }
}