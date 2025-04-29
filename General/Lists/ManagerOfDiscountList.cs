using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ManagerOfDiscountList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DeliveryDay>
    {
        public ManagerOfDiscountList()
        {
            this.spName = "ManagerOfDiscount";
            this.list = new List<RASF.General.Data.DeliveryDay>();
            this.deletedlist = new List<RASF.General.Data.DeliveryDay>();
        }

        public ManagerOfDiscountList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

