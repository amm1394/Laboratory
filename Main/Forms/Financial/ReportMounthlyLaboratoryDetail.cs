using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportMounthlyLaboratoryDetail : RASF.General.Forms.Base.DockContentForm
    {
        public RASF.General.Data.RemindDebtorYearToYear RemindDebtor
        {
            get
            {
                return null;
            }
            set
            {
                FinancialYear.Text = value.FinancialYear.ToString();
                TotalSale.Text = value.TotalSale.ToString();
                TotalCreditSale.Text = value.TotalCreditSale.ToString();
                TotalCashSale.Text = value.TotalCashSale.ToString();
                TotalMonagesheSale.Text = value.TotalMonagesheSale.ToString();
                TotalHaghighihSale.Text = value.TotalHaghighihSale.ToString();
                TotalHoghughihSale.Text = value.TotalHoghughihSale.ToString();
                InsuranceSale.Text = value.InsuranceSale.ToString();
                TotalInsuranceMonagesheSale.Text = value.TotalInsuranceMonagesheSale.ToString();
                TotalInsuranceOthereSale.Text = value.TotalInsuranceOthereSale.ToString();
                TotalDebtor.Text = value.TotalDebtor.ToString();
                TotalCreditDebtor.Text = value.TotalCreditDebtor.ToString();
                TotalCashDebtor.Text = value.TotalCashDebtor.ToString();
                TotalMonagesheDebtor.Text = value.TotalMonagesheDebtor.ToString();
                OfficeEtebari.Text = value.OfficeEtebari.ToString();
                OfficeNaghd.Text = value.OfficeNaghd.ToString();
                Monageseh.Text = value.Monageseh.ToString();
                RemindGrant.Text = value.RemindGrant.ToString();
                Insurance.Text = value.Insurance.ToString();
                MonageInsurance.Text = value.MonageInsurance.ToString();
                DeborSalePercent.Text = value.DeborSalePercent.ToString();
                CashDebtorCashSalePercent.Text = value.CashDebtorCashSalePercent.ToString();
                CreditDebtorCreditSalePercent.Text = value.CreditDebtorCreditSalePercent.ToString();
                MonagesheDebtorMonagesheSalePercent.Text = value.MonagesheDebtorMonagesheSalePercent.ToString();
                InsuranceSalePercent.Text = value.InsuranceSalePercent.ToString();
                InsuranceDebtorPercent.Text = value.InsuranceDebtorPercent.ToString();
                SaleInsuranceSalePercent.Text = value.SaleInsuranceSalePercent.ToString();
            }
        }
        public ReportMounthlyLaboratoryDetail()
        {
            InitializeComponent();
        }
    }
}
