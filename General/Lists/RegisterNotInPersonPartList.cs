using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RegisterNotInPersonPartList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RegisterNotInPersonPart>
    {
        public RegisterNotInPersonPartList()
        {
            this.spName = "RegisterNotInPersonPart";
            this.list = new List<RASF.General.Data.RegisterNotInPersonPart>();
            this.deletedlist = new List<RASF.General.Data.RegisterNotInPersonPart>();
        }

        public RegisterNotInPersonPartList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
