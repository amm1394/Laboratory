namespace RASF.Main.Forms.BillsReports
{
    partial class SendBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendBills));
            Janus.Windows.GridEX.GridEXLayout grdBills_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdDetail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.billsissuedList1 = new RASF.General.Lists.BillsissuedList(this.components);
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.grdBills = new RASF.General.Controls.Grid();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.grdDetail = new RASF.General.Controls.Grid();
            this.billsissuedList2 = new RASF.General.Lists.BillsissuedList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBills)).BeginInit();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 719);
            this.pnlButton.Size = new System.Drawing.Size(1276, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1276, 719);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1071, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1154, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1216, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1276, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "محدوده زمانی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(849, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 37);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1270, 651);
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
            this.uiTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiTabPage1.Size = new System.Drawing.Size(1266, 627);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "صورت حساب های صادر شده";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdBills);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1266, 627);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdBills
            // 
            this.grdBills.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdBills.AlowRetrieveStructure = false;
            this.grdBills.AlternatingColors = true;
            this.grdBills.BuiltInTextsData = resources.GetString("grdBills.BuiltInTextsData");
            this.grdBills.DataSource = this.billsissuedList1;
            this.grdBills.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBills_DesignTimeLayout.LayoutString = resources.GetString("grdBills_DesignTimeLayout.LayoutString");
            this.grdBills.DesignTimeLayout = grdBills_DesignTimeLayout;
            this.grdBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBills.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdBills.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdBills.GroupByBoxVisible = false;
            this.grdBills.Location = new System.Drawing.Point(3, 8);
            this.grdBills.Name = "grdBills";
            this.grdBills.RecordNavigator = true;
            this.grdBills.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdBills.Size = new System.Drawing.Size(1260, 616);
            this.grdBills.TabIndex = 1;
            this.grdBills.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBills.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdBills.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.grdDetail);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(1266, 627);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "جزئیات صورتحساب های صادر شده";
            // 
            // grdDetail
            // 
            this.grdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDetail.AlowRetrieveStructure = false;
            this.grdDetail.AlternatingColors = true;
            this.grdDetail.BuiltInTextsData = resources.GetString("grdDetail.BuiltInTextsData");
            this.grdDetail.DataSource = this.billsissuedList2;
            this.grdDetail.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDetail_DesignTimeLayout.LayoutString = resources.GetString("grdDetail_DesignTimeLayout.LayoutString");
            this.grdDetail.DesignTimeLayout = grdDetail_DesignTimeLayout;
            this.grdDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDetail.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDetail.GroupByBoxVisible = false;
            this.grdDetail.Location = new System.Drawing.Point(0, 0);
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.RecordNavigator = true;
            this.grdDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdDetail.Size = new System.Drawing.Size(1266, 627);
            this.grdDetail.TabIndex = 2;
            this.grdDetail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1276, 662);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // SendBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1276, 749);
            this.Name = "SendBills";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBills)).EndInit();
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate1;
        private General.Lists.BillsissuedList billsissuedList1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.Grid grdBills;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Controls.Grid grdDetail;
        private General.Lists.BillsissuedList billsissuedList2;
    }
}
