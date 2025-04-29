using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PageOfLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Parts_Tests_Master>
    {
        public PageOfLaboratoryList()
        {
            this.spName = "PageOfLaboratory";
            this.list = new List<RASF.General.Data.Parts_Tests_Master>();
            this.deletedlist = new List<RASF.General.Data.Parts_Tests_Master>();
        }

        public PageOfLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
