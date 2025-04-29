using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesAgencyListList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Agency>
    {
        public CompaniesAgencyListList()
        {
            this.spName = "Companies_Agency";
            this.list = new List<RASF.General.Data.Companies_Agency>();
            this.deletedlist = new List<RASF.General.Data.Companies_Agency>();
        }

        public CompaniesAgencyListList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
}
