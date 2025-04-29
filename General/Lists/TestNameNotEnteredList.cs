using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TestNameNotEnteredlist : RASF.General.Lists.Base.BaseList<RASF.General.Data.TestNameNotEntered>
    {
        public TestNameNotEnteredlist()
        {
            this.spName = "TestName_NotEntered";
            this.list = new List<RASF.General.Data.TestNameNotEntered>();
            this.deletedlist = new List<RASF.General.Data.TestNameNotEntered>();
        }

        public TestNameNotEnteredlist(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
