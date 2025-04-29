using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SendedCostPaperList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportSendingInPerson>
    {
        public SendedCostPaperList()
        {
            this.spName = "SendedCostPaper";
            this.list = new List<RASF.General.Data.ReportSendingInPerson>();
            this.deletedlist = new List<RASF.General.Data.ReportSendingInPerson>();
        }

        public SendedCostPaperList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

