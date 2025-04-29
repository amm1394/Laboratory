namespace RASF.Main.Forms.Base
{
    partial class CompaniesConector
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
            Janus.Windows.GridEX.GridEXLayout grdCompanyBase_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesConector));
            Janus.Windows.GridEX.GridEXLayout grdConnector_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.pnlCompanyBase = new RASF.General.Controls.Panel();
            this.grpCompanies = new RASF.General.Controls.GroupBox();
            this.grdCompanyBase = new RASF.General.Controls.Grid();
            this.companiesBaseList1 = new RASF.General.Lists.CompaniesBaseList(this.components);
            this.pnlOtherThings = new RASF.General.Controls.Panel();
            this.grpConnector = new RASF.General.Controls.GroupBox();
            this.grdConnector = new RASF.General.Controls.Grid();
            this.companiesConectorList1 = new RASF.General.Lists.CompaniesConectorList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlCompanyBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompanies)).BeginInit();
            this.grpCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanyBase)).BeginInit();
            this.pnlOtherThings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpConnector)).BeginInit();
            this.grpConnector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConnector)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 586);
            this.pnlButton.Size = new System.Drawing.Size(1262, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlOtherThings);
            this.pnlContent.Controls.Add(this.pnlCompanyBase);
            this.pnlContent.Size = new System.Drawing.Size(1262, 586);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1057, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1140, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1202, 0);
            // 
            // pnlCompanyBase
            // 
            this.pnlCompanyBase.Controls.Add(this.grpCompanies);
            this.pnlCompanyBase.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCompanyBase.Location = new System.Drawing.Point(713, 0);
            this.pnlCompanyBase.Name = "pnlCompanyBase";
            this.pnlCompanyBase.Size = new System.Drawing.Size(549, 586);
            this.pnlCompanyBase.TabIndex = 0;
            // 
            // grpCompanies
            // 
            this.grpCompanies.Controls.Add(this.grdCompanyBase);
            this.grpCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompanies.Location = new System.Drawing.Point(0, 0);
            this.grpCompanies.Name = "grpCompanies";
            this.grpCompanies.Size = new System.Drawing.Size(549, 586);
            this.grpCompanies.TabIndex = 1;
            this.grpCompanies.Text = "نام شرکت";
            this.grpCompanies.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompanyBase
            // 
            this.grdCompanyBase.AcceptsEscape = false;
            this.grdCompanyBase.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCompanyBase.AlowRetrieveStructure = false;
            this.grdCompanyBase.AlternatingColors = true;
            this.grdCompanyBase.BuiltInTextsData = resources.GetString("grdCompanyBase.BuiltInTextsData");
            this.grdCompanyBase.DataSource = this.companiesBaseList1;
            this.grdCompanyBase.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompanyBase_DesignTimeLayout.LayoutString = resources.GetString("grdCompanyBase_DesignTimeLayout.LayoutString");
            this.grdCompanyBase.DesignTimeLayout = grdCompanyBase_DesignTimeLayout;
            this.grdCompanyBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompanyBase.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompanyBase.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompanyBase.GroupByBoxVisible = false;
            this.grdCompanyBase.Location = new System.Drawing.Point(3, 17);
            this.grdCompanyBase.Name = "grdCompanyBase";
            this.grdCompanyBase.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToAddedRow;
            this.grdCompanyBase.RecordNavigator = true;
            this.grdCompanyBase.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical;
            this.grdCompanyBase.Size = new System.Drawing.Size(543, 566);
            this.grdCompanyBase.TabIndex = 0;
            this.grdCompanyBase.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompanyBase.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompanyBase.SelectionChanged += new System.EventHandler(this.grdCompanyBase_SelectionChanged_1);
            // 
            // pnlOtherThings
            // 
            this.pnlOtherThings.Controls.Add(this.grpConnector);
            this.pnlOtherThings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOtherThings.Location = new System.Drawing.Point(0, 0);
            this.pnlOtherThings.Name = "pnlOtherThings";
            this.pnlOtherThings.Size = new System.Drawing.Size(713, 586);
            this.pnlOtherThings.TabIndex = 1;
            // 
            // grpConnector
            // 
            this.grpConnector.Controls.Add(this.grdConnector);
            this.grpConnector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConnector.Location = new System.Drawing.Point(0, 0);
            this.grpConnector.Name = "grpConnector";
            this.grpConnector.Size = new System.Drawing.Size(713, 586);
            this.grpConnector.TabIndex = 0;
            this.grpConnector.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdConnector
            // 
            this.grdConnector.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdConnector.AlowRetrieveStructure = false;
            this.grdConnector.AlternatingColors = true;
            this.grdConnector.BuiltInTextsData = resources.GetString("grdConnector.BuiltInTextsData");
            this.grdConnector.DataSource = this.companiesConectorList1;
            this.grdConnector.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdConnector_DesignTimeLayout.LayoutString = resources.GetString("grdConnector_DesignTimeLayout.LayoutString");
            this.grdConnector.DesignTimeLayout = grdConnector_DesignTimeLayout;
            this.grdConnector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdConnector.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdConnector.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdConnector.GroupByBoxVisible = false;
            this.grdConnector.Location = new System.Drawing.Point(3, 8);
            this.grdConnector.Name = "grdConnector";
            this.grdConnector.RecordNavigator = true;
            this.grdConnector.Size = new System.Drawing.Size(707, 575);
            this.grdConnector.TabIndex = 0;
            this.grdConnector.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdConnector.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // CompaniesConector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1262, 616);
            this.Name = "CompaniesConector";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.COMPANIES_BASE_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.pnlCompanyBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCompanies)).EndInit();
            this.grpCompanies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanyBase)).EndInit();
            this.pnlOtherThings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpConnector)).EndInit();
            this.grpConnector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConnector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Panel pnlCompanyBase;
        private General.Controls.Panel pnlOtherThings;
        private General.Controls.Grid grdCompanyBase;
        private General.Lists.CompaniesBaseList companiesBaseList1;
        private General.Controls.GroupBox grpCompanies;
        private General.Controls.GroupBox grpConnector;
        private General.Controls.Grid grdConnector;
        private General.Lists.CompaniesConectorList companiesConectorList1;
    }
}
