namespace RASF.Main.Forms.Financial
{
    partial class RegisterNopayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterNopayments));
            Janus.Windows.GridEX.GridEXLayout grdIsHold_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grdIsHold = new RASF.General.Controls.Grid();
            this.registerNopaymentsList1 = new RASF.General.Lists.RegisterNopaymentsList(this.components);
            this.cashOrderStatusList1 = new RASF.General.Lists.CashOrderStatusList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).BeginInit();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIsHold)).BeginInit();
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
            this.grpGrid.Controls.Add(this.grdIsHold);
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGrid.Location = new System.Drawing.Point(0, 0);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(971, 501);
            this.grpGrid.TabIndex = 0;
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdIsHold
            // 
            this.grdIsHold.AlowRetrieveStructure = false;
            this.grdIsHold.AlternatingColors = true;
            this.grdIsHold.BuiltInTextsData = resources.GetString("grdIsHold.BuiltInTextsData");
            this.grdIsHold.DataSource = this.registerNopaymentsList1;
            this.grdIsHold.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdIsHold_DesignTimeLayout.LayoutString = resources.GetString("grdIsHold_DesignTimeLayout.LayoutString");
            this.grdIsHold.DesignTimeLayout = grdIsHold_DesignTimeLayout;
            this.grdIsHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIsHold.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdIsHold.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdIsHold.GroupByBoxVisible = false;
            this.grdIsHold.Location = new System.Drawing.Point(3, 8);
            this.grdIsHold.Name = "grdIsHold";
            this.grdIsHold.Size = new System.Drawing.Size(965, 490);
            this.grdIsHold.TabIndex = 0;
            this.grdIsHold.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdIsHold.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdIsHold.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdIsHold.SelectionChanged += new System.EventHandler(this.grdIsHold_SelectionChanged);
            // 
            // RegisterNopayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 531);
            this.Name = "RegisterNopayments";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "IsHoldForm";
            this.Load += new System.EventHandler(this.IsHoldForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).EndInit();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIsHold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpGrid;
        private General.Controls.Grid grdIsHold;
        private General.Lists.RegisterNopaymentsList registerNopaymentsList1;
        private General.Lists.CashOrderStatusList cashOrderStatusList1;
    }
}