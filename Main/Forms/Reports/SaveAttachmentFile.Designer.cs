namespace RASF.Main.Forms.Reports
{
    partial class SaveAttachmentFile
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
            this.letter_Scan1 = new RASF.Main.Controls.Letter_Scan();
            this.showSaveCostPaperList1 = new RASF.General.Lists.ShowSaveCostPaperList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 581);
            this.pnlButton.Size = new System.Drawing.Size(855, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.letter_Scan1);
            this.pnlContent.Size = new System.Drawing.Size(855, 581);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(650, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(733, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(795, 0);
            // 
            // letter_Scan1
            // 
            this.letter_Scan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letter_Scan1.Document = null;
            this.letter_Scan1.Location = new System.Drawing.Point(0, 0);
            this.letter_Scan1.Name = "letter_Scan1";
            this.letter_Scan1.Size = new System.Drawing.Size(855, 581);
            this.letter_Scan1.TabIndex = 1;
            // 
            // SaveAttachmentFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 611);
            this.Name = "SaveAttachmentFile";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "SaveCostPaper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveCostPaper_FormClosing);
            this.Load += new System.EventHandler(this.SaveCostPaper_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Letter_Scan letter_Scan1;
        private General.Lists.ShowSaveCostPaperList showSaveCostPaperList1;
    }
}