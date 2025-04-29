using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Yes_NoList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Yes_No>
    {
        public Yes_NoList()
        {
            this.spName = "Yes_No";
            this.list = new List<RASF.General.Data.Yes_No>();
            this.deletedlist = new List<RASF.General.Data.Yes_No>();
        }

        public Yes_NoList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
