using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CancelExitForEditInScienceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CancelExitForEditInScience>
    {
        public CancelExitForEditInScienceList()
        {
            this.spName = "CancelExitForEdit";
            this.list = new List<RASF.General.Data.CancelExitForEditInScience>();
            this.deletedlist = new List<RASF.General.Data.CancelExitForEditInScience>();
        }

        public CancelExitForEditInScienceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

