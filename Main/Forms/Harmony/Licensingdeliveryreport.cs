using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class Licensingdeliveryreport : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime from;
        private DateTime to;
        public Licensingdeliveryreport()
        {
            InitializeComponent();
            this.companiesBaseList1.spName = "Companies_Base_Blocked";
        }

        private void IsHoldForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void grdIsHold_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdBills.CurrentRow != null) && (this.grdBills.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpGrid.Text = "قرارداد" + " " + this.grdBills.CurrentRow.Cells["ContractNo"].Value.ToString();
            }
            else
            {
                this.grpGrid.Text = "";
            }
           
        }

        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", from));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", to));
            this.licensingdeliveryreportList1.Fill(Parameter);
            this.grdBills.Refetch();

            this.companiesBaseList1.Fill();
            this.grdcompanies.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.Billsissued licensingdeliveryrepor in this.licensingdeliveryreportList1.Where(row => row.Checked == true))
            {
                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", licensingdeliveryrepor.ContractCode));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@MasterBillCode", licensingdeliveryrepor.MasterBillsCode));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@Username",RASF.General.Classes.Global.CurrentUserName));
                  //  Parameters.Add(new System.Data.SqlClient.SqlParameter("@Status", 1));

                    RASF.General.Lists.BanksList.FillScalar("Licensingdeliveryreport_Accept", Parameters);
                   
                
            }

            this.companiesBaseList1.Update();
            FillGrid();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.licensingdeliveryreportList1.Fill(Parameter);
            this.grdBills.Refetch();

            this.from = e.From;
            this.to = e.To;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.Billsissued licensingdeliveryrepor in this.licensingdeliveryreportList1.Where(row => row.Checked == true))
            {
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", licensingdeliveryrepor.ContractCode));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@MasterBillCode", licensingdeliveryrepor.MasterBillsCode));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@Username", RASF.General.Classes.Global.CurrentUserName));
              //  Parameters.Add(new System.Data.SqlClient.SqlParameter("@Status", 0));

                RASF.General.Lists.BanksList.FillScalar("Licensingdeliveryreport_NotAccept", Parameters);

              

            }
            FillGrid();
        }


    }
}
