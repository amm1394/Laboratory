using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ClearReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AddReport>
    {
        public ClearReportList()
        {
            this.spName = "ClearReport";
            this.list = new List<RASF.General.Data.AddReport>();
            this.deletedlist = new List<RASF.General.Data.AddReport>();
        }

        public ClearReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
