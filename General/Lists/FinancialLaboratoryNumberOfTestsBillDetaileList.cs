using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FinancialLaboratoryNumberOfTestsBillDetaileList : RASF.General.Lists.Base.BaseList<RASF.General.Data.LaboratoryofFinancialConditionReport>
    {
        public FinancialLaboratoryNumberOfTestsBillDetaileList()
        {
            this.spName = "FinancialLaboratoryNumberOfTestsBillDetaile";
            this.list = new List<RASF.General.Data.LaboratoryofFinancialConditionReport>();
            this.deletedlist = new List<RASF.General.Data.LaboratoryofFinancialConditionReport>();
        }

        public FinancialLaboratoryNumberOfTestsBillDetaileList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        //public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        //{
        //    base.Fill(parameters);
        //    if (this.Count() > 0)
        //    {
        //        Data.FinancialLaboratoryNumberOfTests FinancialLaboratoryNumberOfTests = new Data.FinancialLaboratoryNumberOfTests();
        //        FinancialLaboratoryNumberOfTests.NumberOfTests = this.list.Sum(row => row.NumberOfTests);
        //        FinancialLaboratoryNumberOfTests.LaboratoryName = "جمع کل";
        //     //   this.list.Add(LaboratoryofFinancialConditionReport);

        //    //    List<RASF.General.Data.FinancialLaboratoryNumberOfTests> OfficesFinancialList = (from row in this.list orderby row.NumberOfTests descending select row).ToList();
        //        this.list.Clear();
        //     //   this.list.AddRange(OfficesFinancialList);
        //    }
        //    return this.list.Count;

        //}
    }
    
}
