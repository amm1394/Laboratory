using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReferralsCompanyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Base>
    {
        public ReferralsCompanyList()
        {
            this.spName = "ReferralsCompany";
            this.list = new List<RASF.General.Data.Companies_Base>();
            this.deletedlist = new List<RASF.General.Data.Companies_Base>();
        }

        public ReferralsCompanyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
