namespace RASF.Main.Forms.Harmony
{
    partial class EmailMonthlyBillShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailMonthlyBillShow));
            Janus.Windows.GridEX.GridEXLayout grdEmail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdEmail = new RASF.General.Controls.Grid();
            this.emailMonthlyBillShowList1 = new RASF.General.Lists.EmailMonthlyBillShowList(this.components);
            this.Report2 = new Stimulsoft.Report.StiReport();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 552);
            this.pnlButton.Size = new System.Drawing.Size(641, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(641, 552);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(436, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(519, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(581, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "محدوده زمانی تاریخ صورت حساب های صادر شده";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(214, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 40);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdEmail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 492);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdEmail
            // 
            this.grdEmail.AlowRetrieveStructure = false;
            this.grdEmail.AlternatingColors = true;
            this.grdEmail.BuiltInTextsData = resources.GetString("grdEmail.BuiltInTextsData");
            this.grdEmail.DataSource = this.emailMonthlyBillShowList1;
            this.grdEmail.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdEmail_DesignTimeLayout.LayoutString = resources.GetString("grdEmail_DesignTimeLayout.LayoutString");
            this.grdEmail.DesignTimeLayout = grdEmail_DesignTimeLayout;
            this.grdEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEmail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdEmail.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdEmail.GroupByBoxVisible = false;
            this.grdEmail.Location = new System.Drawing.Point(3, 8);
            this.grdEmail.Name = "grdEmail";
            this.grdEmail.Size = new System.Drawing.Size(635, 481);
            this.grdEmail.TabIndex = 0;
            this.grdEmail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdEmail.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdEmail_ColumnButtonClick);
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
            // 
            // EmailMonthlyBillShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(641, 582);
            this.Name = "EmailMonthlyBillShow";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.EmailMonthlyBillShow_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox2;
        private RASF.General.Controls.Grid grdEmail;
        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.Main.Controls.PickDate.PickDate pickDate1;
        private RASF.General.Lists.EmailMonthlyBillShowList emailMonthlyBillShowList1;
        private Stimulsoft.Report.StiReport Report2;
    }
}
