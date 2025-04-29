namespace RASF.Main.Controls.Reciept
{
    partial class UnKnown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nbReceiptAmount = new RASF.General.Controls.NumberBox();
            this.label4 = new RASF.General.Controls.Label();
            this.drpCash = new RASF.General.Controls.DropDown();
            this.label3 = new RASF.General.Controls.Label();
            this.label2 = new RASF.General.Controls.Label();
            this.label1 = new RASF.General.Controls.Label();
            this.label5 = new RASF.General.Controls.Label();
            this.label6 = new RASF.General.Controls.Label();
            this.drpBank = new RASF.General.Controls.DropDown();
            this.nbRemind = new RASF.General.Controls.NumberBox();
            this.label7 = new RASF.General.Controls.Label();
            this.DatePickerMoneyOrder = new FarsiLibrary.Win.Controls.FADatePicker();
            this.banksList1 = new RASF.General.Lists.BanksList(this.components);
            this.cashList1 = new RASF.General.Lists.CashList(this.components);
            this.receiptAmountMasterList1 = new RASF.General.Lists.ReceiptAmountMasterList(this.components);
            this.txtMoneyOrderNo = new RASF.General.Controls.TextBox();
            this.SuspendLayout();
            // 
            // nbReceiptAmount
            // 
            this.nbReceiptAmount.Location = new System.Drawing.Point(3, 29);
            this.nbReceiptAmount.Name = "nbReceiptAmount";
            this.nbReceiptAmount.Size = new System.Drawing.Size(169, 20);
            this.nbReceiptAmount.TabIndex = 14;
            this.nbReceiptAmount.Text = "0";
            this.nbReceiptAmount.Value = ((long)(0));
            this.nbReceiptAmount.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.nbReceiptAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = ":تاریخ حواله";
            // 
            // drpCash
            // 
            this.drpCash.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.drpCash.Location = new System.Drawing.Point(3, 3);
            this.drpCash.Name = "drpCash";
            this.drpCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpCash.Size = new System.Drawing.Size(169, 20);
            this.drpCash.TabIndex = 12;
            this.drpCash.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = ":صندوق";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = ":شماره حواله";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = ":بانک عامل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = ":مبلغ دریافتی";
            // 
            // drpBank
            // 
            this.drpBank.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.drpBank.Location = new System.Drawing.Point(3, 81);
            this.drpBank.Name = "drpBank";
            this.drpBank.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drpBank.Size = new System.Drawing.Size(169, 20);
            this.drpBank.TabIndex = 21;
            this.drpBank.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // nbRemind
            // 
            this.nbRemind.Location = new System.Drawing.Point(3, 133);
            this.nbRemind.Name = "nbRemind";
            this.nbRemind.ReadOnly = true;
            this.nbRemind.Size = new System.Drawing.Size(169, 20);
            this.nbRemind.TabIndex = 23;
            this.nbRemind.Text = "0";
            this.nbRemind.Value = ((long)(0));
            this.nbRemind.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.nbRemind.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "مانده بستانکار";
            // 
            // DatePickerMoneyOrder
            // 
            this.DatePickerMoneyOrder.IsNull = false;
            this.DatePickerMoneyOrder.Location = new System.Drawing.Point(3, 107);
            this.DatePickerMoneyOrder.Name = "DatePickerMoneyOrder";
            this.DatePickerMoneyOrder.SelectedDateTime = new System.DateTime(2014, 3, 15, 15, 34, 43, 0);
            this.DatePickerMoneyOrder.Size = new System.Drawing.Size(169, 20);
            this.DatePickerMoneyOrder.TabIndex = 24;
            this.DatePickerMoneyOrder.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // txtMoneyOrderNo
            // 
            this.txtMoneyOrderNo.Location = new System.Drawing.Point(3, 55);
            this.txtMoneyOrderNo.Name = "txtMoneyOrderNo";
            this.txtMoneyOrderNo.Size = new System.Drawing.Size(169, 20);
            this.txtMoneyOrderNo.TabIndex = 25;
            this.txtMoneyOrderNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtMoneyOrderNo.Leave += new System.EventHandler(this.txtMoneyOrderNo_Leave);
            // 
            // MoneyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtMoneyOrderNo);
            this.Controls.Add(this.DatePickerMoneyOrder);
            this.Controls.Add(this.nbRemind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.drpBank);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbReceiptAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drpCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MoneyOrder";
            this.Size = new System.Drawing.Size(252, 156);
            this.Load += new System.EventHandler(this.MoneyOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RASF.General.Controls.NumberBox nbReceiptAmount;
        private RASF.General.Controls.Label label4;
        private RASF.General.Controls.DropDown drpCash;
        private RASF.General.Controls.Label label3;
        private RASF.General.Controls.Label label2;
        private General.Controls.Label label1;
        private General.Controls.Label label5;
        private General.Controls.Label label6;
        private General.Controls.DropDown drpBank;
        private General.Controls.NumberBox nbRemind;
        private General.Controls.Label label7;
        protected FarsiLibrary.Win.Controls.FADatePicker DatePickerMoneyOrder;
        private General.Lists.BanksList banksList1;
        private General.Lists.CashList cashList1;
        private General.Lists.ReceiptAmountMasterList receiptAmountMasterList1;
        private General.Controls.TextBox txtMoneyOrderNo;
    }
}
