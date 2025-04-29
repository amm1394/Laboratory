using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MessagingMarketingList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MessagingMarketing>
    {
        public MessagingMarketingList()
        {
            this.spName = "MessagingMarketing";
            this.list = new List<RASF.General.Data.MessagingMarketing>();
            this.deletedlist = new List<RASF.General.Data.MessagingMarketing>();
        }

        public MessagingMarketingList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

