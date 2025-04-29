using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ComplaintTypeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ComplaintType>
    {
        public ComplaintTypeList()
        {
            this.spName = "ComplaintType";
            this.list = new List<RASF.General.Data.ComplaintType>();
            this.deletedlist = new List<RASF.General.Data.ComplaintType>();
        }

        public ComplaintTypeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
