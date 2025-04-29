using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class ViewSabtSamane : RASF.General.Forms.Base.DockContentForm
    {
        public ViewSabtSamane()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            

            this.viewSabtSamaneList2.spName = "ViewSabtSamaneDesc";
        }

        private void ViewSabtSamane_Load(object sender, EventArgs e)
        {
            this.viewSabtSamaneList1.Fill();
            this.grdcontracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdcontracts.SelectedItems.Count > 0)
            {
                RASF.General.Data.ViewSabtSamane Current_Contract = (RASF.General.Data.ViewSabtSamane)this.grdcontracts.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (txtdesc.Text != null))
                {

                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", Current_Contract.ContractsCode));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", txtdesc.Text));
                    RASF.General.Lists.BanksList.FillScalar("ViewSabtSamaneDesc_Insert", Parameters);
                    //Current_Contract.RowState = General.Enums.RowState.Added;
                    //Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                    //Current_Contract.Description = this.txtdesc.Text;
                    //this.viewSabtSamaneList2.Update();
                    
                    this.txtdesc.Text = String.Empty;
                }
            }

            

            this.viewSabtSamaneList1.Fill();
            this.grdcontracts.Refetch();
            //this.grdcontracts.ExportToExcel("قراردادهای ثبت در سامانه");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.viewSabtSamaneList1.Fill();
            this.grdcontracts.Refetch();
        }

        private void grdcontracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "ContractNo":

                    RASF.General.Data.ViewSabtSamane CurrentRow = (RASF.General.Data.ViewSabtSamane)this.grdcontracts.CurrentRow.DataRow;
                    RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
                    CostPaper.Show();
                    break;
                case "CompanyName":

                    if (this.grdcontracts.SelectedItems.Count > 0)
                    {
                        RASF.General.Data.ViewSabtSamane Current_Contract = (RASF.General.Data.ViewSabtSamane)this.grdcontracts.SelectedItems[0].GetRow().DataRow;

                        if (Current_Contract != null )
                        {

                            Current_Contract.RowState = General.Enums.RowState.Added;
                            Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                            this.viewSabtSamaneList1.Update();
                        }
                    }
                  break;
            }
            this.viewSabtSamaneList1.Fill();
            this.grdcontracts.Refetch();          
         
        }
    }
}
