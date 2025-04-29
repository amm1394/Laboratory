namespace RASF.Main.Forms.Manager
{
    partial class DiscountOfCompanies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountOfCompanies));
            Janus.Windows.GridEX.GridEXLayout grddiscount_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grddiscount = new RASF.General.Controls.Grid();
            this.discountOfCompaniesList1 = new RASF.General.Lists.DiscountOfCompaniesList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 496);
            this.pnlButton.Size = new System.Drawing.Size(781, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(781, 496);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(576, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(659, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(721, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grddiscount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "شرکت هایی که شامل تخفیف می باشند";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            this.groupBox1.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // grddiscount
            // 
            this.grddiscount.AlowRetrieveStructure = false;
            this.grddiscount.AlternatingColors = true;
            this.grddiscount.BuiltInTextsData = resources.GetString("grddiscount.BuiltInTextsData");
            this.grddiscount.DataSource = this.discountOfCompaniesList1;
            this.grddiscount.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grddiscount_DesignTimeLayout.LayoutString = resources.GetString("grddiscount_DesignTimeLayout.LayoutString");
            this.grddiscount.DesignTimeLayout = grddiscount_DesignTimeLayout;
            this.grddiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grddiscount.GroupByBoxVisible = false;
            this.grddiscount.Location = new System.Drawing.Point(3, 17);
            this.grddiscount.Name = "grddiscount";
            this.grddiscount.Size = new System.Drawing.Size(775, 476);
            this.grddiscount.TabIndex = 0;
            this.grddiscount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grddiscount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // DiscountOfCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(781, 526);
            this.Name = "DiscountOfCompanies";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.DiscountOfCompanies_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grddiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grddiscount;
        private General.Lists.DiscountOfCompaniesList discountOfCompaniesList1;
    }
}
