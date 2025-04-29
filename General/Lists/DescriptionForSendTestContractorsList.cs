using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DescriptionForSendTestContractorsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractors>
    {
        public DescriptionForSendTestContractorsList()
        {
            this.spName = "DescriptionForSendTestContractors";
            this.list = new List<RASF.General.Data.SentPartToContractors>();
            this.deletedlist = new List<RASF.General.Data.SentPartToContractors>();
        }

        public DescriptionForSendTestContractorsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

