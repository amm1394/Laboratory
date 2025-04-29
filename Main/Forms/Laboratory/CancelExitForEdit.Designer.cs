namespace RASF.Main.Forms.Laboratory
{
    partial class CancelExitForEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelExitForEdit));
            Janus.Windows.GridEX.GridEXLayout grdContracts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdContracts = new RASF.General.Controls.Grid();
            this.cancelExitForEditInScienceList1 = new RASF.General.Lists.CancelExitForEditInScienceList(this.components);
            this.scientificExpertsList1 = new RASF.General.Lists.ScientificExpertsList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 596);
            this.pnlButton.Size = new System.Drawing.Size(1125, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1125, 596);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(920, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1003, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1065, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdContracts);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContracts
            // 
            this.grdContracts.AlowRetrieveStructure = false;
            this.grdContracts.AlternatingColors = true;
            this.grdContracts.BuiltInTextsData = resources.GetString("grdContracts.BuiltInTextsData");
            this.grdContracts.DataSource = this.cancelExitForEditInScienceList1;
            this.grdContracts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContracts_DesignTimeLayout.LayoutString = resources.GetString("grdContracts_DesignTimeLayout.LayoutString");
            this.grdContracts.DesignTimeLayout = grdContracts_DesignTimeLayout;
            this.grdContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContracts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContracts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContracts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grdContracts.GroupByBoxVisible = false;
            this.grdContracts.Hierarchical = true;
            this.grdContracts.HierarchicalExpandBoxStyle = Janus.Windows.GridEX.ExpandBoxStyle.Arrows;
            this.grdContracts.Location = new System.Drawing.Point(3, 8);
            this.grdContracts.Name = "grdContracts";
            this.grdContracts.Size = new System.Drawing.Size(1119, 585);
            this.grdContracts.TabIndex = 1;
            this.grdContracts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContracts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdContracts.SelectionChanged += new System.EventHandler(this.grdContracts_SelectionChanged);
            // 
            // CancelExitForEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1125, 626);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "CancelExitForEdit";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.TabText = "لغو خروج برای اصلاح گزارش";
            this.Text = "لغو خروج برای اصلاح گزارش";
            this.Load += new System.EventHandler(this.ExitForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Lists.ScientificExpertsList scientificExpertsList1;
        private General.Lists.CancelExitForEditInScienceList cancelExitForEditInScienceList1;
        public General.Controls.Grid grdContracts;
    }
}
