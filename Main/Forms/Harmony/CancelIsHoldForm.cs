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
    public partial class CancelIsHoldForm : RASF.General.Forms.Base.DockContentForm
    {
        public CancelIsHoldForm()
        {
            InitializeComponent();
           
        }

        private void CancelIsHoldForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.cancel_Contracts_IsHoldList1.Fill(Parameters);
            this.grdCancelIsHold.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.Cancel_Contracts_IsHold Cancel_Contracts_IsHold in this.cancel_Contracts_IsHoldList1)
            {
                if (Cancel_Contracts_IsHold.IsCheck == true)
                {
                    Cancel_Contracts_IsHold.UserId = RASF.General.Classes.Global.CurrentUserCode;
                  //  this.cancel_Contracts_IsHoldList1.Update();
                }
            }
            this.cancel_Contracts_IsHoldList1.Update();

            FillGrid();
        }
    }
}
