using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Standard_BaseList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Standard_Base>
    {
        public Standard_BaseList()
        {
            this.spName = "Standard_Base";
            this.list = new List<RASF.General.Data.Standard_Base>();
            this.deletedlist = new List<RASF.General.Data.Standard_Base>();
        }

        public Standard_BaseList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
