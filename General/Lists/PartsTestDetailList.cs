using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class PartsTestDetailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Parts_Tests_Detail>
    {
        public PartsTestDetailList()
        {
            this.spName = "Parts_Tests_Detail";
            this.list = new List<RASF.General.Data.Parts_Tests_Detail>();
            this.deletedlist = new List<RASF.General.Data.Parts_Tests_Detail>();

        }

        public PartsTestDetailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }    
}
