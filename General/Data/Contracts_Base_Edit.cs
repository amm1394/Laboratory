using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{

     public class Contracts_Base_Edit : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(true)]
         public Guid ContractsCode
        {
            get;
            set;
        }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid MasterBillsCode
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("شرکت", "")]
         public string CompanyName
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid ValidatorCode
         {
             get;
             set;
         }
         
         //صورت حساب شرکت
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid Company_Invoice
         {
             get;
             set;
         }

          //گزارش شرکت
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid Company_Report
         {
             get;
             set;
         }
        
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Boolean InformalFactor
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Boolean AcceptServiceTopic
         {
             get;
             set;
         }      
                
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]{5}")]
        [RASF.General.Attributes.DataAttribute("شماره قرارداد","")]
        public int ContractNo
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("تاریخ تایید مالی", "")]
        public string FinancialSupportDateString
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public string Email
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("تاریخ دریافت", "")]
        public string ReceptionDateString
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("گزارش انگلیسی", "")]
        public string EnglishReporter
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("تاریخ تحویل", "")]
        public string DeliveryString
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("تاریخ روز", "")]
        public string DateOfDay
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("داخلی", "")]
        public string EXT
        {
            get;
            set;
        }


        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("تاریخ دریافت","")]
        public DateTime ReceptionDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("آخرین پذیرش", "")]
        public string SReceptionDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("آخرین رسید", "")]
        public string LastReceiptDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("آخرین رسید", "")]
        public Int64 LastAmount
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("تاریخ تحویل", "")]
        public DateTime Delivery
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("تاریخ تحویل", "")]
        public string CooperationName
        {
            get;
            set;
        }

    
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]{4}")]
        [RASF.General.Attributes.DataAttribute()]
        public int ContractYear
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public bool IsCompleted
        {
            get ;
            set;
        }
         
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ اتمام","")]
        public string CompletedDate
        {
            get ;
            set;
        }
         
         [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public string AgencyName
        {
            get;
            set;
        }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public int BillNo
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public int ReceiptNo
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
         [RASF.General.Attributes.DataAttribute("گرنت","")]
         public Int64 GrantAmount
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("گرنت", "")]
         public Boolean Grant
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("گرنت", "")]
         public string StrGrant
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
         
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid UserId
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid UserID
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public bool officialBill
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Int64 Debtor
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("مانده","")]
         public Int64 Remind
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("مانده قرارداد", "")]
         public Int64 RemindContract
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("اعتبار", "")]
         public Int64 Credit
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تاریخ لغو", "")]
         public string DateExit
         {
             get;
             set;
         }
         
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute ("علت لغو","")]
         public string Description
         {
             get;
             set;
         }
         
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute ("خروج از بخش علمی","")]
         public string ScientificExpertDateExite
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تعداد", "")]
         public int CNDaneshBonyan
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("رابط", "")]
         public string ConnectorName
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("مانده واقعی", "")]
         public Int64 Notinvoice
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("", "")]
         public Int64 FourtyPercentageOFCredit
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("شماره نامه", "")]
         public string LetterNo
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تاریخ نامه", "")]
         public string LetterDate
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("", "")]
         public string CancelExit
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تخفیف مدیریت", "")]
         public int ManagerDiscount
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("نوع ارسال", "")]
         public string SendType
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("مبلغ بیمه", "")]
         public Double InsAmount
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("مبلغ بیمه", "")]
         public String ExecuterName
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("", "")]
         public int ChangePriceId
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("", "")]
         public string RegisterDate
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("", "")]
         public string StepByStep
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("مساله داری قبل تایید مالی", "")]
         public string STRIsHoldBeforFinancial
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("", "")]
         public int DiffDate
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

     

        public Contracts_Base_Edit()
        {
          //  this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
}
