using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ChartLaboratoryofFinancialConditionReportMasterTestList : RASF.General.Lists.Base.BaseList<RASF.General.Data.LaboratoryofFinancialConditionReport>
    {
        public ChartLaboratoryofFinancialConditionReportMasterTestList()
        {
            this.spName = "ChartLaboratoryofFinancialConditionReportMasterTest";
            this.list = new List<RASF.General.Data.LaboratoryofFinancialConditionReport>();
            this.deletedlist = new List<RASF.General.Data.LaboratoryofFinancialConditionReport>();
        }

        public ChartLaboratoryofFinancialConditionReportMasterTestList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

