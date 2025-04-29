using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DebtorCreditorContractBaseList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DebtorCreditorContractBase>
    {
        public DebtorCreditorContractBaseList()
        {
            this.spName = "DebtorCreditorContractBase";
            this.list = new List<RASF.General.Data.DebtorCreditorContractBase>();
            this.deletedlist = new List<RASF.General.Data.DebtorCreditorContractBase>();
        }

        public DebtorCreditorContractBaseList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);
            this.list[0].Reminding = this.list[0].RemindAfterIns - this.list[0].ReceiptAmount;

            if (this.list.Count > 1)
            {
                for (int i = 1; i < this.list.Count; i++)
                {
                    this.list[i].Reminding = this.list[i].RemindAfterIns - this.list[i].ReceiptAmount;

                }
            }
            return this.list.Count;

        }
    }
    
}
