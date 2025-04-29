using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class StandardDataList : RASF.General.Lists.Base.BaseList<RASF.General.Data.StandardData>
    {
        public StandardDataList()
        {
            this.spName = "StandardData";
            this.list = new List<RASF.General.Data.StandardData>();
            this.deletedlist = new List<RASF.General.Data.StandardData>();
        }

        public StandardDataList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
