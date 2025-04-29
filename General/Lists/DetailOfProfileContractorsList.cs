using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DetailOfProfileContractorsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ProfileOfContractors>
    {
        public DetailOfProfileContractorsList()
        {
            this.spName = "DetailOfProfileContractors";
            this.list = new List<RASF.General.Data.ProfileOfContractors>();
            this.deletedlist = new List<RASF.General.Data.ProfileOfContractors>();
        }

        public DetailOfProfileContractorsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
