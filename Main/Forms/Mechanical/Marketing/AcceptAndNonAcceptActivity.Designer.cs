namespace RASF.Main.Forms.Marketing
{
    partial class AcceptAndNonAcceptActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcceptAndNonAcceptActivity));
            Janus.Windows.GridEX.GridEXLayout grdnonAccept_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdReport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdAccept_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grid3_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdnonAccept = new RASF.General.Controls.Grid();
            this.nonAcceptedMarketingActivityList1 = new RASF.General.Lists.NonAcceptedMarketingActivityList(this.components);
            this.grdReport = new RASF.General.Controls.Grid();
            this.groupBox6 = new RASF.General.Controls.GroupBox();
            this.textBox1 = new RASF.General.Controls.TextBox();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdAccept = new RASF.General.Controls.Grid();
            this.acceptedMarketingActivityList1 = new RASF.General.Lists.AcceptedMarketingActivityList(this.components);
            this.grid3 = new RASF.General.Controls.Grid();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.textBox2 = new RASF.General.Controls.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdnonAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 560);
            this.pnlButton.Size = new System.Drawing.Size(1027, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(1027, 560);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(822, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(905, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(967, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1027, 560);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox2);
            this.uiTabPage1.Controls.Add(this.groupBox6);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1023, 536);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "تایید نشده ها";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdnonAccept);
            this.groupBox2.Controls.Add(this.grdReport);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 426);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "تایید نشده ها";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdnonAccept
            // 
            this.grdnonAccept.AlowRetrieveStructure = false;
            this.grdnonAccept.AlternatingColors = true;
            this.grdnonAccept.BuiltInTextsData = resources.GetString("grdnonAccept.BuiltInTextsData");
            this.grdnonAccept.DataSource = this.nonAcceptedMarketingActivityList1;
            this.grdnonAccept.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdnonAccept_DesignTimeLayout.LayoutString = resources.GetString("grdnonAccept_DesignTimeLayout.LayoutString");
            this.grdnonAccept.DesignTimeLayout = grdnonAccept_DesignTimeLayout;
            this.grdnonAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdnonAccept.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdnonAccept.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdnonAccept.GroupByBoxVisible = false;
            this.grdnonAccept.Location = new System.Drawing.Point(3, 17);
            this.grdnonAccept.Name = "grdnonAccept";
            this.grdnonAccept.RecordNavigator = true;
            this.grdnonAccept.Size = new System.Drawing.Size(1017, 406);
            this.grdnonAccept.TabIndex = 1;
            this.grdnonAccept.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdnonAccept.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdnonAccept.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdnonAccept_ColumnButtonClick);
            this.grdnonAccept.SelectionChanged += new System.EventHandler(this.grdnonAccept_SelectionChanged);
            // 
            // grdReport
            // 
            this.grdReport.AlowRetrieveStructure = false;
            this.grdReport.AlternatingColors = true;
            this.grdReport.BuiltInTextsData = resources.GetString("grdReport.BuiltInTextsData");
            this.grdReport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReport_DesignTimeLayout.LayoutString = resources.GetString("grdReport_DesignTimeLayout.LayoutString");
            this.grdReport.DesignTimeLayout = grdReport_DesignTimeLayout;
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReport.GroupByBoxVisible = false;
            this.grdReport.Location = new System.Drawing.Point(3, 17);
            this.grdReport.Name = "grdReport";
            this.grdReport.Size = new System.Drawing.Size(1017, 406);
            this.grdReport.TabIndex = 0;
            this.grdReport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(0, 426);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1023, 110);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.Text = "توضیحات";
            this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1017, 90);
            this.textBox1.TabIndex = 0;
            this.textBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox1);
            this.uiTabPage2.Controls.Add(this.groupBox3);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(1023, 536);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "تایید شده ها";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdAccept);
            this.groupBox1.Controls.Add(this.grid3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.Text = "تایید شده ها";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAccept
            // 
            this.grdAccept.AlowRetrieveStructure = false;
            this.grdAccept.AlternatingColors = true;
            this.grdAccept.BuiltInTextsData = resources.GetString("grdAccept.BuiltInTextsData");
            this.grdAccept.DataSource = this.acceptedMarketingActivityList1;
            this.grdAccept.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAccept_DesignTimeLayout.LayoutString = resources.GetString("grdAccept_DesignTimeLayout.LayoutString");
            this.grdAccept.DesignTimeLayout = grdAccept_DesignTimeLayout;
            this.grdAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAccept.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdAccept.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdAccept.GroupByBoxVisible = false;
            this.grdAccept.Location = new System.Drawing.Point(3, 17);
            this.grdAccept.Name = "grdAccept";
            this.grdAccept.Size = new System.Drawing.Size(1017, 406);
            this.grdAccept.TabIndex = 1;
            this.grdAccept.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAccept.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdAccept.SelectionChanged += new System.EventHandler(this.grdAccept_SelectionChanged);
            // 
            // grid3
            // 
            this.grid3.AlowRetrieveStructure = false;
            this.grid3.AlternatingColors = true;
            this.grid3.BuiltInTextsData = resources.GetString("grid3.BuiltInTextsData");
            this.grid3.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grid3_DesignTimeLayout.LayoutString = resources.GetString("grid3_DesignTimeLayout.LayoutString");
            this.grid3.DesignTimeLayout = grid3_DesignTimeLayout;
            this.grid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid3.GroupByBoxVisible = false;
            this.grid3.Location = new System.Drawing.Point(3, 17);
            this.grid3.Name = "grid3";
            this.grid3.Size = new System.Drawing.Size(1017, 406);
            this.grid3.TabIndex = 0;
            this.grid3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grid3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1023, 110);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.Text = "توضیحات";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 17);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1017, 90);
            this.textBox2.TabIndex = 0;
            this.textBox2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // AcceptAndNonAcceptActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1027, 590);
            this.Name = "AcceptAndNonAcceptActivity";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.AcceptAndNonAcceptActivity_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdnonAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private RASF.General.Controls.TabControl tabControl1;
        private RASF.General.Controls.GroupBox groupBox2;
        private RASF.General.Controls.Grid grdnonAccept;
        private RASF.General.Controls.Grid grdReport;
        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Grid grdAccept;
        private RASF.General.Controls.Grid grid3;
        private RASF.General.Lists.NonAcceptedMarketingActivityList nonAcceptedMarketingActivityList1;
        private RASF.General.Lists.AcceptedMarketingActivityList acceptedMarketingActivityList1;
        private General.Controls.GroupBox groupBox6;
        private General.Controls.TextBox textBox1;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.TextBox textBox2;
    }
}
