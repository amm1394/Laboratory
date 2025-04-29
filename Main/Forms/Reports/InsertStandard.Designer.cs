namespace RASF.Main.Forms.Reports
{
    partial class InsertStandard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertStandard));
            Janus.Windows.GridEX.GridEXLayout grdStandard_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdStandard = new RASF.General.Controls.Grid();
            this.insertStandardList1 = new RASF.General.Lists.InsertStandardList(this.components);
            this.standardDataList1 = new RASF.General.Lists.StandardDataList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStandard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 451);
            this.pnlButton.Size = new System.Drawing.Size(680, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdStandard);
            this.pnlContent.Size = new System.Drawing.Size(680, 451);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(473, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(558, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(620, 0);
            // 
            // grdStandard
            // 
            this.grdStandard.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdStandard.AlowRetrieveStructure = false;
            this.grdStandard.AlternatingColors = true;
            this.grdStandard.BuiltInTextsData = resources.GetString("grdStandard.BuiltInTextsData");
            this.grdStandard.DataSource = this.insertStandardList1;
            this.grdStandard.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdStandard_DesignTimeLayout.LayoutString = resources.GetString("grdStandard_DesignTimeLayout.LayoutString");
            this.grdStandard.DesignTimeLayout = grdStandard_DesignTimeLayout;
            this.grdStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStandard.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdStandard.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdStandard.GroupByBoxVisible = false;
            this.grdStandard.Location = new System.Drawing.Point(0, 0);
            this.grdStandard.Name = "grdStandard";
            this.grdStandard.Size = new System.Drawing.Size(680, 451);
            this.grdStandard.TabIndex = 0;
            this.grdStandard.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdStandard.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdStandard.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdStandard_ColumnButtonClick);
            // 
            // InsertStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 481);
            this.Name = "InsertStandard";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.InsertStandard_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStandard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdStandard;
        private General.Lists.InsertStandardList insertStandardList1;
        public General.Lists.StandardDataList standardDataList1;
    }
}
