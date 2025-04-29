namespace RASF.Main.Forms.Harmony
{
    partial class SentPartToContractorsForPreBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentPartToContractorsForPreBill));
            Janus.Windows.GridEX.GridEXLayout grdbill_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpbill = new RASF.General.Controls.GroupBox();
            this.grdbill = new RASF.General.Controls.Grid();
            this.sentPartToContractorsForPreBillList1 = new RASF.General.Lists.SentPartToContractorsForPreBillList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate2 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpbill)).BeginInit();
            this.grpbill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 520);
            this.pnlButton.Size = new System.Drawing.Size(1229, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpbill);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1229, 520);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(3744, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1107, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1169, 0);
            // 
            // grpbill
            // 
            this.grpbill.Controls.Add(this.grdbill);
            this.grpbill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbill.Location = new System.Drawing.Point(0, 52);
            this.grpbill.Name = "grpbill";
            this.grpbill.Size = new System.Drawing.Size(1229, 468);
            this.grpbill.TabIndex = 0;
            this.grpbill.Text = "دریافت پیش فاکتور";
            this.grpbill.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdbill
            // 
            this.grdbill.AlowRetrieveStructure = false;
            this.grdbill.AlternatingColors = true;
            this.grdbill.BuiltInTextsData = resources.GetString("grdbill.BuiltInTextsData");
            this.grdbill.DataSource = this.sentPartToContractorsForPreBillList1;
            this.grdbill.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdbill_DesignTimeLayout.LayoutString = resources.GetString("grdbill_DesignTimeLayout.LayoutString");
            this.grdbill.DesignTimeLayout = grdbill_DesignTimeLayout;
            this.grdbill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdbill.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdbill.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdbill.GroupByBoxVisible = false;
            this.grdbill.Location = new System.Drawing.Point(3, 17);
            this.grdbill.Name = "grdbill";
            this.grdbill.Size = new System.Drawing.Size(1223, 448);
            this.grdbill.TabIndex = 0;
            this.grdbill.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdbill.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1229, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "تاریخ ارسال";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate2
            // 
            this.pickDate2.BackColor = System.Drawing.Color.Transparent;
            this.pickDate2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate2.Location = new System.Drawing.Point(802, 17);
            this.pickDate2.Name = "pickDate2";
            this.pickDate2.Size = new System.Drawing.Size(424, 32);
            this.pickDate2.TabIndex = 1;
            this.pickDate2.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate2_DateSelected);
            // 
            // SentPartToContractorsForPreBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1229, 550);
            this.Name = "SentPartToContractorsForPreBill";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "دریافت پیش فاکتور از پیمانکار";
            this.Load += new System.EventHandler(this.SentPartToContractorsForPreBill_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpbill)).EndInit();
            this.grpbill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpbill;
        private General.Controls.Grid grdbill;
        private General.Lists.SentPartToContractorsForPreBillList sentPartToContractorsForPreBillList1;
        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate2;
    }
}
