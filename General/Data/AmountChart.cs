using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class AmountChart : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid OfficesCode
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid LaboratoryCode
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid MainCode
         {
             get;
             set;
         }
         
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ","")]
        public String Date
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("کارکرد", "")]
        public Int64 Amount
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

        public AmountChart()
        {
        }
     }
}
