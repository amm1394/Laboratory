using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ShowDeliveryDateChangeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ShowDeliveryDateChange>
    {
        public ShowDeliveryDateChangeList()
        {
            this.spName = "ShowDeliveryDateChange";
            this.list = new List<RASF.General.Data.ShowDeliveryDateChange>();
            this.deletedlist = new List<RASF.General.Data.ShowDeliveryDateChange>();
        }

        public ShowDeliveryDateChangeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

