using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReadOfUnreadMessageList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SendMessage>
    {
        public ReadOfUnreadMessageList()
        {
            this.spName = "ReadOfUnreadMessage";
            this.list = new List<RASF.General.Data.SendMessage>();
            this.deletedlist = new List<RASF.General.Data.SendMessage>();
        }

        public ReadOfUnreadMessageList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}

