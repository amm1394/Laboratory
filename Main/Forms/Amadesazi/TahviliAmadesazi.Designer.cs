namespace RASF.Main.Forms.Amadesazi
{
    partial class TahviliAmadesazi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TahviliAmadesazi));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.amadesazi3 = new RASF.Main.Controls.Amadesazi.Amadesazi();
            this.amadesazi4 = new RASF.Main.Controls.Amadesazi.Amadesazi();
            this.tahviliAmadesaziList1 = new RASF.General.Lists.TahviliAmadesaziList(this.components);
            this.showTahviliAmadesaziList1 = new RASF.General.Lists.ShowTahviliAmadesaziList(this.components);
            this.showTakhiriMonthlyList1 = new RASF.General.Lists.ShowTakhiriMonthlyList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.amadesazi3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.amadesazi4);
            this.splitContainer1.Size = new System.Drawing.Size(1155, 765);
            this.splitContainer1.SplitterDistance = 617;
            this.splitContainer1.TabIndex = 0;
            // 
            // amadesazi3
            // 
            this.amadesazi3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amadesazi3.Location = new System.Drawing.Point(0, 0);
            this.amadesazi3.Name = "amadesazi3";
            this.amadesazi3.Size = new System.Drawing.Size(617, 765);
            this.amadesazi3.TabIndex = 0;
            this.amadesazi3.UserName = "label1";
            // 
            // amadesazi4
            // 
            this.amadesazi4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amadesazi4.Location = new System.Drawing.Point(0, 0);
            this.amadesazi4.Name = "amadesazi4";
            this.amadesazi4.Size = new System.Drawing.Size(534, 765);
            this.amadesazi4.TabIndex = 1;
            this.amadesazi4.UserName = "label1";
            // 
            // TahviliAmadesazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 765);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TahviliAmadesazi";
            this.ShowIcon = false;
            this.Text = "TahviliAmadesazi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TahviliAmadesazi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private RASF.General.Lists.TahviliAmadesaziList tahviliAmadesaziList1;
        private Controls.Amadesazi.Amadesazi amadesazi3;
        private Controls.Amadesazi.Amadesazi amadesazi4;
        private RASF.General.Lists.ShowTahviliAmadesaziList showTahviliAmadesaziList1;
        private General.Lists.ShowTakhiriMonthlyList showTakhiriMonthlyList1;
    }
}