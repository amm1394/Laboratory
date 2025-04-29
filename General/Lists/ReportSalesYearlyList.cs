using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportSalesYearlyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportSalesYearly>
    {
        public ReportSalesYearlyList()
        {
            this.spName = "ReportSalesYearly";
            this.list = new List<RASF.General.Data.ReportSalesYearly>();
            this.deletedlist = new List<RASF.General.Data.ReportSalesYearly>();
        }

        public ReportSalesYearlyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
