namespace RASF.Main.Forms.Store
{
    partial class PartsThatExitedFromStoreToLaboratory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsThatExitedFromStoreToLaboratory));
            Janus.Windows.GridEX.GridEXLayout grdParts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdReceiver_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdEmptyBasket_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpSearch = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.grpParts = new RASF.General.Controls.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdParts = new RASF.General.Controls.Grid();
            this.partsAreNotExitedFromStoredList1 = new RASF.General.Lists.PartsAreNotExitedFromStoredList(this.components);
            this.grpUser = new RASF.General.Controls.GroupBox();
            this.grdReceiver = new RASF.General.Controls.Grid();
            this.laboratory_UserList1 = new RASF.General.Lists.Laboratory_UserList(this.components);
            this.panel1 = new RASF.General.Controls.Panel();
            this.grpLaboratory = new RASF.General.Controls.GroupBox();
            this.drpUser = new RASF.General.Controls.DropDown();
            this.txtDesc = new RASF.General.Controls.TextBox();
            this.drpLab = new RASF.General.Controls.DropDown();
            this.findUsersLaboratoryList1 = new RASF.General.Lists.FindUsersLaboratoryList(this.components);
            this.laboratoryList1 = new RASF.General.Lists.LaboratoryList(this.components);
            this.grpEmptyBasket = new RASF.General.Controls.GroupBox();
            this.grdEmptyBasket = new RASF.General.Controls.Grid();
            this.emptyBasketList1 = new RASF.General.Lists.EmptyBasketList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).BeginInit();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpParts)).BeginInit();
            this.grpParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).BeginInit();
            this.grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpLaboratory)).BeginInit();
            this.grpLaboratory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpEmptyBasket)).BeginInit();
            this.grpEmptyBasket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmptyBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 376);
            this.pnlButton.Size = new System.Drawing.Size(935, 27);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpEmptyBasket);
            this.pnlContent.Controls.Add(this.grpParts);
            this.pnlContent.Controls.Add(this.grpSearch);
            this.pnlContent.Size = new System.Drawing.Size(935, 376);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 3);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(730, 0);
            this.pnlUpdate.Size = new System.Drawing.Size(83, 27);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(813, 0);
            this.pnlExit.Size = new System.Drawing.Size(62, 27);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(875, 0);
            this.pnlSave.Size = new System.Drawing.Size(60, 27);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.searchContract1);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(935, 54);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.Text = "جستجو";
            this.grpSearch.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(706, 17);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(226, 34);
            this.searchContract1.TabIndex = 0;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // grpParts
            // 
            this.grpParts.Controls.Add(this.splitContainer1);
            this.grpParts.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpParts.Location = new System.Drawing.Point(234, 54);
            this.grpParts.Name = "grpParts";
            this.grpParts.Size = new System.Drawing.Size(701, 322);
            this.grpParts.TabIndex = 1;
            this.grpParts.Text = "نمونه های وارد شده به انبار";
            this.grpParts.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 17);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grdParts);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpUser);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.grpLaboratory);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(695, 302);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 4;
            // 
            // grdParts
            // 
            this.grdParts.AlowRetrieveStructure = false;
            this.grdParts.AlternatingColors = true;
            this.grdParts.BuiltInTextsData = resources.GetString("grdParts.BuiltInTextsData");
            this.grdParts.DataSource = this.partsAreNotExitedFromStoredList1;
            this.grdParts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdParts_DesignTimeLayout.LayoutString = resources.GetString("grdParts_DesignTimeLayout.LayoutString");
            this.grdParts.DesignTimeLayout = grdParts_DesignTimeLayout;
            this.grdParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdParts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdParts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdParts.GroupByBoxVisible = false;
            this.grdParts.Location = new System.Drawing.Point(0, 0);
            this.grdParts.Name = "grdParts";
            this.grdParts.Size = new System.Drawing.Size(695, 136);
            this.grdParts.TabIndex = 4;
            this.grdParts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdParts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grdReceiver);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(377, 162);
            this.grpUser.TabIndex = 1;
            this.grpUser.Text = "تحویل گیرنده";
            this.grpUser.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReceiver
            // 
            this.grdReceiver.AlowRetrieveStructure = false;
            this.grdReceiver.AlternatingColors = true;
            this.grdReceiver.BuiltInTextsData = resources.GetString("grdReceiver.BuiltInTextsData");
            this.grdReceiver.DataSource = this.laboratory_UserList1;
            this.grdReceiver.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReceiver_DesignTimeLayout.LayoutString = resources.GetString("grdReceiver_DesignTimeLayout.LayoutString");
            this.grdReceiver.DesignTimeLayout = grdReceiver_DesignTimeLayout;
            this.grdReceiver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReceiver.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReceiver.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReceiver.GroupByBoxVisible = false;
            this.grdReceiver.Location = new System.Drawing.Point(3, 17);
            this.grdReceiver.Name = "grdReceiver";
            this.grdReceiver.Size = new System.Drawing.Size(371, 142);
            this.grdReceiver.TabIndex = 1;
            this.grdReceiver.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReceiver.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(377, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 162);
            this.panel1.TabIndex = 2;
            // 
            // grpLaboratory
            // 
            this.grpLaboratory.Controls.Add(this.drpUser);
            this.grpLaboratory.Controls.Add(this.txtDesc);
            this.grpLaboratory.Controls.Add(this.drpLab);
            this.grpLaboratory.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpLaboratory.Location = new System.Drawing.Point(387, 0);
            this.grpLaboratory.Name = "grpLaboratory";
            this.grpLaboratory.Size = new System.Drawing.Size(308, 162);
            this.grpLaboratory.TabIndex = 0;
            this.grpLaboratory.Text = "آزمایشگاه ها";
            this.grpLaboratory.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // drpUser
            // 
            this.drpUser.Enabled = false;
            this.drpUser.Location = new System.Drawing.Point(35, 105);
            this.drpUser.Name = "drpUser";
            this.drpUser.SelectInDataSource = true;
            this.drpUser.Size = new System.Drawing.Size(233, 21);
            this.drpUser.TabIndex = 1;
            this.drpUser.Text = "dropDown1";
            this.drpUser.Visible = false;
            this.drpUser.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(35, 67);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(233, 21);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.Text = "l";
            this.txtDesc.Visible = false;
            this.txtDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // drpLab
            // 
            this.drpLab.Location = new System.Drawing.Point(35, 40);
            this.drpLab.Name = "drpLab";
            this.drpLab.Size = new System.Drawing.Size(233, 21);
            this.drpLab.TabIndex = 0;
            this.drpLab.Text = "dropDown1";
            this.drpLab.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // grpEmptyBasket
            // 
            this.grpEmptyBasket.Controls.Add(this.grdEmptyBasket);
            this.grpEmptyBasket.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpEmptyBasket.Location = new System.Drawing.Point(-467, 54);
            this.grpEmptyBasket.Name = "grpEmptyBasket";
            this.grpEmptyBasket.Size = new System.Drawing.Size(701, 322);
            this.grpEmptyBasket.TabIndex = 2;
            this.grpEmptyBasket.Text = "سبد مربوط به قرارداد";
            this.grpEmptyBasket.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdEmptyBasket
            // 
            this.grdEmptyBasket.AlowRetrieveStructure = false;
            this.grdEmptyBasket.AlternatingColors = true;
            this.grdEmptyBasket.BuiltInTextsData = resources.GetString("grdEmptyBasket.BuiltInTextsData");
            this.grdEmptyBasket.DataSource = this.emptyBasketList1;
            this.grdEmptyBasket.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdEmptyBasket_DesignTimeLayout.LayoutString = resources.GetString("grdEmptyBasket_DesignTimeLayout.LayoutString");
            this.grdEmptyBasket.DesignTimeLayout = grdEmptyBasket_DesignTimeLayout;
            this.grdEmptyBasket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEmptyBasket.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdEmptyBasket.GroupByBoxVisible = false;
            this.grdEmptyBasket.Location = new System.Drawing.Point(3, 17);
            this.grdEmptyBasket.Name = "grdEmptyBasket";
            this.grdEmptyBasket.Size = new System.Drawing.Size(695, 302);
            this.grdEmptyBasket.TabIndex = 2;
            this.grdEmptyBasket.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdEmptyBasket.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // PartsThatExitedFromStoreToLaboratory
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(935, 403);
            this.Name = "PartsThatExitedFromStoreToLaboratory";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.PartsThatExitedFromStoreToLaboratory_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpParts)).EndInit();
            this.grpParts.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpLaboratory)).EndInit();
            this.grpLaboratory.ResumeLayout(false);
            this.grpLaboratory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpEmptyBasket)).EndInit();
            this.grpEmptyBasket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmptyBasket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpEmptyBasket;
        private General.Controls.GroupBox grpParts;
        private General.Controls.GroupBox grpSearch;
        private Controls.SearchContract searchContract1;
        private General.Controls.Grid grdEmptyBasket;
        private General.Lists.EmptyBasketList emptyBasketList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.Grid grdParts;
        private General.Lists.PartsAreNotExitedFromStoredList partsAreNotExitedFromStoredList1;
        private General.Lists.LaboratoryList laboratoryList1;
        private General.Lists.FindUsersLaboratoryList findUsersLaboratoryList1;
        private General.Controls.GroupBox grpUser;
        private General.Controls.GroupBox grpLaboratory;
        private General.Controls.Panel panel1;
        private General.Controls.DropDown drpUser;
        private General.Controls.DropDown drpLab;
        private General.Controls.TextBox txtDesc;
        private General.Lists.Laboratory_UserList laboratory_UserList1;
        private General.Controls.Grid grdReceiver;

    }
}
