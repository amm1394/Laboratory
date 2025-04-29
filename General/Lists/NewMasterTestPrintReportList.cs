using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class NewMasterTestPrintReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterTestPrintReport>
    {
        public NewMasterTestPrintReportList()
        {
            this.spName = "NewMasterTestPrintReport";
            this.list = new List<RASF.General.Data.MasterTestPrintReport>();
            this.deletedlist = new List<RASF.General.Data.MasterTestPrintReport>();
        }

        public NewMasterTestPrintReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
