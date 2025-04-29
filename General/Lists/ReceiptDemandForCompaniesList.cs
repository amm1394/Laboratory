using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReceiptDemandForCompaniesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReceiptDemandForCompanies>
    {
        public ReceiptDemandForCompaniesList()
        {
            this.spName = "ReceiptDemandForCompanies";
            this.list = new List<RASF.General.Data.ReceiptDemandForCompanies>();
            this.deletedlist = new List<RASF.General.Data.ReceiptDemandForCompanies>();
        }

        public ReceiptDemandForCompaniesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

