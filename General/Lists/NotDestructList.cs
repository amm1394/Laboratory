using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class NotDestructList : RASF.General.Lists.Base.BaseList<RASF.General.Data.NotDestruct>
    {
        public NotDestructList()
        {
            this.spName = "NotDestruct";
            this.list = new List<RASF.General.Data.NotDestruct>();
            this.deletedlist = new List<RASF.General.Data.NotDestruct>();
        }

        public NotDestructList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
