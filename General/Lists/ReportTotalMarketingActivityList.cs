using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportTotalMarketingActivityList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MarketingActivity>
    {
        public ReportTotalMarketingActivityList()
        {
            this.spName = "ReportTotalMarketingActivity";
            this.list = new List<RASF.General.Data.MarketingActivity>();
            this.deletedlist = new List<RASF.General.Data.MarketingActivity>();
        }

        public ReportTotalMarketingActivityList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
