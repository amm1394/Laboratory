using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class TarrifList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Tarrif>
    {
        public TarrifList()
        {
            this.spName = "Tarrif";
            this.list = new List<RASF.General.Data.Tarrif>();
            this.deletedlist = new List<RASF.General.Data.Tarrif>();

        }

        public TarrifList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
    
}
