namespace RASF.Main.Controls //Contracts_Letter_Scan
{
    partial class Generate_Label
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
            this.radPdfViewer1 = new Telerik.WinControls.UI.RadPdfViewer();
            this.radPDFCommandBar1 = new Telerik.WinControls.UI.RadPdfViewerNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPDFCommandBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPdfViewer1
            // 
            this.radPdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPdfViewer1.Location = new System.Drawing.Point(0, 38);
            this.radPdfViewer1.Name = "radPdfViewer1";
            this.radPdfViewer1.Size = new System.Drawing.Size(978, 541);
            this.radPdfViewer1.TabIndex = 0;
            this.radPdfViewer1.Text = "radPdfViewer1";
            this.radPdfViewer1.ThumbnailsScaleFactor = 0.15F;
            // 
            // radPDFCommandBar1
            // 
            this.radPDFCommandBar1.AssociatedViewer = this.radPdfViewer1;
            this.radPDFCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPDFCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radPDFCommandBar1.Name = "radPDFCommandBar1";
            this.radPDFCommandBar1.Size = new System.Drawing.Size(978, 38);
            this.radPDFCommandBar1.TabIndex = 0;
            this.radPDFCommandBar1.Text = "radPdfViewerNavigator1";
            // 
            // Letter_Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPdfViewer1);
            this.Controls.Add(this.radPDFCommandBar1);
            this.Name = "Letter_Scan";
            this.Size = new System.Drawing.Size(978, 579);
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPDFCommandBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer1;
        private Telerik.WinControls.UI.RadPdfViewerNavigator radPDFCommandBar1;
    }
}
