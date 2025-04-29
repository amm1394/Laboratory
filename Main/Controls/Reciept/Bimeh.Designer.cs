namespace RASF.Main.Controls.Reciept
{
    partial class Bimeh
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
            this.drpCash = new RASF.General.Controls.DropDown();
            this.label3 = new RASF.General.Controls.Label();
            this.label2 = new RASF.General.Controls.Label();
            this.cashList1 = new RASF.General.Lists.CashList(this.components);
            this.SuspendLayout();
            // 
            // nbReceiptAmount
            // 
            this.nbReceiptAmount.Location = new System.Drawing.Point(3, 43);
            this.nbReceiptAmount.Name = "nbReceiptAmount";
            this.nbReceiptAmount.Size = new System.Drawing.Size(169, 20);
            this.nbReceiptAmount.TabIndex = 14;
            this.nbReceiptAmount.Text = "0";
            this.nbReceiptAmount.Value = ((long)(0));
            this.nbReceiptAmount.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            this.nbReceiptAmount.Visible = false;
            this.nbReceiptAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // drpCash
            // 
            this.drpCash.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.drpCash.Location = new System.Drawing.Point(3, 3);
            this.drpCash.Name = "drpCash";
            this.drpCash.Size = new System.Drawing.Size(169, 20);
            this.drpCash.TabIndex = 12;
            this.drpCash.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "صندوق";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "مبلغ دریافتی";
            this.label2.Visible = false;
            // 
            // Bimeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.nbReceiptAmount);
            this.Controls.Add(this.drpCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Bimeh";
            this.Size = new System.Drawing.Size(252, 78);
            this.Load += new System.EventHandler(this.Cash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RASF.General.Controls.NumberBox nbReceiptAmount;
        private RASF.General.Controls.DropDown drpCash;
        private RASF.General.Controls.Label label3;
        private RASF.General.Controls.Label label2;
        private General.Lists.CashList cashList1;
    }
}
