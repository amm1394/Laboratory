using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MonthlyReport2014To2015List : RASF.General.Lists.Base.BaseList<RASF.General.Data.MonthlyReport>
    {
        public MonthlyReport2014To2015List()
        {
            this.spName = "MonthlyReport2014To2015";
            this.list = new List<RASF.General.Data.MonthlyReport>();
            this.deletedlist = new List<RASF.General.Data.MonthlyReport>();
        }

        public MonthlyReport2014To2015List(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

