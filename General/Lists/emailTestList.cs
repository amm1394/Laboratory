using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class emailTestList : RASF.General.Lists.Base.BaseList<RASF.General.Data.emailTest>
    {
        public emailTestList()
        {
            this.spName = "emailTest";
            this.list = new List<RASF.General.Data.emailTest>();
            this.deletedlist = new List<RASF.General.Data.emailTest>();
        }

        public emailTestList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

