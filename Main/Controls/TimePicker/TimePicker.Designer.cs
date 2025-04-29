namespace RASF.Main.Controls.TimePicker
{
    partial class TimePicker
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
            this.timePicker1 = new RASF.General.Controls.TimePicker();
            this.label1 = new RASF.General.Controls.Label();
            this.label2 = new RASF.General.Controls.Label();
            this.timePicker2 = new RASF.General.Controls.TimePicker();
            this.SuspendLayout();
            // 
            // timePicker1
            // 
            this.timePicker1.CustomFormat = "HH:MM";
            this.timePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker1.Location = new System.Drawing.Point(149, 8);
            this.timePicker1.Name = "timePicker1";
            this.timePicker1.ShowUpDown = true;
            this.timePicker1.Size = new System.Drawing.Size(88, 20);
            this.timePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "از ساعت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تا ساعت";
            // 
            // timePicker2
            // 
            this.timePicker2.CustomFormat = "HH:MM";
            this.timePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker2.Location = new System.Drawing.Point(3, 7);
            this.timePicker2.Name = "timePicker2";
            this.timePicker2.ShowUpDown = true;
            this.timePicker2.Size = new System.Drawing.Size(88, 20);
            this.timePicker2.TabIndex = 3;
            // 
            // TimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.timePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePicker1);
            this.Name = "TimePicker";
            this.Size = new System.Drawing.Size(289, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RASF.General.Controls.TimePicker timePicker1;
        private RASF.General.Controls.Label label1;
        private RASF.General.Controls.Label label2;
        private RASF.General.Controls.TimePicker timePicker2;
    }
}
