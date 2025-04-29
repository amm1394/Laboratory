using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{

     public class Contracts_Executers : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(true)]
         public Guid Code
        {
            get;
            set;
        }

        //[System.ComponentModel.Category("RASF")]
        //[RASF.General.Attributes.Validator("")]
        //[RASF.General.Attributes.DataAttribute()]
        //public Guid USERID
        //{
        //    get;
        //    set;
        //}

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid ApproverId
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public byte Priority
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نام ", "")]
        public Guid ScientifiManager
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public byte Status
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

        public Contracts_Executers()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
    
}
