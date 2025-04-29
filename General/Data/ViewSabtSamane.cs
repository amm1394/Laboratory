using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class ViewSabtSamane : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("", "")]
         public Guid ContractsCode
         {
             get;
             set;
         }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("","")]
         public int ContractNo
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("شرکت", "")]
        public String CompanyName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("شرکت", "")]
        public String Description
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("شرکت", "")]
        public String InvoiceCompany
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ پذیرش", "")]
        public String ReceptionDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ تحویل", "")]
        public String Delivery
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تایید مالی", "")]
        public String FinancialSupportDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("اتمام قرارداد", "")]
        public String CompletedDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مسئول اجرائی", "")]
        public String Executers
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مسئول پذیرش", "")]
        public String Recieptin
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public String UserName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مسئول ثبت", "")]
        public String SamanehUserName
        {
            get;
            set;
        }


        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("ثبت در سامانه", "")]
        public String SabtDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public String Sabt
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

        public ViewSabtSamane()
        {

        }
    }
}
