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
    public partial class DeliveryDateChange : RASF.General.Forms.Base.DockContentForm
    {

        public DeliveryDateChange()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }
        
        private void IsHoldForm_Load(object sender, EventArgs e)
        {
          //  DatePickertxtDelivery.IsNull = true;
         //   DatePickertxtDelivery.SelectedDateTime = System.DateTime.Now.AddDays(0);
            FillGrid();
        }     

        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.deliveryDateChangeList1.Fill(Parameter);

            this.grdDelivery.Refetch();
           
        }
     
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdDelivery.SelectedItems.Count > 0)
            {
                RASF.General.Data.DeliveryDateChange Current_Contract = (RASF.General.Data.DeliveryDateChange)this.grdDelivery.SelectedItems[0].GetRow().DataRow;

                 if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                {
                  
                        Current_Contract.RowState = General.Enums.RowState.Added;
                        Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                        Current_Contract.UserID = RASF.General.Classes.Global.CurrentUserCode;
                        this.deliveryDateChangeList1.Update();

                        List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", Current_Contract.ContractsCode));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("@EditUser", RASF.General.Classes.Global.CurrentUserCode));
                        RASF.General.Lists.Base.BaseList<Object>.FillScalar("EditedContractBase_Update", Parameter);

                        FillGrid();

                        this.txtReason.Text = String.Empty;
                    }
                }
            
        
        }

        private void grdDelivery_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdDelivery.CurrentRow != null) && (this.grdDelivery.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpGrid.Text = "قرارداد" + " " + this.grdDelivery.CurrentRow.Cells["ContractNo"].Value.ToString();
            }
            else
            {
                this.grpGrid.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            
    }
}
