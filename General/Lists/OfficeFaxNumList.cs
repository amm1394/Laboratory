using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class OfficeFaxNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Office_FaxNum>
    {
        public OfficeFaxNumList()
        {
            this.spName = "Office_FaxNum";
            this.list = new List<RASF.General.Data.Office_FaxNum>();
            this.deletedlist = new List<RASF.General.Data.Office_FaxNum>();

        }

        public OfficeFaxNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
       
    }
    
}
