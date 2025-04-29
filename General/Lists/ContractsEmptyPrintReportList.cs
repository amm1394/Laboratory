using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsEmptyPrintReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterEmptyPrintReport>
    {
        public ContractsEmptyPrintReportList()
        {
            this.spName = "ContractsEmptyPrintReport";
            this.list = new List<RASF.General.Data.PartsMasterEmptyPrintReport>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterEmptyPrintReport>();
        }

        public ContractsEmptyPrintReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

