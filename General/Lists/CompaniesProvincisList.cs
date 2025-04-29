using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesProvincisList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Company_Province>
    {
        public CompaniesProvincisList()
        {
            this.spName = "Company_Province";
            this.list = new List<RASF.General.Data.Company_Province>();
            this.deletedlist= new List<RASF.General.Data.Company_Province>();

        }

        public CompaniesProvincisList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       

    }
    
}
