using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class InsertStandardList : RASF.General.Lists.Base.BaseList<RASF.General.Data.InsertStandard>
    {
        public InsertStandardList()
        {
            this.spName = "InsertStandard";
            this.list = new List<RASF.General.Data.InsertStandard>();
            this.deletedlist = new List<RASF.General.Data.InsertStandard>();
        }

        public InsertStandardList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
