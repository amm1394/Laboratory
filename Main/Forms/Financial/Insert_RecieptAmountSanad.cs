using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class Insert_RecieptAmountSanad : RASF.General.Forms.Base.DockContentForm
    {
        DateTime ReceiptDate = DateTime.MinValue;
        public Insert_RecieptAmountSanad()
        {
            InitializeComponent();
        }

        private void pickDateFrom1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            this.ReceiptDate = e.From;
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ReceiptDate", this.ReceiptDate));
            this.insert_RecieptAmountSanadList1.Fill(Parameter);

            this.grdSanad.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ReceiptDate != DateTime.MinValue)
            {
                this.insert_RecieptAmountSanadList1.Update(this.ReceiptDate);
                this.ReceiptDate = DateTime.MinValue;
            }
        }
    }
}
