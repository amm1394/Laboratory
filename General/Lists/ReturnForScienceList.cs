using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReturnForScienceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Parts_Master>
    {
        public ReturnForScienceList()
        {
            this.spName = "ReturnForScience";
            this.list = new List<RASF.General.Data.Parts_Master>();
            this.deletedlist = new List<RASF.General.Data.Parts_Master>();
        }

        public ReturnForScienceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
