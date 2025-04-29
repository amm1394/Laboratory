using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TypesOfCostStatementsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TypesOfCostStatements>
    {
        public TypesOfCostStatementsList()
        {
            this.spName = "TypesOfCostStatements";
            this.list = new List<RASF.General.Data.TypesOfCostStatements>();
            this.deletedlist = new List<RASF.General.Data.TypesOfCostStatements>();
        }

        public TypesOfCostStatementsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
