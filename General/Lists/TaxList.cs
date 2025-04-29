using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class TaxList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Tax>
    {
        public TaxList()
        {
            this.spName = "Tax";
            this.list = new List<RASF.General.Data.Tax>();
            this.deletedlist = new List<RASF.General.Data.Tax>();

        }

        public TaxList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

      
    }
}
