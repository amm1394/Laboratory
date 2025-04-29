using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TestExecutersAmadesaziList : RASF.General.Lists.Base.BaseList<RASF.General.Data.USER>
    {
        public TestExecutersAmadesaziList()
        {
            this.spName = "TestExecutersAmadesazi";
            this.list = new List<RASF.General.Data.USER>();
            this.deletedlist = new List<RASF.General.Data.USER>();
        }

        public TestExecutersAmadesaziList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

