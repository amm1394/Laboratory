using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PaymentTypesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PayMentType>
    {
        public PaymentTypesList()
        {
            this.spName = "PaymentTypes";
            this.list = new List<RASF.General.Data.PayMentType>();
            this.deletedlist = new List<RASF.General.Data.PayMentType>();
        }

        public PaymentTypesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
