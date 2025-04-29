namespace RASF.Main.Forms
{
    partial class Companies_AgencyList
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
            Janus.Windows.GridEX.GridEXLayout grdAgencyName_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdAgencyInfo_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdPhone_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Companies_AgencyList));
            Janus.Windows.GridEX.GridEXLayout grdAgencyMobile_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdAgencyFax_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.companiesAgencyListList1 = new RASF.General.Lists.CompaniesAgencyListList(this.components);
            this.activeNonActiveList1 = new RASF.General.Lists.ActiveNonActiveList(this.components);
            this.pnlAgencyName = new RASF.General.Controls.Panel();
            this.grbAgencyName = new RASF.General.Controls.GroupBox();
            this.grdAgencyName = new RASF.General.Controls.Grid();
            this.pnlAgencyInfo = new RASF.General.Controls.Panel();
            this.grbAgencyInfo = new RASF.General.Controls.GroupBox();
            this.grdAgencyInfo = new RASF.General.Controls.Grid();
            this.pnlAgencyPhone = new RASF.General.Controls.Panel();
            this.grbPhone = new RASF.General.Controls.GroupBox();
            this.grdPhone = new RASF.General.Controls.Grid();
            this.agencyPhoneNumList1 = new RASF.General.Lists.AgencyPhoneNumList(this.components);
            this.pnlAgencyFax = new RASF.General.Controls.Panel();
            this.grbMobile = new RASF.General.Controls.GroupBox();
            this.grdAgencyMobile = new RASF.General.Controls.Grid();
            this.agencyMobileNumList1 = new RASF.General.Lists.AgencyMobileNumList(this.components);
            this.grbFax = new RASF.General.Controls.GroupBox();
            this.grdAgencyFax = new RASF.General.Controls.Grid();
            this.agencyFaxNumList1 = new RASF.General.Lists.AgencyFaxNumList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlAgencyName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbAgencyName)).BeginInit();
            this.grbAgencyName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgencyName)).BeginInit();
            this.pnlAgencyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbAgencyInfo)).BeginInit();
            this.grbAgencyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgencyInfo)).BeginInit();
            this.pnlAgencyPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbPhone)).BeginInit();
            this.grbPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhone)).BeginInit();
            this.pnlAgencyFax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbMobile)).BeginInit();
            this.grbMobile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgencyMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbFax)).BeginInit();
            this.grbFax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgencyFax)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 417);
            this.pnlButton.Size = new System.Drawing.Size(604, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlAgencyFax);
            this.pnlContent.Controls.Add(this.pnlAgencyPhone);
            this.pnlContent.Controls.Add(this.pnlAgencyInfo);
            this.pnlContent.Controls.Add(this.pnlAgencyName);
            this.pnlContent.Size = new System.Drawing.Size(604, 417);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(397, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(482, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(544, 0);
            // 
            // pnlAgencyName
            // 
            this.pnlAgencyName.Controls.Add(this.grbAgencyName);
            this.pnlAgencyName.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAgencyName.Location = new System.Drawing.Point(404, 0);
            this.pnlAgencyName.Name = "pnlAgencyName";
            this.pnlAgencyName.Size = new System.Drawing.Size(200, 417);
            this.pnlAgencyName.TabIndex = 0;
            // 
            // grbAgencyName
            // 
            this.grbAgencyName.Controls.Add(this.grdAgencyName);
            this.grbAgencyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAgencyName.Location = new System.Drawing.Point(0, 0);
            this.grbAgencyName.Name = "grbAgencyName";
            this.grbAgencyName.Size = new System.Drawing.Size(200, 417);
            this.grbAgencyName.TabIndex = 1;
            this.grbAgencyName.Text = "نام دفتر";
            this.grbAgencyName.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAgencyName
            // 
            this.grdAgencyName.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgencyName.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgencyName.AlowRetrieveStructure = false;
            this.grdAgencyName.AlternatingColors = true;
            this.grdAgencyName.BuiltInTextsData = resources.GetString("grdAgencyName.BuiltInTextsData");
            this.grdAgencyName.DataSource = this.companiesAgencyListList1;
            this.grdAgencyName.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAgencyName_DesignTimeLayout.LayoutString = resources.GetString("grdAgencyName_DesignTimeLayout.LayoutString");
            this.grdAgencyName.DesignTimeLayout = grdAgencyName_DesignTimeLayout;
            this.grdAgencyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAgencyName.GroupByBoxVisible = false;
            this.grdAgencyName.Location = new System.Drawing.Point(3, 17);
            this.grdAgencyName.Name = "grdAgencyName";
            this.grdAgencyName.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToAddedRow;
            this.grdAgencyName.Size = new System.Drawing.Size(194, 397);
            this.grdAgencyName.TabIndex = 0;
            this.grdAgencyName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAgencyName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdAgencyName.RowCountChanged += new System.EventHandler(this.grdAgencyName_RowCountChanged);
            // 
            // pnlAgencyInfo
            // 
            this.pnlAgencyInfo.Controls.Add(this.grbAgencyInfo);
            this.pnlAgencyInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAgencyInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlAgencyInfo.Name = "pnlAgencyInfo";
            this.pnlAgencyInfo.Size = new System.Drawing.Size(404, 216);
            this.pnlAgencyInfo.TabIndex = 1;
            // 
            // grbAgencyInfo
            // 
            this.grbAgencyInfo.Controls.Add(this.grdAgencyInfo);
            this.grbAgencyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAgencyInfo.Location = new System.Drawing.Point(0, 0);
            this.grbAgencyInfo.Name = "grbAgencyInfo";
            this.grbAgencyInfo.Size = new System.Drawing.Size(404, 216);
            this.grbAgencyInfo.TabIndex = 1;
            this.grbAgencyInfo.Text = "اطلاعات تکمیلی";
            this.grbAgencyInfo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAgencyInfo
            // 
            this.grdAgencyInfo.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgencyInfo.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgencyInfo.AlowRetrieveStructure = false;
            this.grdAgencyInfo.AlternatingColors = true;
            this.grdAgencyInfo.BuiltInTextsData = resources.GetString("grdAgencyInfo.BuiltInTextsData");
            this.grdAgencyInfo.CardHeaders = false;
            this.grdAgencyInfo.CardSpacing = 0;
            this.grdAgencyInfo.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.grdAgencyInfo.CardWidth = 396;
            this.grdAgencyInfo.DataSource = this.companiesAgencyListList1;
            this.grdAgencyInfo.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAgencyInfo_DesignTimeLayout.LayoutString = resources.GetString("grdAgencyInfo_DesignTimeLayout.LayoutString");
            this.grdAgencyInfo.DesignTimeLayout = grdAgencyInfo_DesignTimeLayout;
            this.grdAgencyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAgencyInfo.GroupByBoxVisible = false;
            this.grdAgencyInfo.Location = new System.Drawing.Point(3, 17);
            this.grdAgencyInfo.Name = "grdAgencyInfo";
            this.grdAgencyInfo.Size = new System.Drawing.Size(398, 196);
            this.grdAgencyInfo.TabIndex = 0;
            this.grdAgencyInfo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.grdAgencyInfo.View = Janus.Windows.GridEX.View.SingleCard;
            this.grdAgencyInfo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // pnlAgencyPhone
            // 
            this.pnlAgencyPhone.Controls.Add(this.grbPhone);
            this.pnlAgencyPhone.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAgencyPhone.Location = new System.Drawing.Point(284, 216);
            this.pnlAgencyPhone.Name = "pnlAgencyPhone";
            this.pnlAgencyPhone.Size = new System.Drawing.Size(120, 201);
            this.pnlAgencyPhone.TabIndex = 2;
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.grdPhone);
            this.grbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPhone.Location = new System.Drawing.Point(0, 0);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(120, 201);
            this.grbPhone.TabIndex = 1;
            this.grbPhone.Text = "شماره تلفن";
            this.grbPhone.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdPhone
            // 
            this.grdPhone.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdPhone.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdPhone.AlowRetrieveStructure = false;
            this.grdPhone.AlternatingColors = true;
            this.grdPhone.BuiltInTextsData = resources.GetString("grdPhone.BuiltInTextsData");
            this.grdPhone.DataSource = this.agencyPhoneNumList1;
            this.grdPhone.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdPhone_DesignTimeLayout.LayoutString = resources.GetString("grdPhone_DesignTimeLayout.LayoutString");
            this.grdPhone.DesignTimeLayout = grdPhone_DesignTimeLayout;
            this.grdPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPhone.GroupByBoxVisible = false;
            this.grdPhone.Location = new System.Drawing.Point(3, 17);
            this.grdPhone.Name = "grdPhone";
            this.grdPhone.Size = new System.Drawing.Size(114, 181);
            this.grdPhone.TabIndex = 1;
            this.grdPhone.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdPhone.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // pnlAgencyFax
            // 
            this.pnlAgencyFax.Controls.Add(this.grbMobile);
            this.pnlAgencyFax.Controls.Add(this.grbFax);
            this.pnlAgencyFax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAgencyFax.Location = new System.Drawing.Point(0, 216);
            this.pnlAgencyFax.Name = "pnlAgencyFax";
            this.pnlAgencyFax.Size = new System.Drawing.Size(284, 201);
            this.pnlAgencyFax.TabIndex = 3;
            // 
            // grbMobile
            // 
            this.grbMobile.Controls.Add(this.grdAgencyMobile);
            this.grbMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMobile.Location = new System.Drawing.Point(144, 0);
            this.grbMobile.Name = "grbMobile";
            this.grbMobile.Size = new System.Drawing.Size(140, 201);
            this.grbMobile.TabIndex = 2;
            this.grbMobile.Text = "شماره موبایل";
            this.grbMobile.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAgencyMobile
            // 
            this.grdAgencyMobile.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgencyMobile.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgencyMobile.AlowRetrieveStructure = false;
            this.grdAgencyMobile.AlternatingColors = true;
            this.grdAgencyMobile.BuiltInTextsData = resources.GetString("grdAgencyMobile.BuiltInTextsData");
            this.grdAgencyMobile.DataSource = this.agencyMobileNumList1;
            this.grdAgencyMobile.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAgencyMobile_DesignTimeLayout.LayoutString = resources.GetString("grdAgencyMobile_DesignTimeLayout.LayoutString");
            this.grdAgencyMobile.DesignTimeLayout = grdAgencyMobile_DesignTimeLayout;
            this.grdAgencyMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAgencyMobile.GroupByBoxVisible = false;
            this.grdAgencyMobile.Location = new System.Drawing.Point(3, 17);
            this.grdAgencyMobile.Name = "grdAgencyMobile";
            this.grdAgencyMobile.Size = new System.Drawing.Size(134, 181);
            this.grdAgencyMobile.TabIndex = 0;
            this.grdAgencyMobile.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAgencyMobile.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grbFax
            // 
            this.grbFax.Controls.Add(this.grdAgencyFax);
            this.grbFax.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbFax.Location = new System.Drawing.Point(0, 0);
            this.grbFax.Name = "grbFax";
            this.grbFax.Size = new System.Drawing.Size(144, 201);
            this.grbFax.TabIndex = 1;
            this.grbFax.Text = "شماره فکس";
            this.grbFax.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAgencyFax
            // 
            this.grdAgencyFax.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgencyFax.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgencyFax.AlowRetrieveStructure = false;
            this.grdAgencyFax.AlternatingColors = true;
            this.grdAgencyFax.BuiltInTextsData = resources.GetString("grdAgencyFax.BuiltInTextsData");
            this.grdAgencyFax.DataSource = this.agencyFaxNumList1;
            this.grdAgencyFax.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAgencyFax_DesignTimeLayout.LayoutString = resources.GetString("grdAgencyFax_DesignTimeLayout.LayoutString");
            this.grdAgencyFax.DesignTimeLayout = grdAgencyFax_DesignTimeLayout;
            this.grdAgencyFax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAgencyFax.GroupByBoxVisible = false;
            this.grdAgencyFax.Location = new System.Drawing.Point(3, 17);
            this.grdAgencyFax.Name = "grdAgencyFax";
            this.grdAgencyFax.Size = new System.Drawing.Size(138, 181);
            this.grdAgencyFax.TabIndex = 1;
            this.grdAgencyFax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAgencyFax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Companies_AgencyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(604, 447);
            this.Name = "Companies_AgencyList";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Companies_AgencyList_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.pnlAgencyName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbAgencyName)).EndInit();
            this.grbAgencyName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgencyName)).EndInit();
            this.pnlAgencyInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbAgencyInfo)).EndInit();
            this.grbAgencyInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgencyInfo)).EndInit();
            this.pnlAgencyPhone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbPhone)).EndInit();
            this.grbPhone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhone)).EndInit();
            this.pnlAgencyFax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbMobile)).EndInit();
            this.grbMobile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgencyMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbFax)).EndInit();
            this.grbFax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgencyFax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Lists.CompaniesAgencyListList companiesAgencyListList1;
        private General.Lists.ActiveNonActiveList activeNonActiveList1;
        private General.Controls.Panel pnlAgencyName;
        private General.Controls.Grid grdAgencyName;
        private General.Controls.Panel pnlAgencyFax;
        private General.Lists.AgencyFaxNumList agencyFaxNumList1;
        private General.Controls.Panel pnlAgencyPhone;
        private General.Lists.AgencyPhoneNumList agencyPhoneNumList1;
        private General.Controls.Panel pnlAgencyInfo;
        private General.Controls.Grid grdAgencyInfo;
        private General.Controls.GroupBox grbMobile;
        private General.Controls.GroupBox grbFax;
        private General.Controls.Grid grdAgencyFax;
        private General.Controls.GroupBox grbPhone;
        private General.Controls.Grid grdPhone;
        private General.Controls.GroupBox grbAgencyInfo;
        private General.Controls.GroupBox grbAgencyName;
        private General.Lists.AgencyMobileNumList agencyMobileNumList1;
        private General.Controls.Grid grdAgencyMobile;
    }
}
