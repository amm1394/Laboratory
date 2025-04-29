using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReceiptTypeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReceiptType>
    {
        public ReceiptTypeList()
        {
            this.spName = "Receipt_Type";
            this.list = new List<RASF.General.Data.ReceiptType>();
            this.deletedlist = new List<RASF.General.Data.ReceiptType>();
        }

        public ReceiptTypeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
