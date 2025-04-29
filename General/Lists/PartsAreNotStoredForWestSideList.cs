using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsAreNotStoredForWestSideList : RASF.General.Lists.Base.BaseList<RASF.General.Data.EnterExitPieces>
    {
        public PartsAreNotStoredForWestSideList()
        {
            this.spName = "PartsAreNotStoredForWestSide";
            this.list = new List<RASF.General.Data.EnterExitPieces>();
            this.deletedlist = new List<RASF.General.Data.EnterExitPieces>();
        }

        public PartsAreNotStoredForWestSideList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
