using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OpenReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ObservationReport>
    {
        public OpenReportList()
        {
            this.spName = "OpenReport";
            this.list = new List<RASF.General.Data.ObservationReport>();
            this.deletedlist = new List<RASF.General.Data.ObservationReport>();
        }

        public OpenReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
