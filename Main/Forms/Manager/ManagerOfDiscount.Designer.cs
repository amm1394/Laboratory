namespace RASF.Main.Forms.Manager
{
    partial class ManagerOfDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerOfDiscount));
            Janus.Windows.GridEX.GridEXLayout grdDiscount_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdDiscount = new RASF.General.Controls.Grid();
            this.managerOfDiscountList1 = new RASF.General.Lists.ManagerOfDiscountList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 713);
            this.pnlButton.Size = new System.Drawing.Size(968, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(968, 713);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(763, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(846, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(908, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdDiscount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 713);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "تخفیف مدیریت";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDiscount
            // 
            this.grdDiscount.AlowRetrieveStructure = false;
            this.grdDiscount.AlternatingColors = true;
            this.grdDiscount.BuiltInTextsData = resources.GetString("grdDiscount.BuiltInTextsData");
            this.grdDiscount.DataSource = this.managerOfDiscountList1;
            this.grdDiscount.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDiscount_DesignTimeLayout.LayoutString = resources.GetString("grdDiscount_DesignTimeLayout.LayoutString");
            this.grdDiscount.DesignTimeLayout = grdDiscount_DesignTimeLayout;
            this.grdDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDiscount.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDiscount.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDiscount.GroupByBoxVisible = false;
            this.grdDiscount.Location = new System.Drawing.Point(3, 17);
            this.grdDiscount.Name = "grdDiscount";
            this.grdDiscount.RecordNavigator = true;
            this.grdDiscount.Size = new System.Drawing.Size(962, 693);
            this.grdDiscount.TabIndex = 0;
            this.grdDiscount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDiscount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ManagerOfDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 743);
            this.Name = "ManagerOfDiscount";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ManagerOfDiscount";
            this.Load += new System.EventHandler(this.ManagerOfDiscount_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdDiscount;
        private General.Lists.ManagerOfDiscountList managerOfDiscountList1;
    }
}