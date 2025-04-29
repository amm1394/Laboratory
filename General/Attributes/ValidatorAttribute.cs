using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Attributes
{
    public class ValidatorAttribute : System.Attribute
    {
        [System.ComponentModel.Category("RASF")]
        public String Pattern;
        public ValidatorAttribute(string pattern)
        {
            this.Pattern = pattern;
        }
    }
}
