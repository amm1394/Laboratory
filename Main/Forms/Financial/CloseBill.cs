using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class CloseBill : RASF.General.Forms.Base.DockContentForm
    {
        public CloseBill()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
           
        }
        RASF.General.Data.CloseBill CloseBill1 = new General.Data.CloseBill();
        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
           

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.closeBillList1.Fill(Parameter);
            this.grdBills.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.CloseBill Contracts_Base_Edit in this.closeBillList1)
            {
                if (Contracts_Base_Edit.IsClose == true)
                {
                    Contracts_Base_Edit.RowState = General.Enums.RowState.Updated;
                    this.closeBillList1.Update();
                }
                
            }
          
        }
    }
}
