using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class Parts_EnglishName : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(true)]
         public Guid PartsMastersCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator(@"([A-Z|a-z| ]*) ([A-Z|a-z]*) ([\d|A-Z]*)")]
        [RASF.General.Attributes.DataAttribute("نام ", "")]
         public String EnglishName
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

        public Parts_EnglishName()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
        }
    }    
}
