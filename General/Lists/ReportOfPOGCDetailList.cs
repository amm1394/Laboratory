using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportOfPOGCDetailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportOfPOGCDetail>
    {
        public ReportOfPOGCDetailList()
        {
            this.spName = "ReportOfPOGCDetail";
            this.list = new List<RASF.General.Data.ReportOfPOGCDetail>();
            this.deletedlist = new List<RASF.General.Data.ReportOfPOGCDetail>();
        }

        public ReportOfPOGCDetailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

