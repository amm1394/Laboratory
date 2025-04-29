using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class FinancialOffices : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public FinancialOffices()
        {
            InitializeComponent();
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.From = e.From;
            this.To = e.To;
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.officesFinancialList1.Fill(Parameters1);
            grdTotal.Refetch();
           this.chartTotal.DrawBarChart("Debtor", "AgencyName", "Test");

            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.amountChartList1.Fill(Parameters2);
            this.grdOffice.Refetch();
            this.chartOffice.DrawLineChart("Date", "Amount", String.Format("گزارش از تاریخ {0}  لغایت {1}", FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(e.From).ToString(), FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(e.To).ToString()));
            this.chartOffice.Title = "";
        }

        private void FinancialOffices_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdTotal.ExportToExcel("کارکرد دفاتر");
        }

        private void grdTotal_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.OfficesFinancial CurrentRow = (RASF.General.Data.OfficesFinancial)this.grdTotal.CurrentRow.DataRow;
            if (CurrentRow.OfficesCode != Guid.Empty)
            {
                RASF.Main.Forms.Financial.FinancialOfficesDetail FinancialOfficesDetail = new FinancialOfficesDetail(CurrentRow.AgencyName, CurrentRow.OfficesCode, this.From, this.To);
                FinancialOfficesDetail.MdiParent = this.MdiParent;
                FinancialOfficesDetail.Show();
            }
        }

        private void grdTotal_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
