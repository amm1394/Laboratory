using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RepotOfGrantList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DebtorCreditorContractBase>
    {
        public RepotOfGrantList()
        {
            this.spName = "RepotOfGrant";
            this.list = new List<RASF.General.Data.DebtorCreditorContractBase>();
            this.deletedlist = new List<RASF.General.Data.DebtorCreditorContractBase>();
        }

        public RepotOfGrantList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

