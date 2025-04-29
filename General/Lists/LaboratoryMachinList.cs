using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class LaboratoryMachinList : RASF.General.Lists.Base.BaseList<RASF.General.Data.LaboratoryMachin>
    {
        public LaboratoryMachinList()
        {
            this.spName = "LaboratoryMachin";
            this.list = new List<RASF.General.Data.LaboratoryMachin>();
            this.deletedlist = new List<RASF.General.Data.LaboratoryMachin>();
        }

        public LaboratoryMachinList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
