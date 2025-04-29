using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class AgencyFaxNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AgencyFaxNum>
    {
        public AgencyFaxNumList()
        {
            this.spName = "AgencyFaxNum";
            this.list = new List<RASF.General.Data.AgencyFaxNum>();
            this.deletedlist = new List<RASF.General.Data.AgencyFaxNum>();
        }

        public AgencyFaxNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
