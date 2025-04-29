using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class AmountChartDetailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AmountChart>
    {
        public AmountChartDetailList()
        {
            this.spName = "AmountChartDetail";
            this.list = new List<RASF.General.Data.AmountChart>();
            this.deletedlist = new List<RASF.General.Data.AmountChart>();
        }

        public AmountChartDetailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
