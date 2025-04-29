using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DeliveryDateChangeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DeliveryDateChange>
    {
        public DeliveryDateChangeList()
        {
            this.spName = "DeliveryDateChange";
            this.list = new List<RASF.General.Data.DeliveryDateChange>();
            this.deletedlist = new List<RASF.General.Data.DeliveryDateChange>();
        }

        public DeliveryDateChangeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

