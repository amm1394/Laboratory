using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReceiptAssignmentList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReceiptAssignment>
    {
        public ReceiptAssignmentList()
        {
            this.spName = "Receipt_Assignment";
            this.list = new List<RASF.General.Data.ReceiptAssignment>();
            this.deletedlist = new List<RASF.General.Data.ReceiptAssignment>();
        }

        public ReceiptAssignmentList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
