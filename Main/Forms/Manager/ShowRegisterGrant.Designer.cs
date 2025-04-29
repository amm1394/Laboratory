namespace RASF.Main.Forms.Manager
{
    partial class ShowRegisterGrant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowRegisterGrant));
            Janus.Windows.GridEX.GridEXLayout grdGrant_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdGrant = new RASF.General.Controls.Grid();
            this.viewGrantList1 = new RASF.General.Lists.ViewGrantList(this.components);
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 496);
            this.pnlButton.Size = new System.Drawing.Size(791, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(791, 496);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(586, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(669, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(731, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdGrant);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdGrant
            // 
            this.grdGrant.AlowRetrieveStructure = false;
            this.grdGrant.AlternatingColors = true;
            this.grdGrant.BuiltInTextsData = resources.GetString("grdGrant.BuiltInTextsData");
            this.grdGrant.DataSource = this.viewGrantList1;
            this.grdGrant.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdGrant_DesignTimeLayout.LayoutString = resources.GetString("grdGrant_DesignTimeLayout.LayoutString");
            this.grdGrant.DesignTimeLayout = grdGrant_DesignTimeLayout;
            this.grdGrant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGrant.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdGrant.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdGrant.GroupByBoxVisible = false;
            this.grdGrant.Location = new System.Drawing.Point(3, 8);
            this.grdGrant.Name = "grdGrant";
            this.grdGrant.Size = new System.Drawing.Size(781, 461);
            this.grdGrant.TabIndex = 0;
            this.grdGrant.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdGrant.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdGrant.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(791, 496);
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
            this.uiTabPage1.Size = new System.Drawing.Size(787, 472);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "گرنت";
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(787, 472);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "بیمه";
            // 
            // ShowRegisterGrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 526);
            this.Name = "ShowRegisterGrant";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ShowRegisterGrant";
            this.Load += new System.EventHandler(this.ShowRegisterGrant_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGrant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdGrant;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Lists.ViewGrantList viewGrantList1;
    }
}