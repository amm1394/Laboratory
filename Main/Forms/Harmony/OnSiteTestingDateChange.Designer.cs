namespace RASF.Main.Forms.Harmony
{
    partial class OnSiteTestingDateChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnSiteTestingDateChange));
            Janus.Windows.GridEX.GridEXLayout grdTest_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grdTest = new RASF.General.Controls.Grid();
            this.testForThePresenceDateChangeList1 = new RASF.General.Lists.TestForThePresenceDateChangeList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.txttime = new RASF.General.Controls.TextBox();
            this.label2 = new RASF.General.Controls.Label();
            this.DatePickertxtTest = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new RASF.General.Controls.Label();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).BeginInit();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 558);
            this.pnlButton.Size = new System.Drawing.Size(931, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.grpGrid);
            this.pnlContent.Size = new System.Drawing.Size(931, 558);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(726, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(809, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(871, 0);
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.grdTest);
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGrid.Location = new System.Drawing.Point(0, 0);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(931, 319);
            this.grpGrid.TabIndex = 1;
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdTest
            // 
            this.grdTest.AlowRetrieveStructure = false;
            this.grdTest.AlternatingColors = true;
            this.grdTest.BuiltInTextsData = resources.GetString("grdTest.BuiltInTextsData");
            this.grdTest.DataSource = this.testForThePresenceDateChangeList1;
            this.grdTest.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTest_DesignTimeLayout.LayoutString = resources.GetString("grdTest_DesignTimeLayout.LayoutString");
            this.grdTest.DesignTimeLayout = grdTest_DesignTimeLayout;
            this.grdTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTest.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdTest.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdTest.GroupByBoxVisible = false;
            this.grdTest.Location = new System.Drawing.Point(3, 8);
            this.grdTest.Name = "grdTest";
            this.grdTest.Size = new System.Drawing.Size(925, 308);
            this.grdTest.TabIndex = 0;
            this.grdTest.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdTest.SelectionChanged += new System.EventHandler(this.grdDelivery_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DatePickertxtTest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 239);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "تغییر تاریخ تست در محل";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txttime
            // 
            this.txttime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testForThePresenceDateChangeList1, "TimeOfTestForThePresence", true));
            this.txttime.Location = new System.Drawing.Point(705, 83);
            this.txttime.Name = "txttime";
            this.txttime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttime.Size = new System.Drawing.Size(79, 21);
            this.txttime.TabIndex = 11;
            this.txttime.Text = "00:00";
            this.txttime.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(803, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ساعت تست در محل";
            // 
            // DatePickertxtTest
            // 
            this.DatePickertxtTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickertxtTest.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.testForThePresenceDateChangeList1, "DateOfTestForThePresence", true));
            this.DatePickertxtTest.IsNull = false;
            this.DatePickertxtTest.Location = new System.Drawing.Point(638, 29);
            this.DatePickertxtTest.Name = "DatePickertxtTest";
            this.DatePickertxtTest.SelectedDateTime = new System.DateTime(2014, 3, 15, 15, 34, 43, 0);
            this.DatePickertxtTest.Size = new System.Drawing.Size(146, 20);
            this.DatePickertxtTest.TabIndex = 9;
            this.DatePickertxtTest.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاریخ تست در محل:";
            // 
            // OnSiteTestingDateChange
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 588);
            this.Name = "OnSiteTestingDateChange";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "DeliveryDateChange";
            this.Load += new System.EventHandler(this.IsHoldForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).EndInit();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpGrid;
        private General.Controls.Grid grdTest;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Label label1;
        private General.Lists.TestForThePresenceDateChangeList testForThePresenceDateChangeList1;
        protected FarsiLibrary.Win.Controls.FADatePicker DatePickertxtTest;
        private General.Controls.TextBox txttime;
        private General.Controls.Label label2;

    }
}