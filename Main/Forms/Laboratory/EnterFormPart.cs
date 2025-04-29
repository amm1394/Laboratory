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
    public partial class EnterFormPart : RASF.General.Forms.Base.DockContentForm
    {
        public EnterFormPart()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = true;
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            FillContracts();
          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.contractsNotEnteredAmadesaziList1.Update();

            FillContracts();
        }

        private void FillContracts()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.contractsNotEnteredAmadesaziList1.Fill(Parameter);
            this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillContracts();
        }
    }
}
