using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class PartsReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Parts_Report>
    {
        public PartsReportList()
        {
            this.spName = "Parts_Report";
            this.list = new List<RASF.General.Data.Parts_Report>();
            this.deletedlist = new List<RASF.General.Data.Parts_Report>();

        }

        public PartsReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }    
}
