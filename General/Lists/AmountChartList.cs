using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class AmountChartList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AmountChart>
    {
        public AmountChartList()
        {
            this.spName = "AmountChart";
            this.list = new List<RASF.General.Data.AmountChart>();
            this.deletedlist = new List<RASF.General.Data.AmountChart>();
        }

        public AmountChartList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
