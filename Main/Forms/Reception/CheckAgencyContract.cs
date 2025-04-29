using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class CheckAgencyContract : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime from;
        private DateTime to;
        public CheckAgencyContract()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
            this.checkContractList1.spName = "CheckAgencyContract";
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

        private void CheckContract_Load(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@From", from));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@To", to));
            this.checkContractList1.Fill(Parameters);
            this.grdReport.Refetch();
        }

        private void grdReport_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdReport.SelectedItems.Count > 0)
            {
                RASF.General.Data.Contracts_Base_Edit Current_Contract = (RASF.General.Data.Contracts_Base_Edit)this.grdReport.SelectedItems[0].GetRow().DataRow;

                if (Current_Contract != null)
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.UserId = RASF.General.Classes.Global.CurrentUserCode;
                    this.checkContractList1.Update();

                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@From", from));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@To", to));
                    this.checkContractList1.Fill(Parameters);
                    this.grdReport.Refetch();                  
                }
            }
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
            from = e.From;
            to = e.To;
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@From", e.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@To", e.To));
            this.checkContractList1.Fill(Parameters);
            this.grdReport.Refetch();
        }
    }
}
