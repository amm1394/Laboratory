using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class Cancel_Contracts_IsHoldDetail : RASF.General.InterFaces.IRow
    {
       

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
         public Guid ContractsCode
        {
            get;
            set;
        }

       
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ مسئله دارشدن قرارداد ", "")]
        public string IsHoldDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ لغو خروج ", "")]
        public string CancelDate
        {
            get;

            set;
        }
        

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("توضیحات", "")]
        public string Description
        {
            get;
            set;
        }
         
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نام کاربری", "")]
        public string UserName
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

        public Cancel_Contracts_IsHoldDetail()
        {

        }
    }
}
