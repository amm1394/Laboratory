using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CancelEnterScienceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CancelEnterMaster>
    {
        public CancelEnterScienceList()
        {
            this.spName = "CancelEnterScience";
            this.list = new List<RASF.General.Data.CancelEnterMaster>();
            this.deletedlist = new List<RASF.General.Data.CancelEnterMaster>();
        }

        public CancelEnterScienceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
