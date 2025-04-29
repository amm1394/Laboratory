using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{

     public class Office_PhoneNum : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute(true)]
         public Guid OFFICEPHONENUMCODE
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid OFFICECODEOFFICE_PHONENUM
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator(@"^[0-9\u0600-\u06FF\s]+$")]
        [RASF.General.Attributes.DataAttribute("نام ", "")]
        public string PHONENUMOFFICE_PHONENUM
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

        public Office_PhoneNum()
        {
          //  this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
    
}
