using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
    public class Csv_Data : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        public String Name 
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        public String Value
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        public String Sign
        {
            get;
            set;
        }
        public Csv_Data()
        {
        }

        public Enums.RowState RowState
        {
            get;
            set;
        }
    }
}
