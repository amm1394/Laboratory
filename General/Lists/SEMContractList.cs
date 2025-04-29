using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SEMContractList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TimeOfSem>
    {
        public SEMContractList()
        {
            this.spName = "SEMContract";
            this.list = new List<RASF.General.Data.TimeOfSem>();
            this.deletedlist = new List<RASF.General.Data.TimeOfSem>();
        }

        public SEMContractList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
