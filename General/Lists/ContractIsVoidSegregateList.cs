using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractIsVoidSegregateList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DailyProcessReport>
    {
        public ContractIsVoidSegregateList()
        {
            this.spName = "ContractIsVoidSegregate";
            this.list = new List<RASF.General.Data.DailyProcessReport>();
            this.deletedlist = new List<RASF.General.Data.DailyProcessReport>();
        }

        public ContractIsVoidSegregateList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

