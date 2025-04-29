using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MonthlyReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MonthlyReport>
    {
        public MonthlyReportList()
        {
            this.spName = "MonthlyReport";
            this.list = new List<RASF.General.Data.MonthlyReport>();
            this.deletedlist = new List<RASF.General.Data.MonthlyReport>();
        }

        public MonthlyReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

