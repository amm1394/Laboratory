using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportMounthlyLaboratory2017To2018List : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportMounthlyLaboratory>
    {
        public ReportMounthlyLaboratory2017To2018List()
        {
            this.spName = "ReportMounthlyLaboratory2017To2018";
            this.list = new List<RASF.General.Data.ReportMounthlyLaboratory>();
            this.deletedlist = new List<RASF.General.Data.ReportMounthlyLaboratory>();
        }

        public ReportMounthlyLaboratory2017To2018List(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

