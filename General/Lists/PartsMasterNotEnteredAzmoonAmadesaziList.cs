using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsMasterNotEnteredAzmoonAmadesaziList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterNotEnteredAzmoonAmadesazi>
    {
        public PartsMasterNotEnteredAzmoonAmadesaziList()
        {
            this.spName = "PartsMaster_NotEnteredAzmoonAmadesazi";
            this.list = new List<RASF.General.Data.PartsMasterNotEnteredAzmoonAmadesazi>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterNotEnteredAzmoonAmadesazi>();
        }

        public PartsMasterNotEnteredAzmoonAmadesaziList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
