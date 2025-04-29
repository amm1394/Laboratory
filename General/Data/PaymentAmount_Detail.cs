using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class PaymentAmount_Detail : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
         public Guid PaymentAmountDetailCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid PaymentAmountMasterCode
        {
            get;
            set;
        }
         
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid ReceiptMasterAmounCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public int PeymentType
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
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

        public PaymentAmount_Detail()
        {

        }
    }
}
