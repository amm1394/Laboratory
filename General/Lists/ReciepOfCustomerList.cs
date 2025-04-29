using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReciepOfCustomerList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReciepOfCustomer>
    {
        public ReciepOfCustomerList()
        {
            this.spName = "ReciepOfCustomer";
            this.list = new List<RASF.General.Data.ReciepOfCustomer>();
            this.deletedlist = new List<RASF.General.Data.ReciepOfCustomer>();
        }

        public ReciepOfCustomerList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
