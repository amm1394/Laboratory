using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class BillReissuesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterBillDetailBill>
    {
        public BillReissuesList()
        {
            this.spName = "Bill_Reissues";
            this.list = new List<RASF.General.Data.MasterBillDetailBill>();
            this.deletedlist = new List<RASF.General.Data.MasterBillDetailBill>();
        }

        public BillReissuesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);

            List<RASF.General.Data.MasterBillDetailBill> Parts_Test = this.list.Where(row => row.IsPartsTest == 1).ToList();
            List<RASF.General.Data.MasterBillDetailBill> Detail_Bill = this.list.Where(row => row.IsPartsTest == 0).ToList();
            this.list.Clear();

            
            for (int i = 0; i <= Parts_Test.Count(); )
            {
                RASF.General.Data.MasterBillDetailBill row = Detail_Bill.Where(r => r.MasterTestCode == Parts_Test[i].MasterTestCode).SingleOrDefault();
                if (row != null)
                {
                    if ((Parts_Test[i].NumberOfTests != row.NumberOfTests) || (Parts_Test[i].Tax != row.Tax) || (Parts_Test[i].DisCount != row.DisCount) || (Parts_Test[i].InvoicePrice != row.InvoicePrice))
                    {
                        row.RowState = Enums.RowState.Updated;
                        row.NumberOfTests = Parts_Test[i].NumberOfTests;
                    }
                    this.list.Add(row);
                    Parts_Test.RemoveAt(i);
                    Detail_Bill.Remove(row);
                }
                else
                {
                    i++;
                }
                if ((Parts_Test.Count() == 0) || (i == Parts_Test.Count()))
                {
                    break;
                }
            }
            foreach (RASF.General.Data.MasterBillDetailBill row in Parts_Test)
            {
                row.RowState = Enums.RowState.Added;
                this.list.Add(row);
            }

            foreach (RASF.General.Data.MasterBillDetailBill row in Detail_Bill)
            {
                row.RowState = Enums.RowState.Deleted;
                this.deletedlist .Add(row);
            }

            return this.list.Count;
        }
        public void UpdateRow()
        {
            foreach (RASF.General.Data.MasterBillDetailBill MasterBillDetailBill in this)
            {
                if (MasterBillDetailBill.RowState != Enums.RowState.Added)
                {
                    MasterBillDetailBill.RowState = Enums.RowState.Updated;
                }
                Single Price = MasterBillDetailBill.InvoicePrice * MasterBillDetailBill.NumberOfTests;
                Single Discount = (Int32)(Price * (MasterBillDetailBill.DisCount / 100.0));
                MasterBillDetailBill.TotalTax = (Int32)((Price - Discount) * (MasterBillDetailBill.Tax / 100.0));
                MasterBillDetailBill.TotalPrice = (Int32)(Price - Discount + MasterBillDetailBill.TotalTax);
            }
        }
    }
    
}
