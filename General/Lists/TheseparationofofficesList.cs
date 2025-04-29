using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TheseparationofofficesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Theseparationofoffices>
    {
        public TheseparationofofficesList()
        {
            this.spName = "Theseparationofoffices";
            this.list = new List<RASF.General.Data.Theseparationofoffices>();
            this.deletedlist = new List<RASF.General.Data.Theseparationofoffices>();
        }

        public TheseparationofofficesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
