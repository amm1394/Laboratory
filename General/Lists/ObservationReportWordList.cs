using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ObservationReportWordList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ObservationReport>
    {
        public ObservationReportWordList()
        {
            this.spName = "ObservationReportWord";
            this.list = new List<RASF.General.Data.ObservationReport>();
            this.deletedlist = new List<RASF.General.Data.ObservationReport>();
        }

        public ObservationReportWordList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
