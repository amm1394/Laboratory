using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SendEmailCostomerCostPDFForOfficesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SendEmailOfCostOfCustomer>
    {
        public SendEmailCostomerCostPDFForOfficesList()
        {
            this.spName = "SendEmailOfCostOfCustomerForOffices";
            this.list = new List<RASF.General.Data.SendEmailOfCostOfCustomer>();
            this.deletedlist = new List<RASF.General.Data.SendEmailOfCostOfCustomer>();
        }

        public SendEmailCostomerCostPDFForOfficesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

