using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OrderStatusCreditCompanyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.OrderStatusCompany>
    {
        public OrderStatusCreditCompanyList()
        {
            this.spName = "OrderStatuseCreditCompany";
            this.list = new List<RASF.General.Data.OrderStatusCompany>();
            this.deletedlist = new List<RASF.General.Data.OrderStatusCompany>();
        }

        public OrderStatusCreditCompanyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
