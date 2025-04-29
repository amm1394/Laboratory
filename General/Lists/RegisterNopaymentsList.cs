using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RegisterNopaymentsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RegisterNopayments>
    {
        public RegisterNopaymentsList()
        {
            this.spName = "RegisterNopayments";
            this.list = new List<RASF.General.Data.RegisterNopayments>();
            this.deletedlist = new List<RASF.General.Data.RegisterNopayments>();
        }

        public RegisterNopaymentsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

