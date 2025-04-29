using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ContractsVoidList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_Void>
    {
        public ContractsVoidList()
        {
            this.spName = "Contracts_Void";
            this.list = new List<RASF.General.Data.Contracts_Void>();
            this.deletedlist = new List<RASF.General.Data.Contracts_Void>();

        }

        public ContractsVoidList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
     

    }
 }
