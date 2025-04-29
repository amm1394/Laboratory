namespace RASF.Main.Forms.Manager
{
    partial class DetaiolOfRecieptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetaiolOfRecieptForm));
            Janus.Windows.GridEX.GridEXLayout grdRec_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdRec = new RASF.General.Controls.Grid();
            this.detaiolOfRecieptList1 = new RASF.General.Lists.DetaiolOfRecieptList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRec)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 514);
            this.pnlButton.Size = new System.Drawing.Size(754, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(754, 514);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(549, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(632, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(694, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdRec);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdRec
            // 
            this.grdRec.AlowRetrieveStructure = false;
            this.grdRec.AlternatingColors = true;
            this.grdRec.BuiltInTextsData = resources.GetString("grdRec.BuiltInTextsData");
            this.grdRec.DataSource = this.detaiolOfRecieptList1;
            this.grdRec.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdRec_DesignTimeLayout.LayoutString = resources.GetString("grdRec_DesignTimeLayout.LayoutString");
            this.grdRec.DesignTimeLayout = grdRec_DesignTimeLayout;
            this.grdRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRec.GroupByBoxVisible = false;
            this.grdRec.Location = new System.Drawing.Point(3, 8);
            this.grdRec.Name = "grdRec";
            this.grdRec.Size = new System.Drawing.Size(748, 503);
            this.grdRec.TabIndex = 0;
            this.grdRec.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdRec.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdRec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // DetaiolOfRecieptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(754, 544);
            this.Name = "DetaiolOfRecieptForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.DetaiolOfRecieptForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdRec;
        private General.Lists.DetaiolOfRecieptList detaiolOfRecieptList1;
    }
}
