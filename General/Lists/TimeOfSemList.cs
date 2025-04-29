using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TimeOfSemList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TimeOfSem>
    {
        public TimeOfSemList()
        {
            this.spName = "TimeOfSem";
            this.list = new List<RASF.General.Data.TimeOfSem>();
            this.deletedlist = new List<RASF.General.Data.TimeOfSem>();
        }

        public TimeOfSemList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
