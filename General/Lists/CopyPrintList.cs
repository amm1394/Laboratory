using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CopyPrintList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RecDuplicatePrint>
    {
        public CopyPrintList()
        {
            this.spName = "CopyPrint";
            this.list = new List<RASF.General.Data.RecDuplicatePrint>();
            this.deletedlist = new List<RASF.General.Data.RecDuplicatePrint>();
        }

        public CopyPrintList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
