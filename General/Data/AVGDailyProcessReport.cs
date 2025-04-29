using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class AVGDailyProcessReport : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ","")]
         public string ActionDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public string x
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("پذیرش","")]
        public decimal Recipt_Amount
        {
            get;
            set;
        }
         

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تایید مالی","")]
        public decimal FinancialAmount
        {
            get;
            set;
        }
         
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("صورت حساب","")]
        public decimal Bill_Amount
        {
            get;
            set;
        }
         
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نقد","")]
        public decimal Pay_Amount_Type_1
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("چک", "")]
        public decimal Pay_Amount_Type_2
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("حواله", "")]
        public decimal Pay_Amount_Type_3
        {
            get;
            set;
        }
                  
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مبلغ کل", "")]
        public decimal Pay_Amount
        {
            get;
            set;
        }
         
         [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("ارزش افزوده", "")]
        public decimal TotalTax
        {
            get;
            set;
        }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تحویلی روز", "")]
         public decimal DeliveryAmount
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تخفیف", "")]
         public decimal TotalDisCount
         {
             get;
             set;
         }
         
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("صورت حساب با ارزش افزوده", "")]
         public decimal BillWithTax
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("مبالغ دریافتی قراردادها", "")]
         public Int64 ContractAmount
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("بستانکاری مشتریان", "")]
         public Int64 RemindofCustomer
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تایید مالی شده", "")]
         public Int64 FinancialVoidContract
         {
             get;
             set;
         }
         
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("صورت حساب", "")]
         public Int64 MasterBilVoided
         {
             get;
             set;
         }
         
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("پذیرش", "")]
         public Int64 ContractVoid
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("مانده نقدی", "")]
         public Int64 RemindNaghd
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("مانده اعتباری", "")]
         public Int64 RemindEtebari
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("", "")]
         public Int64 Debtor
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("درصد مانده به کل", "")]
         public decimal Darsad
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

        public AVGDailyProcessReport()
        {

        }
    }
}
