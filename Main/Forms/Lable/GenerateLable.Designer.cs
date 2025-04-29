namespace RASF.Main.Forms.Lable
{
    partial class GenerateLabel
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
            this.groupBox6 = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.generate_Label1 = new RASF.Main.Controls.Generate_Label();
            this.generateLabelList1 = new RASF.General.Lists.GenerateLabelList(this.components);
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.generate_Label1);
            this.pnlContent.Location = new System.Drawing.Point(0, 43);
            this.pnlContent.Size = new System.Drawing.Size(921, 550);
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 593);
            this.pnlButton.Size = new System.Drawing.Size(921, 30);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.searchContract1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(921, 43);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(689, 8);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(229, 32);
            this.searchContract1.TabIndex = 0;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // generate_Label1
            // 
            this.generate_Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generate_Label1.Location = new System.Drawing.Point(0, 0);
            this.generate_Label1.Name = "generate_Label1";
            this.generate_Label1.Size = new System.Drawing.Size(921, 550);
            this.generate_Label1.TabIndex = 0;
            // 
            // GenerateLabel
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 623);
            this.Controls.Add(this.groupBox6);
            this.Name = "GenerateLabel";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.Text = "GenerateLable";
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.groupBox6, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Generate_Label generate_Label1;
        private General.Controls.GroupBox groupBox6;
        private Controls.SearchContract searchContract1;
        private General.Lists.GenerateLabelList generateLabelList1;
    }
}