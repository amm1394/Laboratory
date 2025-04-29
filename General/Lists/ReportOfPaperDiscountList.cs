using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportOfPaperDiscountList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DeliveryDay>
    {
        public ReportOfPaperDiscountList()
        {
            this.spName = "ReportOfPaperDiscount";
            this.list = new List<RASF.General.Data.DeliveryDay>();
            this.deletedlist = new List<RASF.General.Data.DeliveryDay>();
        }

        public ReportOfPaperDiscountList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

