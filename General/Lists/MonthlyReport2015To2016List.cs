using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MonthlyReport2015To2016List : RASF.General.Lists.Base.BaseList<RASF.General.Data.MonthlyReport>
    {
        public MonthlyReport2015To2016List()
        {
            this.spName = "MonthlyReport2015To2016";
            this.list = new List<RASF.General.Data.MonthlyReport>();
            this.deletedlist = new List<RASF.General.Data.MonthlyReport>();
        }

        public MonthlyReport2015To2016List(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

