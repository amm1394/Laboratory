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
    public partial class ViewCancelExitedContractsForm : RASF.General.Forms.Base.DockContentForm
    {
        public ViewCancelExitedContractsForm()
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
            this.reasonOfCancelToExitList1.Fill(Parameters);
            this.grdCancelExited.Refetch();
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    this.Update();

        //    FillGrid();
        //}
    }
}
