using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ShowOpenInvoiceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.OpenCloseBill>
    {
        public ShowOpenInvoiceList()
        {
            this.spName = "ShowOpenInvoice";
            this.list = new List<RASF.General.Data.OpenCloseBill>();
            this.deletedlist = new List<RASF.General.Data.OpenCloseBill>();
        }

        public ShowOpenInvoiceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

