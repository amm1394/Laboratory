using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MasterTestListCostPaperForOfficesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterTestListCostPaper>
    {
        public MasterTestListCostPaperForOfficesList()
        {
            this.spName = "MasterTestListCostPaperForOffices";
            this.list = new List<RASF.General.Data.MasterTestListCostPaper>();
            this.deletedlist = new List<RASF.General.Data.MasterTestListCostPaper>();
        }

        public MasterTestListCostPaperForOfficesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
