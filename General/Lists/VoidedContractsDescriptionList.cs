using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class VoidedContractsDescriptionList : RASF.General.Lists.Base.BaseList<RASF.General.Data.VoidedContractsDescription>
    {
        public VoidedContractsDescriptionList()
        {
            this.spName = "VoidedContractsDescription";
            this.list = new List<RASF.General.Data.VoidedContractsDescription>();
            this.deletedlist = new List<RASF.General.Data.VoidedContractsDescription>();
        }

        public VoidedContractsDescriptionList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
