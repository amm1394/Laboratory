namespace RASF.Main.Forms.Marketing
{
    partial class WriteOffMarketingCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteOffMarketingCompany));
            Janus.Windows.GridEX.GridEXLayout grdcompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpcompany = new RASF.General.Controls.GroupBox();
            this.grdcompany = new RASF.General.Controls.Grid();
            this.writeOffMarketingCompanyList1 = new RASF.General.Lists.WriteOffMarketingCompanyList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpcompany)).BeginInit();
            this.grpcompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpcompany);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpcompany
            // 
            this.grpcompany.Controls.Add(this.grdcompany);
            this.grpcompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpcompany.Location = new System.Drawing.Point(0, 0);
            this.grpcompany.Name = "grpcompany";
            this.grpcompany.Size = new System.Drawing.Size(474, 434);
            this.grpcompany.TabIndex = 0;
            this.grpcompany.Text = "groupBox1";
            this.grpcompany.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcompany
            // 
            this.grdcompany.AlowRetrieveStructure = false;
            this.grdcompany.AlternatingColors = true;
            this.grdcompany.BuiltInTextsData = resources.GetString("grdcompany.BuiltInTextsData");
            this.grdcompany.DataSource = this.writeOffMarketingCompanyList1;
            this.grdcompany.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcompany_DesignTimeLayout.LayoutString = resources.GetString("grdcompany_DesignTimeLayout.LayoutString");
            this.grdcompany.DesignTimeLayout = grdcompany_DesignTimeLayout;
            this.grdcompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcompany.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdcompany.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdcompany.GroupByBoxVisible = false;
            this.grdcompany.Location = new System.Drawing.Point(3, 17);
            this.grdcompany.Name = "grdcompany";
            this.grdcompany.Size = new System.Drawing.Size(468, 414);
            this.grdcompany.TabIndex = 0;
            this.grdcompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcompany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdcompany.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdcompany_ColumnButtonClick);
            this.grdcompany.SelectionChanged += new System.EventHandler(this.grdcompany_SelectionChanged);
            // 
            // WriteOffMarketingCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(474, 464);
            this.Name = "WriteOffMarketingCompany";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.WriteOffMarketingCompany_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpcompany)).EndInit();
            this.grpcompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpcompany;
        private General.Controls.Grid grdcompany;
        private General.Lists.WriteOffMarketingCompanyList writeOffMarketingCompanyList1;
    }
}
