using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SettledcontractsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Settledcontracts>
    {
        public SettledcontractsList()
        {
            this.spName = "Settledcontracts";
            this.list = new List<RASF.General.Data.Settledcontracts>();
            this.deletedlist = new List<RASF.General.Data.Settledcontracts>();
        }

        public SettledcontractsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
