using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class DetailOfReceptionLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle DestructFormat;

        public DetailOfReceptionLaboratory()
        {
            InitializeComponent();
            this.To = this.From = System.DateTime.Now;
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TestFormat.BackColor = Color.Yellow;
            this.TestFormat.ForeColor = Color.Black;

            this.DestructFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.DestructFormat.BackColor = Color.Red;
            this.DestructFormat.ForeColor = Color.Black;
        }

        private DateTime From;
        private DateTime To;


        private void DetailOfReceptionForm_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            From = e.From;
            To = e.To;
            if (e.From == DateTime.MinValue || e.To == DateTime.MinValue)
            {
                From = DateTime.Now; To = DateTime.Now;
            }
            else
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
                this.detailOfReceptionList1.Fill(Parameter);
                this.grdDetail.Refetch();
            }
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.detailOfReceptionList1.Fill(Parameter);
            this.grdDetail.Refetch();
            From = e.From;
            To = e.To;
        }

        private void grdDetail_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DetailOfReception CurrentRow = (RASF.General.Data.DetailOfReception)this.grdDetail.CurrentRow.DataRow;
            RASF.Main.Forms.Laboratory.ViewCostPaperLaboratory CostPaper = new Laboratory.ViewCostPaperLaboratory(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
            this.detailOfReceptionList1.Fill(Parameter);
            this.grdDetail.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdDetail.ExportToExcel("گزارش جزئیات پذیرش");
        }

        private void grdDetail_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["DateOfTestForThePresence"].Value) != "")
            {
                e.Row.Cells["DateOfTestForThePresence"].FormatStyle = this.TestFormat;
            }

            if (Convert.ToString(e.Row.Cells["Destruct"].Value) != "")
            {
                e.Row.Cells["Destruct"].FormatStyle = this.DestructFormat;
            }

          }
        
        }
    }

