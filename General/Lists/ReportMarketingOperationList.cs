using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportMarketingOperationList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MarketingActivity>
    {
        public ReportMarketingOperationList()
        {
            this.spName = "ReportMarketingOperation";
            this.list = new List<RASF.General.Data.MarketingActivity>();
            this.deletedlist = new List<RASF.General.Data.MarketingActivity>();
        }

        public ReportMarketingOperationList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
