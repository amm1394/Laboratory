using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class EarninigOfAgency : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid ContractsCode
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator("")]
         [RASF.General.Attributes.DataAttribute("دفتر", "")]
         public string AgencyName
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator("")]
         [RASF.General.Attributes.DataAttribute("درصد فروش", "")]
         public decimal DarsadInvoice
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator("")]
         [RASF.General.Attributes.DataAttribute("درصد مانده", "")]
         public decimal DarsadRemind
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator("")]
         [RASF.General.Attributes.DataAttribute("مبلغ بدهکاری", "")]
         public Int64 Debtor
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator("")]
         [RASF.General.Attributes.DataAttribute("مبلغ بستانکاری", "")]
         public Int64 creditor
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator("")]
         [RASF.General.Attributes.DataAttribute("مانده", "")]
         public Int64 Remind
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator("")]
         [RASF.General.Attributes.DataAttribute("مانده نقدی", "")]
         public Int64 CashRemind
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator("")]
         [RASF.General.Attributes.DataAttribute("مانده اعتباری", "")]
         public Int64 CreditRemind
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator("")]
         [RASF.General.Attributes.DataAttribute("مانده حقیقی", "")]
         public Int64 HaghRemind
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

        public EarninigOfAgency()
        {

        }
    }
}
