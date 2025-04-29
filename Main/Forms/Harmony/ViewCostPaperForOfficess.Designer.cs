namespace RASF.Main.Forms.Harmony
{
    partial class ViewCostPaperForOfficess
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
            Janus.Windows.GridEX.GridEXLayout grdMessage_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCostPaperForOfficess));
            Janus.Windows.GridEX.GridEXLayout grdMaterList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.masterTestListCostPaperList1 = new RASF.General.Lists.MasterTestListCostPaperList(this.components);
            this.sendMessageList1 = new RASF.General.Lists.SendMessageList(this.components);
            this.companiesCostPaperList1 = new RASF.General.Lists.CompaniesCostPaperList(this.components);
            this.groupBox6 = new RASF.General.Controls.GroupBox();
            this.searchContractcsForAll1 = new RASF.Main.Controls.SearchContractcsForAll();
            this.findContractNoList1 = new RASF.General.Lists.FindContractNoList(this.components);
            this.part_PicList1 = new RASF.General.Lists.Part_PicList(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.part_Pic2Lis1 = new RASF.General.Lists.Part_Pic2Lis(this.components);
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.letter_Scan2 = new RASF.Main.Controls.Letter_Scan();
            this.uiTabPage6 = new Janus.Windows.UI.Tab.UITabPage();
            this.letter_Scan5 = new RASF.Main.Controls.Letter_Scan();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.letter_Scan1 = new RASF.Main.Controls.Letter_Scan();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBoxInvoice = new RASF.General.Controls.GroupBox();
            this.grdCompanisInvoice = new RASF.General.Controls.Grid();
            this.tabControl2 = new RASF.General.Controls.TabControl();
            this.uiTabPage7 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdMessage = new RASF.General.Controls.Grid();
            this.grdMaterList = new RASF.General.Controls.Grid();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            this.uiTabPage6.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).BeginInit();
            this.groupBoxInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanisInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl2)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.uiTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 807);
            this.pnlButton.Size = new System.Drawing.Size(1266, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Controls.Add(this.groupBox6);
            this.pnlContent.Size = new System.Drawing.Size(1266, 807);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1061, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1144, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1206, 0);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.searchContractcsForAll1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1266, 43);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContractcsForAll1
            // 
            this.searchContractcsForAll1.BackColor = System.Drawing.Color.Transparent;
            this.searchContractcsForAll1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContractcsForAll1.Location = new System.Drawing.Point(1037, 8);
            this.searchContractcsForAll1.Name = "searchContractcsForAll1";
            this.searchContractcsForAll1.Size = new System.Drawing.Size(226, 32);
            this.searchContractcsForAll1.TabIndex = 0;
            this.searchContractcsForAll1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContractcsForAll1_ReturnContractsCode);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Controls.Add(this.letter_Scan2);
            this.uiTabPage3.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(1232, 740);
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "مکاتبات";
            // 
            // letter_Scan2
            // 
            this.letter_Scan2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letter_Scan2.Document = null;
            this.letter_Scan2.Location = new System.Drawing.Point(0, 0);
            this.letter_Scan2.Name = "letter_Scan2";
            this.letter_Scan2.Size = new System.Drawing.Size(1232, 740);
            this.letter_Scan2.TabIndex = 0;
            // 
            // uiTabPage6
            // 
            this.uiTabPage6.Controls.Add(this.letter_Scan5);
            this.uiTabPage6.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage6.Name = "uiTabPage6";
            this.uiTabPage6.Size = new System.Drawing.Size(1232, 740);
            this.uiTabPage6.TabStop = true;
            this.uiTabPage6.Text = "مشاهده عکس قطعات 2";
            // 
            // letter_Scan5
            // 
            this.letter_Scan5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letter_Scan5.Document = null;
            this.letter_Scan5.Location = new System.Drawing.Point(0, 0);
            this.letter_Scan5.Name = "letter_Scan5";
            this.letter_Scan5.Size = new System.Drawing.Size(1232, 740);
            this.letter_Scan5.TabIndex = 2;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.letter_Scan1);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(1232, 740);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "مشاهده عکس قطعات";
            // 
            // letter_Scan1
            // 
            this.letter_Scan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letter_Scan1.Document = null;
            this.letter_Scan1.Location = new System.Drawing.Point(0, 0);
            this.letter_Scan1.Name = "letter_Scan1";
            this.letter_Scan1.Size = new System.Drawing.Size(1232, 740);
            this.letter_Scan1.TabIndex = 1;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.grdMaterList);
            this.uiTabPage1.Controls.Add(this.tabControl2);
            this.uiTabPage1.Controls.Add(this.groupBoxInvoice);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1262, 740);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "مشاهده برگه هزینه";
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Controls.Add(this.grdCompanisInvoice);
            this.groupBoxInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInvoice.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInvoice.Name = "groupBoxInvoice";
            this.groupBoxInvoice.Size = new System.Drawing.Size(1262, 261);
            this.groupBoxInvoice.TabIndex = 3;
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
            this.grdCompanisInvoice.CardWidth = 1230;
            this.grdCompanisInvoice.DataSource = this.companiesCostPaperList1;
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
            this.grdCompanisInvoice.Size = new System.Drawing.Size(1256, 241);
            this.grdCompanisInvoice.TabIndex = 0;
            this.grdCompanisInvoice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompanisInvoice.View = Janus.Windows.GridEX.View.SingleCard;
            this.grdCompanisInvoice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // tabControl2
            // 
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(0, 553);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Size = new System.Drawing.Size(1262, 187);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage7});
            // 
            // uiTabPage7
            // 
            this.uiTabPage7.Controls.Add(this.groupBox2);
            this.uiTabPage7.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage7.Name = "uiTabPage7";
            this.uiTabPage7.Size = new System.Drawing.Size(1258, 163);
            this.uiTabPage7.TabStop = true;
            this.uiTabPage7.Text = "پیام های ارسال شده";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdMessage);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1258, 163);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = "پیام های ارسال شده";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMessage
            // 
            this.grdMessage.AlowRetrieveStructure = false;
            this.grdMessage.AlternatingColors = true;
            this.grdMessage.BuiltInTextsData = resources.GetString("grdMessage.BuiltInTextsData");
            this.grdMessage.DataSource = this.sendMessageList1;
            this.grdMessage.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMessage_DesignTimeLayout.LayoutString = resources.GetString("grdMessage_DesignTimeLayout.LayoutString");
            this.grdMessage.DesignTimeLayout = grdMessage_DesignTimeLayout;
            this.grdMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMessage.GroupByBoxVisible = false;
            this.grdMessage.Location = new System.Drawing.Point(3, 17);
            this.grdMessage.Name = "grdMessage";
            this.grdMessage.Size = new System.Drawing.Size(1252, 143);
            this.grdMessage.TabIndex = 1;
            this.grdMessage.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMessage.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grdMaterList
            // 
            this.grdMaterList.AlowRetrieveStructure = false;
            this.grdMaterList.AlternatingColors = true;
            this.grdMaterList.BuiltInTextsData = resources.GetString("grdMaterList.BuiltInTextsData");
            this.grdMaterList.DataSource = this.masterTestListCostPaperList1;
            this.grdMaterList.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMaterList_DesignTimeLayout.LayoutString = resources.GetString("grdMaterList_DesignTimeLayout.LayoutString");
            this.grdMaterList.DesignTimeLayout = grdMaterList_DesignTimeLayout;
            this.grdMaterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterList.GroupByBoxVisible = false;
            this.grdMaterList.Location = new System.Drawing.Point(0, 261);
            this.grdMaterList.Name = "grdMaterList";
            this.grdMaterList.Size = new System.Drawing.Size(1262, 292);
            this.grdMaterList.TabIndex = 10;
            this.grdMaterList.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMaterList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1266, 764);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2,
            this.uiTabPage6,
            this.uiTabPage3});
            // 
            // ViewCostPaperForOfficess
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 837);
            this.Name = "ViewCostPaperForOfficess";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "CostPaper1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewCostPaper_FormClosing);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            this.uiTabPage6.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).EndInit();
            this.groupBoxInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanisInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl2)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.uiTabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox6;
        private General.Lists.SendMessageList sendMessageList1;
        private General.Lists.MasterTestListCostPaperList masterTestListCostPaperList1;
        private General.Lists.FindContractNoList findContractNoList1;
        private General.Lists.CompaniesCostPaperList companiesCostPaperList1;
        private General.Lists.Part_PicList part_PicList1;
        private Controls.SearchContractcsForAll searchContractcsForAll1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private General.Lists.Part_Pic2Lis part_Pic2Lis1;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private General.Controls.Grid grdMaterList;
        private General.Controls.TabControl tabControl2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage7;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdMessage;
        protected General.Controls.GroupBox groupBoxInvoice;
        private General.Controls.Grid grdCompanisInvoice;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Controls.Letter_Scan letter_Scan1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage6;
        private Controls.Letter_Scan letter_Scan5;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Controls.Letter_Scan letter_Scan2;
     //   private Lable.Letter_Scan letter_Scan1;
     //   private Lable.Letter_Scan letter_Scan2;
    }
}