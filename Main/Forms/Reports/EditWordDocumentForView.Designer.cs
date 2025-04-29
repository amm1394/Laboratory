namespace RASF.Main.Forms.Reports
{
    partial class EditWordDocumentForView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWordDocument));
            this.editWord = new AxEDOfficeLib.AxEDOffice();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editWord)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 560);
            this.pnlButton.Size = new System.Drawing.Size(1242, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.editWord);
            this.pnlContent.Size = new System.Drawing.Size(1242, 560);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1035, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1120, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1182, 0);
            // 
            // editWord
            // 
            this.editWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editWord.Enabled = true;
            this.editWord.Location = new System.Drawing.Point(0, 0);
            this.editWord.Name = "editWord";
            this.editWord.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("editWord.OcxState")));
            this.editWord.Size = new System.Drawing.Size(1242, 560);
            this.editWord.TabIndex = 0;
            // 
            // EditWordDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1242, 590);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "EditWordDocument";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditWordDocument_FormClosed);
            this.Load += new System.EventHandler(this.EditWordDocument_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editWord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxEDOfficeLib.AxEDOffice editWord;
    }
}
