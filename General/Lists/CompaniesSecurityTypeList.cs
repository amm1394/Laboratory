using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesSecurityTypeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Security>
    {
        public CompaniesSecurityTypeList()
        {
            this.spName = "Companies_Security";
            this.list = new List<RASF.General.Data.Companies_Security>();
            this.deletedlist = new List<RASF.General.Data.Companies_Security>();

        }

        public CompaniesSecurityTypeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        
    }    
}
