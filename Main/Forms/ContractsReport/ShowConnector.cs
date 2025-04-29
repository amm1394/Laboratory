using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class ShowConnector : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle EtebariFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle TwoFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle FourFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;
        public ShowConnector()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;

            this.EtebariFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.EtebariFormat.BackColor = Color.Orange;
            this.EtebariFormat.ForeColor = Color.Black;

            this.TwoFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TwoFormat.BackColor = Color.Yellow;
            this.TwoFormat.ForeColor = Color.Black;

            this.FourFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.FourFormat.BackColor = Color.Red;
            this.FourFormat.ForeColor = Color.Black;


            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;
        }

        private void ShowVoidedContracts_Load(object sender, EventArgs e)
        {
            this.listOfConnectorNameList1.Fill();
            this.grdconnector.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdconnector.ExportToExcel("رابطین");
        }

        private void grdconnector_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["CooperationName"].Value) == "اعتباری")
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.EtebariFormat;
            }

            if (Convert.ToString(e.Row.Cells["CooperationName"].Value) == "اعتباری")
            {
                e.Row.Cells["CooperationName"].FormatStyle = this.EtebariFormat;
            }

            if (Convert.ToInt32(e.Row.Cells["Recdiif"].Value) > 60)
            {
                e.Row.Cells["ReceptionDate"].FormatStyle = this.TwoFormat;
            }

            if (Convert.ToInt32(e.Row.Cells["Recdiif"].Value) > 120)
            {
                e.Row.Cells["ReceptionDate"].FormatStyle = this.FourFormat;
            }

            if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            }
        }

        private void grdconnector_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Companies_Base CurrentRow = (RASF.General.Data.Companies_Base)this.grdconnector.CurrentRow.DataRow;
            RASF.Main.Forms.Financial.Info_PeapleRelated Info_PeapleRelated = new Financial.Info_PeapleRelated(CurrentRow.CompaniesCode);
            Info_PeapleRelated.Show();
        }

      
    }
}
