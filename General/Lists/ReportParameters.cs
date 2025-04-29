using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ReportParameters :List<RASF.General.Data.ReportParameter>
    {
        public String ReportName { get; set; }
        public ReportParameters()
        {
        }
    }
}
