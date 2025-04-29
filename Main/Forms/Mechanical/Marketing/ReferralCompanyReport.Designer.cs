namespace RASF.Main.Forms.Marketing
{
    partial class ReferralCompanyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferralCompanyReport));
            Janus.Windows.GridEX.GridEXLayout grdcompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpCompany = new RASF.General.Controls.GroupBox();
            this.grdcompany = new RASF.General.Controls.Grid();
            this.referralCompanyReportList1 = new RASF.General.Lists.ReferralCompanyReportList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompany)).BeginInit();
            this.grpCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 579);
            this.pnlButton.Size = new System.Drawing.Size(794, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpCompany);
            this.pnlContent.Size = new System.Drawing.Size(794, 579);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(589, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(672, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(734, 0);
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.grdcompany);
            this.grpCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompany.Location = new System.Drawing.Point(0, 0);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(794, 579);
            this.grpCompany.TabIndex = 0;
            this.grpCompany.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcompany
            // 
            this.grdcompany.AlowRetrieveStructure = false;
            this.grdcompany.AlternatingColors = true;
            this.grdcompany.BuiltInTextsData = resources.GetString("grdcompany.BuiltInTextsData");
            this.grdcompany.DataSource = this.referralCompanyReportList1;
            this.grdcompany.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcompany_DesignTimeLayout.LayoutString = resources.GetString("grdcompany_DesignTimeLayout.LayoutString");
            this.grdcompany.DesignTimeLayout = grdcompany_DesignTimeLayout;
            this.grdcompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcompany.GroupByBoxVisible = false;
            this.grdcompany.Location = new System.Drawing.Point(3, 8);
            this.grdcompany.Name = "grdcompany";
            this.grdcompany.Size = new System.Drawing.Size(788, 568);
            this.grdcompany.TabIndex = 0;
            this.grdcompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcompany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ReferralCompanyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(794, 609);
            this.Name = "ReferralCompanyReport";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ReferralCompanyReport_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCompany)).EndInit();
            this.grpCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpCompany;
        private General.Controls.Grid grdcompany;
        private General.Lists.ReferralCompanyReportList referralCompanyReportList1;
    }
}
