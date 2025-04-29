using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RecieptionLongIsHoldTestList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DeliveryDay>
    {
        public RecieptionLongIsHoldTestList()
        {
            this.spName = "RecieptionLongIsHoldTest";
            this.list = new List<RASF.General.Data.DeliveryDay>();
            this.deletedlist = new List<RASF.General.Data.DeliveryDay>();
        }

        public RecieptionLongIsHoldTestList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

