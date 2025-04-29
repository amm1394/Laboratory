using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class ShowDeliveryDateChange : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("توضیحات","")]
         public string Description
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ قدیم", "")]
        public String OldDelivery
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
        [RASF.General.Attributes.DataAttribute("تایید مالی","")]
        public String FinancialSupportDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نام کاربر", "")]
        public String UserName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ تغییر", "")]
        public String ChangeDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ جدید", "")]
        public String NewDelivery
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("قراداد", "")]
        public int ContractNo
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
        [RASF.General.Attributes.DataAttribute("مسئول اجرایی", "")]
        public string Executers
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

        public ShowDeliveryDateChange()
        {

        }
    }
}
