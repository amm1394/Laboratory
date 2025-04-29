using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DefinitionPersianTemplateList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DefinitionTemplate>
    {
        public DefinitionPersianTemplateList()
        {
            this.spName = "DefinitionTempLaboratory";
            this.list = new List<RASF.General.Data.DefinitionTemplate>();
            this.deletedlist = new List<RASF.General.Data.DefinitionTemplate>();
        }

        public DefinitionPersianTemplateList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
