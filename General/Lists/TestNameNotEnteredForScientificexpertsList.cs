using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TestNameNotEnteredForScientificexpertsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TestNameNotEntered>
    {
        public TestNameNotEnteredForScientificexpertsList()
        {
            this.spName = "TestName_NotEnteredForScientificexperts";
            this.list = new List<RASF.General.Data.TestNameNotEntered>();
            this.deletedlist = new List<RASF.General.Data.TestNameNotEntered>();
        }

        public TestNameNotEnteredForScientificexpertsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
