namespace RASF.Main.Forms.Reception
{
    partial class EditAgencyName
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
            this.grpContracts = new RASF.General.Controls.GroupBox();
            this.drpOffices = new RASF.General.Controls.DropDown();
            this.label5 = new RASF.General.Controls.Label();
            this.companiesAgencyListList1 = new RASF.General.Lists.CompaniesAgencyListList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContracts)).BeginInit();
            this.grpContracts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 173);
            this.pnlButton.Size = new System.Drawing.Size(435, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpContracts);
            this.pnlContent.Size = new System.Drawing.Size(435, 173);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(230, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(313, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(375, 0);
            // 
            // grpContracts
            // 
            this.grpContracts.Controls.Add(this.drpOffices);
            this.grpContracts.Controls.Add(this.label5);
            this.grpContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContracts.Location = new System.Drawing.Point(0, 0);
            this.grpContracts.Name = "grpContracts";
            this.grpContracts.Size = new System.Drawing.Size(435, 173);
            this.grpContracts.TabIndex = 0;
            this.grpContracts.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // drpOffices
            // 
            this.drpOffices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drpOffices.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.drpOffices.Location = new System.Drawing.Point(102, 70);
            this.drpOffices.Name = "drpOffices";
            this.drpOffices.Size = new System.Drawing.Size(152, 21);
            this.drpOffices.TabIndex = 8;
            this.drpOffices.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "محل ارسال نمونه :";
            // 
            // EditAgencyName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(435, 203);
            this.Name = "EditAgencyName";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.EditAgencyName_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpContracts)).EndInit();
            this.grpContracts.ResumeLayout(false);
            this.grpContracts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpContracts;
        protected General.Controls.DropDown drpOffices;
        private General.Controls.Label label5;
        private General.Lists.CompaniesAgencyListList companiesAgencyListList1;
    }
}
