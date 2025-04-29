namespace RASF.Main.Forms.Reception
{
    partial class New_Reciption_Edit
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
            Janus.Windows.GridEX.GridEXLayout grdPartsMaster_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Reciption_Edit));
            ((System.ComponentModel.ISupportInitialize)(this.tabLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Size = new System.Drawing.Size(642, 335);
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.Size = new System.Drawing.Size(768, 335);
            // 
            // grdPartsMaster
            // 
            grdPartsMaster_DesignTimeLayout.LayoutString = resources.GetString("grdPartsMaster_DesignTimeLayout.LayoutString");
            this.grdPartsMaster.DesignTimeLayout = grdPartsMaster_DesignTimeLayout;
            // 
            // New_Reciption_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 824);
            this.Name = "New_Reciption_Edit";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.New_Reciption_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}