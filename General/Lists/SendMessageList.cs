using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SendMessageList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SendMessage>
    {
        public SendMessageList()
        {
            this.spName = "SendMessage";
            this.list = new List<RASF.General.Data.SendMessage>();
            this.deletedlist = new List<RASF.General.Data.SendMessage>();
        }

        public SendMessageList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
