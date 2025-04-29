using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FindBillNumberList : RASF.General.Lists.Base.BaseList<RASF.General.Data.FindBillNumber>
    {
        public FindBillNumberList()
        {
            this.spName = "FindBillNumber";
            this.list = new List<RASF.General.Data.FindBillNumber>();
            this.deletedlist = new List<RASF.General.Data.FindBillNumber>();
        }

        public FindBillNumberList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
