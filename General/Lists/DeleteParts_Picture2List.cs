using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DeleteParts_Picture2List : RASF.General.Lists.Base.BaseList<RASF.General.Data.Parts_Master>
    {
        public DeleteParts_Picture2List()
        {
            this.spName = "DeleteParts_Picture2";
            this.list = new List<RASF.General.Data.Parts_Master>();
            this.deletedlist = new List<RASF.General.Data.Parts_Master>();
        }

        public DeleteParts_Picture2List(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
