using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TurnoverreachedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Turnoverreached>
    {
        public TurnoverreachedList()
        {
            this.spName = "Turnoverreached";
            this.list = new List<RASF.General.Data.Turnoverreached>();
            this.deletedlist = new List<RASF.General.Data.Turnoverreached>();
        }

        public TurnoverreachedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
