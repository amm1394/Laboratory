namespace RASF.Main.Forms.Financial
{
    partial class CalcLaboratoryCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcLaboratoryCost));
            Janus.Windows.GridEX.GridEXLayout grdLaboratory_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpLaboratory = new RASF.General.Controls.GroupBox();
            this.grdLaboratory = new RASF.General.Controls.Grid();
            this.calcLaboratoryCost1 = new RASF.General.Lists.CalcLaboratoryCost(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpLaboratory)).BeginInit();
            this.grpLaboratory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLaboratory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 510);
            this.pnlButton.Size = new System.Drawing.Size(915, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpLaboratory);
            this.pnlContent.Size = new System.Drawing.Size(915, 510);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(710, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(793, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(855, 0);
            // 
            // grpLaboratory
            // 
            this.grpLaboratory.Controls.Add(this.grdLaboratory);
            this.grpLaboratory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLaboratory.Location = new System.Drawing.Point(0, 0);
            this.grpLaboratory.Name = "grpLaboratory";
            this.grpLaboratory.Size = new System.Drawing.Size(915, 510);
            this.grpLaboratory.TabIndex = 0;
            this.grpLaboratory.Text = "آزمایشگاه ";
            this.grpLaboratory.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdLaboratory
            // 
            this.grdLaboratory.AlowRetrieveStructure = false;
            this.grdLaboratory.AlternatingColors = true;
            this.grdLaboratory.BuiltInTextsData = resources.GetString("grdLaboratory.BuiltInTextsData");
            this.grdLaboratory.DataSource = this.calcLaboratoryCost1;
            this.grdLaboratory.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdLaboratory_DesignTimeLayout.LayoutString = resources.GetString("grdLaboratory_DesignTimeLayout.LayoutString");
            this.grdLaboratory.DesignTimeLayout = grdLaboratory_DesignTimeLayout;
            this.grdLaboratory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLaboratory.GroupByBoxVisible = false;
            this.grdLaboratory.Location = new System.Drawing.Point(3, 17);
            this.grdLaboratory.Name = "grdLaboratory";
            this.grdLaboratory.Size = new System.Drawing.Size(909, 490);
            this.grdLaboratory.TabIndex = 0;
            this.grdLaboratory.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdLaboratory.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdLaboratory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // CalcLaboratoryCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(915, 540);
            this.Name = "CalcLaboratoryCost";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CalcLaboratoryCost_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpLaboratory)).EndInit();
            this.grpLaboratory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLaboratory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpLaboratory;
        private General.Controls.Grid grdLaboratory;
        private General.Lists.CalcLaboratoryCost calcLaboratoryCost1;
    }
}
