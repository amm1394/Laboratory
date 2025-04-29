using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class EmptyBasketNotApprovedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Basket>
    {
        public EmptyBasketNotApprovedList()
        {
            this.spName = "EmptyBasketNotApproved";
            this.list = new List<RASF.General.Data.Basket>();
            this.deletedlist = new List<RASF.General.Data.Basket>();
        }

        public EmptyBasketNotApprovedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
