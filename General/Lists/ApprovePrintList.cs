using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ApprovePrintList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RecDuplicatePrint>
    {
        public ApprovePrintList()
        {
            this.spName = "ApprovePrint";
            this.list = new List<RASF.General.Data.RecDuplicatePrint>();
            this.deletedlist = new List<RASF.General.Data.RecDuplicatePrint>();
        }

        public ApprovePrintList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
