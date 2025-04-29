using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReceiptAmountMasterList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReceiptAmount_Master>
    {
        public ReceiptAmountMasterList()
        {
            this.spName = "ReceiptAmount_Master";
            this.list = new List<RASF.General.Data.ReceiptAmount_Master>();
            this.deletedlist = new List<RASF.General.Data.ReceiptAmount_Master>();
        }

        public ReceiptAmountMasterList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
