using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportMounthlyLaboratory2021To2022Form : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle Plus;
        private Janus.Windows.GridEX.GridEXFormatStyle Negative;
        public ReportMounthlyLaboratory2021To2022Form()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
          //  this.ShowpnlSave = false;
            this.reportMounthlyLaboratory2017To2018List1.spName = "ReportMounthlyLaboratory2021To2022";
            this.monthlyReport2017To2018List1.spName = "MonthlyReport2021To2022";
            this.darsad98List1.spName = "Darsad1400";

            this.Negative = new Janus.Windows.GridEX.GridEXFormatStyle();
          //  this.Negative.BackColor = Color.White;
            this.Negative.ForeColor = Color.DarkRed;

            this.Plus = new Janus.Windows.GridEX.GridEXFormatStyle();
        //    this.Plus.BackColor = Color.White;
            this.Plus.ForeColor = Color.DarkGreen;

        }

        private void ReportMounthlyLaboratoryForm_Load(object sender, EventArgs e)
        {
           this.reportMounthlyLaboratory2017To2018List1.Fill();
           this.grdReport.Refetch();

            this.monthlyReport2017To2018List1.Fill();
            this.grdkol.Refetch();

            this.darsadAndRemindList1.Fill();
            this.grdDarsad.Refetch();

            this.darsad98List1.Fill();
            this.grdDarsad98.Refetch();

            this.remindSeparatedbycustomerCashList1.Fill();
            this.grdCash.Refetch();

            this.remindSeparatedbycustomerCreditorList1.Fill();
            this.grdCredit.Refetch();

            this.remindDebtorYearToYearList1.Fill();
            this.grid1.Refetch();

            this.remindSeparatedbycustomerMarketingList1.Fill();
            this.grdMarketing.Refetch();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportMounthlyLaboratory2017To2018List1.Fill();
            this.grdReport.Refetch();

            this.monthlyReport2017To2018List1.Fill();
            this.grdkol.Refetch();

            this.darsadAndRemindList1.Fill();
            this.grdDarsad.Refetch();

            this.remindSeparatedbycustomerCashList1.Fill();
            this.grdCash.Refetch();

            this.remindSeparatedbycustomerCreditorList1.Fill();
            this.grdCredit.Refetch();

            this.remindDebtorYearToYearList1.Fill();
            this.grid1.Refetch();

            this.remindSeparatedbycustomerMarketingList1.Fill();
            this.grdMarketing.Refetch();

            this.darsad98List1.Fill();
            this.grdDarsad98.Refetch();
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
            if (Convert.ToDecimal(e.Row.Cells["DarsadFarvardin"].Value) >0)
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

       
    }
}
