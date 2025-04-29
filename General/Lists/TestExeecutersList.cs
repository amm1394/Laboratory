using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class TestExeecutersList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TestExecuters>
    {
        public TestExeecutersList()
        {
            this.spName = "TestExecuters";
            this.list = new List<RASF.General.Data.TestExecuters>();
            this.deletedlist = new List<RASF.General.Data.TestExecuters>();

        }

        public TestExeecutersList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
}