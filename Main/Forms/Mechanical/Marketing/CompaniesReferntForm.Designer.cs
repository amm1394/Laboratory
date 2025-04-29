namespace RASF.Main.Forms.Marketing
{
    partial class CompaniesReferntForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesReferntForm));
            Janus.Windows.GridEX.GridEXLayout grdCompaneis_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.companiesReferntList1 = new RASF.General.Lists.CompaniesReferntList(this.components);
            this.grdCompaneis = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompaneis)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 579);
            this.pnlButton.Size = new System.Drawing.Size(1091, 30);
            // 
            // btnExit
            // 
            this.btnExit.Text = "چاپ";
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdCompaneis);
            this.pnlContent.Size = new System.Drawing.Size(1091, 579);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(886, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(969, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1031, 0);
            // 
            // grdCompaneis
            // 
            this.grdCompaneis.AlowRetrieveStructure = false;
            this.grdCompaneis.AlternatingColors = true;
            this.grdCompaneis.BuiltInTextsData = resources.GetString("grdCompaneis.BuiltInTextsData");
            this.grdCompaneis.DataSource = this.companiesReferntList1;
            this.grdCompaneis.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompaneis_DesignTimeLayout.LayoutString = resources.GetString("grdCompaneis_DesignTimeLayout.LayoutString");
            this.grdCompaneis.DesignTimeLayout = grdCompaneis_DesignTimeLayout;
            this.grdCompaneis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompaneis.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompaneis.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompaneis.GroupByBoxVisible = false;
            this.grdCompaneis.Location = new System.Drawing.Point(0, 0);
            this.grdCompaneis.Name = "grdCompaneis";
            this.grdCompaneis.Size = new System.Drawing.Size(1091, 579);
            this.grdCompaneis.TabIndex = 0;
            this.grdCompaneis.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompaneis.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // CompaniesReferntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1091, 609);
            this.Name = "CompaniesReferntForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CompaniesReferntForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompaneis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Lists.CompaniesReferntList companiesReferntList1;
        private RASF.General.Controls.Grid grdCompaneis;
    }
}
