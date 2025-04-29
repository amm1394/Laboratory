using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class EmailMonthlyBillShowList : RASF.General.Lists.Base.BaseList<RASF.General.Data.EmailMonthlyBillShow>
    {
        public EmailMonthlyBillShowList()
        {
            this.spName = "EmailMonthlyBillShow";
            this.list = new List<RASF.General.Data.EmailMonthlyBillShow>();
            this.deletedlist = new List<RASF.General.Data.EmailMonthlyBillShow>();
        }

        public EmailMonthlyBillShowList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

