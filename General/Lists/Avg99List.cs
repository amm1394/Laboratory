using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Avg99List : RASF.General.Lists.Base.BaseList<RASF.General.Data.AVGDailyProcessReport>
    {
        public Avg99List()
        {
            this.spName = "Avg98-99";
            this.list = new List<RASF.General.Data.AVGDailyProcessReport>();
            this.deletedlist = new List<RASF.General.Data.AVGDailyProcessReport>();
        }

        public Avg99List(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

