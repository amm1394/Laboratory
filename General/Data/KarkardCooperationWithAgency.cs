using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class KarkardCooperationWithAgency : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("دفتر","")]
         public string AgencyName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نقد","")]
        public Int64 Naghd
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("اعتباری", "")]
        public Int64 Etebari
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("چک تضمین", "")]
        public Int64 Cheque
        {
            get;
            set;
        }
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("منوط به تسویه", "")]
        public Int64 ManutBeTasviye
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تسویه فاکتور قبل", "")]
        public Int64 FactorGhabl
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مانده نقد", "")]
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
        [RASF.General.Attributes.DataAttribute("مانده چک", "")]
        public Int64 RemindCheque
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مانده منوط به تسویه", "")]
        public Int64 RemindManutBeTasviye
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مانده فاکتور قبل", "")]
        public Int64 RemindFactorGhabl
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد نقد", "")]
        public Decimal DarsadRemindNaghd
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد اعتباری", "")]
        public Decimal DarsadRemindEtebari
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد چک", "")]
        public Decimal DarsadRemindCheque
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد منوط به تسویه", "")]
        public Decimal DarsadRemindManutBeTasviye
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد فاکتور قبل", "")]
        public Decimal DarsadRemindFactorGhabl
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

        public KarkardCooperationWithAgency()
        {

        }
    }
}
