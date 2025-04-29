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
    public partial class PaperOfDiscount : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime from;
        private DateTime to;
        public PaperOfDiscount()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

        private void PaperOfDiscount_Load(object sender, EventArgs e)
        {
            this.reportOfPaperDiscountList1.Fill();
            this.grdRe.Refetch();

        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@To", e.To));
            this.paperOfDiscountList1.Fill(Parameter);
            this.grdReports.Refetch();

            from = e.From;
            to = e.To;

            this.reportOfPaperDiscountList1.Fill();
            this.grdRe.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.paperOfDiscountList1.Update();

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@From", from));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@To", to));
            this.paperOfDiscountList1.Fill(Parameter);
            this.grdReports.Refetch();

            this.reportOfPaperDiscountList1.Fill();
            this.grdRe.Refetch();
        }
    }
}
