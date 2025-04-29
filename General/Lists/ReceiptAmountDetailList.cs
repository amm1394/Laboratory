using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReceiptAmountDetailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReceiptAmountDetail>
    {
        public ReceiptAmountDetailList()
        {
            this.spName = "ReceiptAmount_Detail";
            this.list = new List<RASF.General.Data.ReceiptAmountDetail>();
            this.deletedlist = new List<RASF.General.Data.ReceiptAmountDetail>();
        }

        public ReceiptAmountDetailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
