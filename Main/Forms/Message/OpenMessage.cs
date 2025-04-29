using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Message
{
    public partial class OpenMessage : RASF.General.Forms.Base.DockContentForm
    {
      //  private RASF.General.Data.SendMessage SendMessage1;
        public event System.EventHandler NumofUnreadMessage;
        public OpenMessage()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
           // this.ShowpnlUpdate = true;
        }

        
        private void OpenMessage_Load(object sender, EventArgs e)
        {
            FillOpenMessage();
        }

        private void FillOpenMessage()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Receiver", RASF.General.Classes.Global.CurrentUserCode));
            this.readOfUnreadMessageList1.Fill(Parameter);

            this.grdShowMessage.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.SendMessage Recive in this.readOfUnreadMessageList1.Where(row => row.Check == true))
            {
                this.readOfUnreadMessageList1.Update();
                
            }
            FillOpenMessage();
        }

        private void grdShowMessage_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.SendMessage CurrentRow = (RASF.General.Data.SendMessage)this.grdShowMessage.CurrentRow.DataRow;
            RASF.Main.Forms.Message.SendMessage SendMessage = new RASF.Main.Forms.Message.SendMessage(CurrentRow.ContractsCode,CurrentRow.ContractNo);
            SendMessage.Show();
            CurrentRow.RowState = RASF.General.Enums.RowState.Updated;
            this.readOfUnreadMessageList1.Update();
            FillOpenMessage();

            if (this.NumofUnreadMessage != null)
            {
                this.NumofUnreadMessage(this, new EventArgs());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillOpenMessage();
        }
    }
}
