using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
    public class SentPartToContractors : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("","")]
         public Boolean Check
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("", "")]
         public Boolean CheckForEdit
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("دریافت تست", "")]
         public Boolean RecieveTest
         {
             get;
             set;
         }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
         public Guid code
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid UserIdSelect
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
        [RASF.General.Attributes.DataAttribute("پیمانکار","")]
        public Guid countractorsCode   
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid ContractCode
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
        [RASF.General.Attributes.DataAttribute("تاریخ ارسال","")]
        public string SendDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ دریافت","")]
        public string RecieveDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("آزمون","")]
        public string MasterName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("آزمایشگاه","")]
        public string LaboratoryName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نام پیمانکار","")]
        public string contractorsName
        {
            get;
            set;
        }
        

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تنوع","")]
        public int PartNumber
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("قطعه","")]
        public string Name
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
        [RASF.General.Attributes.DataAttribute("مبلغ","")]
        public Int64 Price
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
        [RASF.General.Attributes.DataAttribute()]
        public Guid SentPartToContractorsCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("توضیحات", "")]
        public string DescriptionsHarmony
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ هماهنگی", "")]
        public string DecsDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public bool Printed
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
        [RASF.General.Attributes.DataAttribute("تلفن", "")]
        public string PhoneNo
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ صورت حساب", "")]
        public string StrInvoicedate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public DateTime Invoicedate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("صورت حساب", "")]
        public string InvoiceNo
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("سال مالی", "")]
        public int ContractYear
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public DateTime ForecastDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("سال مالی", "")]
        public String StringForecastDate
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

        public SentPartToContractors()
        {

        }
    }
}
