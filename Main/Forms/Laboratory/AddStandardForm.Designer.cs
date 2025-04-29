namespace RASF.Main.Forms.Laboratory
{
    partial class AddStandardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStandardForm));
            Janus.Windows.GridEX.GridEXLayout grdBase_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdName_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdData_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpBase = new RASF.General.Controls.GroupBox();
            this.grdBase = new RASF.General.Controls.Grid();
            this.standard_BaseList1 = new RASF.General.Lists.Standard_BaseList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grpName = new RASF.General.Controls.GroupBox();
            this.grdName = new RASF.General.Controls.Grid();
            this.standard_NamesList1 = new RASF.General.Lists.Standard_NamesList(this.components);
            this.grpData = new RASF.General.Controls.GroupBox();
            this.grdData = new RASF.General.Controls.Grid();
            this.standard_DataList1 = new RASF.General.Lists.Standard_DataList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpBase)).BeginInit();
            this.grpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpName)).BeginInit();
            this.grpName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpData)).BeginInit();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 561);
            this.pnlButton.Size = new System.Drawing.Size(926, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Size = new System.Drawing.Size(926, 561);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(721, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(804, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(866, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpBase);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(926, 561);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpBase
            // 
            this.grpBase.Controls.Add(this.grdBase);
            this.grpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBase.Location = new System.Drawing.Point(0, 0);
            this.grpBase.Name = "grpBase";
            this.grpBase.Size = new System.Drawing.Size(324, 561);
            this.grpBase.TabIndex = 0;
            this.grpBase.Text = "پایه استاندارد";
            this.grpBase.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdBase
            // 
            this.grdBase.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdBase.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdBase.AlowRetrieveStructure = false;
            this.grdBase.AlternatingColors = true;
            this.grdBase.BuiltInTextsData = resources.GetString("grdBase.BuiltInTextsData");
            this.grdBase.DataSource = this.standard_BaseList1;
            this.grdBase.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBase_DesignTimeLayout.LayoutString = resources.GetString("grdBase_DesignTimeLayout.LayoutString");
            this.grdBase.DesignTimeLayout = grdBase_DesignTimeLayout;
            this.grdBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBase.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdBase.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdBase.GroupByBoxVisible = false;
            this.grdBase.Location = new System.Drawing.Point(3, 17);
            this.grdBase.Name = "grdBase";
            this.grdBase.Size = new System.Drawing.Size(318, 541);
            this.grdBase.TabIndex = 0;
            this.grdBase.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBase.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdBase.SelectionChanged += new System.EventHandler(this.grdBase_SelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpName);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grpData);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(598, 561);
            this.splitContainer2.SplitterDistance = 319;
            this.splitContainer2.TabIndex = 0;
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.grdName);
            this.grpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpName.Location = new System.Drawing.Point(0, 0);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(319, 561);
            this.grpName.TabIndex = 1;
            this.grpName.Text = "نام استاندارد";
            this.grpName.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdName
            // 
            this.grdName.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdName.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdName.AlowRetrieveStructure = false;
            this.grdName.AlternatingColors = true;
            this.grdName.BuiltInTextsData = resources.GetString("grdName.BuiltInTextsData");
            this.grdName.DataSource = this.standard_NamesList1;
            this.grdName.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdName_DesignTimeLayout.LayoutString = resources.GetString("grdName_DesignTimeLayout.LayoutString");
            this.grdName.DesignTimeLayout = grdName_DesignTimeLayout;
            this.grdName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdName.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdName.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdName.GroupByBoxVisible = false;
            this.grdName.Location = new System.Drawing.Point(3, 17);
            this.grdName.Name = "grdName";
            this.grdName.Size = new System.Drawing.Size(313, 541);
            this.grdName.TabIndex = 1;
            this.grdName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdName.SelectionChanged += new System.EventHandler(this.grdName_SelectionChanged);
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.grdData);
            this.grpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpData.Location = new System.Drawing.Point(0, 0);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(275, 561);
            this.grpData.TabIndex = 1;
            this.grpData.Text = "دیتا استاندارد";
            this.grpData.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdData
            // 
            this.grdData.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdData.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdData.AlowRetrieveStructure = false;
            this.grdData.AlternatingColors = true;
            this.grdData.BuiltInTextsData = resources.GetString("grdData.BuiltInTextsData");
            this.grdData.DataSource = this.standard_DataList1;
            this.grdData.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdData_DesignTimeLayout.LayoutString = resources.GetString("grdData_DesignTimeLayout.LayoutString");
            this.grdData.DesignTimeLayout = grdData_DesignTimeLayout;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdData.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdData.GroupByBoxVisible = false;
            this.grdData.Location = new System.Drawing.Point(3, 17);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(269, 541);
            this.grdData.TabIndex = 1;
            this.grdData.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdData.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // AddStandardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(926, 591);
            this.Name = "AddStandardForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.AddStandardForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpBase)).EndInit();
            this.grpBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBase)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpName)).EndInit();
            this.grpName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpData)).EndInit();
            this.grpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox grpBase;
        private General.Controls.Grid grdBase;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private General.Controls.GroupBox grpName;
        private General.Controls.Grid grdName;
        private General.Controls.GroupBox grpData;
        private General.Controls.Grid grdData;
        private General.Lists.Standard_NamesList standard_NamesList1;
        private General.Lists.Standard_BaseList standard_BaseList1;
        private General.Lists.Standard_DataList standard_DataList1;
    }
}
