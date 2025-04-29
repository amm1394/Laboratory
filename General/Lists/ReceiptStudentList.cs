using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ReceiptStudentList : RASF.General.Lists.Base.BaseList<RASF.General.Data.New_Receipt>
    {
        public ReceiptStudentList()
        {
            this.spName = "ReceiptStudent";
            this.list = new List<RASF.General.Data.New_Receipt>();
            this.deletedlist = new List<RASF.General.Data.New_Receipt>();

        }

        public ReceiptStudentList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

    
    }
}
