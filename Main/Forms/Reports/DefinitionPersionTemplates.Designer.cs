namespace RASF.Main.Forms.Reports
{
    partial class DefinitionPersionTemplates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinitionPersionTemplates));
            Janus.Windows.GridEX.GridEXLayout grdlaboratory_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdMaster_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdMain_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdTemplate_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splt_Main = new System.Windows.Forms.SplitContainer();
            this.splt_Left = new System.Windows.Forms.SplitContainer();
            this.grp_Lab = new RASF.General.Controls.GroupBox();
            this.grdlaboratory = new RASF.General.Controls.Grid();
            this.laboratoryReportsList1 = new RASF.General.Lists.LaboratoryReportsList(this.components);
            this.grpmaster = new RASF.General.Controls.GroupBox();
            this.grdMaster = new RASF.General.Controls.Grid();
            this.masterTestList1 = new RASF.General.Lists.MasterTestList(this.components);
            this.splt_Top = new System.Windows.Forms.SplitContainer();
            this.grpMain = new RASF.General.Controls.GroupBox();
            this.grdMain = new RASF.General.Controls.Grid();
            this.mainTestList1 = new RASF.General.Lists.MainTestList(this.components);
            this.grpDetail = new RASF.General.Controls.GroupBox();
            this.grdTemplate = new RASF.General.Controls.Grid();
            this.definitionTemplateList1 = new RASF.General.Lists.DefinitionPersianTemplateList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_Main)).BeginInit();
            this.splt_Main.Panel1.SuspendLayout();
            this.splt_Main.Panel2.SuspendLayout();
            this.splt_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_Left)).BeginInit();
            this.splt_Left.Panel1.SuspendLayout();
            this.splt_Left.Panel2.SuspendLayout();
            this.splt_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Lab)).BeginInit();
            this.grp_Lab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdlaboratory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpmaster)).BeginInit();
            this.grpmaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splt_Top)).BeginInit();
            this.splt_Top.Panel1.SuspendLayout();
            this.splt_Top.Panel2.SuspendLayout();
            this.splt_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDetail)).BeginInit();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 444);
            this.pnlButton.Size = new System.Drawing.Size(1284, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(1284, 444);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1079, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1162, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1224, 0);
            // 
            // splt_Main
            // 
            this.splt_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_Main.Location = new System.Drawing.Point(0, 0);
            this.splt_Main.Name = "splt_Main";
            // 
            // splt_Main.Panel1
            // 
            this.splt_Main.Panel1.Controls.Add(this.splt_Left);
            this.splt_Main.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splt_Main.Panel2
            // 
            this.splt_Main.Panel2.Controls.Add(this.splt_Top);
            this.splt_Main.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splt_Main.Size = new System.Drawing.Size(1284, 444);
            this.splt_Main.SplitterDistance = 656;
            this.splt_Main.TabIndex = 2;
            // 
            // splt_Left
            // 
            this.splt_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_Left.Location = new System.Drawing.Point(0, 0);
            this.splt_Left.Name = "splt_Left";
            this.splt_Left.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splt_Left.Panel1
            // 
            this.splt_Left.Panel1.Controls.Add(this.grp_Lab);
            this.splt_Left.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splt_Left.Panel2
            // 
            this.splt_Left.Panel2.Controls.Add(this.grpmaster);
            this.splt_Left.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splt_Left.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splt_Left.Size = new System.Drawing.Size(656, 444);
            this.splt_Left.SplitterDistance = 203;
            this.splt_Left.TabIndex = 0;
            // 
            // grp_Lab
            // 
            this.grp_Lab.Controls.Add(this.grdlaboratory);
            this.grp_Lab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Lab.Location = new System.Drawing.Point(0, 0);
            this.grp_Lab.Name = "grp_Lab";
            this.grp_Lab.Size = new System.Drawing.Size(656, 203);
            this.grp_Lab.TabIndex = 1;
            this.grp_Lab.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdlaboratory
            // 
            this.grdlaboratory.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdlaboratory.AlowRetrieveStructure = false;
            this.grdlaboratory.AlternatingColors = true;
            this.grdlaboratory.BuiltInTextsData = resources.GetString("grdlaboratory.BuiltInTextsData");
            this.grdlaboratory.DataSource = this.laboratoryReportsList1;
            this.grdlaboratory.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdlaboratory_DesignTimeLayout.LayoutString = resources.GetString("grdlaboratory_DesignTimeLayout.LayoutString");
            this.grdlaboratory.DesignTimeLayout = grdlaboratory_DesignTimeLayout;
            this.grdlaboratory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdlaboratory.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdlaboratory.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdlaboratory.GroupByBoxVisible = false;
            this.grdlaboratory.Location = new System.Drawing.Point(3, 8);
            this.grdlaboratory.Name = "grdlaboratory";
            this.grdlaboratory.Size = new System.Drawing.Size(650, 192);
            this.grdlaboratory.TabIndex = 0;
            this.grdlaboratory.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdlaboratory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdlaboratory.SelectionChanged += new System.EventHandler(this.grdlaboratory_SelectionChanged);
            // 
            // grpmaster
            // 
            this.grpmaster.Controls.Add(this.grdMaster);
            this.grpmaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpmaster.Location = new System.Drawing.Point(0, 0);
            this.grpmaster.Name = "grpmaster";
            this.grpmaster.Size = new System.Drawing.Size(656, 237);
            this.grpmaster.TabIndex = 2;
            this.grpmaster.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMaster
            // 
            this.grdMaster.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdMaster.AlowRetrieveStructure = false;
            this.grdMaster.AlternatingColors = true;
            this.grdMaster.BuiltInTextsData = resources.GetString("grdMaster.BuiltInTextsData");
            this.grdMaster.DataSource = this.masterTestList1;
            this.grdMaster.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMaster_DesignTimeLayout.LayoutString = resources.GetString("grdMaster_DesignTimeLayout.LayoutString");
            this.grdMaster.DesignTimeLayout = grdMaster_DesignTimeLayout;
            this.grdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaster.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdMaster.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdMaster.GroupByBoxVisible = false;
            this.grdMaster.Location = new System.Drawing.Point(3, 8);
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.Size = new System.Drawing.Size(650, 226);
            this.grdMaster.TabIndex = 2;
            this.grdMaster.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMaster.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdMaster.SelectionChanged += new System.EventHandler(this.grdMaster_SelectionChanged);
            // 
            // splt_Top
            // 
            this.splt_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_Top.Location = new System.Drawing.Point(0, 0);
            this.splt_Top.Name = "splt_Top";
            this.splt_Top.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splt_Top.Panel1
            // 
            this.splt_Top.Panel1.Controls.Add(this.grpMain);
            this.splt_Top.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splt_Top.Panel2
            // 
            this.splt_Top.Panel2.Controls.Add(this.grpDetail);
            this.splt_Top.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splt_Top.Size = new System.Drawing.Size(624, 444);
            this.splt_Top.SplitterDistance = 199;
            this.splt_Top.TabIndex = 0;
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.grdMain);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.Location = new System.Drawing.Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(624, 199);
            this.grpMain.TabIndex = 3;
            this.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMain
            // 
            this.grdMain.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdMain.AlowRetrieveStructure = false;
            this.grdMain.AlternatingColors = true;
            this.grdMain.BuiltInTextsData = resources.GetString("grdMain.BuiltInTextsData");
            this.grdMain.DataSource = this.mainTestList1;
            this.grdMain.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMain_DesignTimeLayout.LayoutString = resources.GetString("grdMain_DesignTimeLayout.LayoutString");
            this.grdMain.DesignTimeLayout = grdMain_DesignTimeLayout;
            this.grdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdMain.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdMain.GroupByBoxVisible = false;
            this.grdMain.Location = new System.Drawing.Point(3, 8);
            this.grdMain.Name = "grdMain";
            this.grdMain.Size = new System.Drawing.Size(618, 188);
            this.grdMain.TabIndex = 1;
            this.grdMain.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdMain.SelectionChanged += new System.EventHandler(this.grdMain_SelectionChanged);
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.grdTemplate);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Location = new System.Drawing.Point(0, 0);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(624, 241);
            this.grpDetail.TabIndex = 1;
            this.grpDetail.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdTemplate
            // 
            this.grdTemplate.AcceptsEscape = false;
            this.grdTemplate.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdTemplate.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdTemplate.AlowRetrieveStructure = false;
            this.grdTemplate.AlternatingColors = true;
            this.grdTemplate.BuiltInTextsData = resources.GetString("grdTemplate.BuiltInTextsData");
            this.grdTemplate.DataSource = this.definitionTemplateList1;
            this.grdTemplate.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTemplate_DesignTimeLayout.LayoutString = resources.GetString("grdTemplate_DesignTimeLayout.LayoutString");
            this.grdTemplate.DesignTimeLayout = grdTemplate_DesignTimeLayout;
            this.grdTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTemplate.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdTemplate.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdTemplate.GroupByBoxVisible = false;
            this.grdTemplate.Location = new System.Drawing.Point(3, 8);
            this.grdTemplate.Name = "grdTemplate";
            this.grdTemplate.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToAddedRow;
            this.grdTemplate.RecordNavigator = true;
            this.grdTemplate.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical;
            this.grdTemplate.Size = new System.Drawing.Size(618, 230);
            this.grdTemplate.TabIndex = 1;
            this.grdTemplate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTemplate.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdTemplate.ReturnRow += new RASF.General.Events.ReturnRow(this.grdTemplate_ReturnRow);
            this.grdTemplate.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdTemplate_ColumnButtonClick);
            // 
            // DefinitionPersionTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1284, 474);
            this.Controls.Add(this.splt_Main);
            this.Name = "DefinitionPersionTemplates";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LABORATORY_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.splt_Main, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.splt_Main.Panel1.ResumeLayout(false);
            this.splt_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_Main)).EndInit();
            this.splt_Main.ResumeLayout(false);
            this.splt_Left.Panel1.ResumeLayout(false);
            this.splt_Left.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_Left)).EndInit();
            this.splt_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_Lab)).EndInit();
            this.grp_Lab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdlaboratory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpmaster)).EndInit();
            this.grpmaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).EndInit();
            this.splt_Top.Panel1.ResumeLayout(false);
            this.splt_Top.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_Top)).EndInit();
            this.splt_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDetail)).EndInit();
            this.grpDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splt_Main;
        private System.Windows.Forms.SplitContainer splt_Top;
        private System.Windows.Forms.SplitContainer splt_Left;
        private General.Controls.GroupBox grp_Lab;
        private General.Controls.GroupBox grpMain;
        private General.Controls.GroupBox grpmaster;
        private General.Controls.GroupBox grpDetail;
        private General.Controls.Grid grdlaboratory;
        private General.Lists.LaboratoryReportsList laboratoryReportsList1;
        private General.Controls.Grid grdMain;
        private General.Lists.MainTestList mainTestList1;
        private General.Controls.Grid grdMaster;
        private General.Lists.MasterTestList masterTestList1;
        private General.Lists.DefinitionPersianTemplateList definitionTemplateList1;
        private General.Controls.Grid grdTemplate;
    }
}
