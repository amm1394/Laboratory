namespace RASF.Main.Forms.Reports
{
    partial class TempAndHumid
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
            this.label1 = new RASF.General.Controls.Label();
            this.label2 = new RASF.General.Controls.Label();
            this.validateCredentialsList1 = new RASF.General.Lists.ValidateCredentialsList(this.components);
            this.label3 = new RASF.General.Controls.Label();
            this.label4 = new RASF.General.Controls.Label();
            this.mnbTemprature = new RASF.General.Controls.NumberBox();
            this.mnbHumid = new RASF.General.Controls.NumberBox();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.mnbHumid);
            this.pnlContent.Controls.Add(this.mnbTemprature);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Size = new System.Drawing.Size(221, 82);
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 82);
            this.pnlButton.Size = new System.Drawing.Size(221, 30);
            // 
            // btnExit
            // 
            this.btnExit.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "دما:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "رطوبت:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "درجه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "درصد";
            // 
            // mnbTemprature
            // 
            this.mnbTemprature.Location = new System.Drawing.Point(85, 15);
            this.mnbTemprature.Name = "mnbTemprature";
            this.mnbTemprature.Size = new System.Drawing.Size(55, 20);
            this.mnbTemprature.TabIndex = 4;
            this.mnbTemprature.Text = "0.00";
            this.mnbTemprature.Value = 0F;
            this.mnbTemprature.ValueType = Janus.Windows.GridEX.NumericEditValueType.Single;
            // 
            // mnbHumid
            // 
            this.mnbHumid.Location = new System.Drawing.Point(85, 49);
            this.mnbHumid.Name = "mnbHumid";
            this.mnbHumid.Size = new System.Drawing.Size(55, 20);
            this.mnbHumid.TabIndex = 5;
            this.mnbHumid.Text = "0.00";
            this.mnbHumid.Value = 0F;
            this.mnbHumid.ValueType = Janus.Windows.GridEX.NumericEditValueType.Single;
            // 
            // TempAndHumid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(221, 112);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TempAndHumid";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TempAndHumid_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Label label1;
        private RASF.General.Controls.Label label2;
        private General.Lists.ValidateCredentialsList validateCredentialsList1;
        private General.Controls.Label label4;
        private General.Controls.Label label3;
        private General.Controls.NumberBox mnbHumid;
        private General.Controls.NumberBox mnbTemprature;
    }
}
