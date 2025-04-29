using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{

     public class USERSGroup : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(true)]
         public Guid UserId
        {
            get;
            set;
        }

       [System.ComponentModel.Category("RASF")]
       [RASF.General.Attributes.DataAttribute()]
        public string UserName
        {
            get;
            set;
        }

       
        [RASF.General.Attributes.DataAttribute()]
        public Enums.RowState RowState
        {
            get;
            set;
        }

        public USERSGroup()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
    
}
