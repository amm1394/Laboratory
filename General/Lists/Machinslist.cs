using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class Machinslist : RASF.General.Lists.Base.BaseList<RASF.General.Data.Machins>
    {
        public Machinslist()
        {
            this.spName = "Machins";
            this.list = new List<RASF.General.Data.Machins>();
            this.deletedlist = new List<RASF.General.Data.Machins>();

        }

        public Machinslist(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

      
    }
    
}
