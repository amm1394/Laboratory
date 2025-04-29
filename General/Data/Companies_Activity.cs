using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{

     public class Companies_Activity : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(true)]
         public Guid ActivityCode
         { 
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator(@"^[0-9\u0600-\u06FF\s]+$")]
        [RASF.General.Attributes.DataAttribute("نوع فعالیت ", "")]
         public String ActivityName 
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

        public Companies_Activity()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
}
