using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OfficesFinancialDetailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.OfficesFinancial>
    {
        public OfficesFinancialDetailList()
        {
            this.spName = "OfficesFinancialDetail";
            this.list = new List<RASF.General.Data.OfficesFinancial>();
            this.deletedlist = new List<RASF.General.Data.OfficesFinancial>();
        }

        public OfficesFinancialDetailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
