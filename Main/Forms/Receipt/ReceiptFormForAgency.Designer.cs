namespace RASF.Main.Forms.Receipt
{
    partial class ReceiptFormForAgency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptFormForAgency));
            Janus.Windows.GridEX.GridEXLayout grdCompanies_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdContracts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpCompany = new RASF.General.Controls.GroupBox();
            this.grdCompanies = new RASF.General.Controls.Grid();
            this.debtorCreditorCompaniesList1 = new RASF.General.Lists.DebtorCreditorCompaniesList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grpReceieptAmount = new RASF.General.Controls.GroupBox();
            this.pnlContain = new RASF.General.Controls.Panel();
            this.panel2 = new RASF.General.Controls.Panel();
            this.chkPrint = new RASF.General.Controls.CheckBox();
            this.panel1 = new RASF.General.Controls.Panel();
            this.drpPeyment = new RASF.General.Controls.DropDown();
            this.label1 = new RASF.General.Controls.Label();
            this.grpContract = new RASF.General.Controls.GroupBox();
            this.grdContracts = new RASF.General.Controls.Grid();
            this.debtorCreditorContractBaseList1 = new RASF.General.Lists.DebtorCreditorContractBaseList(this.components);
            this.receiptTypeList1 = new RASF.General.Lists.ReceiptTypeList(this.components);
            this.cashList1 = new RASF.General.Lists.CashList(this.components);
            this.creditorRemindList1 = new RASF.General.Lists.CreditorRemindList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompany)).BeginInit();
            this.grpCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpReceieptAmount)).BeginInit();
            this.grpReceieptAmount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContract)).BeginInit();
            this.grpContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 548);
            this.pnlButton.Size = new System.Drawing.Size(1002, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Size = new System.Drawing.Size(1002, 548);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(5019, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(880, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(942, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpCompany);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1002, 548);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.grdCompanies);
            this.grpCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompany.Location = new System.Drawing.Point(0, 0);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(1002, 277);
            this.grpCompany.TabIndex = 0;
            this.grpCompany.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompanies
            // 
            this.grdCompanies.AlowRetrieveStructure = false;
            this.grdCompanies.AlternatingColors = true;
            this.grdCompanies.BuiltInTextsData = resources.GetString("grdCompanies.BuiltInTextsData");
            this.grdCompanies.DataSource = this.debtorCreditorCompaniesList1;
            this.grdCompanies.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompanies_DesignTimeLayout.LayoutString = resources.GetString("grdCompanies_DesignTimeLayout.LayoutString");
            this.grdCompanies.DesignTimeLayout = grdCompanies_DesignTimeLayout;
            this.grdCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompanies.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompanies.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompanies.GroupByBoxVisible = false;
            this.grdCompanies.Location = new System.Drawing.Point(3, 8);
            this.grdCompanies.Name = "grdCompanies";
            this.grdCompanies.Size = new System.Drawing.Size(996, 266);
            this.grdCompanies.TabIndex = 0;
            this.grdCompanies.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompanies.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompanies.SelectionChanged += new System.EventHandler(this.grdCompanies_SelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpReceieptAmount);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grpContract);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1002, 267);
            this.splitContainer2.SplitterDistance = 295;
            this.splitContainer2.TabIndex = 0;
            // 
            // grpReceieptAmount
            // 
            this.grpReceieptAmount.Controls.Add(this.pnlContain);
            this.grpReceieptAmount.Controls.Add(this.panel2);
            this.grpReceieptAmount.Controls.Add(this.panel1);
            this.grpReceieptAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReceieptAmount.Location = new System.Drawing.Point(0, 0);
            this.grpReceieptAmount.Name = "grpReceieptAmount";
            this.grpReceieptAmount.Size = new System.Drawing.Size(295, 267);
            this.grpReceieptAmount.TabIndex = 0;
            this.grpReceieptAmount.Text = "فرم پرداخت";
            this.grpReceieptAmount.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pnlContain
            // 
            this.pnlContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContain.Location = new System.Drawing.Point(3, 47);
            this.pnlContain.Name = "pnlContain";
            this.pnlContain.Size = new System.Drawing.Size(289, 192);
            this.pnlContain.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkPrint);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 25);
            this.panel2.TabIndex = 12;
            // 
            // chkPrint
            // 
            this.chkPrint.Location = new System.Drawing.Point(199, 3);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(73, 17);
            this.chkPrint.TabIndex = 10;
            this.chkPrint.Text = "چاپ رسید";
            this.chkPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drpPeyment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 30);
            this.panel1.TabIndex = 11;
            // 
            // drpPeyment
            // 
            this.drpPeyment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drpPeyment.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.drpPeyment.Location = new System.Drawing.Point(31, 4);
            this.drpPeyment.Name = "drpPeyment";
            this.drpPeyment.Size = new System.Drawing.Size(169, 21);
            this.drpPeyment.TabIndex = 0;
            this.drpPeyment.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.drpPeyment.SelectedIndexChanged += new System.EventHandler(this.drpPeyment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(215, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نحوه پرداخت";
            // 
            // grpContract
            // 
            this.grpContract.Controls.Add(this.grdContracts);
            this.grpContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContract.Location = new System.Drawing.Point(0, 0);
            this.grpContract.Name = "grpContract";
            this.grpContract.Size = new System.Drawing.Size(703, 267);
            this.grpContract.TabIndex = 0;
            this.grpContract.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContracts
            // 
            this.grdContracts.AlowRetrieveStructure = false;
            this.grdContracts.AlternatingColors = true;
            this.grdContracts.BuiltInTextsData = resources.GetString("grdContracts.BuiltInTextsData");
            this.grdContracts.DataSource = this.debtorCreditorContractBaseList1;
            this.grdContracts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContracts_DesignTimeLayout.LayoutString = resources.GetString("grdContracts_DesignTimeLayout.LayoutString");
            this.grdContracts.DesignTimeLayout = grdContracts_DesignTimeLayout;
            this.grdContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContracts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContracts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContracts.GroupByBoxVisible = false;
            this.grdContracts.Location = new System.Drawing.Point(3, 8);
            this.grdContracts.Name = "grdContracts";
            this.grdContracts.Size = new System.Drawing.Size(697, 256);
            this.grdContracts.TabIndex = 1;
            this.grdContracts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContracts.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdContracts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ReceiptFormForAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1002, 578);
            this.MinimumSize = new System.Drawing.Size(970, 516);
            this.Name = "ReceiptFormForAgency";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCompany)).EndInit();
            this.grpCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpReceieptAmount)).EndInit();
            this.grpReceieptAmount.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpContract)).EndInit();
            this.grpContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private RASF.General.Controls.GroupBox grpCompany;
        private RASF.General.Controls.Grid grdCompanies;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private RASF.General.Controls.GroupBox grpReceieptAmount;
        private RASF.General.Controls.GroupBox grpContract;
        private RASF.General.Controls.Grid grdContracts;
        private General.Lists.DebtorCreditorCompaniesList debtorCreditorCompaniesList1;
        private General.Lists.DebtorCreditorContractBaseList debtorCreditorContractBaseList1;
        private General.Controls.Label label1;
        private General.Controls.DropDown drpPeyment;
        private General.Lists.ReceiptTypeList receiptTypeList1;
        private General.Lists.CashList cashList1;
        private General.Lists.CreditorRemindList creditorRemindList1;
        private General.Controls.CheckBox chkPrint;
        private General.Controls.Panel pnlContain;
        private General.Controls.Panel panel2;
        private General.Controls.Panel panel1;
    }
}
