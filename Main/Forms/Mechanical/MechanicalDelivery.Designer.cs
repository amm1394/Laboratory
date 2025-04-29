namespace RASF.Main.Forms.Mechanical
{
    partial class MechanicalDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MechanicalDelivery));
            this.mechanicalLabDeliveryList1 = new RASF.General.Lists.MechanicalLabDeliveryList(this.components);
            this.mechanical1 = new RASF.Main.Controls.Amadesazi.Mechanical();
            this.SuspendLayout();
            // 
            // mechanical1
            // 
            this.mechanical1.Location = new System.Drawing.Point(0, 0);
            this.mechanical1.Name = "mechanical1";
            this.mechanical1.Size = new System.Drawing.Size(408, 615);
            this.mechanical1.TabIndex = 0;
            this.mechanical1.UserName = "label1";
            // 
            // MechanicalDelivery
            // 
            this.ClientSize = new System.Drawing.Size(682, 662);
            this.Name = "MechanicalDelivery";
            this.Load += new System.EventHandler(this.MechanicalDelivery_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.MechanicalLabDeliveryList mechanicalLabDeliveryList1;
        private Controls.Amadesazi.Mechanical mechanical1;
    }
}