using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RASF.Main.Forms.Reception
{
    public partial class CancelToExitReport : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle EnglishReport;
        //private string To;
        public CancelToExitReport()
        {
            InitializeComponent();

            this.iscompletedForCancelToExitList1.spName = "CancelToExitReport";

            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
           

            this.EnglishReport = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.EnglishReport.BackColor = Color.Red;
            this.EnglishReport.ForeColor = Color.Black;
        }
       
     
        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.iscompletedForCancelToExitList1.Fill(Parameter);

            grdIsCompleted.Refetch();
        }

        private void grdIsCompleted_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["EnglishReporter"].Value) == "دارد")
            {
                e.Row.Cells["EnglishReporter"].FormatStyle = this.EnglishReport;
            }
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);

        }
            
        }
    }

