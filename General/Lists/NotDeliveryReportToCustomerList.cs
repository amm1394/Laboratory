using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class NotDeliveryReportToCustomerList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Indicator>
    {
        public NotDeliveryReportToCustomerList()
        {
            this.spName = "NotDeliveryReportToCustomer";
            this.list = new List<RASF.General.Data.Indicator>();
            this.deletedlist = new List<RASF.General.Data.Indicator>();
        }

        public NotDeliveryReportToCustomerList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

