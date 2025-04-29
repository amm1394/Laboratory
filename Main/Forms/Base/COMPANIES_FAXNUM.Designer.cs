namespace RASF.Main.Forms
{
    partial class COMPANIES_FAXNUM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMPANIES_FAXNUM));
            Janus.Windows.GridEX.GridEXLayout grdCOMPANIES_FAXNUM_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdCOMPANIES_FAXNUM = new RASF.General.Controls.Grid();
            this.companiesFaxNumList1 = new RASF.General.Lists.Base.CompaniesFaxNumList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCOMPANIES_FAXNUM)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 396);
            this.pnlButton.Size = new System.Drawing.Size(546, 30);
            // 
            // btnExit
            // 
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdCOMPANIES_FAXNUM);
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
            // grdCOMPANIES_FAXNUM
            // 
            this.grdCOMPANIES_FAXNUM.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCOMPANIES_FAXNUM.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCOMPANIES_FAXNUM.AlowRetrieveStructure = true;
            this.grdCOMPANIES_FAXNUM.AlternatingColors = true;
            this.grdCOMPANIES_FAXNUM.BuiltInTextsData = resources.GetString("grdCOMPANIES_FAXNUM.BuiltInTextsData");
            this.grdCOMPANIES_FAXNUM.DataSource = this.companiesFaxNumList1;
            this.grdCOMPANIES_FAXNUM.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCOMPANIES_FAXNUM_DesignTimeLayout.LayoutString = resources.GetString("grdCOMPANIES_FAXNUM_DesignTimeLayout.LayoutString");
            this.grdCOMPANIES_FAXNUM.DesignTimeLayout = grdCOMPANIES_FAXNUM_DesignTimeLayout;
            this.grdCOMPANIES_FAXNUM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCOMPANIES_FAXNUM.GroupByBoxVisible = false;
            this.grdCOMPANIES_FAXNUM.Location = new System.Drawing.Point(0, 0);
            this.grdCOMPANIES_FAXNUM.Name = "grdCOMPANIES_FAXNUM";
            this.grdCOMPANIES_FAXNUM.RecordNavigator = true;
            this.grdCOMPANIES_FAXNUM.Size = new System.Drawing.Size(546, 396);
            this.grdCOMPANIES_FAXNUM.TabIndex = 0;
            this.grdCOMPANIES_FAXNUM.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCOMPANIES_FAXNUM.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // COMPANIES_FAXNUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Name = "COMPANIES_FAXNUM";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.COMPANIES_FAXNUM_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCOMPANIES_FAXNUM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grdCOMPANIES_FAXNUM;
        private RASF.General.Lists.Base.CompaniesFaxNumList companiesFaxNumList1;

    }
}
