using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OfficeofFinancialConditionReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.OfficeofFinancialConditionReport>
    {
        public OfficeofFinancialConditionReportList()
        {
            this.spName = "OfficeofFinancialConditionReport";
            this.list = new List<RASF.General.Data.OfficeofFinancialConditionReport>();
            this.deletedlist = new List<RASF.General.Data.OfficeofFinancialConditionReport>();
        }

        public OfficeofFinancialConditionReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
