namespace RASF.Main.Forms.Manager
{
    partial class ChequeForTafahomName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequeForTafahomName));
            Janus.Windows.GridEX.GridEXLayout grdTafahom_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox4 = new RASF.General.Controls.GroupBox();
            this.grdTafahom = new RASF.General.Controls.Grid();
            this.cooperationGroup_TafahomNameList1 = new RASF.General.Lists.CooperationGroup_TafahomNameList(this.components);
            this.tafahomNameList1 = new RASF.General.Lists.TafahomNameList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTafahom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 530);
            this.pnlButton.Size = new System.Drawing.Size(795, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox4);
            this.pnlContent.Size = new System.Drawing.Size(795, 530);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(590, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(673, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(735, 0);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdTafahom);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(795, 530);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.Text = "چک تضمین";
            this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdTafahom
            // 
            this.grdTafahom.AlowRetrieveStructure = false;
            this.grdTafahom.AlternatingColors = true;
            this.grdTafahom.BuiltInTextsData = resources.GetString("grdTafahom.BuiltInTextsData");
            this.grdTafahom.DataSource = this.tafahomNameList1;
            this.grdTafahom.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTafahom_DesignTimeLayout.LayoutString = resources.GetString("grdTafahom_DesignTimeLayout.LayoutString");
            this.grdTafahom.DesignTimeLayout = grdTafahom_DesignTimeLayout;
            this.grdTafahom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTafahom.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdTafahom.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdTafahom.GroupByBoxVisible = false;
            this.grdTafahom.Location = new System.Drawing.Point(3, 17);
            this.grdTafahom.Name = "grdTafahom";
            this.grdTafahom.RecordNavigator = true;
            this.grdTafahom.Size = new System.Drawing.Size(789, 510);
            this.grdTafahom.TabIndex = 0;
            this.grdTafahom.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTafahom.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ChequeForTafahomName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(795, 560);
            this.Name = "ChequeForTafahomName";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ChequeForTafahomName_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTafahom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox4;
        private General.Controls.Grid grdTafahom;
        private General.Lists.TafahomNameList tafahomNameList1;
        private General.Lists.CooperationGroup_TafahomNameList cooperationGroup_TafahomNameList1;
    }
}
