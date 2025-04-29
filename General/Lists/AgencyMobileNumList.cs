using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class AgencyMobileNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AgencyMobileNum>
    {
        public AgencyMobileNumList()
        {
            this.spName = "AgencyMobileNum";
            this.list = new List<RASF.General.Data.AgencyMobileNum>();
            this.deletedlist = new List<RASF.General.Data.AgencyMobileNum>();
        }

        public AgencyMobileNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
