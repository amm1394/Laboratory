using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CostomersCostGridForOfficesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.costomersCostGrid>
    {
        public CostomersCostGridForOfficesList()
        {
            this.spName = "costomersCostGridforOffices";
            this.list = new List<RASF.General.Data.costomersCostGrid>();
            this.deletedlist = new List<RASF.General.Data.costomersCostGrid>();
        }

        public CostomersCostGridForOfficesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
