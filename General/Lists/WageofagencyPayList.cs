using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class WageofagencyPayList : RASF.General.Lists.Base.BaseList<RASF.General.Data.WageofagencyPay>
    {
        public WageofagencyPayList()
        {
            this.spName = "WageofagencyPay";
            this.list = new List<RASF.General.Data.WageofagencyPay>();
            this.deletedlist = new List<RASF.General.Data.WageofagencyPay>();
        }

        public WageofagencyPayList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

