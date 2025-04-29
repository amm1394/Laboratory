using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class DailyProcessReport : RASF.General.InterFaces.IRow
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
        public Int64 Recipt_Amount
        {
            get;
            set;
        }
         

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تایید مالی","")]
        public Int64 FinancialAmount
        {
            get;
            set;
        }
         
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("صورت حساب","")]
        public Int64 Bill_Amount
        {
            get;
            set;
        }
         
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نقد","")]
        public Int64 Pay_Amount_Type_1
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("چک", "")]
        public Int64 Pay_Amount_Type_2
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("حواله", "")]
        public Int64 Pay_Amount_Type_3
        {
            get;
            set;
        }
                  
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مبلغ کل", "")]
        public Int64 Pay_Amount
        {
            get;
            set;
        }
         
         [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("ارزش افزوده", "")]
        public Int64 TotalTax
        {
            get;
            set;
        }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تحویلی روز", "")]
         public Int64 DeliveryAmount
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تخفیف", "")]
         public Int64 TotalDisCount
         {
             get;
             set;
         }
         
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("صورت حساب با ارزش افزوده", "")]
         public Int64 BillWithTax
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

        public DailyProcessReport()
        {

        }
    }
}
