using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ActingGroupList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SendType>
    {
        public ActingGroupList()
        {
            this.spName = "ActingGroup";
            this.list = new List<RASF.General.Data.SendType>();
            this.deletedlist = new List<RASF.General.Data.SendType>();
        }

        public ActingGroupList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
