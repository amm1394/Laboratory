using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ChasierList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Cashier>
    {
        public ChasierList()
        {
            this.spName = "Cashier";
            this.list = new List<RASF.General.Data.Cashier>();
            this.deletedlist = new List<RASF.General.Data.Cashier>();
        }

        public ChasierList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
}
