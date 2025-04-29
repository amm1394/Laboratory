namespace RASF.Main.Forms.Reception
{
    partial class voidContractForHarmony
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoidContract));
            Janus.Windows.GridEX.GridEXLayout grdContracts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpContracts = new RASF.General.Controls.GroupBox();
            this.grdContracts = new RASF.General.Controls.Grid();
            this.voidContractList1 = new RASF.General.Lists.voidContractList(this.components);
            this.grpDescription = new RASF.General.Controls.GroupBox();
            this.txtVoid = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContracts)).BeginInit();
            this.grpContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDescription)).BeginInit();
            this.grpDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 514);
            this.pnlButton.Size = new System.Drawing.Size(674, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpDescription);
            this.pnlContent.Controls.Add(this.grpContracts);
            this.pnlContent.Size = new System.Drawing.Size(674, 514);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(467, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(552, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(614, 0);
            // 
            // grpContracts
            // 
            this.grpContracts.Controls.Add(this.grdContracts);
            this.grpContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContracts.Location = new System.Drawing.Point(0, 0);
            this.grpContracts.Name = "grpContracts";
            this.grpContracts.Size = new System.Drawing.Size(674, 329);
            this.grpContracts.TabIndex = 0;
            this.grpContracts.Text = "قرارداد";
            this.grpContracts.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContracts
            // 
            this.grdContracts.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdContracts.AlowRetrieveStructure = false;
            this.grdContracts.AlternatingColors = true;
            this.grdContracts.BuiltInTextsData = resources.GetString("grdContracts.BuiltInTextsData");
            this.grdContracts.DataSource = this.voidContractList1;
            this.grdContracts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContracts_DesignTimeLayout.LayoutString = resources.GetString("grdContracts_DesignTimeLayout.LayoutString");
            this.grdContracts.DesignTimeLayout = grdContracts_DesignTimeLayout;
            this.grdContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContracts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContracts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContracts.GroupByBoxVisible = false;
            this.grdContracts.Location = new System.Drawing.Point(3, 17);
            this.grdContracts.Name = "grdContracts";
            this.grdContracts.Size = new System.Drawing.Size(668, 309);
            this.grdContracts.TabIndex = 0;
            this.grdContracts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContracts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdContracts.SelectionChanged += new System.EventHandler(this.grdContracts_SelectionChanged);
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.txtVoid);
            this.grpDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDescription.Location = new System.Drawing.Point(0, 329);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(674, 185);
            this.grpDescription.TabIndex = 1;
            this.grpDescription.Text = "علت ابطال قرارداد";
            this.grpDescription.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtVoid
            // 
            this.txtVoid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voidContractList1, "Description", true));
            this.txtVoid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVoid.Location = new System.Drawing.Point(3, 17);
            this.txtVoid.Multiline = true;
            this.txtVoid.Name = "txtVoid";
            this.txtVoid.Size = new System.Drawing.Size(668, 165);
            this.txtVoid.TabIndex = 0;
            this.txtVoid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // VoidContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(674, 544);
            this.Name = "VoidContract";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.VoidContract_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpContracts)).EndInit();
            this.grpContracts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDescription)).EndInit();
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpDescription;
        private General.Controls.TextBox txtVoid;
        private General.Controls.GroupBox grpContracts;
        private General.Controls.Grid grdContracts;
        private General.Lists.voidContractList voidContractList1;
    }
}
