namespace RASF.Main.Controls.PickDate
{
    partial class PickDate
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
            this.pickdateFrom = new FarsiLibrary.Win.Controls.FADatePicker();
            this.pickDateTo = new FarsiLibrary.Win.Controls.FADatePicker();
            this.btnConfirmation = new RASF.General.Controls.Button();
            this.label2 = new RASF.General.Controls.Label();
            this.label1 = new RASF.General.Controls.Label();
            this.SuspendLayout();
            // 
            // pickdateFrom
            // 
            this.pickdateFrom.IsNull = false;
            this.pickdateFrom.Location = new System.Drawing.Point(245, 7);
            this.pickdateFrom.Name = "pickdateFrom";
            this.pickdateFrom.SelectedDateTime = new System.DateTime(2014, 3, 15, 15, 34, 43, 0);
            this.pickdateFrom.Size = new System.Drawing.Size(115, 20);
            this.pickdateFrom.TabIndex = 8;
            this.pickdateFrom.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // pickDateTo
            // 
            this.pickDateTo.IsNull = false;
            this.pickDateTo.Location = new System.Drawing.Point(80, 6);
            this.pickDateTo.Name = "pickDateTo";
            this.pickDateTo.SelectedDateTime = new System.DateTime(2014, 3, 15, 15, 34, 43, 0);
            this.pickDateTo.Size = new System.Drawing.Size(115, 20);
            this.pickDateTo.TabIndex = 9;
            this.pickDateTo.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 10);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "لغایت:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "از تاریخ:";
            // 
            // PickDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pickDateTo);
            this.Controls.Add(this.pickdateFrom);
            this.Controls.Add(this.btnConfirmation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PickDate";
            this.Size = new System.Drawing.Size(424, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RASF.General.Controls.Label label1;
        private RASF.General.Controls.Label label2;
        private RASF.General.Controls.Button btnConfirmation;
        protected FarsiLibrary.Win.Controls.FADatePicker pickdateFrom;
        protected FarsiLibrary.Win.Controls.FADatePicker pickDateTo;
    }
}
