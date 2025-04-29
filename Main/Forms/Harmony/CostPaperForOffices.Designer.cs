namespace RASF.Main.Forms.Harmony
{
    partial class CostPaperForOffices
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
            Janus.Windows.GridEX.GridEXLayout grdCompanisInvoice_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostPaperForOffices));
            Janus.Windows.GridEX.GridEXLayout grdMaterList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdReciptHistory_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBoxInvoice = new RASF.General.Controls.GroupBox();
            this.grdCompanisInvoice = new RASF.General.Controls.Grid();
            this.companiesCostPaperForOfficesList1 = new RASF.General.Lists.CompaniesCostPaperForOfficesList(this.components);
            this.findContractNoList1 = new RASF.General.Lists.FindContractNoList(this.components);
            this.recieptHistoryList1 = new RASF.General.Lists.RecieptHistoryList(this.components);
            this.groupBox6 = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.grpLab = new RASF.General.Controls.GroupBox();
            this.grdMaterList = new RASF.General.Controls.Grid();
            this.masterTestListCostPaperForOfficesList1 = new RASF.General.Lists.MasterTestListCostPaperForOfficesList(this.components);
            this.grpMali = new RASF.General.Controls.GroupBox();
            this.grdReciptHistory = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).BeginInit();
            this.groupBoxInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanisInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpLab)).BeginInit();
            this.grpLab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMali)).BeginInit();
            this.grpMali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReciptHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 623);
            this.pnlButton.Size = new System.Drawing.Size(1229, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpLab);
            this.pnlContent.Controls.Add(this.groupBoxInvoice);
            this.pnlContent.Controls.Add(this.groupBox6);
            this.pnlContent.Size = new System.Drawing.Size(1229, 623);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1022, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1107, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1169, 0);
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Controls.Add(this.grdCompanisInvoice);
            this.groupBoxInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInvoice.Location = new System.Drawing.Point(0, 43);
            this.groupBoxInvoice.Name = "groupBoxInvoice";
            this.groupBoxInvoice.Size = new System.Drawing.Size(1229, 259);
            this.groupBoxInvoice.TabIndex = 2;
            this.groupBoxInvoice.Text = "نام شرکت جهت صدور صورت حساب";
            this.groupBoxInvoice.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompanisInvoice
            // 
            this.grdCompanisInvoice.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCompanisInvoice.AlowRetrieveStructure = false;
            this.grdCompanisInvoice.AlternatingColors = true;
            this.grdCompanisInvoice.BuiltInTextsData = resources.GetString("grdCompanisInvoice.BuiltInTextsData");
            this.grdCompanisInvoice.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.grdCompanisInvoice.CardWidth = 1200;
            this.grdCompanisInvoice.DataSource = this.companiesCostPaperForOfficesList1;
            this.grdCompanisInvoice.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompanisInvoice_DesignTimeLayout.LayoutString = resources.GetString("grdCompanisInvoice_DesignTimeLayout.LayoutString");
            this.grdCompanisInvoice.DesignTimeLayout = grdCompanisInvoice_DesignTimeLayout;
            this.grdCompanisInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompanisInvoice.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompanisInvoice.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompanisInvoice.GroupByBoxVisible = false;
            this.grdCompanisInvoice.Location = new System.Drawing.Point(3, 17);
            this.grdCompanisInvoice.Name = "grdCompanisInvoice";
            this.grdCompanisInvoice.ScrollBars = Janus.Windows.GridEX.ScrollBars.None;
            this.grdCompanisInvoice.Size = new System.Drawing.Size(1223, 239);
            this.grdCompanisInvoice.TabIndex = 0;
            this.grdCompanisInvoice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompanisInvoice.View = Janus.Windows.GridEX.View.CardView;
            this.grdCompanisInvoice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.searchContract1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1229, 43);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(997, 8);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(229, 32);
            this.searchContract1.TabIndex = 0;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // grpLab
            // 
            this.grpLab.Controls.Add(this.grdMaterList);
            this.grpLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLab.Location = new System.Drawing.Point(0, 302);
            this.grpLab.Name = "grpLab";
            this.grpLab.Size = new System.Drawing.Size(1229, 321);
            this.grpLab.TabIndex = 7;
            this.grpLab.Text = "لیست آزمایشات";
            this.grpLab.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMaterList
            // 
            this.grdMaterList.AlowRetrieveStructure = false;
            this.grdMaterList.AlternatingColors = true;
            this.grdMaterList.BuiltInTextsData = resources.GetString("grdMaterList.BuiltInTextsData");
            this.grdMaterList.DataSource = this.masterTestListCostPaperForOfficesList1;
            this.grdMaterList.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMaterList_DesignTimeLayout.LayoutString = resources.GetString("grdMaterList_DesignTimeLayout.LayoutString");
            this.grdMaterList.DesignTimeLayout = grdMaterList_DesignTimeLayout;
            this.grdMaterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterList.GroupByBoxVisible = false;
            this.grdMaterList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.grdMaterList.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle;
            this.grdMaterList.Location = new System.Drawing.Point(3, 17);
            this.grdMaterList.Name = "grdMaterList";
            this.grdMaterList.Size = new System.Drawing.Size(1223, 301);
            this.grdMaterList.TabIndex = 0;
            this.grdMaterList.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMaterList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpMali
            // 
            this.grpMali.Controls.Add(this.grdReciptHistory);
            this.grpMali.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpMali.Location = new System.Drawing.Point(702, 302);
            this.grpMali.Name = "grpMali";
            this.grpMali.Size = new System.Drawing.Size(527, 321);
            this.grpMali.TabIndex = 6;
            this.grpMali.Text = "تاریخچه پرداخت ها";
            this.grpMali.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReciptHistory
            // 
            this.grdReciptHistory.AlowRetrieveStructure = false;
            this.grdReciptHistory.AlternatingColors = true;
            this.grdReciptHistory.BuiltInTextsData = resources.GetString("grdReciptHistory.BuiltInTextsData");
            this.grdReciptHistory.DataSource = this.recieptHistoryList1;
            this.grdReciptHistory.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReciptHistory_DesignTimeLayout.LayoutString = resources.GetString("grdReciptHistory_DesignTimeLayout.LayoutString");
            this.grdReciptHistory.DesignTimeLayout = grdReciptHistory_DesignTimeLayout;
            this.grdReciptHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReciptHistory.GroupByBoxVisible = false;
            this.grdReciptHistory.Location = new System.Drawing.Point(3, 16);
            this.grdReciptHistory.Name = "grdReciptHistory";
            this.grdReciptHistory.Size = new System.Drawing.Size(521, 302);
            this.grdReciptHistory.TabIndex = 1;
            this.grdReciptHistory.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // CostPaperForOffices
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1229, 653);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CostPaperForOffices";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).EndInit();
            this.groupBoxInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanisInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpLab)).EndInit();
            this.grpLab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMali)).EndInit();
            this.grpMali.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReciptHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected RASF.General.Controls.GroupBox groupBoxInvoice;
        private RASF.General.Controls.Grid grdCompanisInvoice;
        private General.Lists.FindContractNoList findContractNoList1;
        private General.Lists.RecieptHistoryList recieptHistoryList1;
        private General.Controls.GroupBox grpLab;
        private General.Controls.Grid grdMaterList;
        private General.Controls.GroupBox grpMali;
        private General.Controls.Grid grdReciptHistory;
        private General.Controls.GroupBox groupBox6;
        private Controls.SearchContract searchContract1;
        private General.Lists.CompaniesCostPaperForOfficesList companiesCostPaperForOfficesList1;
        private General.Lists.MasterTestListCostPaperForOfficesList masterTestListCostPaperForOfficesList1;
    }
}
