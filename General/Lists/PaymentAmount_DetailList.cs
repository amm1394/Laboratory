using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PaymentAmount_DetailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PaymentAmount_Detail>
    {
        public PaymentAmount_DetailList()
        {
            this.spName = "PaymentAmount_Detail";
            this.list = new List<RASF.General.Data.PaymentAmount_Detail>();
            this.deletedlist = new List<RASF.General.Data.PaymentAmount_Detail>();
        }

        public PaymentAmount_DetailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

