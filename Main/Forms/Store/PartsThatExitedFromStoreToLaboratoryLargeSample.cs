using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RASF.Main.Forms.Store
{
    public partial class PartsThatExitedFromStoreToLaboratoryLargeSample : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        public PartsThatExitedFromStoreToLaboratoryLargeSample()
        {
            InitializeComponent();
            this.findUsersLaboratoryList1.spName = "UserOfTackoverer";

        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            this.ContractsCode = e.ContractsCode;
            RefechGrids();
        }

        private void RefechGrids()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.emptyBasketForLargeSampleList1.Fill(Parameter1);

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.partsAreNotExitedFromStoredForLargeSampleList1.Fill(Parameter2);


            this.grdParts.Refetch();
            this.grdEmptyBasket.Refetch();
        }

        private void grdEmptyBasket_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }

        private void PartsThatExitedFromStoreToLaboratory_Load(object sender, EventArgs e)
        {
            this.laboratoryList1.Fill();
            this.findUsersLaboratoryList1.Fill();

            this.laboratory_UserList1.Fill();
            this.grdReceiver.Refetch();

            General.Classes.Utility.CreateDropDow(drpLab, "LaboratoryName", "LaboratoryCode", laboratoryList1);
            General.Classes.Utility.CreateDropDow(drpUser, "UserName", "UserId", findUsersLaboratoryList1);

            this.drpLab.SelectedIndex = 0;
            this.drpUser.SelectedIndex = 0;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int32 ReciverCount = this.laboratory_UserList1.Count(row => row.Check == true);
            RASF.General.Data.Laboratory_User Recive = (RASF.General.Data.Laboratory_User)this.grdReceiver.CurrentRow.DataRow;

            if ((ReciverCount == 1))
            {
                foreach (RASF.General.Data.EnterExitPieces Exits in this.partsAreNotExitedFromStoredForLargeSampleList1)
                {
                    if (Exits.IsCheked == true)
                    {
                        Exits.RowState = General.Enums.RowState.Added;
                        Exits.UserId = Recive.UserId;
                        Exits.LaboratoryCode = (Guid)(drpLab.SelectedValue);
                        Exits.DelivererUserName = txtDesc.Text;
                    }
                    else
                    {
                        Exits.RowState = General.Enums.RowState.Original;
                    }

                }

                this.partsAreNotExitedFromStoredForLargeSampleList1.Update();
            }

            this.laboratory_UserList1.Fill();
            this.grdReceiver.Refetch();
        }

     

       
    }
}
