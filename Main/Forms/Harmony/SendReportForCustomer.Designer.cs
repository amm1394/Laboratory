namespace RASF.Main.Forms.Harmony
{
    partial class SendReportForCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendReportForCustomer));
            Janus.Windows.GridEX.GridEXLayout grdSendReports_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grddelivery_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.grdSendReports = new RASF.General.Controls.Grid();
            this.sendReportForCustomerList1 = new RASF.General.Lists.SendReportForCustomerList(this.components);
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox4 = new RASF.General.Controls.GroupBox();
            this.grddelivery = new RASF.General.Controls.Grid();
            this.deliveryOfReportsToTheCustomerList1 = new RASF.General.Lists.DeliveryOfReportsToTheCustomerList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSendReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 517);
            this.pnlButton.Size = new System.Drawing.Size(774, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Location = new System.Drawing.Point(0, 46);
            this.pnlContent.Size = new System.Drawing.Size(774, 471);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(569, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(652, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(714, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "تاریخ تحویل";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(347, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 501);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "صورت حساب های صادر شده";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdSendReports);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 447);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.Text = "تایید ارسال گزارشات";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdSendReports
            // 
            this.grdSendReports.AlowRetrieveStructure = false;
            this.grdSendReports.AlternatingColors = true;
            this.grdSendReports.BuiltInTextsData = resources.GetString("grdSendReports.BuiltInTextsData");
            this.grdSendReports.DataSource = this.sendReportForCustomerList1;
            this.grdSendReports.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdSendReports_DesignTimeLayout.LayoutString = resources.GetString("grdSendReports_DesignTimeLayout.LayoutString");
            this.grdSendReports.DesignTimeLayout = grdSendReports_DesignTimeLayout;
            this.grdSendReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSendReports.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdSendReports.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdSendReports.GroupByBoxVisible = false;
            this.grdSendReports.Location = new System.Drawing.Point(3, 17);
            this.grdSendReports.Name = "grdSendReports";
            this.grdSendReports.RecordNavigator = true;
            this.grdSendReports.Size = new System.Drawing.Size(764, 427);
            this.grdSendReports.TabIndex = 0;
            this.grdSendReports.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdSendReports.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdSendReports.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdSendReports_ColumnButtonClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(774, 471);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox3);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(770, 447);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "گزارشات آماده تحویل";
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox4);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(770, 447);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "گزارشات تحویل داده شده";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grddelivery);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(770, 447);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.Text = "گزارشات تحویل داده شده";
            this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grddelivery
            // 
            this.grddelivery.AlowRetrieveStructure = false;
            this.grddelivery.AlternatingColors = true;
            this.grddelivery.BuiltInTextsData = resources.GetString("grddelivery.BuiltInTextsData");
            this.grddelivery.DataSource = this.deliveryOfReportsToTheCustomerList1;
            this.grddelivery.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grddelivery_DesignTimeLayout.LayoutString = resources.GetString("grddelivery_DesignTimeLayout.LayoutString");
            this.grddelivery.DesignTimeLayout = grddelivery_DesignTimeLayout;
            this.grddelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grddelivery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grddelivery.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grddelivery.GroupByBoxVisible = false;
            this.grddelivery.Location = new System.Drawing.Point(3, 17);
            this.grddelivery.Name = "grddelivery";
            this.grddelivery.RecordNavigator = true;
            this.grddelivery.Size = new System.Drawing.Size(764, 427);
            this.grddelivery.TabIndex = 0;
            this.grddelivery.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grddelivery.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // SendReportForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SendReportForCustomer";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "SendReportForCustomer";
            this.Load += new System.EventHandler(this.SendReportForCustomer_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSendReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grddelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.Main.Controls.PickDate.PickDate pickDate1;
        private RASF.General.Controls.GroupBox groupBox2;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.Grid grdSendReports;
        private General.Lists.SendReportForCustomerList sendReportForCustomerList1;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Controls.GroupBox groupBox4;
        private General.Controls.Grid grddelivery;
        private General.Lists.DeliveryOfReportsToTheCustomerList deliveryOfReportsToTheCustomerList1;
    }
}