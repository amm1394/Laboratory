namespace RASF.Main.Forms.Base
{
    partial class AgencyPhoneNum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgencyPhoneNum));
            Janus.Windows.GridEX.GridEXLayout grdPhoneNum_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdPhoneNum = new RASF.General.Controls.Grid();
            this.agencyPhoneNumList1 = new RASF.General.Lists.AgencyPhoneNumList(this.components);
            this.companiesAgencyListList1 = new RASF.General.Lists.CompaniesAgencyListList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhoneNum)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 396);
            this.pnlButton.Size = new System.Drawing.Size(546, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdPhoneNum);
            this.pnlContent.Size = new System.Drawing.Size(546, 396);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(339, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(424, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(486, 0);
            // 
            // grdPhoneNum
            // 
            this.grdPhoneNum.AlowRetrieveStructure = false;
            this.grdPhoneNum.AlternatingColors = true;
            this.grdPhoneNum.BuiltInTextsData = resources.GetString("grdPhoneNum.BuiltInTextsData");
            this.grdPhoneNum.DataSource = this.agencyPhoneNumList1;
            this.grdPhoneNum.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdPhoneNum_DesignTimeLayout.LayoutString = resources.GetString("grdPhoneNum_DesignTimeLayout.LayoutString");
            this.grdPhoneNum.DesignTimeLayout = grdPhoneNum_DesignTimeLayout;
            this.grdPhoneNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPhoneNum.GroupByBoxVisible = false;
            this.grdPhoneNum.Location = new System.Drawing.Point(0, 0);
            this.grdPhoneNum.Name = "grdPhoneNum";
            this.grdPhoneNum.Size = new System.Drawing.Size(546, 396);
            this.grdPhoneNum.TabIndex = 0;
            this.grdPhoneNum.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdPhoneNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // AgencyPhoneNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Name = "AgencyPhoneNum";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.AgencyPhoneNum_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhoneNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grdPhoneNum;
        private RASF.General.Lists.AgencyPhoneNumList agencyPhoneNumList1;
        private RASF.General.Lists.CompaniesAgencyListList companiesAgencyListList1;
    }
}
