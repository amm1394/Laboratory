using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Parts_Tests_MasterForWorkFlowList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Parts_Tests_MasterForWorkFlow>
    {
        public Parts_Tests_MasterForWorkFlowList()
        {
            this.spName = "Parts_Tests_MasterForWorkFlow";
            this.list = new List<RASF.General.Data.Parts_Tests_MasterForWorkFlow>();
            this.deletedlist = new List<RASF.General.Data.Parts_Tests_MasterForWorkFlow>();
        }

        public Parts_Tests_MasterForWorkFlowList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
