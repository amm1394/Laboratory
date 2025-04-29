using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SentPartToContractorsDetailReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractorsDetailReport>
    {
        public SentPartToContractorsDetailReportList()
        {
            this.spName = "SentPartToContractorsDetailReport";
            this.list = new List<RASF.General.Data.SentPartToContractorsDetailReport>();
            this.deletedlist = new List<RASF.General.Data.SentPartToContractorsDetailReport>();
        }

        public SentPartToContractorsDetailReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

