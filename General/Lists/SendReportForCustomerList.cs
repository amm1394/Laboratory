using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SendReportForCustomerList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_Base_Edit>
    {
        public SendReportForCustomerList()
        {
            this.spName = "SendReportForCustomer";
            this.list = new List<RASF.General.Data.Contracts_Base_Edit>();
            this.deletedlist = new List<RASF.General.Data.Contracts_Base_Edit>();
        }

        public SendReportForCustomerList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
