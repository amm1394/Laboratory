namespace RASF.Main.Forms.Laboratory
{
    partial class CancelExitForEditReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelExitForEditReport));
            Janus.Windows.GridEX.GridEXLayout grdReports_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdReports = new RASF.General.Controls.Grid();
            this.cancelExitForEditReportList1 = new RASF.General.Lists.CancelExitForEditReportList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 490);
            this.pnlButton.Size = new System.Drawing.Size(813, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(813, 490);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(608, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(691, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(753, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdReports);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "گزارش لغو خروج";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReports
            // 
            this.grdReports.AlowRetrieveStructure = false;
            this.grdReports.AlternatingColors = true;
            this.grdReports.BuiltInTextsData = resources.GetString("grdReports.BuiltInTextsData");
            this.grdReports.DataSource = this.cancelExitForEditReportList1;
            this.grdReports.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReports_DesignTimeLayout.LayoutString = resources.GetString("grdReports_DesignTimeLayout.LayoutString");
            this.grdReports.DesignTimeLayout = grdReports_DesignTimeLayout;
            this.grdReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReports.GroupByBoxVisible = false;
            this.grdReports.Location = new System.Drawing.Point(3, 17);
            this.grdReports.Name = "grdReports";
            this.grdReports.Size = new System.Drawing.Size(807, 470);
            this.grdReports.TabIndex = 0;
            this.grdReports.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReports.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // CancelExitForEditReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(813, 520);
            this.Name = "CancelExitForEditReport";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CancelExitForEditReport_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdReports;
        private General.Lists.CancelExitForEditReportList cancelExitForEditReportList1;
    }
}
