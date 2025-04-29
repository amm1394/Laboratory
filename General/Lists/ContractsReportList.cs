using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ContractsReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_Report>
    {
        public ContractsReportList()
        {
            this.spName = "Contracts_Report";
            this.list = new List<RASF.General.Data.Contracts_Report>();
            this.deletedlist = new List<RASF.General.Data.Contracts_Report>();

        }

        public ContractsReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

     
    }    
}
