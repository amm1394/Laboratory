using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TahviliAmadesaziList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TahviliAmadesazi>
    {
        public TahviliAmadesaziList()
        {
            this.spName = "TahviliAmadesazi";
            this.list = new List<RASF.General.Data.TahviliAmadesazi>();
            this.deletedlist = new List<RASF.General.Data.TahviliAmadesazi>();
        }

        public TahviliAmadesaziList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

