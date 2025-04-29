using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class LicensingdeliveryreportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Billsissued>
    {
        public LicensingdeliveryreportList()
        {
            this.spName = "Licensingdeliveryreport";
            this.list = new List<RASF.General.Data.Billsissued>();
            this.deletedlist = new List<RASF.General.Data.Billsissued>();
        }

        public LicensingdeliveryreportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
