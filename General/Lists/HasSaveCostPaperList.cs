using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class HasSaveCostPaperList : RASF.General.Lists.Base.BaseList<RASF.General.Data.HasContracsLetter>
    {
        public HasSaveCostPaperList()
        {
            this.spName = "HasSaveCostPaper";
            this.list = new List<RASF.General.Data.HasContracsLetter>();
            this.deletedlist = new List<RASF.General.Data.HasContracsLetter>();
        }

        public HasSaveCostPaperList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
