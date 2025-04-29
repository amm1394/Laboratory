using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ShowDeliveryDateChangeForManagerList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ShowDeliveryDateChange>
    {
        public ShowDeliveryDateChangeForManagerList()
        {
            this.spName = "ShowDeliveryDateChangeForManager";
            this.list = new List<RASF.General.Data.ShowDeliveryDateChange>();
            this.deletedlist = new List<RASF.General.Data.ShowDeliveryDateChange>();
        }

        public ShowDeliveryDateChangeForManagerList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

