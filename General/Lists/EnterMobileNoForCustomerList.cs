using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class EnterMobileNoForCustomerList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Base>
    {
        public EnterMobileNoForCustomerList()
        {
            this.spName = "EnterMobileNoForCustomer";
            this.list = new List<RASF.General.Data.Companies_Base>();
            this.deletedlist = new List<RASF.General.Data.Companies_Base>();
        }

        public EnterMobileNoForCustomerList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

