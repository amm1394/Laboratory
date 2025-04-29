using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportMounthlyLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportMounthlyLaboratory>
    {
        public ReportMounthlyLaboratoryList()
        {
            this.spName = "ReportMounthlyLaboratory";
            this.list = new List<RASF.General.Data.ReportMounthlyLaboratory>();
            this.deletedlist = new List<RASF.General.Data.ReportMounthlyLaboratory>();
        }

        public ReportMounthlyLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

