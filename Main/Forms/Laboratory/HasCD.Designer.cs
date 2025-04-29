namespace RASF.Main.Forms.Laboratory
{
    partial class HasCD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HasCD));
            Janus.Windows.GridEX.GridEXLayout grdCD_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdCD = new RASF.General.Controls.Grid();
            this.hasCdMasterList1 = new RASF.General.Lists.HasCdMasterList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Size = new System.Drawing.Size(845, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(845, 434);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(640, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(723, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(785, 0);
            // 
            // grdCD
            // 
            this.grdCD.AlowRetrieveStructure = false;
            this.grdCD.AlternatingColors = true;
            this.grdCD.BuiltInTextsData = resources.GetString("grdCD.BuiltInTextsData");
            this.grdCD.DataSource = this.hasCdMasterList1;
            this.grdCD.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCD_DesignTimeLayout.LayoutString = resources.GetString("grdCD_DesignTimeLayout.LayoutString");
            this.grdCD.DesignTimeLayout = grdCD_DesignTimeLayout;
            this.grdCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCD.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCD.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCD.GroupByBoxVisible = false;
            this.grdCD.Hierarchical = true;
            this.grdCD.Location = new System.Drawing.Point(3, 17);
            this.grdCD.Name = "grdCD";
            this.grdCD.RecordNavigator = true;
            this.grdCD.Size = new System.Drawing.Size(839, 414);
            this.grdCD.TabIndex = 0;
            this.grdCD.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCD.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 434);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "سی دی آزمایشگاه ها";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // HasCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 464);
            this.Name = "HasCD";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "HasCD";
            this.Load += new System.EventHandler(this.HasCD_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdCD;
        private General.Controls.GroupBox groupBox1;
        private General.Lists.HasCdMasterList hasCdMasterList1;
    }
}