using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class WriteOffMarketingCompanyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MarketingActivity>
    {
        public WriteOffMarketingCompanyList()
        {
            this.spName = "WriteOffMarketingCompany";
            this.list = new List<RASF.General.Data.MarketingActivity>();
            this.deletedlist = new List<RASF.General.Data.MarketingActivity>();
        }

        public WriteOffMarketingCompanyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

