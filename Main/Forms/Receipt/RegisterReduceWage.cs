using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Receipt
{
    public partial class RegisterReduceWage : RASF.General.Forms.Base.DockContentForm
    {
        public RegisterReduceWage()
        {
            InitializeComponent();
            this.registerInsuranceForViewList1.spName = "RegisterReduceWage";
            
        }

        private void RegisterInsurance_Load(object sender, EventArgs e)
        {
            this.registerInsuranceForViewList1.Fill();
            this.grdContracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.DebtorCreditorContractBase rowUser in registerInsuranceForViewList1)
            {
                rowUser.UserId = RASF.General.Classes.Global.CurrentUserCode;
            }

            this.registerInsuranceForViewList1.Update();
            this.registerInsuranceForViewList1.Fill();
            this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.registerInsuranceForViewList1.Fill();
            this.grdContracts.Refetch();
        }
    }
}
