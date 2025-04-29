using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class NotSendedCostPaperList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportSendingInPerson>
    {
        public NotSendedCostPaperList()
        {
            this.spName = "NotSendedCostPaper";
            this.list = new List<RASF.General.Data.ReportSendingInPerson>();
            this.deletedlist = new List<RASF.General.Data.ReportSendingInPerson>();
        }

        public NotSendedCostPaperList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

