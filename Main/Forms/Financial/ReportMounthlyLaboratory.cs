using RASF.General.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportMounthlyLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle Plus;
        private Janus.Windows.GridEX.GridEXFormatStyle Negative;
        private int _shamsiYear;

        public ReportMounthlyLaboratory(int ShamsiYear)
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this._shamsiYear = ShamsiYear;

            this.reportMounthlyLaboratory2017To2018List1.spName = "ReportMounthlyLaboratory_Year";
            this.monthlyReport2017To2018List1.spName = "MonthlyReport_Year";
            this.darsad98List1.spName = "Darsad_Year";

            this.Negative = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.Negative.ForeColor = Color.DarkRed;

            this.Plus = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.Plus.ForeColor = Color.DarkGreen;
        }

        private void ReportMounthlyLaboratoryForm_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            List<System.Data.SqlClient.SqlParameter> P1 = new List<System.Data.SqlClient.SqlParameter>();
            P1.Add(new System.Data.SqlClient.SqlParameter("ShamsiYear", this._shamsiYear));
            this.reportMounthlyLaboratory2017To2018List1.Fill(P1);
            this.grdReport.Refetch();

            List<System.Data.SqlClient.SqlParameter> P2 = new List<System.Data.SqlClient.SqlParameter>();
            P2.Add(new System.Data.SqlClient.SqlParameter("ShamsiYear", this._shamsiYear));
            this.monthlyReport2017To2018List1.Fill(P2);
            this.grdkol.Refetch();

            this.darsadAndRemindList1.Fill();
            this.grdDarsad.Refetch();

            List<System.Data.SqlClient.SqlParameter> P3 = new List<System.Data.SqlClient.SqlParameter>();
            P3.Add(new System.Data.SqlClient.SqlParameter("ShamsiYear", this._shamsiYear));
            this.darsad98List1.Fill(P3);
            this.grdDarsad98.Refetch();

            this.remindDebtorYearToYearList1.Fill();
            this.grid2.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ماهانه آزمایشگاه ها");
            this.grdReport.ExportToExcel("گزارش ماهانه آزمایشگاه ها");
            MessageBox.Show("ماهانه کل");
            this.grdkol.ExportToExcel("گزارش ماهانه کل");
            MessageBox.Show("درصد مانده ها");
            this.grdDarsad.ExportToExcel("گزارش درصد مانده ها");
        }

        private void grdkol_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.MonthlyReport CurrentRow = (RASF.General.Data.MonthlyReport)this.grdkol.CurrentRow.DataRow;
            RASF.Main.Forms.Manager.DetaiolOfRecieptForm Detail = new Manager.DetaiolOfRecieptForm(CurrentRow.Id);
            Detail.Show();
        }

        private void grdReport_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToDecimal(e.Row.Cells["DarsadFarvardin"].Value) > 0)
            {
                e.Row.Cells["DarsadFarvardin"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadFarvardin"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadOrdibehesht"].Value) > 0)
            {
                e.Row.Cells["DarsadOrdibehesht"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadOrdibehesht"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadKol"].Value) > 0)
            {
                e.Row.Cells["DarsadKol"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadKol"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadKhordad"].Value) > 0)
            {
                e.Row.Cells["DarsadKhordad"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadKhordad"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadTir"].Value) > 0)
            {
                e.Row.Cells["DarsadTir"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadTir"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadMordad"].Value) > 0)
            {
                e.Row.Cells["DarsadMordad"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadMordad"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadShahriver"].Value) > 0)
            {
                e.Row.Cells["DarsadShahriver"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadShahriver"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadMehr"].Value) > 0)
            {
                e.Row.Cells["DarsadMehr"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadMehr"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadAban"].Value) > 0)
            {
                e.Row.Cells["DarsadAban"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadAban"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadAzar"].Value) > 0)
            {
                e.Row.Cells["DarsadAzar"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadAzar"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadDey"].Value) > 0)
            {
                e.Row.Cells["DarsadDey"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadDey"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadBahman"].Value) > 0)
            {
                e.Row.Cells["DarsadBahman"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadBahman"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadEsfand"].Value) > 0)
            {
                e.Row.Cells["DarsadEsfand"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadEsfand"].FormatStyle = this.Negative;
            }
        }

        private void grdDarsad98_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToDecimal(e.Row.Cells["DarsadFarvardin"].Value) > 0)
            {
                e.Row.Cells["DarsadFarvardin"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadFarvardin"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadOrdibehesht"].Value) > 0)
            {
                e.Row.Cells["DarsadOrdibehesht"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadOrdibehesht"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadKhordad"].Value) > 0)
            {
                e.Row.Cells["DarsadKhordad"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadKhordad"].FormatStyle = this.Negative;
            }


            if (Convert.ToDecimal(e.Row.Cells["DarsadTir"].Value) > 0)
            {
                e.Row.Cells["DarsadTir"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadTir"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadMordad"].Value) > 0)
            {
                e.Row.Cells["DarsadMordad"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadMordad"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadShahriver"].Value) > 0)
            {
                e.Row.Cells["DarsadShahriver"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadShahriver"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadMehr"].Value) > 0)
            {
                e.Row.Cells["DarsadMehr"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadMehr"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadAban"].Value) > 0)
            {
                e.Row.Cells["DarsadAban"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadAban"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadAzar"].Value) > 0)
            {
                e.Row.Cells["DarsadAzar"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadAzar"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadDey"].Value) > 0)
            {
                e.Row.Cells["DarsadDey"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadDey"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadBahman"].Value) > 0)
            {
                e.Row.Cells["DarsadBahman"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadBahman"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadEsfand"].Value) > 0)
            {
                e.Row.Cells["DarsadEsfand"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadEsfand"].FormatStyle = this.Negative;
            }

            if (Convert.ToDecimal(e.Row.Cells["DarsadKol"].Value) > 0)
            {
                e.Row.Cells["DarsadKol"].FormatStyle = this.Plus;
            }
            else
            {
                e.Row.Cells["DarsadKol"].FormatStyle = this.Negative;
            }
        }

        private void grid2_SelectionChanged(object sender, EventArgs e)
        {
            var CurrentRow = (RemindDebtorYearToYear)this.grid2.CurrentRow.DataRow;
            if (CurrentRow != null)
            {
                TotalSaleNoTax.Text = ((Int64)CurrentRow.TotalSaleNoTax).ToString();
                TotalSale.Text = ((Int64)CurrentRow.TotalSale).ToString();
                TotalCreditSale.Text = ((Int64)CurrentRow.TotalCreditSale).ToString();
                TotalCashSale.Text = ((Int64)CurrentRow.TotalCashSale).ToString();
                TotalMonagesheSale.Text = ((Int64)CurrentRow.TotalMonagesheSale).ToString();
                TotalHaghighihSale.Text = ((Int64)CurrentRow.TotalHaghighihSale).ToString();
                TotalHoghughihSale.Text = ((Int64)CurrentRow.TotalHoghughihSale).ToString();
                InsuranceSale.Text = ((Int64)CurrentRow.InsuranceSale).ToString();
                TotalInsuranceMonagesheSale.Text = ((Int64)CurrentRow.TotalInsuranceMonagesheSale).ToString();
                TotalInsuranceOthereSale.Text = ((Int64)CurrentRow.TotalInsuranceOthereSale).ToString();
                TotalDebtor.Text = ((Int64)CurrentRow.TotalDebtor).ToString();
                TotalCreditDebtor.Text = ((Int64)CurrentRow.TotalCreditDebtor).ToString();
                TotalCashDebtor.Text = ((Int64)CurrentRow.TotalCashDebtor).ToString();
                TotalMonagesheDebtor.Text = ((Int64)CurrentRow.TotalMonagesheDebtor).ToString();
                OfficeEtebari.Text = ((Int64)CurrentRow.OfficeEtebari).ToString();
                OfficeNaghd.Text = ((Int64)CurrentRow.OfficeNaghd).ToString();
                Monageseh.Text = ((Int64)CurrentRow.Monageseh).ToString();
                RemindGrant.Text = ((Int64)CurrentRow.RemindGrant).ToString();
                Insurance.Text = ((Int64)CurrentRow.Insurance).ToString();
                MonageInsurance.Text = ((Int64)CurrentRow.MonageInsurance).ToString();
                DeborSalePercent.Text = ((Int64)CurrentRow.DeborSalePercent).ToString();
                CashDebtorCashSalePercent.Text = ((Int64)CurrentRow.CashDebtorCashSalePercent).ToString();
                CreditDebtorCreditSalePercent.Text = ((Int64)CurrentRow.CreditDebtorCreditSalePercent).ToString();
                MonagesheDebtorMonagesheSalePercent.Text = ((Int64)CurrentRow.MonagesheDebtorMonagesheSalePercent).ToString();
                InsuranceSalePercent.Text = ((Int64)CurrentRow.InsuranceSalePercent).ToString();
                InsuranceDebtorPercent.Text = ((Int64)CurrentRow.InsuranceDebtorPercent).ToString();
                SaleInsuranceSalePercent.Text = ((Int64)CurrentRow.SaleInsuranceSalePercent).ToString();

            }
        }
    }
}
