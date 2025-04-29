namespace RASF.Main.Forms.Secretariat
{
    partial class SendLettersForDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendLettersForDelete));
            Janus.Windows.GridEX.GridEXLayout grdReports_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.sendLettersReportList1 = new RASF.General.Lists.SendLettersReportList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdReports = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 500);
            this.pnlButton.Size = new System.Drawing.Size(1103, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(1103, 500);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(898, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(981, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1043, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdReports);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1103, 500);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.Text = "نامه های ارسالی";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReports
            // 
            this.grdReports.AlowRetrieveStructure = false;
            this.grdReports.AlternatingColors = true;
            this.grdReports.BuiltInTextsData = resources.GetString("grdReports.BuiltInTextsData");
            this.grdReports.DataSource = this.sendLettersReportList1;
            this.grdReports.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReports_DesignTimeLayout.LayoutString = resources.GetString("grdReports_DesignTimeLayout.LayoutString");
            this.grdReports.DesignTimeLayout = grdReports_DesignTimeLayout;
            this.grdReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReports.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReports.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReports.GroupByBoxVisible = false;
            this.grdReports.Location = new System.Drawing.Point(3, 17);
            this.grdReports.Name = "grdReports";
            this.grdReports.RecordNavigator = true;
            this.grdReports.Size = new System.Drawing.Size(1097, 480);
            this.grdReports.TabIndex = 0;
            this.grdReports.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReports.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdReports.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdReports_ColumnButtonClick);
            // 
            // SendLettersForDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 530);
            this.Name = "SendLettersForDelete";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "SendLettersReport";
            this.Load += new System.EventHandler(this.SendLettersReport_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.SendLettersReportList sendLettersReportList1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdReports;
    }
}