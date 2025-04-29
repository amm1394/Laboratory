namespace RASF.Main.Forms.Reception
{
    partial class New_Reciption_Edit_DeclareCost
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
            Janus.Windows.GridEX.GridEXLayout grdPartsMaster_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Reciption_Edit_DeclareCost));
            this.contractsBaseDeclareCostList1 = new RASF.General.Lists.ContractsBaseDeclareCostList(this.components);
            this.parts_Master_DeclareCostList1 = new RASF.General.Lists.Parts_Master_DeclareCostList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AllTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLab)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdPartsMaster
            // 
            this.grdPartsMaster.DataSource = this.parts_Master_DeclareCostList1;
            grdPartsMaster_DesignTimeLayout.LayoutString = resources.GetString("grdPartsMaster_DesignTimeLayout.LayoutString");
            this.grdPartsMaster.DesignTimeLayout = grdPartsMaster_DesignTimeLayout;
            // 
            // New_Reciption_Edit_DeclareCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 619);
            this.Name = "New_Reciption_Edit_DeclareCost";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "New_Reciption_Edit_DeclareCost";
            this.Load += new System.EventHandler(this.New_Reciption_Edit_DeclareCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLab)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.ContractsBaseDeclareCostList contractsBaseDeclareCostList1;
        private General.Lists.Parts_Master_DeclareCostList parts_Master_DeclareCostList1;
    }
}