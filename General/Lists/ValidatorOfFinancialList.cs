using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ValidatorOfFinancialList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ValidatorOfFinancial>
    {
        public ValidatorOfFinancialList()
        {
            this.spName = "ValidatorOfFinancial";
            this.list = new List<RASF.General.Data.ValidatorOfFinancial>();
            this.deletedlist = new List<RASF.General.Data.ValidatorOfFinancial>();
        }

        public ValidatorOfFinancialList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

