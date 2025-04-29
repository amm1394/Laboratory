using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ValidateCredentialsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ValidateCredentials>
    {
        public ValidateCredentialsList()
        {
            this.spName = "ValidateCredentials";
            this.list = new List<RASF.General.Data.ValidateCredentials>();
            this.deletedlist = new List<RASF.General.Data.ValidateCredentials>();
        }

        public ValidateCredentialsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
