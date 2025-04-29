using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{

     public class Tarrif : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute(true)]
         public Guid TarrifCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]{10}")]
        [RASF.General.Attributes.DataAttribute("قیمت واحد مبلغ درآمد ", "Number0")]
        public int InvoicePrice
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]{10}")]
        [RASF.General.Attributes.DataAttribute("قیمت واحد آزمون برای آزمایشگاه ", "Number0")]
        public int LabInCome
        {
            get;
            set;
        }


        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]{4}")]
        [RASF.General.Attributes.DataAttribute("سال مالی", "Number0")]
        public int FinancialYear
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid MasterTestCode_Tarrif
         {
             get;
             set;
         }

        //[System.ComponentModel.Category("RASF")]
        //[RASF.General.Attributes.DataAttribute()]
        //public DateTime TarrifDate
        //{
        //    get;
        //    set;
        //}


        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Enums.RowState RowState
        {
            get;
            set;
        }

        public Tarrif()
        {
          //  this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
    
}
