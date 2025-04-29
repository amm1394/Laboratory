namespace RASF.Main.Forms.Reception
{
    partial class EditPiecesName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPiecesName));
            Janus.Windows.GridEX.GridEXLayout grdPartsMaster_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dlgSelectPic = new System.Windows.Forms.OpenFileDialog();
            this.dlgSelectPic2 = new System.Windows.Forms.OpenFileDialog();
            this.partsMasterList1 = new RASF.General.Lists.PartsMasterList(this.components);
            this.yes_NoList1 = new RASF.General.Lists.Yes_NoList(this.components);
            this.yes_NoForDestructList1 = new RASF.General.Lists.Yes_NoForDestructList(this.components);
            this.report = new Stimulsoft.Report.StiReport();
            this.grpParts = new RASF.General.Controls.GroupBox();
            this.grdPartsMaster = new RASF.General.Controls.Grid();
            this.chkPrint = new RASF.General.Controls.CheckBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpParts)).BeginInit();
            this.grpParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.chkPrint);
            this.pnlButton.Location = new System.Drawing.Point(0, 740);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlButton.Size = new System.Drawing.Size(1616, 39);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.chkPrint, 0);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(5, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Size = new System.Drawing.Size(73, 30);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Size = new System.Drawing.Size(68, 30);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpParts);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Size = new System.Drawing.Size(1616, 740);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(8, 8);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Size = new System.Drawing.Size(99, 30);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1342, 0);
            this.pnlUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUpdate.Size = new System.Drawing.Size(111, 39);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1453, 0);
            this.pnlExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlExit.Size = new System.Drawing.Size(83, 39);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1536, 0);
            this.pnlSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSave.Size = new System.Drawing.Size(80, 39);
            // 
            // dlgSelectPic
            // 
            this.dlgSelectPic.DefaultExt = "*.jpg";
            this.dlgSelectPic.Filter = "\"ImageFiles (.jpg)|*.jpg";
            this.dlgSelectPic.Title = "فایل تصویر مورد نظر را انتخاب کنید";
            // 
            // dlgSelectPic2
            // 
            this.dlgSelectPic2.DefaultExt = "*.jpg";
            this.dlgSelectPic2.Filter = "\"ImageFiles (.jpg)|*.jpg";
            this.dlgSelectPic2.Title = "فایل تصویر مورد نظر را انتخاب کنید";
            // 
            // report
            // 
            this.report.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.report.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.report.ReportAlias = "Report";
            this.report.ReportGuid = "3c51ffb0c7c24aa4b2589bfa7ab4d9e6";
            this.report.ReportName = "Report";
            this.report.ReportSource = null;
            this.report.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.report.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.report.UseProgressInThread = false;
            // 
            // grpParts
            // 
            this.grpParts.Controls.Add(this.grdPartsMaster);
            this.grpParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpParts.Location = new System.Drawing.Point(0, 0);
            this.grpParts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpParts.Name = "grpParts";
            this.grpParts.Size = new System.Drawing.Size(1616, 740);
            this.grpParts.TabIndex = 2;
            this.grpParts.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdPartsMaster
            // 
            this.grdPartsMaster.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdPartsMaster.AlowRetrieveStructure = false;
            this.grdPartsMaster.AlternatingColors = true;
            this.grdPartsMaster.BuiltInTextsData = resources.GetString("grdPartsMaster.BuiltInTextsData");
            this.grdPartsMaster.DataSource = this.partsMasterList1;
            this.grdPartsMaster.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdPartsMaster_DesignTimeLayout.LayoutString = resources.GetString("grdPartsMaster_DesignTimeLayout.LayoutString");
            this.grdPartsMaster.DesignTimeLayout = grdPartsMaster_DesignTimeLayout;
            this.grdPartsMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPartsMaster.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdPartsMaster.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdPartsMaster.GroupByBoxVisible = false;
            this.grdPartsMaster.Location = new System.Drawing.Point(3, 8);
            this.grdPartsMaster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdPartsMaster.Name = "grdPartsMaster";
            this.grdPartsMaster.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndStayInCurrentCell;
            this.grdPartsMaster.Size = new System.Drawing.Size(1610, 729);
            this.grdPartsMaster.TabIndex = 1;
            this.grdPartsMaster.TabStop = false;
            this.grdPartsMaster.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdPartsMaster.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdPartsMaster.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdPartsMaster_ColumnButtonClick);
            // 
            // chkPrint
            // 
            this.chkPrint.Checked = true;
            this.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkPrint.Location = new System.Drawing.Point(1203, 0);
            this.chkPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(139, 39);
            this.chkPrint.TabIndex = 6;
            this.chkPrint.Text = "چاپ برگه هزینه";
            this.chkPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // EditPiecesName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1616, 779);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditPiecesName";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.EditPiecesName_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpParts)).EndInit();
            this.grpParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgSelectPic;
        private System.Windows.Forms.OpenFileDialog dlgSelectPic2;
        protected General.Lists.PartsMasterList partsMasterList1;
        private General.Lists.Yes_NoList yes_NoList1;
        private General.Lists.Yes_NoForDestructList yes_NoForDestructList1;
        private Stimulsoft.Report.StiReport report;
        private General.Controls.GroupBox grpParts;
        protected General.Controls.Grid grdPartsMaster;
        private General.Controls.CheckBox chkPrint;
    }
}
