using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesCooperationTypeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Cooperation>
    {
        public CompaniesCooperationTypeList()
        {
            this.spName = "Companies_Cooperation";
            this.list = new List<RASF.General.Data.Companies_Cooperation>();
            this.deletedlist = new List<RASF.General.Data.Companies_Cooperation>();

        }

        public CompaniesCooperationTypeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        
    }
}
