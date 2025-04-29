namespace RASF.Main.Forms.BillsReports
{
    partial class ChengeForAmountOfBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChengeForAmountOfBill));
            Janus.Windows.GridEX.GridEXLayout grdChangeAmount_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdChangeAmount = new RASF.General.Controls.Grid();
            this.chengeForAmountOfBillList1 = new RASF.General.Lists.ChengeForAmountOfBillList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 568);
            this.pnlButton.Size = new System.Drawing.Size(701, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(701, 568);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(496, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(579, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(641, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdChangeAmount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 568);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "صورت حساب هایی که مبلغ شان تغییر کرده";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdChangeAmount
            // 
            this.grdChangeAmount.AlowRetrieveStructure = false;
            this.grdChangeAmount.AlternatingColors = true;
            this.grdChangeAmount.BuiltInTextsData = resources.GetString("grdChangeAmount.BuiltInTextsData");
            this.grdChangeAmount.DataSource = this.chengeForAmountOfBillList1;
            this.grdChangeAmount.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdChangeAmount_DesignTimeLayout.LayoutString = resources.GetString("grdChangeAmount_DesignTimeLayout.LayoutString");
            this.grdChangeAmount.DesignTimeLayout = grdChangeAmount_DesignTimeLayout;
            this.grdChangeAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdChangeAmount.GroupByBoxVisible = false;
            this.grdChangeAmount.Location = new System.Drawing.Point(3, 17);
            this.grdChangeAmount.Name = "grdChangeAmount";
            this.grdChangeAmount.Size = new System.Drawing.Size(695, 548);
            this.grdChangeAmount.TabIndex = 0;
            this.grdChangeAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdChangeAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ChengeForAmountOfBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 598);
            this.Name = "ChengeForAmountOfBill";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ChengeForAmountOfBill";
            this.Load += new System.EventHandler(this.ChengeForAmountOfBill_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdChangeAmount;
        private General.Lists.ChengeForAmountOfBillList chengeForAmountOfBillList1;
    }
}