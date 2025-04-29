namespace RASF.Main.Forms.Financial
{
    partial class RepotOfGrant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepotOfGrant));
            Janus.Windows.GridEX.GridEXLayout grdgrant_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdgrant = new RASF.General.Controls.Grid();
            this.repotOfGrantList1 = new RASF.General.Lists.RepotOfGrantList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdgrant)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 496);
            this.pnlButton.Size = new System.Drawing.Size(781, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(781, 496);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(576, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(659, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(721, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdgrant);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "گرنت های ثبت شده";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdgrant
            // 
            this.grdgrant.AlowRetrieveStructure = false;
            this.grdgrant.AlternatingColors = true;
            this.grdgrant.BuiltInTextsData = resources.GetString("grdgrant.BuiltInTextsData");
            this.grdgrant.DataSource = this.repotOfGrantList1;
            this.grdgrant.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdgrant_DesignTimeLayout.LayoutString = resources.GetString("grdgrant_DesignTimeLayout.LayoutString");
            this.grdgrant.DesignTimeLayout = grdgrant_DesignTimeLayout;
            this.grdgrant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdgrant.GroupByBoxVisible = false;
            this.grdgrant.Location = new System.Drawing.Point(3, 17);
            this.grdgrant.Name = "grdgrant";
            this.grdgrant.Size = new System.Drawing.Size(775, 476);
            this.grdgrant.TabIndex = 0;
            this.grdgrant.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdgrant.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdgrant.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // RepotOfGrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(781, 526);
            this.Name = "RepotOfGrant";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.RepotOfGrant_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdgrant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdgrant;
        private General.Lists.RepotOfGrantList repotOfGrantList1;
    }
}
