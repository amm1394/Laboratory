using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportOfPOGCList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportOfPOGC>
    {
        public ReportOfPOGCList()
        {
            this.spName = "ReportOfPOGC";
            this.list = new List<RASF.General.Data.ReportOfPOGC>();
            this.deletedlist = new List<RASF.General.Data.ReportOfPOGC>();
        }

        public ReportOfPOGCList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

