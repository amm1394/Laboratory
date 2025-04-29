using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class EarnDeliveryDayList : RASF.General.Lists.Base.BaseList<RASF.General.Data.EarnDeliveryDay>
    {
        public EarnDeliveryDayList()
        {
            this.spName = "EarnDeliveryDay";
            this.list = new List<RASF.General.Data.EarnDeliveryDay>();
            this.deletedlist = new List<RASF.General.Data.EarnDeliveryDay>();
        }

        public EarnDeliveryDayList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

