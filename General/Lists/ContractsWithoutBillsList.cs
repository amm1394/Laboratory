using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsWithoutBillsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractsWithoutBills>
    {
        public ContractsWithoutBillsList()
        {
            this.spName = "ContractsWithoutBills";
            this.list = new List<RASF.General.Data.ContractsWithoutBills>();
            this.deletedlist = new List<RASF.General.Data.ContractsWithoutBills>();
        }

        public ContractsWithoutBillsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
