namespace RASF.Main.Forms.Base
{
    partial class DefinitionOfContractors
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
            Janus.Windows.GridEX.GridEXLayout grdContractors_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinitionOfContractors));
            Janus.Windows.GridEX.GridEXLayout grdContractorsAdd_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdPhone_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdFax_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.pnlCompanyBase = new RASF.General.Controls.Panel();
            this.grpCompanies = new RASF.General.Controls.GroupBox();
            this.grdContractors = new RASF.General.Controls.Grid();
            this.constractorsList1 = new RASF.General.Lists.ConstractorsList(this.components);
            this.pnlOtherThings = new RASF.General.Controls.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdContractorsAdd = new RASF.General.Controls.Grid();
            this.grbMobile = new RASF.General.Controls.GroupBox();
            this.grdPhone = new RASF.General.Controls.Grid();
            this.contractorsPhoneNumList1 = new RASF.General.Lists.ContractorsPhoneNumList(this.components);
            this.grbFax = new RASF.General.Controls.GroupBox();
            this.grdFax = new RASF.General.Controls.Grid();
            this.contractors_FaxNumList1 = new RASF.General.Lists.Contractors_FaxNumList(this.components);
            this.activeNonActiveList1 = new RASF.General.Lists.ActiveNonActiveList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlCompanyBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompanies)).BeginInit();
            this.grpCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContractors)).BeginInit();
            this.pnlOtherThings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContractorsAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbMobile)).BeginInit();
            this.grbMobile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbFax)).BeginInit();
            this.grbFax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFax)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 415);
            this.pnlButton.Size = new System.Drawing.Size(852, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlOtherThings);
            this.pnlContent.Controls.Add(this.pnlCompanyBase);
            this.pnlContent.Size = new System.Drawing.Size(852, 415);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(645, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(730, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(792, 0);
            // 
            // pnlCompanyBase
            // 
            this.pnlCompanyBase.Controls.Add(this.grpCompanies);
            this.pnlCompanyBase.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCompanyBase.Location = new System.Drawing.Point(511, 0);
            this.pnlCompanyBase.Name = "pnlCompanyBase";
            this.pnlCompanyBase.Size = new System.Drawing.Size(341, 415);
            this.pnlCompanyBase.TabIndex = 0;
            // 
            // grpCompanies
            // 
            this.grpCompanies.Controls.Add(this.grdContractors);
            this.grpCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompanies.Location = new System.Drawing.Point(0, 0);
            this.grpCompanies.Name = "grpCompanies";
            this.grpCompanies.Size = new System.Drawing.Size(341, 415);
            this.grpCompanies.TabIndex = 1;
            this.grpCompanies.Text = "نام شرکت";
            this.grpCompanies.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContractors
            // 
            this.grdContractors.AcceptsEscape = false;
            this.grdContractors.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdContractors.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdContractors.AlowRetrieveStructure = false;
            this.grdContractors.AlternatingColors = true;
            this.grdContractors.BuiltInTextsData = resources.GetString("grdContractors.BuiltInTextsData");
            this.grdContractors.DataSource = this.constractorsList1;
            this.grdContractors.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContractors_DesignTimeLayout.LayoutString = resources.GetString("grdContractors_DesignTimeLayout.LayoutString");
            this.grdContractors.DesignTimeLayout = grdContractors_DesignTimeLayout;
            this.grdContractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContractors.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContractors.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContractors.GroupByBoxVisible = false;
            this.grdContractors.Location = new System.Drawing.Point(3, 17);
            this.grdContractors.Name = "grdContractors";
            this.grdContractors.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToAddedRow;
            this.grdContractors.RecordNavigator = true;
            this.grdContractors.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical;
            this.grdContractors.Size = new System.Drawing.Size(335, 395);
            this.grdContractors.TabIndex = 0;
            this.grdContractors.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContractors.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdContractors.SelectionChanged += new System.EventHandler(this.grdContractors_SelectionChanged);
            // 
            // pnlOtherThings
            // 
            this.pnlOtherThings.Controls.Add(this.splitContainer1);
            this.pnlOtherThings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOtherThings.Location = new System.Drawing.Point(0, 0);
            this.pnlOtherThings.Name = "pnlOtherThings";
            this.pnlOtherThings.Size = new System.Drawing.Size(511, 415);
            this.pnlOtherThings.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbMobile);
            this.splitContainer1.Panel2.Controls.Add(this.grbFax);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(511, 415);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdContractorsAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "اطلاعات تکمیلی شرکت";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContractorsAdd
            // 
            this.grdContractorsAdd.AlowRetrieveStructure = false;
            this.grdContractorsAdd.AlternatingColors = true;
            this.grdContractorsAdd.BuiltInTextsData = resources.GetString("grdContractorsAdd.BuiltInTextsData");
            this.grdContractorsAdd.CardHeaders = false;
            this.grdContractorsAdd.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.grdContractorsAdd.CardWidth = 479;
            this.grdContractorsAdd.DataSource = this.constractorsList1;
            this.grdContractorsAdd.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContractorsAdd_DesignTimeLayout.LayoutString = resources.GetString("grdContractorsAdd_DesignTimeLayout.LayoutString");
            this.grdContractorsAdd.DesignTimeLayout = grdContractorsAdd_DesignTimeLayout;
            this.grdContractorsAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContractorsAdd.GroupByBoxVisible = false;
            this.grdContractorsAdd.Location = new System.Drawing.Point(3, 17);
            this.grdContractorsAdd.Name = "grdContractorsAdd";
            this.grdContractorsAdd.Size = new System.Drawing.Size(505, 239);
            this.grdContractorsAdd.TabIndex = 0;
            this.grdContractorsAdd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.grdContractorsAdd.View = Janus.Windows.GridEX.View.SingleCard;
            this.grdContractorsAdd.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grbMobile
            // 
            this.grbMobile.Controls.Add(this.grdPhone);
            this.grbMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMobile.Location = new System.Drawing.Point(0, 0);
            this.grbMobile.Name = "grbMobile";
            this.grbMobile.Size = new System.Drawing.Size(249, 152);
            this.grbMobile.TabIndex = 3;
            this.grbMobile.Text = "تلفن همراه";
            this.grbMobile.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
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
            this.grdPhone.Size = new System.Drawing.Size(243, 132);
            this.grdPhone.TabIndex = 7;
            this.grdPhone.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdPhone.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grbFax
            // 
            this.grbFax.Controls.Add(this.grdFax);
            this.grbFax.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbFax.Location = new System.Drawing.Point(249, 0);
            this.grbFax.Name = "grbFax";
            this.grbFax.Size = new System.Drawing.Size(262, 152);
            this.grbFax.TabIndex = 4;
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
            this.grdFax.Size = new System.Drawing.Size(256, 132);
            this.grdFax.TabIndex = 4;
            this.grdFax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdFax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // DefinitionOfContractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 445);
            this.Name = "DefinitionOfContractors";
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
            ((System.ComponentModel.ISupportInitialize)(this.grdContractors)).EndInit();
            this.pnlOtherThings.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContractorsAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbMobile)).EndInit();
            this.grbMobile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbFax)).EndInit();
            this.grbFax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Panel pnlCompanyBase;
        private General.Controls.Panel pnlOtherThings;
        private General.Controls.Grid grdContractors;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.Grid grdContractorsAdd;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.GroupBox grbMobile;
        private General.Controls.Grid grdPhone;
        private General.Controls.GroupBox grbFax;
        private General.Controls.Grid grdFax;
        private General.Controls.GroupBox grpCompanies;
        private General.Lists.ConstractorsList constractorsList1;
        private General.Lists.ContractorsPhoneNumList contractorsPhoneNumList1;
        private General.Lists.Contractors_FaxNumList contractors_FaxNumList1;
        private General.Lists.ActiveNonActiveList activeNonActiveList1;
    }
}
