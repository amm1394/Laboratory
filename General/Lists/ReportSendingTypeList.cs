using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ReportSendingTypeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportSendingType>
    {
        public ReportSendingTypeList()
        {
            this.spName = "ReportSendingType";
            this.list = new List<RASF.General.Data.ReportSendingType>();
            this.deletedlist = new List<RASF.General.Data.ReportSendingType>();

        }

        public ReportSendingTypeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

      
    }    
}
