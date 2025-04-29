using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ExitFromEditInScienceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CancelExitForEditInScience>
    {
        public ExitFromEditInScienceList()
        {
            this.spName = "ExitFromEditInScience";
            this.list = new List<RASF.General.Data.CancelExitForEditInScience>();
            this.deletedlist = new List<RASF.General.Data.CancelExitForEditInScience>();
        }

        public ExitFromEditInScienceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

