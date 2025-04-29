namespace RASF.Main.Forms.PeymentAmount
{
    partial class PayMentAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayMentAmount));
            Janus.Windows.GridEX.GridEXLayout grdCompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpCompany = new RASF.General.Controls.GroupBox();
            this.grdCompany = new RASF.General.Controls.Grid();
            this.copmanyPaymentList1 = new RASF.General.Lists.CopmanyPaymentList(this.components);
            this.grpPay = new RASF.General.Controls.GroupBox();
            this.pnlContain = new RASF.General.Controls.Panel();
            this.chkPrint = new RASF.General.Controls.CheckBox();
            this.panel1 = new RASF.General.Controls.Panel();
            this.grppayment = new RASF.General.Controls.GroupBox();
            this.drppayment = new RASF.General.Controls.DropDown();
            this.paymentTypesList1 = new RASF.General.Lists.PaymentTypesList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompany)).BeginInit();
            this.grpCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPay)).BeginInit();
            this.grpPay.SuspendLayout();
            this.pnlContain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grppayment)).BeginInit();
            this.grppayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 514);
            this.pnlButton.Size = new System.Drawing.Size(823, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpPay);
            this.pnlContent.Location = new System.Drawing.Point(0, 450);
            this.pnlContent.Size = new System.Drawing.Size(823, 64);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(618, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(701, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(763, 0);
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.grdCompany);
            this.grpCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCompany.Location = new System.Drawing.Point(0, 0);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(823, 450);
            this.grpCompany.TabIndex = 0;
            this.grpCompany.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompany
            // 
            this.grdCompany.AlowRetrieveStructure = false;
            this.grdCompany.AlternatingColors = true;
            this.grdCompany.BuiltInTextsData = resources.GetString("grdCompany.BuiltInTextsData");
            this.grdCompany.DataSource = this.copmanyPaymentList1;
            this.grdCompany.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompany_DesignTimeLayout.LayoutString = resources.GetString("grdCompany_DesignTimeLayout.LayoutString");
            this.grdCompany.DesignTimeLayout = grdCompany_DesignTimeLayout;
            this.grdCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompany.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompany.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompany.GroupByBoxVisible = false;
            this.grdCompany.Location = new System.Drawing.Point(3, 8);
            this.grdCompany.Name = "grdCompany";
            this.grdCompany.Size = new System.Drawing.Size(817, 439);
            this.grdCompany.TabIndex = 0;
            this.grdCompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompany.SelectionChanged += new System.EventHandler(this.grdCompany_SelectionChanged);
            // 
            // grpPay
            // 
            this.grpPay.Controls.Add(this.pnlContain);
            this.grpPay.Controls.Add(this.panel1);
            this.grpPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPay.Location = new System.Drawing.Point(0, 0);
            this.grpPay.Name = "grpPay";
            this.grpPay.Size = new System.Drawing.Size(823, 64);
            this.grpPay.TabIndex = 0;
            this.grpPay.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pnlContain
            // 
            this.pnlContain.Controls.Add(this.chkPrint);
            this.pnlContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContain.Location = new System.Drawing.Point(3, 8);
            this.pnlContain.Name = "pnlContain";
            this.pnlContain.Size = new System.Drawing.Size(617, 53);
            this.pnlContain.TabIndex = 1;
            // 
            // chkPrint
            // 
            this.chkPrint.Location = new System.Drawing.Point(538, 33);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(73, 17);
            this.chkPrint.TabIndex = 11;
            this.chkPrint.Text = "چاپ رسید";
            this.chkPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grppayment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(620, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 53);
            this.panel1.TabIndex = 0;
            // 
            // grppayment
            // 
            this.grppayment.Controls.Add(this.drppayment);
            this.grppayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grppayment.Location = new System.Drawing.Point(0, 0);
            this.grppayment.Name = "grppayment";
            this.grppayment.Size = new System.Drawing.Size(200, 53);
            this.grppayment.TabIndex = 0;
            this.grppayment.Text = "نحوه پرداخت";
            this.grppayment.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // drppayment
            // 
            this.drppayment.DataSource = this.paymentTypesList1;
            this.drppayment.Location = new System.Drawing.Point(25, 14);
            this.drppayment.Name = "drppayment";
            this.drppayment.Size = new System.Drawing.Size(159, 21);
            this.drppayment.TabIndex = 0;
            this.drppayment.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.drppayment.SelectedIndexChanged += new System.EventHandler(this.drppayment_SelectedIndexChanged);
            // 
            // PayMentAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 544);
            this.Controls.Add(this.grpCompany);
            this.Name = "PayMentAmount";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.TabText = "پرداخت وجه";
            this.Text = "پرداخت وجه";
            this.Load += new System.EventHandler(this.PayMentAmount_Load);
            this.Controls.SetChildIndex(this.grpCompany, 0);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCompany)).EndInit();
            this.grpCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPay)).EndInit();
            this.grpPay.ResumeLayout(false);
            this.pnlContain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grppayment)).EndInit();
            this.grppayment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpCompany;
        private RASF.General.Controls.GroupBox grpPay;
        private RASF.General.Controls.Grid grdCompany;
        private RASF.General.Lists.CopmanyPaymentList copmanyPaymentList1;
        private General.Controls.Panel pnlContain;
        private General.Controls.Panel panel1;
        private General.Controls.GroupBox grppayment;
        private General.Controls.DropDown drppayment;
        private General.Lists.PaymentTypesList paymentTypesList1;
        private General.Controls.CheckBox chkPrint;
    }
}