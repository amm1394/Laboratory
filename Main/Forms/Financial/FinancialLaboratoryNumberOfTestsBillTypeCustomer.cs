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
    public partial class FinancialLaboratoryNumberOfTestsBillTypeCustomer : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public FinancialLaboratoryNumberOfTestsBillTypeCustomer()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            this.financialLaboratoryNumberOfTestsBillDetaileList1.spName = "FinancialLaboratoryNumberOfTestsBillDetaileTypeCustomer";
        }

        private void FinancialLaboratoryNumberOfTestsBillTypeCustomer_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.From = e.From;
            this.To = e.To;
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.financialLaboratoryNumberOfTestsBillTypeCustomerList1.Fill(Parameters1);
            this.grdKol.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("گزارش کارکرد تعدادی آزمایشگاه ها ");
            this.grdKol.ExportToExcel("گزارش کارکرد تعدادی آزمایشگاه ها");

            MessageBox.Show("جزئیات گزارش کارکرد تعدادی آزمایشگاه ها ");
            this.grdDetail.ExportToExcel("جزئیات گزارش کارکرد تعدادی آزمایشگاه ها");

        }

        private void grdKol_SelectionChanged(object sender, EventArgs e)
        {
            RASF.General.Data.LaboratoryofFinancialConditionReport CurrentRow = (RASF.General.Data.LaboratoryofFinancialConditionReport)this.grdKol.CurrentRow.DataRow;

            if (CurrentRow.LaboratoryCode != Guid.Empty)
            {
                List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("LaboratoryCode", CurrentRow.LaboratoryCode));
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("CooperationCode", CurrentRow.CooperationCode));
                this.financialLaboratoryNumberOfTestsBillDetaileList1.Fill(Parameters2);
            }
            else
            {
                this.financialLaboratoryNumberOfTestsBillDetaileList1.Clear();
             
            }
            this.grdDetail.Refetch();
        }
    }
}
