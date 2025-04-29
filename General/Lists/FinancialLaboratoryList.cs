using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FinancialLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.FinancialLaboratory>
    {
        public FinancialLaboratoryList()
        {
            this.spName = "FinancialLaboratory";
            this.list = new List<RASF.General.Data.FinancialLaboratory>();
            this.deletedlist = new List<RASF.General.Data.FinancialLaboratory>();
        }

        public FinancialLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);
            if (this.Count() > 0)
            {
                Data.FinancialLaboratory FinancialLaboratory = new Data.FinancialLaboratory();
                FinancialLaboratory.Amount = this.list.Sum(row => row.Amount);
                FinancialLaboratory.LaboratoryName = "جمع کل";
                this.list.Add(FinancialLaboratory);

                List<RASF.General.Data.FinancialLaboratory> OfficesFinancialList = (from row in this.list orderby row.Amount descending select row).ToList();
                this.list.Clear();
                this.list.AddRange(OfficesFinancialList);
            }
            return this.list.Count;

        }
    }
    
}
