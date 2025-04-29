using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class Companies_Email : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(true)]
        public Guid Code
        {
            get;
            set;
        }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
        public Guid CompanyCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+(?:[A-Z]{2}|com|org|net|edu|gov|mil|
biz|info|mobi|name|aero|asia|jobs|museum)\b")]
        [RASF.General.Attributes.DataAttribute("ایمیل", "")]
        public string Email
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

        public Companies_Email()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
}
