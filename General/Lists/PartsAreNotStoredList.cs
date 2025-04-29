using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsAreNotStoredList : RASF.General.Lists.Base.BaseList<RASF.General.Data.EnterExitPieces>
    {
        public PartsAreNotStoredList()
        {
            this.spName = "PartsAreNotStored";
            this.list = new List<RASF.General.Data.EnterExitPieces>();
            this.deletedlist = new List<RASF.General.Data.EnterExitPieces>();
        }

        public PartsAreNotStoredList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
