using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class ContractsNotEnteredAzmoonAmadesazi : RASF.General.InterFaces.IRow
     {
         [System.ComponentModel.Category("RASF")]
         public RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterNotEnteredAzmoonAmadesazi> PartsMasterNotEntered { get; set; }

          
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
         public Boolean IsCheck
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
         public Guid ContractsCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("شماره قرارداد","")]
        public int ContractNo
        {
            get;
            set;
        }

         [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute(" تاریخ دریافت","")]
        public string ReceptionDate
        {
            get;
            set;
        }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(" تاریخ تحویل", "")]
         public string Delivery
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("ورود به بخش علمی", "")]
         public string ScientificExpertDateEnter
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(" تاریخ آخرین خروج", "")]
         public string DateExit
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(" مسئول اجرایی", "")]
         public string ExecutersName
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("کارشناس علمی", "")]
         public string TestExecutersCode
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
        public Enums.RowState RowState
        {
            get;
            set;
        }

        public ContractsNotEnteredAzmoonAmadesazi()
        {
//            this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
}
