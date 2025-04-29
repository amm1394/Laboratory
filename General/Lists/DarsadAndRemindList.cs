using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DarsadAndRemindList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DarsadAndRemind>
    {
        public DarsadAndRemindList()
        {
            this.spName = "DarsadAndRemind";
            this.list = new List<RASF.General.Data.DarsadAndRemind>();
            this.deletedlist = new List<RASF.General.Data.DarsadAndRemind>();
        }

        public DarsadAndRemindList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

