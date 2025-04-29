using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class FindUsersLaboratory : RASF.General.InterFaces.IRow
    {
         
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Boolean IsChecked
         {
             get;
             set;
         }  

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("", "")]
         public Boolean Memeber
         {
             get;
             set;
         }
                      
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("نام کاربر", "")]
         public string UserName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid UserId
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid GroupId
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid ExecuterId
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public bool Status
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

        public FindUsersLaboratory()
        {
        }
    }
}
