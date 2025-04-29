using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class voidContractList : RASF.General.Lists.Base.BaseList<RASF.General.Data.voidContract>
    {
        public voidContractList()
        {
            this.spName = "voidContract";
            this.list = new List<RASF.General.Data.voidContract>();
            this.deletedlist = new List<RASF.General.Data.voidContract>();
        }

        public voidContractList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
