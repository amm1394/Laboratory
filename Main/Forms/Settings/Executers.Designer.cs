namespace RASF.Main.Forms.Settings
{
    partial class Executers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Executers));
            Janus.Windows.GridEX.GridEXLayout grdUser_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.panel1 = new RASF.General.Controls.Panel();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdUser = new RASF.General.Controls.Grid();
            this.findUsersLaboratoryList1 = new RASF.General.Lists.FindUsersLaboratoryList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 637);
            this.pnlButton.Size = new System.Drawing.Size(835, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Size = new System.Drawing.Size(835, 637);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(628, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(713, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(775, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 637);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 637);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
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
            this.grdUser.Location = new System.Drawing.Point(3, 8);
            this.grdUser.Name = "grdUser";
            this.grdUser.Size = new System.Drawing.Size(829, 626);
            this.grdUser.TabIndex = 2;
            this.grdUser.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdUser.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Executers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(835, 667);
            this.Name = "Executers";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Executers_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Panel panel1;
        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Lists.FindUsersLaboratoryList findUsersLaboratoryList1;
        private RASF.General.Controls.Grid grdUser;
    }
}
