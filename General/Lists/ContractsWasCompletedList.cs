using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsWasCompletedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractsWasCompleted>
    {
        public ContractsWasCompletedList()
        {
            this.spName = "ContractsWasCompleted";
            this.list = new List<RASF.General.Data.ContractsWasCompleted>();
            this.deletedlist = new List<RASF.General.Data.ContractsWasCompleted>();
        }

        public ContractsWasCompletedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
