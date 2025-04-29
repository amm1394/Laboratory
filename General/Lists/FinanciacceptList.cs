using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FinanciacceptList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_Base_Edit>
    {
        public FinanciacceptList()
        {
            this.spName = "Financiaccept";
            this.list = new List<RASF.General.Data.Contracts_Base_Edit>();
            this.deletedlist = new List<RASF.General.Data.Contracts_Base_Edit>();

        }

        public FinanciacceptList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
