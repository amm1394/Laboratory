using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractBaseWithDiscountList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractBaseWithDiscount>
    {
        public ContractBaseWithDiscountList()
        {
            this.spName = "ContractBaseWithDiscount";
            this.list = new List<RASF.General.Data.ContractBaseWithDiscount>();
            this.deletedlist = new List<RASF.General.Data.ContractBaseWithDiscount>();
        }

        public ContractBaseWithDiscountList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

