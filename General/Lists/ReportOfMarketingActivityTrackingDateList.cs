using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportOfMarketingActivityTrackingDateList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MarketingActivity>
    {
        public ReportOfMarketingActivityTrackingDateList()
        {
            this.spName = "ReportOfMarketingActivityTrackingDate";
            this.list = new List<RASF.General.Data.MarketingActivity>();
            this.deletedlist = new List<RASF.General.Data.MarketingActivity>();
        }

        public ReportOfMarketingActivityTrackingDateList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
