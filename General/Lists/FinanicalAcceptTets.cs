using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    public class FinanicalAcceptTets : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterBillDetailBill>
    {
        public FinanicalAcceptTets()
        {
            this.spName = "FianacialAcceptsTests";
            this.list = new List<RASF.General.Data.MasterBillDetailBill>();
            this.deletedlist = new List<RASF.General.Data.MasterBillDetailBill>();
        }

        public FinanicalAcceptTets(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public void UpdateRow()
        {
            try
            {
                foreach (RASF.General.Data.MasterBillDetailBill MasterBillDetailBill in this)
                {
                    if (MasterBillDetailBill.RowState != Enums.RowState.Added)
                    {
                        MasterBillDetailBill.RowState = Enums.RowState.Updated;
                    }
                    Int64 Price = MasterBillDetailBill.InvoicePrice * MasterBillDetailBill.NumberOfTests;
                    Int64 Discount = (Int64)(Price * (MasterBillDetailBill.DisCount / 100.0));
                    MasterBillDetailBill.TotalDisCount = Discount;
                    MasterBillDetailBill.TotalTax = (Int64)((Price - Discount) * (MasterBillDetailBill.Tax / 100.0));
                    MasterBillDetailBill.TotalPrice = (Int64)(Price - Discount + MasterBillDetailBill.TotalTax);
                }
            }
            catch
            { 
            }
        }
    }
}
