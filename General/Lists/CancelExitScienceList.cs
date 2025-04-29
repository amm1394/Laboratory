using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CancelExitScienceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CancelEnterMaster>
    {
        public CancelExitScienceList()
        {
            this.spName = "CancelExitScience";
            this.list = new List<RASF.General.Data.CancelEnterMaster>();
            this.deletedlist = new List<RASF.General.Data.CancelEnterMaster>();
        }

        public CancelExitScienceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
