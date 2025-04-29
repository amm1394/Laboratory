namespace RASF.Main.Forms
{
    partial class TAX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAX));
            Janus.Windows.GridEX.GridEXLayout grdTax_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdTax = new RASF.General.Controls.Grid();
            this.taxList1 = new RASF.General.Lists.TaxList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTax)).BeginInit();
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
            // grdTax
            // 
            this.grdTax.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdTax.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdTax.AlowRetrieveStructure = true;
            this.grdTax.AlternatingColors = true;
            this.grdTax.BuiltInTextsData = resources.GetString("grdTax.BuiltInTextsData");
            this.grdTax.DataSource = this.taxList1;
            this.grdTax.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTax_DesignTimeLayout.LayoutString = resources.GetString("grdTax_DesignTimeLayout.LayoutString");
            this.grdTax.DesignTimeLayout = grdTax_DesignTimeLayout;
            this.grdTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTax.GroupByBoxVisible = false;
            this.grdTax.Location = new System.Drawing.Point(0, 0);
            this.grdTax.Name = "grdTax";
            this.grdTax.RecordNavigator = true;
            this.grdTax.Size = new System.Drawing.Size(546, 396);
            this.grdTax.TabIndex = 2;
            this.grdTax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // TAX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Controls.Add(this.grdTax);
            this.Name = "TAX";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.TAX_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.grdTax, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdTax;
        private General.Lists.TaxList taxList1;
    }
}
