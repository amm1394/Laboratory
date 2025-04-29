using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DifferenceInvoiceContractList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DifferenceInvoiceContract>
    {
        public DifferenceInvoiceContractList()
        {
            this.spName = "DifferenceInvoiceContract";
            this.list = new List<RASF.General.Data.DifferenceInvoiceContract>();
            this.deletedlist = new List<RASF.General.Data.DifferenceInvoiceContract>();
        }

        public DifferenceInvoiceContractList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

