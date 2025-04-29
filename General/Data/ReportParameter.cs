using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
    public class ReportParameter
    {
        public String Name { get; set; }
        public Object Value { get; set; }
        public ReportParameter(String name, Object value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
