using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MasterBillVoidList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterBillVoid>
    {
        public MasterBillVoidList()
        {
            this.spName = "VoidingBill";
            this.list = new List<RASF.General.Data.MasterBillVoid>();
            this.deletedlist = new List<RASF.General.Data.MasterBillVoid>();
        }

        public MasterBillVoidList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
