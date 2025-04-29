using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class OfficePhoneNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Office_PhoneNum>
    {
        public OfficePhoneNumList()
        {
            this.spName = "Office_PhoneNum";
            this.list = new List<RASF.General.Data.Office_PhoneNum>();
            this.deletedlist = new List<RASF.General.Data.Office_PhoneNum>();

        }

        public OfficePhoneNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
    
}
