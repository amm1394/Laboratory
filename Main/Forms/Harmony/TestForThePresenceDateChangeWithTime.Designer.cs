namespace RASF.Main.Forms.Harmony
{
    partial class TestForThePresenceDateChangeWithTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForThePresenceDateChangeWithTime));
            Janus.Windows.GridEX.GridEXLayout grdTest_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grdTest = new RASF.General.Controls.Grid();
            this.registerMarkingList1 = new RASF.General.Lists.RegisterMarkingList(this.components);
            this.testForThePresenceDateChangeList1 = new RASF.General.Lists.TestForThePresenceDateChangeList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.DatePickertxtTest = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new RASF.General.Controls.Label();
            this.groupBox6 = new RASF.General.Controls.GroupBox();
            this.searchContractcsForAll1 = new RASF.Main.Controls.SearchContractcsForAll();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
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
            this.pnlContent.Location = new System.Drawing.Point(0, 362);
            this.pnlContent.Size = new System.Drawing.Size(931, 196);
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
            this.grpGrid.Location = new System.Drawing.Point(0, 43);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(931, 319);
            this.grpGrid.TabIndex = 1;
            this.grpGrid.Text = "قرارداد";
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdTest
            // 
            this.grdTest.AlowRetrieveStructure = false;
            this.grdTest.AlternatingColors = true;
            this.grdTest.BuiltInTextsData = resources.GetString("grdTest.BuiltInTextsData");
            this.grdTest.DataSource = this.registerMarkingList1;
            this.grdTest.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTest_DesignTimeLayout.LayoutString = resources.GetString("grdTest_DesignTimeLayout.LayoutString");
            this.grdTest.DesignTimeLayout = grdTest_DesignTimeLayout;
            this.grdTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTest.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdTest.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdTest.GroupByBoxVisible = false;
            this.grdTest.Location = new System.Drawing.Point(3, 17);
            this.grdTest.Name = "grdTest";
            this.grdTest.Size = new System.Drawing.Size(925, 299);
            this.grdTest.TabIndex = 0;
            this.grdTest.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdTest.SelectionChanged += new System.EventHandler(this.grdDelivery_SelectionChanged);
            this.grdTest.InitCustomEdit += new Janus.Windows.GridEX.InitCustomEditEventHandler(this.grdTest_InitCustomEdit);
            this.grdTest.EndCustomEdit += new Janus.Windows.GridEX.EndCustomEditEventHandler(this.grdTest_EndCustomEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatePickertxtTest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "تغییر تاریخ تست در حضور";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
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
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاریخ تست در حضور:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.searchContractcsForAll1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(931, 43);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContractcsForAll1
            // 
            this.searchContractcsForAll1.BackColor = System.Drawing.Color.Transparent;
            this.searchContractcsForAll1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContractcsForAll1.Location = new System.Drawing.Point(702, 8);
            this.searchContractcsForAll1.Name = "searchContractcsForAll1";
            this.searchContractcsForAll1.Size = new System.Drawing.Size(226, 32);
            this.searchContractcsForAll1.TabIndex = 0;
            this.searchContractcsForAll1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContractcsForAll1_ReturnContractsCode);
            // 
            // TestForThePresenceDateChangeWithTime
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 588);
            this.Controls.Add(this.grpGrid);
            this.Controls.Add(this.groupBox6);
            this.Name = "TestForThePresenceDateChangeWithTime";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "DeliveryDateChange";
            this.Load += new System.EventHandler(this.IsHoldForm_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.groupBox6, 0);
            this.Controls.SetChildIndex(this.grpGrid, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpGrid;
        private General.Controls.Grid grdTest;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Label label1;
        private General.Lists.TestForThePresenceDateChangeList testForThePresenceDateChangeList1;
        protected FarsiLibrary.Win.Controls.FADatePicker DatePickertxtTest;
        private General.Controls.GroupBox groupBox6;
        private Controls.SearchContractcsForAll searchContractcsForAll1;
        private General.Lists.RegisterMarkingList registerMarkingList1;

    }
}