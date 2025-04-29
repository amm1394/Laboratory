using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RemindSeparatedbycustomerCashList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RemindSeparatedbycustomer>
    {
        public RemindSeparatedbycustomerCashList()
        {
            this.spName = "RemindSeparatedbycustomerCash";
            this.list = new List<RASF.General.Data.RemindSeparatedbycustomer>();
            this.deletedlist = new List<RASF.General.Data.RemindSeparatedbycustomer>();
        }

        public RemindSeparatedbycustomerCashList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
