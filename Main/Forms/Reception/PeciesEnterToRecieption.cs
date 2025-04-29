using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class PeciesEnterToRecieption : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractCode;
        public PeciesEnterToRecieption()
        {
            InitializeComponent();
            this.registerNotInPersonPartList1.spName = "RegisterNotInPersonPartForUser";
        }

        private void pickDate1_DateSelected(RASF.General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.registerNotInPersonPartList1.Fill(Parameter);
            this.grid1.Refetch();
        }

        private void grid1_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            ContractCode = (Guid)(this.grid1.CurrentRow.Cells["ContractsCode"].Value);
            RASF.Main.Forms.Reception.New_Reciption_Edit Reciption_Edit = new RASF.Main.Forms.Reception.New_Reciption_Edit(ContractCode);
            Reciption_Edit.Show();
        }
    }
}
