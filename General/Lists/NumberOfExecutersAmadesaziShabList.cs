using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class NumberOfExecutersAmadesaziShabList : RASF.General.Lists.Base.BaseList<RASF.General.Data.NumberOfExecutersAmadesaziShab>
    {
        public NumberOfExecutersAmadesaziShabList()
        {
            this.spName = "NumberOfExecutersAmadesaziShab";
            this.list = new List<RASF.General.Data.NumberOfExecutersAmadesaziShab>();
            this.deletedlist = new List<RASF.General.Data.NumberOfExecutersAmadesaziShab>();
        }

        public NumberOfExecutersAmadesaziShabList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
