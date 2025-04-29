namespace RASF.Main.Forms.Store
{
    partial class PartsThatExitedToLaboratoryWestSide
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
            Janus.Windows.GridEX.GridEXLayout grdParts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsThatExitedToLaboratoryWestSide));
            Janus.Windows.GridEX.GridEXLayout grdEmptyBasket_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpSearch = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.grpParts = new RASF.General.Controls.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdParts = new RASF.General.Controls.Grid();
            this.partsAreNotExitedFromLaboratoryWestSideList1 = new RASF.General.Lists.PartsAreNotExitedFromLaboratoryWestSideList(this.components);
            this.grpUser = new RASF.General.Controls.GroupBox();
            this.drpUser = new RASF.General.Controls.DropDown();
            this.findUsersLaboratoryList1 = new RASF.General.Lists.FindUsersLaboratoryList(this.components);
            this.grpEmptyBasket = new RASF.General.Controls.GroupBox();
            this.grdEmptyBasket = new RASF.General.Controls.Grid();
            this.emptyBasketList1 = new RASF.General.Lists.EmptyBasketList(this.components);
            this.txtDesc = new RASF.General.Controls.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.grpEmptyBasket)).BeginInit();
            this.grpEmptyBasket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmptyBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 377);
            this.pnlButton.Size = new System.Drawing.Size(885, 27);
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
            this.pnlContent.Size = new System.Drawing.Size(885, 377);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 3);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(680, 0);
            this.pnlUpdate.Size = new System.Drawing.Size(83, 27);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(763, 0);
            this.pnlExit.Size = new System.Drawing.Size(62, 27);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(825, 0);
            this.pnlSave.Size = new System.Drawing.Size(60, 27);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.searchContract1);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(885, 54);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.Text = "جستجو";
            this.grpSearch.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(656, 17);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(226, 34);
            this.searchContract1.TabIndex = 0;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // grpParts
            // 
            this.grpParts.Controls.Add(this.splitContainer1);
            this.grpParts.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpParts.Location = new System.Drawing.Point(184, 54);
            this.grpParts.Name = "grpParts";
            this.grpParts.Size = new System.Drawing.Size(701, 323);
            this.grpParts.TabIndex = 1;
            this.grpParts.Text = "نمونه هایی که وارد آزمایشگاه شده اند";
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
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(695, 303);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 4;
            // 
            // grdParts
            // 
            this.grdParts.AlowRetrieveStructure = false;
            this.grdParts.AlternatingColors = true;
            this.grdParts.BuiltInTextsData = resources.GetString("grdParts.BuiltInTextsData");
            this.grdParts.DataSource = this.partsAreNotExitedFromLaboratoryWestSideList1;
            this.grdParts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdParts_DesignTimeLayout.LayoutString = resources.GetString("grdParts_DesignTimeLayout.LayoutString");
            this.grdParts.DesignTimeLayout = grdParts_DesignTimeLayout;
            this.grdParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdParts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdParts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdParts.GroupByBoxVisible = false;
            this.grdParts.Location = new System.Drawing.Point(0, 0);
            this.grdParts.Name = "grdParts";
            this.grdParts.Size = new System.Drawing.Size(695, 219);
            this.grdParts.TabIndex = 4;
            this.grdParts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdParts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.txtDesc);
            this.grpUser.Controls.Add(this.drpUser);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(695, 80);
            this.grpUser.TabIndex = 1;
            this.grpUser.Text = "تحویل دهنده";
            this.grpUser.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // drpUser
            // 
            this.drpUser.Location = new System.Drawing.Point(447, 26);
            this.drpUser.Name = "drpUser";
            this.drpUser.Size = new System.Drawing.Size(233, 21);
            this.drpUser.TabIndex = 1;
            this.drpUser.Text = "dropDown1";
            this.drpUser.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // grpEmptyBasket
            // 
            this.grpEmptyBasket.Controls.Add(this.grdEmptyBasket);
            this.grpEmptyBasket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEmptyBasket.Location = new System.Drawing.Point(0, 54);
            this.grpEmptyBasket.Name = "grpEmptyBasket";
            this.grpEmptyBasket.Size = new System.Drawing.Size(184, 323);
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
            this.grdEmptyBasket.Size = new System.Drawing.Size(178, 303);
            this.grdEmptyBasket.TabIndex = 2;
            this.grdEmptyBasket.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdEmptyBasket.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(186, 26);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(233, 21);
            this.txtDesc.TabIndex = 6;
            this.txtDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // PartsThatExitedToLaboratoryWestSide
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(885, 404);
            this.Name = "PartsThatExitedToLaboratoryWestSide";
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
            this.grpUser.PerformLayout();
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
        private General.Lists.FindUsersLaboratoryList findUsersLaboratoryList1;
        private General.Controls.GroupBox grpUser;
        private General.Controls.DropDown drpUser;
        private General.Lists.PartsAreNotExitedFromLaboratoryWestSideList partsAreNotExitedFromLaboratoryWestSideList1;
        private General.Controls.TextBox txtDesc;

    }
}
