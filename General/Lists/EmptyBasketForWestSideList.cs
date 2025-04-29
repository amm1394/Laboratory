using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class EmptyBasketForWestSideList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Basket>
    {
        public EmptyBasketForWestSideList()
        {
            this.spName = "EmptyBasketForWestSide";
            this.list = new List<RASF.General.Data.Basket>();
            this.deletedlist = new List<RASF.General.Data.Basket>();
        }

        public EmptyBasketForWestSideList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
