using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsAreNotExitedFromLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.EnterExitPieces>
    {
        public PartsAreNotExitedFromLaboratoryList()
        {
            this.spName = "PartsAreNotExitedFromLaboratory";
            this.list = new List<RASF.General.Data.EnterExitPieces>();
            this.deletedlist = new List<RASF.General.Data.EnterExitPieces>();
        }

        public PartsAreNotExitedFromLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
