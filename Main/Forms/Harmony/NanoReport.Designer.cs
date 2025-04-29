namespace RASF.Main.Forms.Harmony
{
    partial class NanoReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NanoReport));
            Janus.Windows.GridEX.GridEXLayout grdNano_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdNano = new RASF.General.Controls.Grid();
            this.nanoReportsList1 = new RASF.General.Lists.NanoReportsList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 542);
            this.pnlButton.Size = new System.Drawing.Size(851, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(851, 542);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(646, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(729, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(791, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdNano);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "گزارش نانو";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdNano
            // 
            this.grdNano.AlowRetrieveStructure = false;
            this.grdNano.AlternatingColors = true;
            this.grdNano.BuiltInTextsData = resources.GetString("grdNano.BuiltInTextsData");
            this.grdNano.DataSource = this.nanoReportsList1;
            this.grdNano.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdNano_DesignTimeLayout.LayoutString = resources.GetString("grdNano_DesignTimeLayout.LayoutString");
            this.grdNano.DesignTimeLayout = grdNano_DesignTimeLayout;
            this.grdNano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNano.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdNano.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdNano.GroupByBoxVisible = false;
            this.grdNano.Location = new System.Drawing.Point(3, 17);
            this.grdNano.Name = "grdNano";
            this.grdNano.RecordNavigator = true;
            this.grdNano.Size = new System.Drawing.Size(845, 476);
            this.grdNano.TabIndex = 0;
            this.grdNano.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdNano.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pickDate1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 46);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.Text = "تاریخ صورت حساب";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(424, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // NanoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(851, 572);
            this.Name = "NanoReport";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Grid grdNano;
        private RASF.General.Controls.GroupBox groupBox2;
        private RASF.Main.Controls.PickDate.PickDate pickDate1;
        private RASF.General.Lists.NanoReportsList nanoReportsList1;
    }
}
