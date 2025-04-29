using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OfficesFinancialAgencyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.OfficesFinancial>
    {
        public OfficesFinancialAgencyList()
        {
            this.spName = "OfficesFinancial";
            this.list = new List<RASF.General.Data.OfficesFinancial>();
            this.deletedlist = new List<RASF.General.Data.OfficesFinancial>();
        }

        public OfficesFinancialAgencyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

      
    }
}
