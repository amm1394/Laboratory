using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Avg98List : RASF.General.Lists.Base.BaseList<RASF.General.Data.DailyProcessReport>
    {
        public Avg98List()
        {
            this.spName = "Avg98";
            this.list = new List<RASF.General.Data.DailyProcessReport>();
            this.deletedlist = new List<RASF.General.Data.DailyProcessReport>();
        }

        public Avg98List(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

