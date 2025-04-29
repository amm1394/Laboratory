using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     
     public class EditRecieption : RASF.General.InterFaces.IRow
    {
       
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نام آزمایش","")]
        public String MasterName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public int NumberOfTests
        {
            get;
            set;
        }
         
        
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public String NameOfMainTest
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid PartsTestMasterCode
        {
            get;
            set;
        }
         
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public int InvoicePrice
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid Parts_Master_Code
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

        public EditRecieption()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
            //this.IsCheck = false;
        }
    }
}
