using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesEnglishList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_English>
    {
        public CompaniesEnglishList()
        {
            this.spName = "Companies_English";
            this.list = new List<RASF.General.Data.Companies_English>();
            this.deletedlist = new List<RASF.General.Data.Companies_English>();

        }

        public CompaniesEnglishList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
}
