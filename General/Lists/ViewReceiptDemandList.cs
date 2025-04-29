using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ViewReceiptDemandList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReceiptDemandForCompanies>
    {
        public ViewReceiptDemandList()
        {
            this.spName = "ViewReceiptDemand";
            this.list = new List<RASF.General.Data.ReceiptDemandForCompanies>();
            this.deletedlist = new List<RASF.General.Data.ReceiptDemandForCompanies>();
        }

        public ViewReceiptDemandList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

