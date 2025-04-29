using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MarketingReportFollowUpList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MarketingReportFollowUp>
    {
        public MarketingReportFollowUpList()
        {
            this.spName = "MarketingReportFollowUp";
            this.list = new List<RASF.General.Data.MarketingReportFollowUp>();
            this.deletedlist = new List<RASF.General.Data.MarketingReportFollowUp>();
        }

        public MarketingReportFollowUpList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
