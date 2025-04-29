namespace RASF.Main.Forms.Settings
{
    partial class UserAndExecuterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAndExecuterForm));
            Janus.Windows.GridEX.GridEXLayout grdUser_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.executersList1 = new RASF.General.Lists.ExecutersList(this.components);
            this.findUsersLaboratoryList1 = new RASF.General.Lists.FindUsersLaboratoryList(this.components);
            this.grpUser = new RASF.General.Controls.GroupBox();
            this.grdUser = new RASF.General.Controls.Grid();
            this.activeNonActiveList1 = new RASF.General.Lists.ActiveNonActiveList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
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
            this.pnlContent.Controls.Add(this.grpUser);
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
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grdUser);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(813, 525);
            this.grpUser.TabIndex = 1;
            this.grpUser.Text = "کاربران";
            this.grpUser.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdUser
            // 
            this.grdUser.AlowRetrieveStructure = false;
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
            this.grdUser.Size = new System.Drawing.Size(807, 505);
            this.grdUser.TabIndex = 1;
            this.grdUser.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdUser.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // UserAndExecuterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(813, 555);
            this.Name = "UserAndExecuterForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.ExecutersList executersList1;
        private General.Lists.FindUsersLaboratoryList findUsersLaboratoryList1;
        private General.Controls.GroupBox grpUser;
        private General.Lists.ActiveNonActiveList activeNonActiveList1;
        private General.Controls.Grid grdUser;
    }
}
