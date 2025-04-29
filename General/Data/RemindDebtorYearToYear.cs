using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class RemindDebtorYearToYear : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("سال مالی","")]
         public int FinancialYear
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("کل فروش","")]
        public Int64 TotalSaleNoTax
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("کل فروش + ارزش افزوده", "")]
        public Int64 TotalSale
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("فروش اعتباری", "")]
        public Int64 TotalCreditSale
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("فروش نقدی", "")]
        public Int64 TotalCashSale
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("فروش مناقصه ای", "")]
        public Int64 TotalMonagesheSale
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("فروش حقیقی", "")]
        public Int64 TotalHaghighihSale
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("فروش حقوقی", "")]
        public Int64 TotalHoghughihSale
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("فروش مشمول بیمه", "")]
        public Int64 InsuranceSale
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("فروش مشمول بیمه مناقصه", "")]
        public Int64 TotalInsuranceMonagesheSale
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("فروش مشمول بیمه سایر", "")]
        public Int64 TotalInsuranceOthereSale
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مطالبات کل", "")]
        public Int64 TotalDebtor
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مطالبات اعتباری", "")]
        public Int64 TotalCreditDebtor
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مطالبات نقدی", "")]
        public Int64 TotalCashDebtor
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مطالبات مناقصه ای", "")]
        public Int64 TotalMonagesheDebtor
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مانده اعتباری دفاتر", "")]
        public Int64 OfficeEtebari
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مانده نقد دفاتر", "")]
        public Int64 OfficeNaghd
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مانده مناقصه", "")]
        public Int64 Monageseh
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مانده گرانت", "")]
        public Int64 RemindGrant
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مانده بیمه کل", "")]
        public Int64 Insurance
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مانده بیمه مناقصه", "")]
        public Int64 MonageInsurance
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد کل مطالبات به کل فروش", "")]
        public decimal DeborSalePercent
        {
            get;
            set;
        }
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد مطالبات نقدی به فروش نقدی", "")]
        public decimal CashDebtorCashSalePercent
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد مطالبات اعتباری به فروش اعتباری", "")]
        public decimal CreditDebtorCreditSalePercent
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد مطالبات مناقصه به فروش مناقصه", "")]
        public decimal MonagesheDebtorMonagesheSalePercent
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد بیمه کل به فروش کل", "")]
        public decimal InsuranceSalePercent
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد بیمه کل به مطالبات کل", "")]
        public decimal InsuranceDebtorPercent
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد فروش مشمول بیمه به فروش کل", "")]
        public decimal SaleInsuranceSalePercent
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("درصد بیمه مناقصه به فروش ناقصه", "")]
        public decimal InsuranceMonageshePercent
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

        public RemindDebtorYearToYear()
        {

        }
    }
}
