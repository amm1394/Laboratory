namespace RASF.Main.Forms.Manager
{
    partial class ConvertToInformal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertToInformal));
            Janus.Windows.GridEX.GridEXLayout grdCompanies_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpCompanies = new RASF.General.Controls.GroupBox();
            this.grdCompanies = new RASF.General.Controls.Grid();
            this.debtorCreditorCompaniesWorkFlowList1 = new RASF.General.Lists.DebtorCreditorCompaniesWorkFlowList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompanies)).BeginInit();
            this.grpCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 601);
            this.pnlButton.Size = new System.Drawing.Size(1288, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpCompanies);
            this.pnlContent.Size = new System.Drawing.Size(1288, 601);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1083, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1166, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1228, 0);
            // 
            // grpCompanies
            // 
            this.grpCompanies.Controls.Add(this.grdCompanies);
            this.grpCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompanies.Location = new System.Drawing.Point(0, 0);
            this.grpCompanies.Name = "grpCompanies";
            this.grpCompanies.Size = new System.Drawing.Size(1288, 601);
            this.grpCompanies.TabIndex = 1;
            this.grpCompanies.Text = "شرکت";
            this.grpCompanies.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompanies
            // 
            this.grdCompanies.AlowRetrieveStructure = false;
            this.grdCompanies.AlternatingColors = true;
            this.grdCompanies.BuiltInTextsData = resources.GetString("grdCompanies.BuiltInTextsData");
            this.grdCompanies.DataSource = this.debtorCreditorCompaniesWorkFlowList1;
            this.grdCompanies.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompanies_DesignTimeLayout.LayoutString = resources.GetString("grdCompanies_DesignTimeLayout.LayoutString");
            this.grdCompanies.DesignTimeLayout = grdCompanies_DesignTimeLayout;
            this.grdCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompanies.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompanies.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompanies.GroupByBoxVisible = false;
            this.grdCompanies.Location = new System.Drawing.Point(3, 17);
            this.grdCompanies.Name = "grdCompanies";
            this.grdCompanies.Size = new System.Drawing.Size(1282, 581);
            this.grdCompanies.TabIndex = 0;
            this.grdCompanies.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompanies.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCompanies.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompanies.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCompanies_ColumnButtonClick);
            // 
            // ConvertToInformal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 631);
            this.Name = "ConvertToInformal";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ConvertToInformal";
            this.Load += new System.EventHandler(this.ConvertToInformal_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCompanies)).EndInit();
            this.grpCompanies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpCompanies;
        private RASF.General.Controls.Grid grdCompanies;
        private RASF.General.Lists.DebtorCreditorCompaniesWorkFlowList debtorCreditorCompaniesWorkFlowList1;
    }
}