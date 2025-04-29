namespace RASF.Main.Controls.Reception
{
    partial class Test_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_Control));
            Janus.Windows.GridEX.GridEXLayout grdMaster_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.pnlGrid = new RASF.General.Controls.Panel();
            this.grdMaster = new RASF.General.Controls.Grid();
            this.masterTestStatusList1 = new RASF.General.Lists.MasterTestStatusList(this.components);
            this.pnlDone = new RASF.General.Controls.Panel();
            this.labBonyad = new RASF.General.Controls.Label();
            this.pnlUnderWay = new RASF.General.Controls.Panel();
            this.btnUnderway = new RASF.General.Controls.Save_Button();
            this.pnlTextName = new RASF.General.Controls.Panel();
            this.chkTestName = new RASF.General.Controls.CheckBox();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).BeginInit();
            this.pnlDone.SuspendLayout();
            this.pnlUnderWay.SuspendLayout();
            this.pnlTextName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grdMaster);
            this.pnlGrid.Controls.Add(this.pnlDone);
            this.pnlGrid.Controls.Add(this.pnlUnderWay);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlGrid.Size = new System.Drawing.Size(465, 100);
            this.pnlGrid.TabIndex = 1;
            // 
            // grdMaster
            // 
            this.grdMaster.AlowRetrieveStructure = false;
            this.grdMaster.AlternatingColors = true;
            this.grdMaster.BuiltInTextsData = resources.GetString("grdMaster.BuiltInTextsData");
            this.grdMaster.DataSource = this.masterTestStatusList1;
            this.grdMaster.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMaster_DesignTimeLayout.LayoutString = resources.GetString("grdMaster_DesignTimeLayout.LayoutString");
            this.grdMaster.DesignTimeLayout = grdMaster_DesignTimeLayout;
            this.grdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaster.GroupByBoxVisible = false;
            this.grdMaster.Location = new System.Drawing.Point(192, 0);
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.Size = new System.Drawing.Size(273, 100);
            this.grdMaster.TabIndex = 4;
            this.grdMaster.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMaster.UpdatingCell += new Janus.Windows.GridEX.UpdatingCellEventHandler(this.grdMaster_UpdatingCell);
            // 
            // pnlDone
            // 
            this.pnlDone.Controls.Add(this.labBonyad);
            this.pnlDone.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDone.Location = new System.Drawing.Point(90, 0);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(102, 100);
            this.pnlDone.TabIndex = 3;
            // 
            // labBonyad
            // 
            this.labBonyad.AutoSize = true;
            this.labBonyad.Location = new System.Drawing.Point(7, 46);
            this.labBonyad.Name = "labBonyad";
            this.labBonyad.Size = new System.Drawing.Size(91, 13);
            this.labBonyad.TabIndex = 1;
            this.labBonyad.Text = "قابل انجام در بنیاد";
            // 
            // pnlUnderWay
            // 
            this.pnlUnderWay.Controls.Add(this.btnUnderway);
            this.pnlUnderWay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUnderWay.Location = new System.Drawing.Point(0, 0);
            this.pnlUnderWay.Name = "pnlUnderWay";
            this.pnlUnderWay.Size = new System.Drawing.Size(90, 100);
            this.pnlUnderWay.TabIndex = 2;
            // 
            // btnUnderway
            // 
            this.btnUnderway.Location = new System.Drawing.Point(7, 41);
            this.btnUnderway.Name = "btnUnderway";
            this.btnUnderway.Size = new System.Drawing.Size(77, 23);
            this.btnUnderway.TabIndex = 1;
            this.btnUnderway.Text = "در دست انجام";
            this.btnUnderway.Visible = false;
            this.btnUnderway.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // pnlTextName
            // 
            this.pnlTextName.Controls.Add(this.chkTestName);
            this.pnlTextName.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTextName.Location = new System.Drawing.Point(465, 0);
            this.pnlTextName.Name = "pnlTextName";
            this.pnlTextName.Size = new System.Drawing.Size(150, 100);
            this.pnlTextName.TabIndex = 0;
            // 
            // chkTestName
            // 
            this.chkTestName.Location = new System.Drawing.Point(2, 41);
            this.chkTestName.Name = "chkTestName";
            this.chkTestName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkTestName.Size = new System.Drawing.Size(146, 22);
            this.chkTestName.TabIndex = 1;
            this.chkTestName.Text = "Test_Name";
            this.chkTestName.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.chkTestName.CheckedChanged += new System.EventHandler(this.chkTestName_CheckedChanged);
            // 
            // Test_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlTextName);
            this.Name = "Test_Control";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(615, 100);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).EndInit();
            this.pnlDone.ResumeLayout(false);
            this.pnlDone.PerformLayout();
            this.pnlUnderWay.ResumeLayout(false);
            this.pnlTextName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Panel pnlTextName;
        private RASF.General.Controls.Panel pnlGrid;
        private RASF.General.Controls.Panel pnlUnderWay;
        private RASF.General.Controls.Panel pnlDone;
        private RASF.General.Controls.Save_Button btnUnderway;
        private RASF.General.Controls.CheckBox chkTestName;
        private RASF.General.Controls.Grid grdMaster;
        private General.Lists.MasterTestStatusList masterTestStatusList1;
        private General.Controls.Label labBonyad;
    }
}
