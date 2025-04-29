using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Yes_NoForDestructList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Yes_No>
    {
        public Yes_NoForDestructList()
        {
            this.spName = "Yes_NoForDestruct";
            this.list = new List<RASF.General.Data.Yes_No>();
            this.deletedlist = new List<RASF.General.Data.Yes_No>();
        }

        public Yes_NoForDestructList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
