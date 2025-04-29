using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SentPartToContractorsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractors>
    {
        public SentPartToContractorsList()
        {
            this.spName = "SentPartToContractors";
            this.list = new List<RASF.General.Data.SentPartToContractors>();
            this.deletedlist = new List<RASF.General.Data.SentPartToContractors>();
        }

        public SentPartToContractorsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

