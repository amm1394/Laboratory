using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class HasContracsLetterList : RASF.General.Lists.Base.BaseList<RASF.General.Data.HasContracsLetter>
    {
        public HasContracsLetterList()
        {
            this.spName = "HasContracsLetter";
            this.list = new List<RASF.General.Data.HasContracsLetter>();
            this.deletedlist = new List<RASF.General.Data.HasContracsLetter>();
        }

        public HasContracsLetterList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
