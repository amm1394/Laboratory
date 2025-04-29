using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class OfficesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Offices>
    {
        public OfficesList()
        {
            this.spName = "Offices";
            this.list = new List<RASF.General.Data.Offices>();
            this.deletedlist = new List<RASF.General.Data.Offices>();

        }

        public OfficesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
    
}
