using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
     
    [System.ComponentModel.Category("RASF")]
    public class LaboratoryStatusList : RASF.General.Lists.Base.BaseList<RASF.General.Data.LaboratoryStatus>
    {
        public LaboratoryStatusList()
        {
            this.spName = "LaboratoryStatus";
            this.list = new List<RASF.General.Data.LaboratoryStatus>();
            this.deletedlist = new List<RASF.General.Data.LaboratoryStatus>();
        }

        public LaboratoryStatusList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
