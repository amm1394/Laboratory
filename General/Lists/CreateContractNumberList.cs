using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CreateContractNumberList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CreateContractNumber>
    {
        public CreateContractNumberList()
        {
            this.spName = "CreateContractNumber";
            this.list = new List<RASF.General.Data.CreateContractNumber>();
            this.deletedlist = new List<RASF.General.Data.CreateContractNumber>();
        }

        public CreateContractNumberList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
