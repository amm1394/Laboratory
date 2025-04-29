using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CalcLaboratoryCost : RASF.General.Lists.Base.BaseList<RASF.General.Data.CalcLaboratoryCost>
    {
        public CalcLaboratoryCost()
        {
            this.spName = "CalcLaboratoryCost";
            this.list = new List<RASF.General.Data.CalcLaboratoryCost>();
            this.deletedlist = new List<RASF.General.Data.CalcLaboratoryCost>();
        }

        public CalcLaboratoryCost(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
