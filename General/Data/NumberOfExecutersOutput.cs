using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class NumberOfExecutersOutput : RASF.General.InterFaces.IRow
    {

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid UserId
         {
             get;
             set;
         }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نام کاربری","")]
         public string UserName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تعداد کارکرد","")]
        public int NumberOfTests
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("آزمون", "")]
        public string MasterName
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

        public NumberOfExecutersOutput()
        {

        }
    }
}
