using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{

     public class Yes_No : RASF.General.InterFaces.IRow
    {
       [System.ComponentModel.Category("RASF")]
       [RASF.General.Attributes.DataAttribute(true)]
         public byte Code
        {
            get;
            set;
        }

       [System.ComponentModel.Category("RASF")]
       [RASF.General.Attributes.DataAttribute()]
        public String YesNo
        {
            get;
            set;
        }

            
        [RASF.General.Attributes.DataAttribute()]
        public Enums.RowState RowState
        {
            get;
            set;
        }

        public Yes_No()
        {
            //this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
}
