namespace RASF.Main.Forms.Settings
{
    partial class AccessUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessUser));
            Janus.Windows.GridEX.GridEXLayout grdUser_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdUser = new RASF.General.Controls.Grid();
            this.userAccesMenuList1 = new RASF.General.Lists.UserAccesMenuList(this.components);
            this.grpAccesUser = new RASF.General.Controls.GroupBox();
            this.treMenu = new Telerik.WinControls.UI.RadTreeView();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAccesUser)).BeginInit();
            this.grpAccesUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpAccesUser);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1068, 607);
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 607);
            this.pnlButton.Size = new System.Drawing.Size(1068, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(755, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 607);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "کاربران";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdUser
            // 
            this.grdUser.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdUser.AlowRetrieveStructure = false;
            this.grdUser.AlternatingColors = true;
            this.grdUser.BuiltInTextsData = resources.GetString("grdUser.BuiltInTextsData");
            this.grdUser.DataSource = this.userAccesMenuList1;
            this.grdUser.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdUser_DesignTimeLayout.LayoutString = resources.GetString("grdUser_DesignTimeLayout.LayoutString");
            this.grdUser.DesignTimeLayout = grdUser_DesignTimeLayout;
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUser.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdUser.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdUser.GroupByBoxVisible = false;
            this.grdUser.Location = new System.Drawing.Point(3, 16);
            this.grdUser.Name = "grdUser";
            this.grdUser.Size = new System.Drawing.Size(307, 588);
            this.grdUser.TabIndex = 0;
            this.grdUser.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdUser.SelectionChanged += new System.EventHandler(this.grdUser_SelectionChanged);
            // 
            // grpAccesUser
            // 
            this.grpAccesUser.Controls.Add(this.treMenu);
            this.grpAccesUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAccesUser.Location = new System.Drawing.Point(0, 0);
            this.grpAccesUser.Name = "grpAccesUser";
            this.grpAccesUser.Size = new System.Drawing.Size(755, 607);
            this.grpAccesUser.TabIndex = 1;
            this.grpAccesUser.Text = "دسترسی کاربران";
            this.grpAccesUser.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // treMenu
            // 
            this.treMenu.CheckBoxes = true;
            this.treMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treMenu.LineStyle = Telerik.WinControls.UI.TreeLineStyle.Solid;
            this.treMenu.Location = new System.Drawing.Point(3, 16);
            this.treMenu.Name = "treMenu";
            this.treMenu.ShowLines = true;
            this.treMenu.Size = new System.Drawing.Size(749, 588);
            this.treMenu.TabIndex = 0;
            this.treMenu.Text = "radTreeView1";
            this.treMenu.ThemeName = "Office2013Light";
            this.treMenu.TriStateMode = true;
            // 
            // AccessUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1068, 637);
            this.Name = "AccessUser";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.Load += new System.EventHandler(this.AccessUser_Load);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAccesUser)).EndInit();
            this.grpAccesUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.GroupBox grpAccesUser;
        private General.Controls.Grid grdUser;
        private Telerik.WinControls.UI.RadTreeView treMenu;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private General.Lists.UserAccesMenuList userAccesMenuList1;
    }
}
