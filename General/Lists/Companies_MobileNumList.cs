using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class Companies_MobileNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_MobileNum>
    {
        public Companies_MobileNumList()
        {
            this.spName = "Companies_MobileNum";
            this.list = new List<RASF.General.Data.Companies_MobileNum>();
            this.deletedlist = new List<RASF.General.Data.Companies_MobileNum>();

        }

        public Companies_MobileNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

    
    }
}
