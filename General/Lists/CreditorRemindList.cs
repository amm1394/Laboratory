using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CreditorRemindList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CreditorRemind>
    {
        public CreditorRemindList()
        {
            this.spName = "CreditorRemind";
            this.list = new List<RASF.General.Data.CreditorRemind>();
            this.deletedlist = new List<RASF.General.Data.CreditorRemind>();
        }

        public CreditorRemindList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
