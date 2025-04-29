using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OpenCloseInvoiceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.OpenCloseBill>
    {
        public OpenCloseInvoiceList()
        {
            this.spName = "OpenCloseInvoice";
            this.list = new List<RASF.General.Data.OpenCloseBill>();
            this.deletedlist = new List<RASF.General.Data.OpenCloseBill>();
        }

        public OpenCloseInvoiceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

