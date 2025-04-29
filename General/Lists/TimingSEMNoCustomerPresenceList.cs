using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TimingSEMNoCustomerPresenceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TimeOfSem>
    {
        public TimingSEMNoCustomerPresenceList()
        {
            this.spName = "TimingSEMNoCustomerPresence";
            this.list = new List<RASF.General.Data.TimeOfSem>();
            this.deletedlist = new List<RASF.General.Data.TimeOfSem>();
        }

        public TimingSEMNoCustomerPresenceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
