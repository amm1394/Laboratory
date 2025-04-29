using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class EnterFormScientificexpertsForHarmony : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        public EnterFormScientificexpertsForHarmony()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = true;
         //   this.ShowpnlSave = false;
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            FillContracts();
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.ContractsNotEntered contract_Current in this.contracts_NotEnteredForScientificexpertsForHarmonyList1)
            {
                if (contract_Current.IsCheck == true)
                {
                    this.contracts_NotEnteredForScientificexpertsForHarmonyList1.Update();
                }

            }
            FillContracts();
        }

        private void FillContracts()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.contracts_NotEnteredForScientificexpertsForHarmonyList1.Fill(Parameter);
            this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillContracts();
        }

       
    }
}
