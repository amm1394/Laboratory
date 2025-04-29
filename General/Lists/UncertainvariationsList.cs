using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class UncertainvariationsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.uncertainvariations>
    {
        public UncertainvariationsList()
        {
            this.spName = "Uncertainvariations";
            this.list = new List<RASF.General.Data.uncertainvariations>();
            this.deletedlist = new List<RASF.General.Data.uncertainvariations>();
        }

        public UncertainvariationsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
