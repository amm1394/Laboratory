namespace RASF.Main.Controls.Offices
{
    partial class OfficesName
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
            this.LabName = new RASF.General.Controls.Label();
            this.drpName = new RASF.General.Controls.DropDown();
            this.companiesAgencyListList1 = new RASF.General.Lists.CompaniesAgencyListList(this.components);
            this.SuspendLayout();
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Location = new System.Drawing.Point(194, 7);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(43, 13);
            this.LabName.TabIndex = 0;
            this.LabName.Text = "نام دفتر";
            // 
            // drpName
            // 
            this.drpName.DataSource = this.companiesAgencyListList1;
            this.drpName.Location = new System.Drawing.Point(0, 3);
            this.drpName.Name = "drpName";
            this.drpName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpName.Size = new System.Drawing.Size(188, 20);
            this.drpName.TabIndex = 1;
            this.drpName.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // OfficesName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.drpName);
            this.Controls.Add(this.LabName);
            this.Name = "OfficesName";
            this.Size = new System.Drawing.Size(242, 29);
            this.Load += new System.EventHandler(this.OfficesName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private General.Controls.Label LabName;
        private General.Controls.DropDown drpName;
        private General.Lists.CompaniesAgencyListList companiesAgencyListList1;
    }
}
