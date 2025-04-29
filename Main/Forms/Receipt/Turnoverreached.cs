using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Receipt
{
    public partial class Turnoverreached : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ReceiptMasterCode;
        public Turnoverreached(Guid receiptMasterCode)
        {
            InitializeComponent();
            this.ReceiptMasterCode = receiptMasterCode;
        }

        private void Turnoverreached_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ReceiptMasterCode", ReceiptMasterCode));
            this.turnoverreachedList1.Fill(Parameter);
            this.grdAmount.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdAmount.ExportToExcel("گردش مالی دریافت وجه");
        }
    }
}
