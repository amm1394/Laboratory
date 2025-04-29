using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SendEmailOfBillsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SendEmailOfCostOfCustomer>
    {
        public SendEmailOfBillsList()
        {
            this.spName = "SendEmailOfBills";
            this.list = new List<RASF.General.Data.SendEmailOfCostOfCustomer>();
            this.deletedlist = new List<RASF.General.Data.SendEmailOfCostOfCustomer>();
        }

        public SendEmailOfBillsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}

