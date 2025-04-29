namespace RASF.Main.Controls.PickDate
{
    partial class PickDateFrom
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
            this.btnConfirmation = new RASF.General.Controls.Button();
            this.label1 = new RASF.General.Controls.Label();
            this.pickDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.SuspendLayout();
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Location = new System.Drawing.Point(15, 3);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(56, 23);
            this.btnConfirmation.TabIndex = 4;
            this.btnConfirmation.Text = "تایید";
            this.btnConfirmation.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاریخ";
            // 
            // pickDate
            // 
            this.pickDate.IsNull = false;
            this.pickDate.Location = new System.Drawing.Point(77, 6);
            this.pickDate.Name = "pickDate";
            this.pickDate.SelectedDateTime = new System.DateTime(2014, 3, 15, 15, 34, 43, 0);
            this.pickDate.Size = new System.Drawing.Size(115, 20);
            this.pickDate.TabIndex = 9;
            this.pickDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // PickDateFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pickDate);
            this.Controls.Add(this.btnConfirmation);
            this.Controls.Add(this.label1);
            this.Name = "PickDateFrom";
            this.Size = new System.Drawing.Size(241, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RASF.General.Controls.Label label1;
        private RASF.General.Controls.Button btnConfirmation;
        protected FarsiLibrary.Win.Controls.FADatePicker pickDate;
    }
}
