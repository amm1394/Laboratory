using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MasterTestPrintReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterTestPrintReport>
    {
        public MasterTestPrintReportList()
        {
            this.spName = "MasterTestPrintReport";
            this.list = new List<RASF.General.Data.MasterTestPrintReport>();
            this.deletedlist = new List<RASF.General.Data.MasterTestPrintReport>();
        }

        public MasterTestPrintReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
