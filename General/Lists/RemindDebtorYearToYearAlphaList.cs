using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RemindDebtorYearToYearAlphaList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RemindDebtorYearToYear>
    {
        public RemindDebtorYearToYearAlphaList()
        {
            this.spName = "RemindDebtorYearToYearForAlpha";
            this.list = new List<RASF.General.Data.RemindDebtorYearToYear>();
            this.deletedlist = new List<RASF.General.Data.RemindDebtorYearToYear>();
        }

        public RemindDebtorYearToYearAlphaList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

