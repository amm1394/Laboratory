using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsMaster_NotEnteredAmadeSaziList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterNotEnteredAmadesazi>
    {
        public PartsMaster_NotEnteredAmadeSaziList()
        {
            this.spName = "PartsMaster_NotEnteredAmadeSazi";
            this.list = new List<RASF.General.Data.PartsMasterNotEnteredAmadesazi>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterNotEnteredAmadesazi>();
        }

        public PartsMaster_NotEnteredAmadeSaziList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
