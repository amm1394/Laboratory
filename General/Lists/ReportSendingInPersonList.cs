using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportSendingInPersonList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportSendingInPerson>
    {
        public ReportSendingInPersonList()
        {
            this.spName = "ReportSendingInPerson";
            this.list = new List<RASF.General.Data.ReportSendingInPerson>();
            this.deletedlist = new List<RASF.General.Data.ReportSendingInPerson>();
        }

        public ReportSendingInPersonList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}

