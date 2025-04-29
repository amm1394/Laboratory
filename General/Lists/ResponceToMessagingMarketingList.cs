using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ResponceToMessagingMarketingList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MessagingMarketing>
    {
        public ResponceToMessagingMarketingList()
        {
            this.spName = "ResponceToMessagingMarketing";
            this.list = new List<RASF.General.Data.MessagingMarketing>();
            this.deletedlist = new List<RASF.General.Data.MessagingMarketing>();
        }

        public ResponceToMessagingMarketingList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
