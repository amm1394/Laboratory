using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RegisterGrantForViewList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DebtorCreditorContractBase>
    {
        public RegisterGrantForViewList()
        {
            this.spName = "RegisterGrantForView";
            this.list = new List<RASF.General.Data.DebtorCreditorContractBase>();
            this.deletedlist = new List<RASF.General.Data.DebtorCreditorContractBase>();
        }

        public RegisterGrantForViewList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

