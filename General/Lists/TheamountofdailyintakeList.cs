using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TheamountofdailyintakeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Theamountofdailyintake>
    {
        public TheamountofdailyintakeList()
        {
            this.spName = "Theamountofdailyintake";
            this.list = new List<RASF.General.Data.Theamountofdailyintake>();
            this.deletedlist = new List<RASF.General.Data.Theamountofdailyintake>();
        }

        public TheamountofdailyintakeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
