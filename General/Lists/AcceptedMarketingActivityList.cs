using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class AcceptedMarketingActivityList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MarketingActivity>
    {
        public AcceptedMarketingActivityList()
        {
            this.spName = "AcceptedMarketingActivity";
            this.list = new List<RASF.General.Data.MarketingActivity>();
            this.deletedlist = new List<RASF.General.Data.MarketingActivity>();
        }

        public AcceptedMarketingActivityList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
