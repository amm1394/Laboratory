namespace RASF.Main.Forms.Base
{
    partial class LaboratoryMachin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaboratoryMachin));
            Janus.Windows.GridEX.GridEXLayout grdMachin_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdMachin = new RASF.General.Controls.Grid();
            this.laboratoryMachinList1 = new RASF.General.Lists.LaboratoryMachinList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMachin)).BeginInit();
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
            this.pnlContent.Controls.Add(this.grdMachin);
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
            // grdMachin
            // 
            this.grdMachin.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdMachin.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdMachin.AlowRetrieveStructure = false;
            this.grdMachin.AlternatingColors = true;
            this.grdMachin.BuiltInTextsData = resources.GetString("grdMachin.BuiltInTextsData");
            this.grdMachin.DataSource = this.laboratoryMachinList1;
            this.grdMachin.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMachin_DesignTimeLayout.LayoutString = resources.GetString("grdMachin_DesignTimeLayout.LayoutString");
            this.grdMachin.DesignTimeLayout = grdMachin_DesignTimeLayout;
            this.grdMachin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMachin.GroupByBoxVisible = false;
            this.grdMachin.Location = new System.Drawing.Point(0, 0);
            this.grdMachin.Name = "grdMachin";
            this.grdMachin.Size = new System.Drawing.Size(546, 396);
            this.grdMachin.TabIndex = 0;
            this.grdMachin.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMachin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // LaboratoryMachin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Name = "LaboratoryMachin";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.LaboratoryMachin_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMachin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdMachin;
        private General.Lists.LaboratoryMachinList laboratoryMachinList1;
    }
}
