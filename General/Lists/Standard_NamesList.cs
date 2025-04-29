using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Standard_NamesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Standard_Names>
    {
        public Standard_NamesList()
        {
            this.spName = "Standard_Names";
            this.list = new List<RASF.General.Data.Standard_Names>();
            this.deletedlist = new List<RASF.General.Data.Standard_Names>();
        }

        public Standard_NamesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
