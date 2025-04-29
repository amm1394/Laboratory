using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ChartLaboratoryofFinancialConditionReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.LaboratoryofFinancialConditionReport>
    {
        public ChartLaboratoryofFinancialConditionReportList()
        {
            this.spName = "ChartLaboratoryofFinancialConditionReport";
            this.list = new List<RASF.General.Data.LaboratoryofFinancialConditionReport>();
            this.deletedlist = new List<RASF.General.Data.LaboratoryofFinancialConditionReport>();
        }

        public ChartLaboratoryofFinancialConditionReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);
            if (this.Count() > 0)
            {
                Data.LaboratoryofFinancialConditionReport LaboratoryofFinancialConditionReport = new Data.LaboratoryofFinancialConditionReport();
                LaboratoryofFinancialConditionReport.Remind = this.list.Sum(row => row.Remind);
                LaboratoryofFinancialConditionReport.LaboratoryName = "جمع کل";
                this.list.Add(LaboratoryofFinancialConditionReport);

                List<RASF.General.Data.LaboratoryofFinancialConditionReport> OfficesFinancialList = (from row in this.list orderby row.Remind descending select row).ToList();
                this.list.Clear();
                this.list.AddRange(OfficesFinancialList);
            }
            return this.list.Count;

        }


    }
    
}
