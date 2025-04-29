using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DebtorInvoiceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DebtorInvoice>
    {
        public DebtorInvoiceList()
        {
            this.spName = "DebtorInvoice";
            this.list = new List<RASF.General.Data.DebtorInvoice>();
            this.deletedlist = new List<RASF.General.Data.DebtorInvoice>();
        }

        public DebtorInvoiceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
