using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MechanicalLabDeliveryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MechanicalLabDelivery>
    {
        public MechanicalLabDeliveryList()
        {
            this.spName = "MechanicalLabDelivery";
            this.list = new List<RASF.General.Data.MechanicalLabDelivery>();
            this.deletedlist = new List<RASF.General.Data.MechanicalLabDelivery>();
        }

        public MechanicalLabDeliveryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

