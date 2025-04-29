using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RemindSeparatedbycustomerMarketingList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RemindSeparatedbycustomer>
    {
        public RemindSeparatedbycustomerMarketingList()
        {
            this.spName = "RemindSeparatedbycustomerMarketing";
            this.list = new List<RASF.General.Data.RemindSeparatedbycustomer>();
            this.deletedlist = new List<RASF.General.Data.RemindSeparatedbycustomer>();
        }

        public RemindSeparatedbycustomerMarketingList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
