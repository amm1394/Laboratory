using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportOfDaneshBonyanList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportOfDaneshBonyan>
    {
        public ReportOfDaneshBonyanList()
        {
            this.spName = "ReportOfDaneshBonyan";
            this.list = new List<RASF.General.Data.ReportOfDaneshBonyan>();
            this.deletedlist = new List<RASF.General.Data.ReportOfDaneshBonyan>();
        }

        public ReportOfDaneshBonyanList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

