using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Store
{
    public partial class PartsThatExitedToLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        public PartsThatExitedToLaboratory()
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
            this.emptyBasketList1.Fill(Parameter1);

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.partsAreNotExitedFromLaboratoryList1.Fill(Parameter2);


            this.grdParts.Refetch();
            this.grdEmptyBasket.Refetch();
        }

        private void grdEmptyBasket_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }

        private void PartsThatExitedFromStoreToLaboratory_Load(object sender, EventArgs e)
        {
            this.findUsersLaboratoryList1.Fill();

            General.Classes.Utility.CreateDropDow(drpUser, "UserName", "UserId", findUsersLaboratoryList1);
            this.drpUser.SelectedIndex = 0;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.EnterExitPieces Exits in this.partsAreNotExitedFromLaboratoryList1)
            {
                if (Exits.IsCheked == true)
                {
                    Exits.RowState = General.Enums.RowState.Updated;
                    Exits.Deliverer = (Guid)(drpUser.SelectedValue);
                    Exits.DelivererUserName = txtDesc.Text;
                }
                //else
                //{
                //    Exits.RowState = General.Enums.RowState.Original;
                //}
              
            }
          
            this.partsAreNotExitedFromLaboratoryList1.Update();
        }

     

       
    }
}
