using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RecieveExperimentFromContractorList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractors>
    {
        public RecieveExperimentFromContractorList()
        {
            this.spName = "RecieveExperimentFromContractor";
            this.list = new List<RASF.General.Data.SentPartToContractors>();
            this.deletedlist = new List<RASF.General.Data.SentPartToContractors>();
        }

        public RecieveExperimentFromContractorList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

