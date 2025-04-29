using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TestNameNotExitedForScientificExpertList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TestNameNotEntered>
    {
        public TestNameNotExitedForScientificExpertList()
        {
            this.spName = "TestName_NotExitedForScientificExpert";
            this.list = new List<RASF.General.Data.TestNameNotEntered>();
            this.deletedlist = new List<RASF.General.Data.TestNameNotEntered>();
        }

        public TestNameNotExitedForScientificExpertList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
