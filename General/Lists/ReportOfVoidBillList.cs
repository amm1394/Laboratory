using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportOfVoidBillList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterBillVoid>
    {
        public ReportOfVoidBillList()
        {
            this.spName = "ReportOfVoidBill";
            this.list = new List<RASF.General.Data.MasterBillVoid>();
            this.deletedlist = new List<RASF.General.Data.MasterBillVoid>();
        }

        public ReportOfVoidBillList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
