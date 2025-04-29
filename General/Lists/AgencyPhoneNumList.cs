using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class AgencyPhoneNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AgencyPhoneNum>
    {
        public AgencyPhoneNumList()
        {
            this.spName = "AgencyPhoneNum";
            this.list = new List<RASF.General.Data.AgencyPhoneNum>();
            this.deletedlist = new List<RASF.General.Data.AgencyPhoneNum>();
        }

        public AgencyPhoneNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
