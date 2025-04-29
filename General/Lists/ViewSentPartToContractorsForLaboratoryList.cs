using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ViewSentPartToContractorsForLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractorsReport>
    {
        public ViewSentPartToContractorsForLaboratoryList()
        {
            this.spName = "ViewSentPartToContractorsForLaboratory";
            this.list = new List<RASF.General.Data.SentPartToContractorsReport>();
            this.deletedlist = new List<RASF.General.Data.SentPartToContractorsReport>();
        }

        public ViewSentPartToContractorsForLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

