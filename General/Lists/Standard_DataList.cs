using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists

{

    [System.ComponentModel.Category("RASF")]
    public class Standard_DataList : RASF.General.Lists.Base.BaseList<RASF.General.Data.StandardData>
    {
        public Standard_DataList()
        {
            this.spName = "Standard_Data";
            this.list = new List<RASF.General.Data.StandardData>();
            this.deletedlist = new List<RASF.General.Data.StandardData>();
        }

        public Standard_DataList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
