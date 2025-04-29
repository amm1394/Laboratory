using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TestNameNotExitedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TestNameNotEntered>
    {
        public TestNameNotExitedList()
        {
            this.spName = "TestName_NotExited";
            this.list = new List<RASF.General.Data.TestNameNotEntered>();
            this.deletedlist = new List<RASF.General.Data.TestNameNotEntered>();
        }

        public TestNameNotExitedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
