using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class BanksList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Banks>
    {
        public BanksList()
        {
            this.spName = "Banks";
            this.list = new List<RASF.General.Data.Banks>();
            this.deletedlist = new List<RASF.General.Data.Banks>();
        }

        public BanksList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
