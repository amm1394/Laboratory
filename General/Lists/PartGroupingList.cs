using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartGroupingList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SendType>
    {
        public PartGroupingList()
        {
            this.spName = "PartGrouping";
            this.list = new List<RASF.General.Data.SendType>();
            this.deletedlist = new List<RASF.General.Data.SendType>();
        }

        public PartGroupingList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
