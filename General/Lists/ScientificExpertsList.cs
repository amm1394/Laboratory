using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ScientificExpertsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TestExecutersLaboratorys>
    {
        public ScientificExpertsList()
        {
            this.spName = "ScientificExperts";
            this.list = new List<RASF.General.Data.TestExecutersLaboratorys>();
            this.deletedlist = new List<RASF.General.Data.TestExecutersLaboratorys>();
        }

        public ScientificExpertsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

