using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PrePaidAmountForContractList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DeliveryDay>
    {
        public PrePaidAmountForContractList()
        {
            this.spName = "PrePaidAmountForContract";
            this.list = new List<RASF.General.Data.DeliveryDay>();
            this.deletedlist = new List<RASF.General.Data.DeliveryDay>();
        }

        public PrePaidAmountForContractList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
