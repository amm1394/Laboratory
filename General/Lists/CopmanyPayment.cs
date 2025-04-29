using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CopmanyPaymentList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CopmanyPayment>
    {
        public CopmanyPaymentList()
        {
            this.spName = "CopmanyPayment";
            this.list = new List<RASF.General.Data.CopmanyPayment>();
            this.deletedlist = new List<RASF.General.Data.CopmanyPayment>();
        }

        public CopmanyPaymentList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

