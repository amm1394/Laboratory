namespace RASF.Main.Forms.Harmony
{
    partial class TestForThePresenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForThePresenceForm));
            Janus.Windows.GridEX.GridEXLayout grdTest_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdTest = new RASF.General.Controls.Grid();
            this.testForThePresenceList1 = new RASF.General.Lists.TestForThePresenceList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 596);
            this.pnlButton.Size = new System.Drawing.Size(1136, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdTest);
            this.pnlContent.Size = new System.Drawing.Size(1136, 596);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(931, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1014, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1076, 0);
            // 
            // grdTest
            // 
            this.grdTest.AlowRetrieveStructure = false;
            this.grdTest.AlternatingColors = true;
            this.grdTest.BuiltInTextsData = resources.GetString("grdTest.BuiltInTextsData");
            this.grdTest.DataSource = this.testForThePresenceList1;
            this.grdTest.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTest_DesignTimeLayout.LayoutString = resources.GetString("grdTest_DesignTimeLayout.LayoutString");
            this.grdTest.DesignTimeLayout = grdTest_DesignTimeLayout;
            this.grdTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTest.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdTest.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdTest.GroupByBoxVisible = false;
            this.grdTest.Location = new System.Drawing.Point(0, 0);
            this.grdTest.Name = "grdTest";
            this.grdTest.RecordNavigator = true;
            this.grdTest.Size = new System.Drawing.Size(1136, 596);
            this.grdTest.TabIndex = 0;
            this.grdTest.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdTest.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdTest_ColumnButtonClick);
            // 
            // TestForThePresenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1136, 626);
            this.Name = "TestForThePresenceForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.TestForThePresenceForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdTest;
        private General.Lists.TestForThePresenceList testForThePresenceList1;
    }
}
