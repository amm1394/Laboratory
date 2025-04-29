using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ThreemonthssalesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Threemonthssales>
    {
        public ThreemonthssalesList()
        {
            this.spName = "Threemonthssales";
            this.list = new List<RASF.General.Data.Threemonthssales>();
            this.deletedlist = new List<RASF.General.Data.Threemonthssales>();
        }

        public ThreemonthssalesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

