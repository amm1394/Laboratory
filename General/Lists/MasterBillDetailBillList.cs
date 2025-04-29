using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MasterBillDetailBillList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterBillDetailBill>
    {
        public MasterBillDetailBillList()
        {
            this.spName = "MasterBill_DetailBill";
            this.list = new List<RASF.General.Data.MasterBillDetailBill>();
            this.deletedlist = new List<RASF.General.Data.MasterBillDetailBill>();
        }

        public MasterBillDetailBillList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public void UpdateRow()
        {
            foreach (RASF.General.Data.MasterBillDetailBill MasterBillDetailBill in this)
            {
                MasterBillDetailBill.RowState = Enums.RowState.Updated;
                Int64 Price = MasterBillDetailBill.InvoicePrice * MasterBillDetailBill.NumberOfTests;
                Int64 Discount = (Int64)(Price * (MasterBillDetailBill.DisCount / 100.0));
                MasterBillDetailBill.TotalTax = (Int64)((Price - Discount) * (MasterBillDetailBill.Tax / 100.0));
                MasterBillDetailBill.TotalPrice = (Int64)(Price - Discount + MasterBillDetailBill.TotalTax);
            }
        }

        public string Survey(Guid ContractsCode)
        {
            String ReportName;

            RASF.General.Classes.Global.LastUpdate = DateTime.Now;
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(updateconnectionString))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("SurveyFrom_select", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", ContractsCode));
                    Connection.Open();

                    ReportName = (string)Command.ExecuteScalar();
                    Connection.Close();
                }
            }
            return ReportName;
        }
    }
    
}
