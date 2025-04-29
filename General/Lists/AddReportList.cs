using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class AddReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AddReport>
    {
        public AddReportList()
        {
            this.spName = "AddReport";
            this.list = new List<RASF.General.Data.AddReport>();
            this.deletedlist = new List<RASF.General.Data.AddReport>();
        }

        public AddReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
