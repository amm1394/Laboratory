namespace RASF.Main.Forms
{
    partial class COMPANIES_ENGLISH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMPANIES_ENGLISH));
            Janus.Windows.GridEX.GridEXLayout grdCOMPANIES_ENGLISH_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdCOMPANIES_ENGLISH = new RASF.General.Controls.Grid();
            this.companiesEnglishList1 = new RASF.General.Lists.CompaniesEnglishList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCOMPANIES_ENGLISH)).BeginInit();
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
            this.pnlContent.Controls.Add(this.grdCOMPANIES_ENGLISH);
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
            // grdCOMPANIES_ENGLISH
            // 
            this.grdCOMPANIES_ENGLISH.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCOMPANIES_ENGLISH.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCOMPANIES_ENGLISH.AlowRetrieveStructure = true;
            this.grdCOMPANIES_ENGLISH.AlternatingColors = true;
            this.grdCOMPANIES_ENGLISH.BuiltInTextsData = resources.GetString("grdCOMPANIES_ENGLISH.BuiltInTextsData");
            this.grdCOMPANIES_ENGLISH.DataSource = this.companiesEnglishList1;
            this.grdCOMPANIES_ENGLISH.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCOMPANIES_ENGLISH_DesignTimeLayout.LayoutString = resources.GetString("grdCOMPANIES_ENGLISH_DesignTimeLayout.LayoutString");
            this.grdCOMPANIES_ENGLISH.DesignTimeLayout = grdCOMPANIES_ENGLISH_DesignTimeLayout;
            this.grdCOMPANIES_ENGLISH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCOMPANIES_ENGLISH.GroupByBoxVisible = false;
            this.grdCOMPANIES_ENGLISH.Location = new System.Drawing.Point(0, 0);
            this.grdCOMPANIES_ENGLISH.Name = "grdCOMPANIES_ENGLISH";
            this.grdCOMPANIES_ENGLISH.RecordNavigator = true;
            this.grdCOMPANIES_ENGLISH.Size = new System.Drawing.Size(546, 396);
            this.grdCOMPANIES_ENGLISH.TabIndex = 0;
            this.grdCOMPANIES_ENGLISH.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCOMPANIES_ENGLISH.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // COMPANIES_ENGLISH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Name = "COMPANIES_ENGLISH";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.COMPANIES_ENGLISH_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCOMPANIES_ENGLISH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grdCOMPANIES_ENGLISH;
        private RASF.General.Lists.CompaniesEnglishList companiesEnglishList1;
    }
}
