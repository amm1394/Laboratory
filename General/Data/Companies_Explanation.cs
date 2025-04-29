using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class Companies_Explanation : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("توضیحات ", "")]
         public System.IO.MemoryStream Explanation
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute(true)]
        public Guid ExplanationCode
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

        public Companies_Explanation()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
    
}