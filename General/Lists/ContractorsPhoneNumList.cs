using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ContractorsPhoneNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contractors_PhoneNum>
    {
        public ContractorsPhoneNumList()
        {
            this.spName = "Contractors_PhoneNum";
            this.list = new List<RASF.General.Data.Contractors_PhoneNum>();
            this.deletedlist = new List<RASF.General.Data.Contractors_PhoneNum>();

        }

        public ContractorsPhoneNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
    
}
