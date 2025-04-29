using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class HaghighiHoghughiList : RASF.General.Lists.Base.BaseList<RASF.General.Data.HaghighiHoghughi>
    {
        public HaghighiHoghughiList()
        {
            this.spName = "HaghighiHoghughi";
            this.list = new List<RASF.General.Data.HaghighiHoghughi>();
            this.deletedlist = new List<RASF.General.Data.HaghighiHoghughi>();
        }

        public HaghighiHoghughiList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
