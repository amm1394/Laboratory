namespace RASF.Main.Forms.ContractsReport
{
    partial class LaboratoryDayDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaboratoryDayDelivery));
            Janus.Windows.GridEX.GridEXLayout grdLabDelivery_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdlab_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdDelay_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.deliveryDayForHarmonyList1 = new RASF.General.Lists.DeliveryDayForHarmonyList(this.components);
            this.label5 = new RASF.General.Controls.Label();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdLabDelivery = new RASF.General.Controls.Grid();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.grdlab = new RASF.General.Controls.Grid();
            this.deliveryDayForHarmonyList2 = new RASF.General.Lists.DeliveryDayForHarmonyList(this.components);
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.grdDelay = new RASF.General.Controls.Grid();
            this.deliveryDayForHarmonyList3 = new RASF.General.Lists.DeliveryDayForHarmonyList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.janusSuperTip1 = new Janus.Windows.Common.JanusSuperTip(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLabDelivery)).BeginInit();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdlab)).BeginInit();
            this.uiTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.label5);
            this.pnlButton.Location = new System.Drawing.Point(0, 540);
            this.pnlButton.Size = new System.Drawing.Size(1086, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.label5, 0);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1086, 540);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(881, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(964, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1026, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Plum;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "مشتری جدید";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1086, 479);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2,
            this.uiTabPage3});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox2);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1082, 455);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "کارهای تحویلی روز آزمایشگاه";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdLabDelivery);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1082, 455);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "کارهای تحویلی روز";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdLabDelivery
            // 
            this.grdLabDelivery.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdLabDelivery.AlowRetrieveStructure = false;
            this.grdLabDelivery.AlternatingColors = true;
            this.grdLabDelivery.BuiltInTextsData = resources.GetString("grdLabDelivery.BuiltInTextsData");
            this.grdLabDelivery.DataSource = this.deliveryDayForHarmonyList1;
            this.grdLabDelivery.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdLabDelivery_DesignTimeLayout.LayoutString = resources.GetString("grdLabDelivery_DesignTimeLayout.LayoutString");
            this.grdLabDelivery.DesignTimeLayout = grdLabDelivery_DesignTimeLayout;
            this.grdLabDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLabDelivery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdLabDelivery.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdLabDelivery.GroupByBoxVisible = false;
            this.grdLabDelivery.Location = new System.Drawing.Point(3, 17);
            this.grdLabDelivery.Name = "grdLabDelivery";
            this.grdLabDelivery.RecordNavigator = true;
            this.grdLabDelivery.Size = new System.Drawing.Size(1076, 435);
            this.grdLabDelivery.TabIndex = 0;
            this.grdLabDelivery.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdLabDelivery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdLabDelivery.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdLabDelivery.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdLabDelivery_ColumnButtonClick);
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox3);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(1082, 455);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "کارهای تحویلی روز";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdlab);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1082, 455);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.Text = "کارهای تحویلی روز";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdlab
            // 
            this.grdlab.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdlab.AlowRetrieveStructure = false;
            this.grdlab.AlternatingColors = true;
            this.grdlab.BuiltInTextsData = resources.GetString("grdlab.BuiltInTextsData");
            this.grdlab.DataSource = this.deliveryDayForHarmonyList2;
            this.grdlab.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdlab_DesignTimeLayout.LayoutString = resources.GetString("grdlab_DesignTimeLayout.LayoutString");
            this.grdlab.DesignTimeLayout = grdlab_DesignTimeLayout;
            this.grdlab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdlab.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdlab.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdlab.GroupByBoxVisible = false;
            this.grdlab.Location = new System.Drawing.Point(3, 17);
            this.grdlab.Name = "grdlab";
            this.grdlab.RecordNavigator = true;
            this.grdlab.Size = new System.Drawing.Size(1076, 435);
            this.grdlab.TabIndex = 0;
            this.grdlab.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdlab.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdlab.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdlab.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdlab_ColumnButtonClick);
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Controls.Add(this.grdDelay);
            this.uiTabPage3.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(1082, 455);
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "تاخیرات";
            // 
            // grdDelay
            // 
            this.grdDelay.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDelay.AlowRetrieveStructure = false;
            this.grdDelay.AlternatingColors = true;
            this.grdDelay.BuiltInTextsData = resources.GetString("grdDelay.BuiltInTextsData");
            this.grdDelay.DataSource = this.deliveryDayForHarmonyList3;
            this.grdDelay.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDelay_DesignTimeLayout.LayoutString = resources.GetString("grdDelay_DesignTimeLayout.LayoutString");
            this.grdDelay.DesignTimeLayout = grdDelay_DesignTimeLayout;
            this.grdDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDelay.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDelay.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDelay.GroupByBoxVisible = false;
            this.grdDelay.Location = new System.Drawing.Point(0, 0);
            this.grdDelay.Name = "grdDelay";
            this.grdDelay.RecordNavigator = true;
            this.grdDelay.Size = new System.Drawing.Size(1082, 455);
            this.grdDelay.TabIndex = 1;
            this.grdDelay.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDelay.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDelay.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdDelay.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdDelay_ColumnButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.Text = "محدوده زمانی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(659, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 41);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // janusSuperTip1
            // 
            this.janusSuperTip1.AutoPopDelay = 2000;
            this.janusSuperTip1.ImageList = null;
            // 
            // LaboratoryDayDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1086, 570);
            this.Name = "LaboratoryDayDelivery";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "برگه هزینه های تحویل روز (بخش هماهنگی)";
            this.Load += new System.EventHandler(this.LaboratoryDayDelivery_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLabDelivery)).EndInit();
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdlab)).EndInit();
            this.uiTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.DeliveryDayForHarmonyList deliveryDayForHarmonyList1;
        private General.Controls.Label label5;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdLabDelivery;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate1;
        private Janus.Windows.Common.JanusSuperTip janusSuperTip1;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.Grid grdlab;
        private General.Lists.DeliveryDayForHarmonyList deliveryDayForHarmonyList2;
        private General.Controls.Grid grdDelay;
        private General.Lists.DeliveryDayForHarmonyList deliveryDayForHarmonyList3;
    }
}
