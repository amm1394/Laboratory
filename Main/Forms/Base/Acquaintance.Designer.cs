namespace RASF.Main.Forms
{
    partial class Acquaintance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acquaintance));
            Janus.Windows.GridEX.GridEXLayout grdAcquaintance_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdAcquaintance = new RASF.General.Controls.Grid();
            this.companiesAcqaintanceList1 = new RASF.General.Lists.CompaniesAcqaintanceList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAcquaintance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 396);
            this.pnlButton.Size = new System.Drawing.Size(546, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(546, 396);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(339, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(424, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(486, 0);
            // 
            // grdAcquaintance
            // 
            this.grdAcquaintance.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAcquaintance.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAcquaintance.AlowRetrieveStructure = true;
            this.grdAcquaintance.AlternatingColors = true;
            this.grdAcquaintance.BuiltInTextsData = resources.GetString("grdAcquaintance.BuiltInTextsData");
            this.grdAcquaintance.DataSource = this.companiesAcqaintanceList1;
            this.grdAcquaintance.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAcquaintance_DesignTimeLayout.LayoutString = resources.GetString("grdAcquaintance_DesignTimeLayout.LayoutString");
            this.grdAcquaintance.DesignTimeLayout = grdAcquaintance_DesignTimeLayout;
            this.grdAcquaintance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAcquaintance.GroupByBoxVisible = false;
            this.grdAcquaintance.Location = new System.Drawing.Point(0, 0);
            this.grdAcquaintance.Name = "grdAcquaintance";
            this.grdAcquaintance.RecordNavigator = true;
            this.grdAcquaintance.Size = new System.Drawing.Size(546, 396);
            this.grdAcquaintance.TabIndex = 2;
            this.grdAcquaintance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAcquaintance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Acquaintance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Controls.Add(this.grdAcquaintance);
            this.Name = "Acquaintance";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Acquaintance_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.grdAcquaintance, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAcquaintance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdAcquaintance;
        private General.Lists.CompaniesAcqaintanceList companiesAcqaintanceList1;
    }
}
