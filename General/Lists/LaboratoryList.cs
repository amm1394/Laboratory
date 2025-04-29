using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class LaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Laboratory>
    {
        public LaboratoryList()
        {
            this.spName = "Laboratory";
            this.list = new List<RASF.General.Data.Laboratory>();
            this.deletedlist = new List<RASF.General.Data.Laboratory>();

        }

        public LaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
