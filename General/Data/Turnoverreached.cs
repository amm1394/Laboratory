using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
    public class Turnoverreached : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مبلغ بدهکاری","")]
        public int Debtor
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("صندوق", "")]
        public string CashName 
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("شماره قرارداد", "")]
        public int ContractNo 
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("تاریخ دریافت", "")]
        public string ReceiptDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("مبلغ بستانکاری", "")]
        public int creditor
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

        public Turnoverreached()
        {
          
        }
    }
}
