using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class AssignExecutersList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AssignExecuters>
    {
        public AssignExecutersList()
        {
            this.spName = "AssignExecuters";
            this.list = new List<RASF.General.Data.AssignExecuters>();
            this.deletedlist = new List<RASF.General.Data.AssignExecuters>();
        }

        public AssignExecutersList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
