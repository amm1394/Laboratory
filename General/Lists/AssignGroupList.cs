using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class AssignGroupList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AssignGroup>
    {
        public AssignGroupList()
        {
            this.spName = "AssignGroup";
            this.list = new List<RASF.General.Data.AssignGroup>();
            this.deletedlist = new List<RASF.General.Data.AssignGroup>();
        }

        public AssignGroupList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

