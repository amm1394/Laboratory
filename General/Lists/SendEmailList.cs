using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SendEmailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SendEmail>
    {
        public SendEmailList()
        {
            this.spName = "SendEmail";
            this.list = new List<RASF.General.Data.SendEmail>();
            this.deletedlist = new List<RASF.General.Data.SendEmail>();
        }

        public SendEmailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
