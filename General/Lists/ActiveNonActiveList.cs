using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ActiveNonActiveList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ActiveNonActive>
    {
        public ActiveNonActiveList()
        {
            this.spName = "ActiveNonActive";
            this.list = new List<RASF.General.Data.ActiveNonActive>();
            this.deletedlist = new List<RASF.General.Data.ActiveNonActive>();
        }

        public ActiveNonActiveList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
