namespace RASF.Main.Forms.Reception
{
    partial class BillsOfSales
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
            Janus.Windows.GridEX.GridEXLayout grdEditContract_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsOfSales));
            this.Report2 = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.grdEditContract)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEditContract
            // 
            grdEditContract_DesignTimeLayout.LayoutString = resources.GetString("grdEditContract_DesignTimeLayout.LayoutString");
            this.grdEditContract.DesignTimeLayout = grdEditContract_DesignTimeLayout;
            this.grdEditContract.Size = new System.Drawing.Size(854, 497);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(854, 497);
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 497);
            this.pnlButton.Size = new System.Drawing.Size(854, 30);
            // 
            // Report2
            // 
            this.Report2.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Report2.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.Report2.ReportAlias = "Report";
            this.Report2.ReportGuid = "3c51ffb0c7c24aa4b2589bfa7ab4d9e6";
            this.Report2.ReportName = "Report";
            this.Report2.ReportSource = null;
            this.Report2.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.Report2.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.Report2.UseProgressInThread = false;
            this.Report2.Printed += new System.EventHandler(this.Report2_Printed);
            // 
            // BillsOfSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 527);
            this.Name = "BillsOfSales";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.Text = "BillsOfSales";
            //this.Load += new System.EventHandler(this.BillsOfSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEditContract)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Stimulsoft.Report.StiReport Report2;
    }
}