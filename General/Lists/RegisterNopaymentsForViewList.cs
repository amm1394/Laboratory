using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RegisterNopaymentsForViewList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RegisterNopayments>
    {
        public RegisterNopaymentsForViewList()
        {
            this.spName = "RegisterNopaymentsForView";
            this.list = new List<RASF.General.Data.RegisterNopayments>();
            this.deletedlist = new List<RASF.General.Data.RegisterNopayments>();
        }

        public RegisterNopaymentsForViewList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

