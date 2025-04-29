namespace RASF.Main.Forms.Settings
{
    partial class RelationBetweenExecuterAndUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelationBetweenExecuterAndUsers));
            Janus.Windows.GridEX.GridEXLayout grdExecuters_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdUser_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpLaboratory = new RASF.General.Controls.GroupBox();
            this.grdExecuters = new RASF.General.Controls.Grid();
            this.executersList1 = new RASF.General.Lists.ExecutersList(this.components);
            this.grpUser = new RASF.General.Controls.GroupBox();
            this.grdUser = new RASF.General.Controls.Grid();
            this.findUsersLaboratoryList1 = new RASF.General.Lists.FindUsersLaboratoryList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpLaboratory)).BeginInit();
            this.grpLaboratory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExecuters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).BeginInit();
            this.grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 525);
            this.pnlButton.Size = new System.Drawing.Size(813, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Size = new System.Drawing.Size(813, 525);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(608, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(691, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(753, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpLaboratory);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpUser);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(813, 525);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpLaboratory
            // 
            this.grpLaboratory.Controls.Add(this.grdExecuters);
            this.grpLaboratory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLaboratory.Location = new System.Drawing.Point(0, 0);
            this.grpLaboratory.Name = "grpLaboratory";
            this.grpLaboratory.Size = new System.Drawing.Size(401, 525);
            this.grpLaboratory.TabIndex = 0;
            this.grpLaboratory.Text = "مسئولین اجرایی";
            this.grpLaboratory.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdExecuters
            // 
            this.grdExecuters.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdExecuters.AlowRetrieveStructure = false;
            this.grdExecuters.AlternatingColors = true;
            this.grdExecuters.BuiltInTextsData = resources.GetString("grdExecuters.BuiltInTextsData");
            this.grdExecuters.DataSource = this.executersList1;
            this.grdExecuters.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdExecuters_DesignTimeLayout.LayoutString = resources.GetString("grdExecuters_DesignTimeLayout.LayoutString");
            this.grdExecuters.DesignTimeLayout = grdExecuters_DesignTimeLayout;
            this.grdExecuters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdExecuters.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdExecuters.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdExecuters.GroupByBoxVisible = false;
            this.grdExecuters.Location = new System.Drawing.Point(3, 17);
            this.grdExecuters.Name = "grdExecuters";
            this.grdExecuters.Size = new System.Drawing.Size(395, 505);
            this.grdExecuters.TabIndex = 0;
            this.grdExecuters.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdExecuters.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdExecuters.SelectionChanged += new System.EventHandler(this.grdLaboratory_SelectionChanged);
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grdUser);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(408, 525);
            this.grpUser.TabIndex = 0;
            this.grpUser.Text = "کاربران";
            this.grpUser.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdUser
            // 
            this.grdUser.AlowRetrieveStructure = true;
            this.grdUser.AlternatingColors = true;
            this.grdUser.BuiltInTextsData = resources.GetString("grdUser.BuiltInTextsData");
            this.grdUser.DataSource = this.findUsersLaboratoryList1;
            this.grdUser.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdUser_DesignTimeLayout.LayoutString = resources.GetString("grdUser_DesignTimeLayout.LayoutString");
            this.grdUser.DesignTimeLayout = grdUser_DesignTimeLayout;
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUser.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdUser.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdUser.GroupByBoxVisible = false;
            this.grdUser.Location = new System.Drawing.Point(3, 17);
            this.grdUser.Name = "grdUser";
            this.grdUser.Size = new System.Drawing.Size(402, 505);
            this.grdUser.TabIndex = 3;
            this.grdUser.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdUser.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // RelationBetweenExecuterAndUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(813, 555);
            this.Name = "RelationBetweenExecuterAndUsers";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.LaboratoryUser_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpLaboratory)).EndInit();
            this.grpLaboratory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExecuters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private RASF.General.Controls.GroupBox grpLaboratory;
        private RASF.General.Controls.Grid grdExecuters;
        private RASF.General.Controls.GroupBox grpUser;
        private General.Lists.ExecutersList executersList1;
        private General.Controls.Grid grdUser;
        private General.Lists.FindUsersLaboratoryList findUsersLaboratoryList1;
    }
}
