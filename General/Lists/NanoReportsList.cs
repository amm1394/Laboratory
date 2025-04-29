using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class NanoReportsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.NanoReports>
    {
        public NanoReportsList()
        {
            this.spName = "NanoReports";
            this.list = new List<RASF.General.Data.NanoReports>();
            this.deletedlist = new List<RASF.General.Data.NanoReports>();
        }

        public NanoReportsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
