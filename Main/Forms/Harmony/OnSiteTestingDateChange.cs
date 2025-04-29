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
    public partial class OnSiteTestingDateChange : RASF.General.Forms.Base.DockContentForm
    {

        public OnSiteTestingDateChange()
        {
            InitializeComponent();
            this.testForThePresenceDateChangeList1.spName = "OnSiteTestingDateChange";

        }

        private void IsHoldForm_Load(object sender, EventArgs e)
        {
            DatePickertxtTest.IsNull = true;
            FillGrid();
        }     

        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.testForThePresenceDateChangeList1.Fill(Parameter);
            this.grdTest.Refetch();
           
        }
     
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdTest.SelectedItems.Count > 0)
            {
                RASF.General.Data.DeliveryDateChange Current_Contract = (RASF.General.Data.DeliveryDateChange)this.grdTest.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null))
                {
                    Current_Contract.RowState = General.Enums.RowState.Updated;
                    Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                    Current_Contract.UserID = RASF.General.Classes.Global.CurrentUserCode;
                    this.testForThePresenceDateChangeList1.Update();

                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", Current_Contract.ContractsCode));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("@EditUser", RASF.General.Classes.Global.CurrentUserCode));
                    RASF.General.Lists.Base.BaseList<Object>.FillScalar("EditedContractBase_Update", Parameter);    

                    FillGrid();

                  
                }
            }
        
        }

        private void grdDelivery_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdTest.CurrentRow != null) && (this.grdTest.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpGrid.Text = "قرارداد" + " " + this.grdTest.CurrentRow.Cells["ContractNo"].Value.ToString();
            }
            else
            {
                this.grpGrid.Text = "";
            }

        }
                   
    }
}
