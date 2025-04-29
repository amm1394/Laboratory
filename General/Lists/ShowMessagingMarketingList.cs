using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ShowMessagingMarketingList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MessagingMarketing>
    {
        public ShowMessagingMarketingList()
        {
            this.spName = "ShowMessagingMarketing";
            this.list = new List<RASF.General.Data.MessagingMarketing>();
            this.deletedlist = new List<RASF.General.Data.MessagingMarketing>();
        }

        public ShowMessagingMarketingList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
