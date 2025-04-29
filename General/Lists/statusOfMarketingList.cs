using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class statusOfMarketingList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MarketingActivity>
    {
        public statusOfMarketingList()
        {
            this.spName = "statusOfMarketing";
            this.list = new List<RASF.General.Data.MarketingActivity>();
            this.deletedlist = new List<RASF.General.Data.MarketingActivity>();
        }

        public statusOfMarketingList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

