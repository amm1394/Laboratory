using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
     [System.ComponentModel.Category("RASF")]
     public class PartsTestsVoidList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Parts_Tests_Void>
    {
        public PartsTestsVoidList()
        {
            this.spName = "Parts_Tests_Void";
            this.list = new List<RASF.General.Data.Parts_Tests_Void>();
            this.deletedlist = new List<RASF.General.Data.Parts_Tests_Void>();

        }

        public PartsTestsVoidList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
    
}
