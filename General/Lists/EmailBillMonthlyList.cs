using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class EmailBillMonthlyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.EmailMonthlyBillShow>
    {
        public EmailBillMonthlyList()
        {
            this.spName = "EmailBillMonthly";
            this.list = new List<RASF.General.Data.EmailMonthlyBillShow>();
            this.deletedlist = new List<RASF.General.Data.EmailMonthlyBillShow>();
        }

        public EmailBillMonthlyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

