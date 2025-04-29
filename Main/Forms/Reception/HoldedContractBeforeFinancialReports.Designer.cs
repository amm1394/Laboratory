namespace RASF.Main.Forms.Reception
{
    partial class HoldedContractBeforeFinancialReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoldedContractBeforeFinancialReports));
            Janus.Windows.GridEX.GridEXLayout grdHolded_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdHolded = new RASF.General.Controls.Grid();
            this.contracts_IsHoldList1 = new RASF.General.Lists.Contracts_IsHoldList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHolded)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 649);
            this.pnlButton.Size = new System.Drawing.Size(1041, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1041, 649);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(836, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(919, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(981, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdHolded);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 649);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "گزارش قراردادهایی که قبل از تایید مالی مساله دار شده اند";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdHolded
            // 
            this.grdHolded.AlowRetrieveStructure = false;
            this.grdHolded.AlternatingColors = true;
            this.grdHolded.BuiltInTextsData = resources.GetString("grdHolded.BuiltInTextsData");
            this.grdHolded.DataSource = this.contracts_IsHoldList1;
            this.grdHolded.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdHolded_DesignTimeLayout.LayoutString = resources.GetString("grdHolded_DesignTimeLayout.LayoutString");
            this.grdHolded.DesignTimeLayout = grdHolded_DesignTimeLayout;
            this.grdHolded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHolded.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdHolded.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdHolded.GroupByBoxVisible = false;
            this.grdHolded.Location = new System.Drawing.Point(3, 17);
            this.grdHolded.Name = "grdHolded";
            this.grdHolded.Size = new System.Drawing.Size(1035, 629);
            this.grdHolded.TabIndex = 0;
            this.grdHolded.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdHolded.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdHolded.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdHolded_ColumnButtonClick);
            // 
            // HoldedContractBeforeFinancialReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 679);
            this.Name = "HoldedContractBeforeFinancialReports";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "HoldedContractBeforeFinancialReports";
            this.Load += new System.EventHandler(this.HoldedContractBeforeFinancialReports_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHolded)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdHolded;
        private General.Lists.Contracts_IsHoldList contracts_IsHoldList1;
    }
}