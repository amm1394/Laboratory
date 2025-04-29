namespace RASF.Main.Forms.Manager
{
    partial class RemindSeperatorByCustomer
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
            Janus.Windows.GridEX.GridEXLayout grdCash_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemindSeperatorByCustomer));
            Janus.Windows.GridEX.GridEXLayout grdCredit_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdCash = new RASF.General.Controls.Grid();
            this.remindSeparatedbycustomerCashList1 = new RASF.General.Lists.RemindSeparatedbycustomerCashList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdCredit = new RASF.General.Controls.Grid();
            this.remindSeparatedbycustomerCreditorList1 = new RASF.General.Lists.RemindSeparatedbycustomerCreditorList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 490);
            this.pnlButton.Size = new System.Drawing.Size(571, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(571, 490);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(366, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(449, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(511, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCash);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "شرکت های نقدی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCash
            // 
            this.grdCash.AlowRetrieveStructure = false;
            this.grdCash.AlternatingColors = true;
            this.grdCash.BuiltInTextsData = resources.GetString("grdCash.BuiltInTextsData");
            this.grdCash.DataSource = this.remindSeparatedbycustomerCashList1;
            this.grdCash.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCash_DesignTimeLayout.LayoutString = resources.GetString("grdCash_DesignTimeLayout.LayoutString");
            this.grdCash.DesignTimeLayout = grdCash_DesignTimeLayout;
            this.grdCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCash.GroupByBoxVisible = false;
            this.grdCash.Location = new System.Drawing.Point(3, 17);
            this.grdCash.Name = "grdCash";
            this.grdCash.Size = new System.Drawing.Size(565, 227);
            this.grdCash.TabIndex = 0;
            this.grdCash.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCash.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdCredit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "شرکت های اعتباری";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCredit
            // 
            this.grdCredit.AlowRetrieveStructure = false;
            this.grdCredit.AlternatingColors = true;
            this.grdCredit.BuiltInTextsData = resources.GetString("grdCredit.BuiltInTextsData");
            this.grdCredit.DataSource = this.remindSeparatedbycustomerCreditorList1;
            this.grdCredit.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCredit_DesignTimeLayout.LayoutString = resources.GetString("grdCredit_DesignTimeLayout.LayoutString");
            this.grdCredit.DesignTimeLayout = grdCredit_DesignTimeLayout;
            this.grdCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCredit.GroupByBoxVisible = false;
            this.grdCredit.Location = new System.Drawing.Point(3, 17);
            this.grdCredit.Name = "grdCredit";
            this.grdCredit.Size = new System.Drawing.Size(565, 223);
            this.grdCredit.TabIndex = 1;
            this.grdCredit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCredit.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCredit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // RemindSeperatorByCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(571, 520);
            this.Name = "RemindSeperatorByCustomer";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.RemindSeperatorByCustomer_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCredit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.GroupBox groupBox2;
        private RASF.General.Controls.Grid grdCredit;
        private RASF.General.Controls.Grid grdCash;
        private RASF.General.Lists.RemindSeparatedbycustomerCashList remindSeparatedbycustomerCashList1;
        private RASF.General.Lists.RemindSeparatedbycustomerCreditorList remindSeparatedbycustomerCreditorList1;
    }
}
