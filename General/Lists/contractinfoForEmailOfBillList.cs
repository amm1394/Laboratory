using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class contractinfoForEmailOfBillList : RASF.General.Lists.Base.BaseList<RASF.General.Data.contractinfoForEmailOfBill>
    {
        public contractinfoForEmailOfBillList()
        {
            this.spName = "contractinfoForEmailOfBill";
            this.list = new List<RASF.General.Data.contractinfoForEmailOfBill>();
            this.deletedlist = new List<RASF.General.Data.contractinfoForEmailOfBill>();
        }

        public contractinfoForEmailOfBillList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
