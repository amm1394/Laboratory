namespace RASF.Main.Forms.Base
{
    partial class InspectCompany
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
            Janus.Windows.GridEX.GridEXLayout grdInspect_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectCompany));
            Janus.Windows.GridEX.GridEXLayout grdInspector_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpInspect = new RASF.General.Controls.GroupBox();
            this.grdInspect = new RASF.General.Controls.Grid();
            this.companyOfInspectList1 = new RASF.General.Lists.CompanyOfInspectList(this.components);
            this.grpInspector = new RASF.General.Controls.GroupBox();
            this.grdInspector = new RASF.General.Controls.Grid();
            this.inspectorList1 = new RASF.General.Lists.InspectorList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInspect)).BeginInit();
            this.grpInspect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInspect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInspector)).BeginInit();
            this.grpInspector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInspector)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 559);
            this.pnlButton.Size = new System.Drawing.Size(858, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpInspector);
            this.pnlContent.Controls.Add(this.grpInspect);
            this.pnlContent.Size = new System.Drawing.Size(858, 559);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(653, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(736, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(798, 0);
            // 
            // grpInspect
            // 
            this.grpInspect.Controls.Add(this.grdInspect);
            this.grpInspect.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpInspect.Location = new System.Drawing.Point(517, 0);
            this.grpInspect.Name = "grpInspect";
            this.grpInspect.Size = new System.Drawing.Size(341, 559);
            this.grpInspect.TabIndex = 0;
            this.grpInspect.Text = "شرکت های بازرسی";
            this.grpInspect.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdInspect
            // 
            this.grdInspect.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdInspect.AlowRetrieveStructure = false;
            this.grdInspect.AlternatingColors = true;
            this.grdInspect.BuiltInTextsData = resources.GetString("grdInspect.BuiltInTextsData");
            this.grdInspect.DataSource = this.companyOfInspectList1;
            this.grdInspect.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdInspect_DesignTimeLayout.LayoutString = resources.GetString("grdInspect_DesignTimeLayout.LayoutString");
            this.grdInspect.DesignTimeLayout = grdInspect_DesignTimeLayout;
            this.grdInspect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdInspect.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdInspect.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdInspect.GroupByBoxVisible = false;
            this.grdInspect.Location = new System.Drawing.Point(3, 17);
            this.grdInspect.Name = "grdInspect";
            this.grdInspect.Size = new System.Drawing.Size(335, 539);
            this.grdInspect.TabIndex = 0;
            this.grdInspect.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdInspect.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdInspect.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdInspect_ColumnButtonClick);
            this.grdInspect.SelectionChanged += new System.EventHandler(this.grdInspect_SelectionChanged);
            // 
            // grpInspector
            // 
            this.grpInspector.Controls.Add(this.grdInspector);
            this.grpInspector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInspector.Location = new System.Drawing.Point(0, 0);
            this.grpInspector.Name = "grpInspector";
            this.grpInspector.Size = new System.Drawing.Size(517, 559);
            this.grpInspector.TabIndex = 1;
            this.grpInspector.Text = "کارشناسان بازرسی";
            this.grpInspector.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdInspector
            // 
            this.grdInspector.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdInspector.AlowRetrieveStructure = false;
            this.grdInspector.AlternatingColors = true;
            this.grdInspector.BuiltInTextsData = resources.GetString("grdInspector.BuiltInTextsData");
            this.grdInspector.DataSource = this.inspectorList1;
            this.grdInspector.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdInspector_DesignTimeLayout.LayoutString = resources.GetString("grdInspector_DesignTimeLayout.LayoutString");
            this.grdInspector.DesignTimeLayout = grdInspector_DesignTimeLayout;
            this.grdInspector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdInspector.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdInspector.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdInspector.GroupByBoxVisible = false;
            this.grdInspector.Location = new System.Drawing.Point(3, 17);
            this.grdInspector.Name = "grdInspector";
            this.grdInspector.Size = new System.Drawing.Size(511, 539);
            this.grdInspector.TabIndex = 0;
            this.grdInspector.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdInspector.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdInspector.SelectionChanged += new System.EventHandler(this.grdInspector_SelectionChanged);
            // 
            // InspectCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(858, 589);
            this.Name = "InspectCompany";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.InspectCompany_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpInspect)).EndInit();
            this.grpInspect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInspect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInspector)).EndInit();
            this.grpInspector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInspector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpInspect;
        private General.Controls.Grid grdInspect;
        private General.Lists.CompanyOfInspectList companyOfInspectList1;
        private General.Controls.GroupBox grpInspector;
        private General.Controls.Grid grdInspector;
        private General.Lists.InspectorList inspectorList1;
    }
}
