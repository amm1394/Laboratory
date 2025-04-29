namespace RASF.Main.Forms.Harmony
{
    partial class RequestOfContractorDoesnotSendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestOfContractorDoesnotSendForm));
            Janus.Windows.GridEX.GridEXLayout grdRequest_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpRequest = new RASF.General.Controls.GroupBox();
            this.grdRequest = new RASF.General.Controls.Grid();
            this.requestOfContractorDoesnotSendList1 = new RASF.General.Lists.RequestOfContractorDoesnotSendList(this.components);
            this.RequestOfContractor = new Stimulsoft.Report.StiReport();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpRequest)).BeginInit();
            this.grpRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 532);
            this.pnlButton.Size = new System.Drawing.Size(1102, 30);
            // 
            // btnSave
            // 
            this.btnSave.Text = "چاپ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpRequest);
            this.pnlContent.Size = new System.Drawing.Size(1102, 532);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(895, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(980, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1042, 0);
            // 
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.grdRequest);
            this.grpRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRequest.Location = new System.Drawing.Point(0, 0);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(1102, 532);
            this.grpRequest.TabIndex = 0;
            this.grpRequest.Text = "درخواست های ارسال نشده";
            this.grpRequest.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdRequest
            // 
            this.grdRequest.AlowRetrieveStructure = false;
            this.grdRequest.AlternatingColors = true;
            this.grdRequest.BuiltInTextsData = resources.GetString("grdRequest.BuiltInTextsData");
            this.grdRequest.DataSource = this.requestOfContractorDoesnotSendList1;
            this.grdRequest.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdRequest_DesignTimeLayout.LayoutString = resources.GetString("grdRequest_DesignTimeLayout.LayoutString");
            this.grdRequest.DesignTimeLayout = grdRequest_DesignTimeLayout;
            this.grdRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRequest.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdRequest.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdRequest.GroupByBoxVisible = false;
            this.grdRequest.Hierarchical = true;
            this.grdRequest.Location = new System.Drawing.Point(3, 17);
            this.grdRequest.Name = "grdRequest";
            this.grdRequest.Size = new System.Drawing.Size(1096, 512);
            this.grdRequest.TabIndex = 0;
            this.grdRequest.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdRequest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // RequestOfContractor
            // 
            this.RequestOfContractor.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.RequestOfContractor.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.RequestOfContractor.ReportAlias = "Report";
            this.RequestOfContractor.ReportGuid = "3c51ffb0c7c24aa4b2589bfa7ab4d9e6";
            this.RequestOfContractor.ReportName = "Report";
            this.RequestOfContractor.ReportSource = null;
            this.RequestOfContractor.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.RequestOfContractor.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.RequestOfContractor.UseProgressInThread = false;
            // 
            // RequestOfContractorDoesnotSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 562);
            this.Name = "RequestOfContractorDoesnotSendForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "RequestOfContractorDoesnotSendForm";
            this.Load += new System.EventHandler(this.RequestOfContractorDoesnotSendForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpRequest)).EndInit();
            this.grpRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpRequest;
        private General.Controls.Grid grdRequest;
        private General.Lists.RequestOfContractorDoesnotSendList requestOfContractorDoesnotSendList1;
        protected Stimulsoft.Report.StiReport RequestOfContractor;
    }
}