using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportOfRemindHaghighiList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportOfRemindHaghighi>
    {
        public ReportOfRemindHaghighiList()
        {
            this.spName = "ReportOfRemindHaghighi";
            this.list = new List<RASF.General.Data.ReportOfRemindHaghighi>();
            this.deletedlist = new List<RASF.General.Data.ReportOfRemindHaghighi>();
        }

        public ReportOfRemindHaghighiList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

