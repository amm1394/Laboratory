using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportOfInvoiceOfContractorsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractors>
    {
        public ReportOfInvoiceOfContractorsList()
        {
            this.spName = "ReportOfInvoiceOfContractors";
            this.list = new List<RASF.General.Data.SentPartToContractors>();
            this.deletedlist = new List<RASF.General.Data.SentPartToContractors>();
        }

        public ReportOfInvoiceOfContractorsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

