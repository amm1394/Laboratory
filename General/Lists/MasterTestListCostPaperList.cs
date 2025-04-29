using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MasterTestListCostPaperList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterTestListCostPaper>
    {
        public MasterTestListCostPaperList()
        {
            this.spName = "MasterTestListCostPaper";
            this.list = new List<RASF.General.Data.MasterTestListCostPaper>();
            this.deletedlist = new List<RASF.General.Data.MasterTestListCostPaper>();
        }

        public MasterTestListCostPaperList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
