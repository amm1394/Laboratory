namespace RASF.Main.Forms.Base
{
    partial class ViewTarrif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTarrif));
            Janus.Windows.GridEX.GridEXLayout grdview_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdComonTarif_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.viewTarrifList1 = new RASF.General.Lists.ViewTarrifList(this.components);
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdview = new RASF.General.Controls.Grid();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdComonTarif = new RASF.General.Controls.Grid();
            this.viewTarrifList2 = new RASF.General.Lists.ViewTarrifList(this.components);
            this.grpFind = new RASF.General.Controls.GroupBox();
            this.labEmail = new RASF.General.Controls.Label();
            this.txtEmail = new RASF.General.Controls.TextBox();
            this.Report2 = new Stimulsoft.Report.StiReport();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdview)).BeginInit();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComonTarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).BeginInit();
            this.grpFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 485);
            this.pnlButton.Size = new System.Drawing.Size(894, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(894, 485);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Text = "ارسال به مشتری";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(689, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(772, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(834, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(894, 485);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox1);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(890, 461);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "مشاهده تعرفه ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdview);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "مشاهده تعرفه";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdview
            // 
            this.grdview.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdview.AlowRetrieveStructure = false;
            this.grdview.AlternatingColors = true;
            this.grdview.BuiltInTextsData = resources.GetString("grdview.BuiltInTextsData");
            this.grdview.DataSource = this.viewTarrifList1;
            this.grdview.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdview_DesignTimeLayout.LayoutString = resources.GetString("grdview_DesignTimeLayout.LayoutString");
            this.grdview.DesignTimeLayout = grdview_DesignTimeLayout;
            this.grdview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdview.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdview.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdview.GroupByBoxVisible = false;
            this.grdview.Location = new System.Drawing.Point(3, 17);
            this.grdview.Name = "grdview";
            this.grdview.Size = new System.Drawing.Size(884, 441);
            this.grdview.TabIndex = 0;
            this.grdview.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdview.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox2);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(890, 461);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "تعرفه های پرکاربرد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdComonTarif);
            this.groupBox2.Controls.Add(this.grpFind);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 461);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdComonTarif
            // 
            this.grdComonTarif.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdComonTarif.AlowRetrieveStructure = false;
            this.grdComonTarif.AlternatingColors = true;
            this.grdComonTarif.BuiltInTextsData = resources.GetString("grdComonTarif.BuiltInTextsData");
            this.grdComonTarif.DataSource = this.viewTarrifList2;
            this.grdComonTarif.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdComonTarif_DesignTimeLayout.LayoutString = resources.GetString("grdComonTarif_DesignTimeLayout.LayoutString");
            this.grdComonTarif.DesignTimeLayout = grdComonTarif_DesignTimeLayout;
            this.grdComonTarif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdComonTarif.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdComonTarif.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdComonTarif.GroupByBoxVisible = false;
            this.grdComonTarif.Location = new System.Drawing.Point(3, 59);
            this.grdComonTarif.Name = "grdComonTarif";
            this.grdComonTarif.Size = new System.Drawing.Size(884, 399);
            this.grdComonTarif.TabIndex = 0;
            this.grdComonTarif.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdComonTarif.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.labEmail);
            this.grpFind.Controls.Add(this.txtEmail);
            this.grpFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFind.Location = new System.Drawing.Point(3, 8);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(884, 51);
            this.grpFind.TabIndex = 6;
            this.grpFind.Text = "ایمیل مشتری";
            this.grpFind.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(1051, 50);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(36, 13);
            this.labEmail.TabIndex = 3;
            this.labEmail.Text = "ایمیل:";
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(3, 17);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(878, 21);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
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
            // ViewTarrif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(894, 515);
            this.Name = "ViewTarrif";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "مشاهده تعرفه(فرم 2)";
            this.Load += new System.EventHandler(this.ViewTarrif_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdview)).EndInit();
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdComonTarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).EndInit();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.ViewTarrifList viewTarrifList1;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdview;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdComonTarif;
        private General.Lists.ViewTarrifList viewTarrifList2;
        private General.Controls.GroupBox grpFind;
        private General.Controls.Label labEmail;
        private General.Controls.TextBox txtEmail;
        private Stimulsoft.Report.StiReport Report2;
    }
}
