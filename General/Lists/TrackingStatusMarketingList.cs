using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TrackingStatusMarketingList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TrackingStatusMarketing>
    {
        public TrackingStatusMarketingList()
        {
            this.spName = "TrackingStatusMarketing";
            this.list = new List<RASF.General.Data.TrackingStatusMarketing>();
            this.deletedlist = new List<RASF.General.Data.TrackingStatusMarketing>();
        }

        public TrackingStatusMarketingList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
