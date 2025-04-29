using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesBaseList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Base>
    {
        public CompaniesBaseList()
        {
            this.spName = "Companies_Base";
            this.list = new List<RASF.General.Data.Companies_Base>();
            this.deletedlist = new List<RASF.General.Data.Companies_Base>();
            
        }

        public CompaniesBaseList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        
    }
}
