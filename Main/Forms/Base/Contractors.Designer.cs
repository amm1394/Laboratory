namespace RASF.Main.Forms.Base
{
    partial class Contractors
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
            Janus.Windows.GridEX.GridEXLayout grdContractor_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdContractorInfo_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdPhone_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contractors));
            Janus.Windows.GridEX.GridEXLayout grdMobile_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdFax_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.pnlAgencyName = new RASF.General.Controls.Panel();
            this.grbAgencyName = new RASF.General.Controls.GroupBox();
            this.grdContractor = new RASF.General.Controls.Grid();
            this.constractorsList1 = new RASF.General.Lists.ConstractorsList(this.components);
            this.pnlAgencyInfo = new RASF.General.Controls.Panel();
            this.grbAgencyInfo = new RASF.General.Controls.GroupBox();
            this.grdContractorInfo = new RASF.General.Controls.Grid();
            this.pnlAgencyPhone = new RASF.General.Controls.Panel();
            this.grbPhone = new RASF.General.Controls.GroupBox();
            this.grdPhone = new RASF.General.Controls.Grid();
            this.contractorsPhoneNumList1 = new RASF.General.Lists.ContractorsPhoneNumList(this.components);
            this.pnlAgencyFax = new RASF.General.Controls.Panel();
            this.grbMobile = new RASF.General.Controls.GroupBox();
            this.grdMobile = new RASF.General.Controls.Grid();
            this.contractors_MobilNumList1 = new RASF.General.Lists.Contractors_MobilNumList(this.components);
            this.grbFax = new RASF.General.Controls.GroupBox();
            this.grdFax = new RASF.General.Controls.Grid();
            this.contractors_FaxNumList1 = new RASF.General.Lists.Contractors_FaxNumList(this.components);
            this.activeNonActiveList2 = new RASF.General.Lists.ActiveNonActiveList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlAgencyName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbAgencyName)).BeginInit();
            this.grbAgencyName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContractor)).BeginInit();
            this.pnlAgencyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbAgencyInfo)).BeginInit();
            this.grbAgencyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContractorInfo)).BeginInit();
            this.pnlAgencyPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbPhone)).BeginInit();
            this.grbPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhone)).BeginInit();
            this.pnlAgencyFax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbMobile)).BeginInit();
            this.grbMobile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbFax)).BeginInit();
            this.grbFax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFax)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 417);
            this.pnlButton.Size = new System.Drawing.Size(733, 30);
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
            this.pnlContent.Size = new System.Drawing.Size(733, 417);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(528, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(611, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(673, 0);
            // 
            // pnlAgencyName
            // 
            this.pnlAgencyName.Controls.Add(this.grbAgencyName);
            this.pnlAgencyName.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAgencyName.Location = new System.Drawing.Point(489, 0);
            this.pnlAgencyName.Name = "pnlAgencyName";
            this.pnlAgencyName.Size = new System.Drawing.Size(244, 417);
            this.pnlAgencyName.TabIndex = 0;
            // 
            // grbAgencyName
            // 
            this.grbAgencyName.Controls.Add(this.grdContractor);
            this.grbAgencyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAgencyName.Location = new System.Drawing.Point(0, 0);
            this.grbAgencyName.Name = "grbAgencyName";
            this.grbAgencyName.Size = new System.Drawing.Size(244, 417);
            this.grbAgencyName.TabIndex = 1;
            this.grbAgencyName.Text = "پیمانکار";
            this.grbAgencyName.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContractor
            // 
            this.grdContractor.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdContractor.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdContractor.AlowRetrieveStructure = false;
            this.grdContractor.AlternatingColors = true;
            this.grdContractor.BuiltInTextsData = resources.GetString("grdContractor.BuiltInTextsData");
            this.grdContractor.DataSource = this.constractorsList1;
            this.grdContractor.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContractor_DesignTimeLayout.LayoutString = resources.GetString("grdContractor_DesignTimeLayout.LayoutString");
            this.grdContractor.DesignTimeLayout = grdContractor_DesignTimeLayout;
            this.grdContractor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContractor.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContractor.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContractor.GroupByBoxVisible = false;
            this.grdContractor.Location = new System.Drawing.Point(3, 17);
            this.grdContractor.Name = "grdContractor";
            this.grdContractor.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToAddedRow;
            this.grdContractor.Size = new System.Drawing.Size(238, 397);
            this.grdContractor.TabIndex = 0;
            this.grdContractor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContractor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdContractor.RowCountChanged += new System.EventHandler(this.grdContractor_RowCountChanged);
            // 
            // pnlAgencyInfo
            // 
            this.pnlAgencyInfo.Controls.Add(this.grbAgencyInfo);
            this.pnlAgencyInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAgencyInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlAgencyInfo.Name = "pnlAgencyInfo";
            this.pnlAgencyInfo.Size = new System.Drawing.Size(489, 216);
            this.pnlAgencyInfo.TabIndex = 1;
            // 
            // grbAgencyInfo
            // 
            this.grbAgencyInfo.Controls.Add(this.grdContractorInfo);
            this.grbAgencyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAgencyInfo.Location = new System.Drawing.Point(0, 0);
            this.grbAgencyInfo.Name = "grbAgencyInfo";
            this.grbAgencyInfo.Size = new System.Drawing.Size(489, 216);
            this.grbAgencyInfo.TabIndex = 1;
            this.grbAgencyInfo.Text = "اطلاعات تکمیلی";
            this.grbAgencyInfo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContractorInfo
            // 
            this.grdContractorInfo.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdContractorInfo.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdContractorInfo.AlowRetrieveStructure = false;
            this.grdContractorInfo.AlternatingColors = true;
            this.grdContractorInfo.BuiltInTextsData = resources.GetString("grdContractorInfo.BuiltInTextsData");
            this.grdContractorInfo.CardHeaders = false;
            this.grdContractorInfo.CardSpacing = 0;
            this.grdContractorInfo.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.grdContractorInfo.CardWidth = 481;
            this.grdContractorInfo.DataSource = this.constractorsList1;
            this.grdContractorInfo.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContractorInfo_DesignTimeLayout.LayoutString = resources.GetString("grdContractorInfo_DesignTimeLayout.LayoutString");
            this.grdContractorInfo.DesignTimeLayout = grdContractorInfo_DesignTimeLayout;
            this.grdContractorInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContractorInfo.GroupByBoxVisible = false;
            this.grdContractorInfo.Location = new System.Drawing.Point(3, 17);
            this.grdContractorInfo.Name = "grdContractorInfo";
            this.grdContractorInfo.Size = new System.Drawing.Size(483, 196);
            this.grdContractorInfo.TabIndex = 0;
            this.grdContractorInfo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.grdContractorInfo.View = Janus.Windows.GridEX.View.SingleCard;
            this.grdContractorInfo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // pnlAgencyPhone
            // 
            this.pnlAgencyPhone.Controls.Add(this.grbPhone);
            this.pnlAgencyPhone.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAgencyPhone.Location = new System.Drawing.Point(324, 216);
            this.pnlAgencyPhone.Name = "pnlAgencyPhone";
            this.pnlAgencyPhone.Size = new System.Drawing.Size(165, 201);
            this.pnlAgencyPhone.TabIndex = 2;
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.grdPhone);
            this.grbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPhone.Location = new System.Drawing.Point(0, 0);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(165, 201);
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
            this.grdPhone.DataSource = this.contractorsPhoneNumList1;
            this.grdPhone.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdPhone_DesignTimeLayout.LayoutString = resources.GetString("grdPhone_DesignTimeLayout.LayoutString");
            this.grdPhone.DesignTimeLayout = grdPhone_DesignTimeLayout;
            this.grdPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPhone.GroupByBoxVisible = false;
            this.grdPhone.Location = new System.Drawing.Point(3, 17);
            this.grdPhone.Name = "grdPhone";
            this.grdPhone.Size = new System.Drawing.Size(159, 181);
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
            this.pnlAgencyFax.Size = new System.Drawing.Size(324, 201);
            this.pnlAgencyFax.TabIndex = 3;
            // 
            // grbMobile
            // 
            this.grbMobile.Controls.Add(this.grdMobile);
            this.grbMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMobile.Location = new System.Drawing.Point(144, 0);
            this.grbMobile.Name = "grbMobile";
            this.grbMobile.Size = new System.Drawing.Size(180, 201);
            this.grbMobile.TabIndex = 2;
            this.grbMobile.Text = "شماره موبایل";
            this.grbMobile.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMobile
            // 
            this.grdMobile.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdMobile.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdMobile.AlowRetrieveStructure = false;
            this.grdMobile.AlternatingColors = true;
            this.grdMobile.BuiltInTextsData = resources.GetString("grdMobile.BuiltInTextsData");
            this.grdMobile.DataSource = this.contractors_MobilNumList1;
            this.grdMobile.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMobile_DesignTimeLayout.LayoutString = resources.GetString("grdMobile_DesignTimeLayout.LayoutString");
            this.grdMobile.DesignTimeLayout = grdMobile_DesignTimeLayout;
            this.grdMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMobile.GroupByBoxVisible = false;
            this.grdMobile.Location = new System.Drawing.Point(3, 17);
            this.grdMobile.Name = "grdMobile";
            this.grdMobile.Size = new System.Drawing.Size(174, 181);
            this.grdMobile.TabIndex = 0;
            this.grdMobile.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMobile.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grbFax
            // 
            this.grbFax.Controls.Add(this.grdFax);
            this.grbFax.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbFax.Location = new System.Drawing.Point(0, 0);
            this.grbFax.Name = "grbFax";
            this.grbFax.Size = new System.Drawing.Size(144, 201);
            this.grbFax.TabIndex = 1;
            this.grbFax.Text = "شماره فکس";
            this.grbFax.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdFax
            // 
            this.grdFax.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdFax.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdFax.AlowRetrieveStructure = false;
            this.grdFax.AlternatingColors = true;
            this.grdFax.BuiltInTextsData = resources.GetString("grdFax.BuiltInTextsData");
            this.grdFax.DataSource = this.contractors_FaxNumList1;
            this.grdFax.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdFax_DesignTimeLayout.LayoutString = resources.GetString("grdFax_DesignTimeLayout.LayoutString");
            this.grdFax.DesignTimeLayout = grdFax_DesignTimeLayout;
            this.grdFax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFax.GroupByBoxVisible = false;
            this.grdFax.Location = new System.Drawing.Point(3, 17);
            this.grdFax.Name = "grdFax";
            this.grdFax.Size = new System.Drawing.Size(138, 181);
            this.grdFax.TabIndex = 1;
            this.grdFax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdFax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Contractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(733, 447);
            this.Name = "Contractors";
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
            ((System.ComponentModel.ISupportInitialize)(this.grdContractor)).EndInit();
            this.pnlAgencyInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbAgencyInfo)).EndInit();
            this.grbAgencyInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContractorInfo)).EndInit();
            this.pnlAgencyPhone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbPhone)).EndInit();
            this.grbPhone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhone)).EndInit();
            this.pnlAgencyFax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbMobile)).EndInit();
            this.grbMobile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbFax)).EndInit();
            this.grbFax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Panel pnlAgencyName;
        private General.Controls.Grid grdContractor;
        private General.Controls.Panel pnlAgencyFax;
        private General.Controls.Panel pnlAgencyPhone;
        private General.Controls.Panel pnlAgencyInfo;
        private General.Controls.Grid grdContractorInfo;
        private General.Controls.GroupBox grbMobile;
        private General.Controls.GroupBox grbFax;
        private General.Controls.Grid grdFax;
        private General.Controls.GroupBox grbPhone;
        private General.Controls.Grid grdPhone;
        private General.Controls.GroupBox grbAgencyInfo;
        private General.Controls.GroupBox grbAgencyName;
        private General.Controls.Grid grdMobile;
        private General.Lists.ConstractorsList constractorsList1;
        private General.Lists.ContractorsPhoneNumList contractorsPhoneNumList1;
        private General.Lists.Contractors_FaxNumList contractors_FaxNumList1;
        private General.Lists.ActiveNonActiveList activeNonActiveList2;
        private General.Lists.Contractors_MobilNumList contractors_MobilNumList1;
    }
}
