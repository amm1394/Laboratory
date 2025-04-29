namespace RASF.Main.Forms.Harmony
{
    partial class ContractBaseWithDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractBaseWithDiscount));
            Janus.Windows.GridEX.GridEXLayout grdContracts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.grpContracts = new RASF.General.Controls.GroupBox();
            this.grdContracts = new RASF.General.Controls.Grid();
            this.contractBaseWithDiscountList1 = new RASF.General.Lists.ContractBaseWithDiscountList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContracts)).BeginInit();
            this.grpContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 573);
            this.pnlButton.Size = new System.Drawing.Size(918, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpContracts);
            this.pnlContent.Location = new System.Drawing.Point(0, 46);
            this.pnlContent.Size = new System.Drawing.Size(918, 527);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(711, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(796, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(858, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "محدوده زمانی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(491, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // grpContracts
            // 
            this.grpContracts.Controls.Add(this.grdContracts);
            this.grpContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContracts.Location = new System.Drawing.Point(0, 0);
            this.grpContracts.Name = "grpContracts";
            this.grpContracts.Size = new System.Drawing.Size(918, 527);
            this.grpContracts.TabIndex = 0;
            this.grpContracts.Text = "قراردادهایی که شامل تخفیف می باشند";
            this.grpContracts.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContracts
            // 
            this.grdContracts.AlowRetrieveStructure = false;
            this.grdContracts.AlternatingColors = true;
            this.grdContracts.BuiltInTextsData = resources.GetString("grdContracts.BuiltInTextsData");
            this.grdContracts.DataSource = this.contractBaseWithDiscountList1;
            this.grdContracts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContracts_DesignTimeLayout.LayoutString = resources.GetString("grdContracts_DesignTimeLayout.LayoutString");
            this.grdContracts.DesignTimeLayout = grdContracts_DesignTimeLayout;
            this.grdContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContracts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContracts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContracts.GroupByBoxVisible = false;
            this.grdContracts.Location = new System.Drawing.Point(3, 17);
            this.grdContracts.Name = "grdContracts";
            this.grdContracts.Size = new System.Drawing.Size(912, 507);
            this.grdContracts.TabIndex = 0;
            this.grdContracts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContracts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdContracts.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdContracts_ColumnButtonClick);
            // 
            // ContractBaseWithDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(918, 603);
            this.Controls.Add(this.groupBox1);
            this.Name = "ContractBaseWithDiscount";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ContractBaseWithDiscount_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpContracts)).EndInit();
            this.grpContracts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpContracts;
        private RASF.General.Controls.Grid grdContracts;
        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.Main.Controls.PickDate.PickDate pickDate1;
        private RASF.General.Lists.ContractBaseWithDiscountList contractBaseWithDiscountList1;
    }
}
