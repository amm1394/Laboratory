namespace RASF.Main.Forms.Harmony
{
    partial class SentPartToContractorsForBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentPartToContractorsForBill));
            Janus.Windows.GridEX.GridEXLayout grdBill_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpBill = new RASF.General.Controls.GroupBox();
            this.grdBill = new RASF.General.Controls.Grid();
            this.sentPartToContractorsForBillList1 = new RASF.General.Lists.SentPartToContractorsForBillList(this.components);
            this.yes_NoList1 = new RASF.General.Lists.Yes_NoList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatePickerInvoice = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new RASF.General.Controls.Label();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpBill)).BeginInit();
            this.grpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 601);
            this.pnlButton.Size = new System.Drawing.Size(1387, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(1387, 601);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1182, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1265, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1327, 0);
            // 
            // grpBill
            // 
            this.grpBill.Controls.Add(this.grdBill);
            this.grpBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBill.Location = new System.Drawing.Point(0, 0);
            this.grpBill.Name = "grpBill";
            this.grpBill.Size = new System.Drawing.Size(1383, 577);
            this.grpBill.TabIndex = 0;
            this.grpBill.Text = "صورت حساب های پیمانکاران";
            this.grpBill.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdBill
            // 
            this.grdBill.AlowRetrieveStructure = false;
            this.grdBill.AlternatingColors = true;
            this.grdBill.BuiltInTextsData = resources.GetString("grdBill.BuiltInTextsData");
            this.grdBill.DataSource = this.sentPartToContractorsForBillList1;
            this.grdBill.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBill_DesignTimeLayout.LayoutString = resources.GetString("grdBill_DesignTimeLayout.LayoutString");
            this.grdBill.DesignTimeLayout = grdBill_DesignTimeLayout;
            this.grdBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBill.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdBill.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdBill.GroupByBoxVisible = false;
            this.grdBill.Location = new System.Drawing.Point(3, 17);
            this.grdBill.Name = "grdBill";
            this.grdBill.Size = new System.Drawing.Size(1377, 557);
            this.grdBill.TabIndex = 0;
            this.grdBill.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBill.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1383, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "تاریخ صورت حساب";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 17);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatePickerInvoice);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1377, 72);
            this.splitContainer1.SplitterDistance = 344;
            this.splitContainer1.TabIndex = 0;
            // 
            // DatePickerInvoice
            // 
            this.DatePickerInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerInvoice.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.sentPartToContractorsForBillList1, "Invoicedate", true));
            this.DatePickerInvoice.IsNull = false;
            this.DatePickerInvoice.Location = new System.Drawing.Point(148, 32);
            this.DatePickerInvoice.Name = "DatePickerInvoice";
            this.DatePickerInvoice.SelectedDateTime = new System.DateTime(2014, 3, 15, 0, 0, 0, 0);
            this.DatePickerInvoice.Size = new System.Drawing.Size(145, 20);
            this.DatePickerInvoice.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "تاریخ صورت حساب";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1387, 601);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox1);
            this.uiTabPage1.Controls.Add(this.grpBill);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1383, 577);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "صورت حساب";
            // 
            // SentPartToContractorsForBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1387, 631);
            this.Name = "SentPartToContractorsForBill";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "دریافت صورت حساب از پیمانکار";
            this.Load += new System.EventHandler(this.SentPartToContractorsForVoid_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpBill)).EndInit();
            this.grpBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpBill;
        private General.Controls.Grid grdBill;
        private General.Lists.Yes_NoList yes_NoList1;
        private General.Lists.SentPartToContractorsForBillList sentPartToContractorsForBillList1;
        private General.Controls.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        protected FarsiLibrary.Win.Controls.FADatePicker DatePickerInvoice;
        private General.Controls.Label label1;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
    }
}
