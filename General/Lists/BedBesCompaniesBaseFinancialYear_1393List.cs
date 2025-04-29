using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class BedBesCompaniesBaseFinancialYear_1393List : RASF.General.Lists.Base.BaseList<RASF.General.Data.RemindDebtorYearToYear>
    {
        public BedBesCompaniesBaseFinancialYear_1393List()
        {
            this.spName = "BedBesCompaniesBaseFinancialYear_1393";
            this.list = new List<RASF.General.Data.RemindDebtorYearToYear>();
            this.deletedlist = new List<RASF.General.Data.RemindDebtorYearToYear>();
        }

        public BedBesCompaniesBaseFinancialYear_1393List(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
