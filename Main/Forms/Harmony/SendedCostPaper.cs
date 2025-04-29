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
    public partial class SendedCostPaper : RASF.General.Forms.Base.DockContentForm
    {
        public SendedCostPaper()
        {
            InitializeComponent();
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;

        }

        private void SendedCostPaper_Load(object sender, EventArgs e)
        {
            this.sendedCostPaperList1.Fill();
            this.grdSended.Refetch();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@To", e.To));
            this.notSendedCostPaperList1.Fill(Parameter);
            this.grdNotSend.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.sendedCostPaperList1.Fill();
            this.grdSended.Refetch();
        }
    }
}
