namespace RASF.Main.Controls.Company
{
    partial class LightName
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.drpName = new RASF.General.Controls.DropDown();
            this.lightDescList1 = new RASF.General.Lists.LightDescList(this.components);
            this.SuspendLayout();
            // 
            // drpName
            // 
            this.drpName.Location = new System.Drawing.Point(26, 6);
            this.drpName.Name = "drpName";
            this.drpName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpName.Size = new System.Drawing.Size(188, 20);
            this.drpName.TabIndex = 1;
            this.drpName.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // LightName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.drpName);
            this.Name = "LightName";
            this.Size = new System.Drawing.Size(225, 29);
            this.Load += new System.EventHandler(this.OfficesName_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.DropDown drpName;
        private General.Lists.LightDescList lightDescList1;
    }
}
