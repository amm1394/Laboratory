using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CostomerCostList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CostomerCost>
    {
        public CostomerCostList()
        {
            this.spName = "CostomerCost";
            this.list = new List<RASF.General.Data.CostomerCost>();
            this.deletedlist = new List<RASF.General.Data.CostomerCost>();
        }

        public CostomerCostList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
