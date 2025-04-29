namespace RASF.Main.Controls.FinancialYear
{
    partial class FinancialYear
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
            this.drpYear = new RASF.General.Controls.DropDown();
            this.changeYearList1 = new RASF.General.Lists.ChangeYearList(this.components);
            this.SuspendLayout();
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Location = new System.Drawing.Point(194, 7);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(52, 13);
            this.LabName.TabIndex = 0;
            this.LabName.Text = "سال مالی";
            // 
            // drpYear
            // 
            this.drpYear.Location = new System.Drawing.Point(0, 3);
            this.drpYear.Name = "drpYear";
            this.drpYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpYear.Size = new System.Drawing.Size(188, 20);
            this.drpYear.TabIndex = 1;
            this.drpYear.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // FinancialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.drpYear);
            this.Controls.Add(this.LabName);
            this.Name = "FinancialYear";
            this.Size = new System.Drawing.Size(242, 29);
            this.Load += new System.EventHandler(this.OfficesName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private General.Controls.Label LabName;
        private General.Controls.DropDown drpYear;
        private General.Lists.ChangeYearList changeYearList1;
    }
}
