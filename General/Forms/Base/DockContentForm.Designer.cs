namespace RASF.General.Forms.Base
{
    partial class DockContentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockContentForm));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pnlUpdate = new RASF.General.Controls.Panel();
            this.btnUpdate = new RASF.General.Controls.Save_Button();
            this.pnlExit = new RASF.General.Controls.Panel();
            this.btnExit = new RASF.General.Controls.Save_Button();
            this.pnlSave = new RASF.General.Controls.Panel();
            this.btnSave = new RASF.General.Controls.Save_Button();
            this.pnlContent = new RASF.General.Controls.Panel();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.pnlUpdate);
            this.pnlButton.Controls.Add(this.pnlExit);
            this.pnlButton.Controls.Add(this.pnlSave);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 434);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(474, 30);
            this.pnlButton.TabIndex = 1;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUpdate.Location = new System.Drawing.Point(269, 0);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(83, 30);
            this.pnlUpdate.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.Location = new System.Drawing.Point(6, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "به روز رسانی";
            this.btnUpdate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.btnExit);
            this.pnlExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExit.Location = new System.Drawing.Point(352, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(62, 30);
            this.pnlExit.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "خروج";
            this.btnExit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSave.Location = new System.Drawing.Point(414, 0);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(60, 30);
            this.pnlSave.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(6, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ذخیره";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(474, 434);
            this.pnlContent.TabIndex = 2;
            // 
            // DockContentForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(474, 464);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DockContentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DockContentForm";
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlButton;
        protected Controls.Save_Button btnExit;
        protected Controls.Save_Button btnSave;
        protected Controls.Panel pnlContent;
        protected Controls.Save_Button btnUpdate;
        protected Controls.Panel pnlUpdate;
        protected Controls.Panel pnlExit;
        protected Controls.Panel pnlSave;
    }
}