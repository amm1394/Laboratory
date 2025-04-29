using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CheckDestructList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DeliveryDay>
    {
        public CheckDestructList()
        {
            this.spName = "CheckDestruct";
            this.list = new List<RASF.General.Data.DeliveryDay>();
            this.deletedlist = new List<RASF.General.Data.DeliveryDay>();
        }

        public CheckDestructList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

