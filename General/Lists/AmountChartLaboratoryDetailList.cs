using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class AmountChartLaboratoryDetailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AmountChart>
    {
        public AmountChartLaboratoryDetailList()
        {
            this.spName = "AmountChartLaboratoryDetail";
            this.list = new List<RASF.General.Data.AmountChart>();
            this.deletedlist = new List<RASF.General.Data.AmountChart>();
        }

        public AmountChartLaboratoryDetailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
