using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class MasterTarrifList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterTarrif>
    {
        public MasterTarrifList()
        {
            this.spName = "MasterTarrif";
            this.list = new List<RASF.General.Data.MasterTarrif>();
            this.deletedlist = new List<RASF.General.Data.MasterTarrif>();
        }

        public MasterTarrifList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
