namespace RASF.Main.Forms.Dash
{
    partial class ReportMounthlyLaboratory
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
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 561);
            this.pnlButton.Size = new System.Drawing.Size(1039, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.dashboardViewer1);
            this.pnlContent.Size = new System.Drawing.Size(1039, 561);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1962, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(917, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(979, 0);
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.CustomDBSchemaProviderEx = null;
            this.dashboardViewer1.DashboardSource = new System.Uri("D:\\Users\\knabavi\\Source\\Workspaces\\Laboratory\\Main\\Dashboard\\ReportMounthlyLabora" +
        "tory.xml", System.UriKind.Absolute);
            this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.Size = new System.Drawing.Size(1039, 561);
            this.dashboardViewer1.TabIndex = 0;
            this.dashboardViewer1.DashboardLoaded += new DevExpress.DashboardWin.DashboardLoadedEventHandler(this.dashboardViewer1_DashboardLoaded);
            // 
            // ReportMounthlyLaboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1039, 591);
            this.Name = "ReportMounthlyLaboratory";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ReportMounthlyLaboratory_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
    }
}
