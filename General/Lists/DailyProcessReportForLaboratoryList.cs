using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DailyProcessReportForLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DailyProcessReportForLaboratory>
    {
        public DailyProcessReportForLaboratoryList()
        {
            this.spName = "DailyProcessReportForLaboratory";
            this.list = new List<RASF.General.Data.DailyProcessReportForLaboratory>();
            this.deletedlist = new List<RASF.General.Data.DailyProcessReportForLaboratory>();
        }

        public DailyProcessReportForLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

