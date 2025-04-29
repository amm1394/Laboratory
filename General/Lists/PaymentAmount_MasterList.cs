using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PaymentAmount_MasterList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PaymentAmount_Master>
    {
        public PaymentAmount_MasterList()
        {
            this.spName = "PaymentAmount_Master";
            this.list = new List<RASF.General.Data.PaymentAmount_Master>();
            this.deletedlist = new List<RASF.General.Data.PaymentAmount_Master>();
        }

        public PaymentAmount_MasterList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

