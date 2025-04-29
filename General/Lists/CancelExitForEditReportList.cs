using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CancelExitForEditReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CancelExitForEditReport>
    {
        public CancelExitForEditReportList()
        {
            this.spName = "CancelExitForEditReport";
            this.list = new List<RASF.General.Data.CancelExitForEditReport>();
            this.deletedlist = new List<RASF.General.Data.CancelExitForEditReport>();
        }

        public CancelExitForEditReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
