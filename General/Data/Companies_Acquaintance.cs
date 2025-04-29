using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class Companies_Acquaintance : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(true)]
         public Guid AcquaintanceCode 
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator(@"^[\u0600-\u06FF\s]+$")]
        [RASF.General.Attributes.DataAttribute("نحوه آشنایی", "")]
         public String AcquaintanceName 
        {
            get;
            set;
        }


        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Enums.RowState RowState
        {
            get;
            set;
        }

        public Companies_Acquaintance()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
}
