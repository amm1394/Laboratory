using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class Companies_BaseMarketingList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Base>
    {
        public Companies_BaseMarketingList()
        {
            this.spName = "Companies_BaseMarketing";
            this.list = new List<RASF.General.Data.Companies_Base>();
            this.deletedlist = new List<RASF.General.Data.Companies_Base>();


        }

        public Companies_BaseMarketingList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        
    }
}
