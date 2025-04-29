using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ShowVoidContractsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ShowVoidContracts>
    {
        public ShowVoidContractsList()
        {
            this.spName = "ShowVoidContracts";
            this.list = new List<RASF.General.Data.ShowVoidContracts>();
            this.deletedlist = new List<RASF.General.Data.ShowVoidContracts>();
        }

        public ShowVoidContractsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
