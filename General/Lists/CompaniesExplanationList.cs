using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesExplanationList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Explanation>
    {
        public CompaniesExplanationList()
        {
            this.spName = "Companies_Explanation";
            this.list = new List<RASF.General.Data.Companies_Explanation>();
            this.deletedlist = new List<RASF.General.Data.Companies_Explanation>();

        }

        public CompaniesExplanationList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        
    }    
}
