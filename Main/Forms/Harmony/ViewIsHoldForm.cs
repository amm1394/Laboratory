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
    public partial class ViewIsHoldForm : RASF.General.Forms.Base.DockContentForm
    {
        public ViewIsHoldForm()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
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
            this.cancel_Contracts_IsHoldList1.Update();

            FillGrid();
        }
    }
}
