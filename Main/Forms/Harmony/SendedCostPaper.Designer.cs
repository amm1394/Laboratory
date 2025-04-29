namespace RASF.Main.Forms.Harmony
{
    partial class SendedCostPaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendedCostPaper));
            Janus.Windows.GridEX.GridEXLayout grdNotSend_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdSended_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdNotSend = new RASF.General.Controls.Grid();
            this.notSendedCostPaperList1 = new RASF.General.Lists.NotSendedCostPaperList(this.components);
            this.grpdate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdSended = new RASF.General.Controls.Grid();
            this.sendedCostPaperList1 = new RASF.General.Lists.SendedCostPaperList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpdate)).BeginInit();
            this.grpdate.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSended)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 660);
            this.pnlButton.Size = new System.Drawing.Size(866, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(866, 660);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(661, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(744, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(806, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(866, 660);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox1);
            this.uiTabPage1.Controls.Add(this.grpdate);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(862, 636);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "برگه هزینه های ارسال نشده";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdNotSend);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 581);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdNotSend
            // 
            this.grdNotSend.AlowRetrieveStructure = false;
            this.grdNotSend.AlternatingColors = true;
            this.grdNotSend.BuiltInTextsData = resources.GetString("grdNotSend.BuiltInTextsData");
            this.grdNotSend.DataSource = this.notSendedCostPaperList1;
            this.grdNotSend.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdNotSend_DesignTimeLayout.LayoutString = resources.GetString("grdNotSend_DesignTimeLayout.LayoutString");
            this.grdNotSend.DesignTimeLayout = grdNotSend_DesignTimeLayout;
            this.grdNotSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNotSend.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdNotSend.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdNotSend.GroupByBoxVisible = false;
            this.grdNotSend.Location = new System.Drawing.Point(3, 8);
            this.grdNotSend.Name = "grdNotSend";
            this.grdNotSend.RecordNavigator = true;
            this.grdNotSend.Size = new System.Drawing.Size(856, 570);
            this.grdNotSend.TabIndex = 0;
            this.grdNotSend.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdNotSend.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpdate
            // 
            this.grpdate.Controls.Add(this.pickDate1);
            this.grpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpdate.Location = new System.Drawing.Point(0, 0);
            this.grpdate.Name = "grpdate";
            this.grpdate.Size = new System.Drawing.Size(862, 55);
            this.grpdate.TabIndex = 4;
            this.grpdate.Text = "تاریخ پذیرش";
            this.grpdate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(435, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 35);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox2);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(862, 636);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "برگه هزینه های های ارسال شده";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdSended);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 636);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdSended
            // 
            this.grdSended.AlowRetrieveStructure = false;
            this.grdSended.AlternatingColors = true;
            this.grdSended.BuiltInTextsData = resources.GetString("grdSended.BuiltInTextsData");
            this.grdSended.DataSource = this.sendedCostPaperList1;
            this.grdSended.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdSended_DesignTimeLayout.LayoutString = resources.GetString("grdSended_DesignTimeLayout.LayoutString");
            this.grdSended.DesignTimeLayout = grdSended_DesignTimeLayout;
            this.grdSended.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSended.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdSended.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdSended.GroupByBoxVisible = false;
            this.grdSended.Location = new System.Drawing.Point(3, 8);
            this.grdSended.Name = "grdSended";
            this.grdSended.RecordNavigator = true;
            this.grdSended.Size = new System.Drawing.Size(856, 625);
            this.grdSended.TabIndex = 0;
            this.grdSended.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdSended.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // SendedCostPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 690);
            this.Name = "SendedCostPaper";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "SendedCostPaper";
            this.Load += new System.EventHandler(this.SendedCostPaper_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNotSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpdate)).EndInit();
            this.grpdate.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSended)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.GroupBox grpdate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdSended;
        private General.Lists.SendedCostPaperList sendedCostPaperList1;
        private General.Lists.NotSendedCostPaperList notSendedCostPaperList1;
        private General.Controls.Grid grdNotSend;
    }
}