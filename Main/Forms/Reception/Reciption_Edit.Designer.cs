namespace RASF.Main.Forms.Reception
{
    partial class Reciption_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reciption_Edit));
            this.masterTestStatusEditRecieptionList1 = new RASF.General.Lists.MasterTestStatusList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllTab)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPartsMaster
            // 
            grdPartsMaster_DesignTimeLayout.LayoutString = resources.GetString("grdPartsMaster_DesignTimeLayout.LayoutString");
            this.grdPartsMaster.DesignTimeLayout = grdPartsMaster_DesignTimeLayout;
            // 
            // Reciption_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 594);
            this.Name = "Reciption_Edit";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.Text = "اصلاح پذیرش";
            this.Load += new System.EventHandler(this.Reciption_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.MasterTestStatusList masterTestStatusEditRecieptionList1;
    }
}