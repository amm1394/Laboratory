using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ProfileOfContractorsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ProfileOfContractors>
    {
        public ProfileOfContractorsList()
        {
            this.spName = "ProfileOfContractors";
            this.list = new List<RASF.General.Data.ProfileOfContractors>();
            this.deletedlist = new List<RASF.General.Data.ProfileOfContractors>();
        }

        public ProfileOfContractorsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

