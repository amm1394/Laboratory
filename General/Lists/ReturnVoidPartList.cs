using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReturnVoidPartList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Parts_Master>
    {
        public ReturnVoidPartList()
        {
            this.spName = "ReturnVoidPart";
            this.list = new List<RASF.General.Data.Parts_Master>();
            this.deletedlist = new List<RASF.General.Data.Parts_Master>();
        }

        public ReturnVoidPartList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
