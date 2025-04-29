using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class EditMessageList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ShowSendMessage>
    {
        public EditMessageList()
        {
            this.spName = "EditMessage";
            this.list = new List<RASF.General.Data.ShowSendMessage>();
            this.deletedlist = new List<RASF.General.Data.ShowSendMessage>();
        }

        public EditMessageList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

