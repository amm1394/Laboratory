using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Store
{
    public partial class RemindSamleOfCompanyForm : RASF.General.Forms.Base.DockContentForm
    {
        public RemindSamleOfCompanyForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.cultchStoreList1.spName = "RemindSamleOfCompany";
          //  this.ShowpnlSave = false;
        }

        private void CultchStore_Load(object sender, EventArgs e)
        {
            //this.cultchStoreList1.Fill();
            //this.grdContracts.Refetch();
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            //RASF.General.Data.CultchStore CurrentRow = (RASF.General.Data.CultchStore)this.grdContracts.CurrentRow.DataRow;
            //CurrentRow.RowState = RASF.General.Enums.RowState.Updated;
            //this.cultchStoreList1.Update();

            //this.cultchStoreList1.Fill();
            //this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this.cultchStoreList1.Fill();
            //this.grdContracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdContracts.ExportToExcel("نمونه های انیارها");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("CompanyName", String.Format("%{0}%", this.txtSearch.Text)));
                this.cultchStoreList1.Fill(Parameter);

                this.grdContracts.Refetch();
            }
        }
    }
}
