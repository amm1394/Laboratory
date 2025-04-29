using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ChengeForAmountOfBillList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Billsissued>
    {
        public ChengeForAmountOfBillList()
        {
            this.spName = "ChengeForAmountOfBill";
            this.list = new List<RASF.General.Data.Billsissued>();
            this.deletedlist = new List<RASF.General.Data.Billsissued>();
        }

        public ChengeForAmountOfBillList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
