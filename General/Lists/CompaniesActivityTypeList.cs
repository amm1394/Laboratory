using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
     [System.ComponentModel.Category("RASF")]
     public class CompaniesActivityTypeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Activity>
    {
        public CompaniesActivityTypeList()
        {
            this.spName = "Companies_Activity";
            this.list = new List<RASF.General.Data.Companies_Activity>();
            this.deletedlist = new List<RASF.General.Data.Companies_Activity>();
        }

        public CompaniesActivityTypeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        
    }
    
}
