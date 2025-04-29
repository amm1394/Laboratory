using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesPhoneNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_PhoneNum>
    {
        public CompaniesPhoneNumList()
        {
            this.spName = "Companies_PhoneNum";
            this.list = new List<RASF.General.Data.Companies_PhoneNum>();
            this.deletedlist= new List<RASF.General.Data.Companies_PhoneNum>();

        }

        public CompaniesPhoneNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

    
    }
}
