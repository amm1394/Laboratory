using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{

     public class Office_FaxNum : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute(true)]
         public Guid OFFICEFAXNUMCOPDE
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator(@"^[0-9\u0600-\u06FF\s]+$")]
        [RASF.General.Attributes.DataAttribute("نام ", "")]
        public String FAXNUMOFFICE_FAXNUM
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid OFFICECODEOFFICE_FAXNUM
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

        public Office_FaxNum()
        {
         //   this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
    
}
