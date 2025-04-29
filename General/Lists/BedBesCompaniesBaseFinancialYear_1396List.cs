using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class BedBesCompaniesBaseFinancialYear_1396List : RASF.General.Lists.Base.BaseList<RASF.General.Data.RemindDebtorYearToYear>
    {
        public BedBesCompaniesBaseFinancialYear_1396List()
        {
            this.spName = "BedBesCompaniesBaseFinancialYear_1396";
            this.list = new List<RASF.General.Data.RemindDebtorYearToYear>();
            this.deletedlist = new List<RASF.General.Data.RemindDebtorYearToYear>();
        }

        public BedBesCompaniesBaseFinancialYear_1396List(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
