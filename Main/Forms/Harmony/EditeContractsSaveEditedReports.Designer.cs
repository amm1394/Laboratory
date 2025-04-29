namespace RASF.Main.Forms.Harmony
{
    partial class EditeContractsSaveEditedReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditContractForSaveCostPaper));
            Janus.Windows.GridEX.GridEXLayout grdEditContract_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdEditContract = new RASF.General.Controls.Grid();
            this.contractsBaseEditList1 = new RASF.General.Lists.ContractsBaseEditList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEditContract)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 396);
            this.pnlButton.Size = new System.Drawing.Size(546, 30);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Size = new System.Drawing.Size(52, 23);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdEditContract);
            this.pnlContent.Size = new System.Drawing.Size(546, 396);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUpdate.Location = new System.Drawing.Point(341, 0);
            this.pnlUpdate.Size = new System.Drawing.Size(83, 30);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(424, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(486, 0);
            // 
            // grdEditContract
            // 
            this.grdEditContract.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdEditContract.AlowRetrieveStructure = false;
            this.grdEditContract.AlternatingColors = true;
            this.grdEditContract.BuiltInTextsData = resources.GetString("grdEditContract.BuiltInTextsData");
            this.grdEditContract.DataSource = this.contractsBaseEditList1;
            this.grdEditContract.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdEditContract_DesignTimeLayout.LayoutString = resources.GetString("grdEditContract_DesignTimeLayout.LayoutString");
            this.grdEditContract.DesignTimeLayout = grdEditContract_DesignTimeLayout;
            this.grdEditContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEditContract.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdEditContract.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdEditContract.GroupByBoxVisible = false;
            this.grdEditContract.Location = new System.Drawing.Point(0, 0);
            this.grdEditContract.Name = "grdEditContract";
            this.grdEditContract.Size = new System.Drawing.Size(546, 396);
            this.grdEditContract.TabIndex = 0;
            this.grdEditContract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdEditContract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdEditContract.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdEditContract_ColumnButtonClick);
            // 
            // EditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Name = "EditContract";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.EditContract_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEditContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected General.Lists.ContractsBaseEditList contractsBaseEditList1;
        protected General.Controls.Grid grdEditContract;
    }
}
