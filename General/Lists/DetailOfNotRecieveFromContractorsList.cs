using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DetailOfNotRecieveFromContractorsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DetailOfNotRecieveFromContractors>
    {
        public DetailOfNotRecieveFromContractorsList()
        {
            this.spName = "DetailOfNotRecieveFromContractors";
            this.list = new List<RASF.General.Data.DetailOfNotRecieveFromContractors>();
            this.deletedlist = new List<RASF.General.Data.DetailOfNotRecieveFromContractors>();
        }

        public DetailOfNotRecieveFromContractorsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
