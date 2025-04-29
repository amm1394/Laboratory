using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ContractExecutersUnusualList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractExecuters_Unusual>
    {
        public ContractExecutersUnusualList()
        {
            this.spName = "ContractExecuters_Unusual";
            this.list = new List<RASF.General.Data.ContractExecuters_Unusual>();
            this.deletedlist= new List<RASF.General.Data.ContractExecuters_Unusual>();

        }

        public ContractExecutersUnusualList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
}