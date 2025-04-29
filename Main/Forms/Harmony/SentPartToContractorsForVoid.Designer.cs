namespace RASF.Main.Forms.Harmony
{
    partial class SentPartToContractorsForVoid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentPartToContractorsForVoid));
            Janus.Windows.GridEX.GridEXLayout grdVoid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.sentPartToContractorsForVoidList1 = new RASF.General.Lists.SentPartToContractorsForVoidList(this.components);
            this.grpvoid = new RASF.General.Controls.GroupBox();
            this.grdVoid = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpvoid)).BeginInit();
            this.grpvoid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVoid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Size = new System.Drawing.Size(906, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpvoid);
            this.pnlContent.Size = new System.Drawing.Size(906, 434);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(2427, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(784, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(846, 0);
            // 
            // grpvoid
            // 
            this.grpvoid.Controls.Add(this.grdVoid);
            this.grpvoid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpvoid.Location = new System.Drawing.Point(0, 0);
            this.grpvoid.Name = "grpvoid";
            this.grpvoid.Size = new System.Drawing.Size(906, 434);
            this.grpvoid.TabIndex = 0;
            this.grpvoid.Text = "ابطال کارهای پیمانکاران";
            this.grpvoid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdVoid
            // 
            this.grdVoid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdVoid.AlowRetrieveStructure = false;
            this.grdVoid.AlternatingColors = true;
            this.grdVoid.BuiltInTextsData = resources.GetString("grdVoid.BuiltInTextsData");
            this.grdVoid.DataSource = this.sentPartToContractorsForVoidList1;
            this.grdVoid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdVoid_DesignTimeLayout.LayoutString = resources.GetString("grdVoid_DesignTimeLayout.LayoutString");
            this.grdVoid.DesignTimeLayout = grdVoid_DesignTimeLayout;
            this.grdVoid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVoid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdVoid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdVoid.GroupByBoxVisible = false;
            this.grdVoid.Location = new System.Drawing.Point(3, 17);
            this.grdVoid.Name = "grdVoid";
            this.grdVoid.Size = new System.Drawing.Size(900, 414);
            this.grdVoid.TabIndex = 0;
            this.grdVoid.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdVoid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdVoid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdVoid_ColumnButtonClick);
            // 
            // SentPartToContractorsForVoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(906, 464);
            this.Name = "SentPartToContractorsForVoid";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ابطال کارهای پیمانکاران";
            this.Load += new System.EventHandler(this.SentPartToContractorsForVoid_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpvoid)).EndInit();
            this.grpvoid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVoid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpvoid;
        private General.Controls.Grid grdVoid;
        private General.Lists.SentPartToContractorsForVoidList sentPartToContractorsForVoidList1;
    }
}
