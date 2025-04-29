using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class SentPartToContractorsReport : RASF.General.InterFaces.IRow
    {
         public RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractorsDetailReport> SentPartToContractorsDetailReport { get; set; }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid Code
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("آزمایشگاه", "")]
         public string LaboratoryName
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("نام پیمانکار", "")]
         public string contractorsName
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تنوع", "")]
         public int PartNumber
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("شماره قرارداد", "")]
         public int ContractNo
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تاریخ ارسال", "")]
         public string SendDate
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تاریخ دریافت", "")]
         public string RecieveDate
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تاریخ دریافت", "")]
         public string Delivery
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("کارشناس", "")]
         public string Expert
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("توضیحات", "")]
         public string Description
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تایید مالی", "")]
         public string FinancialSupportDate
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تایید مالی", "")]
         public int CountOfDay
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

        public SentPartToContractorsReport()
        {

        }
    }
}
