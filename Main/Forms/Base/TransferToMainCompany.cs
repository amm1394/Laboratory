using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Base
{
    public partial class TransferToMainCompany : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle TwoFormat;
        public TransferToMainCompany()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void TransferToMainCompany_Load(object sender, EventArgs e)
        {
            this.marketingCompanyList1.Fill();
            this.grdCompany.Refetch();

            this.TwoFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TwoFormat.BackColor = Color.Purple;
            this.TwoFormat.ForeColor = Color.Black;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.marketingCompanyList1.Fill();
            this.grdCompany.Refetch();
        }

        private void grdCompany_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if(grdCompany.SelectedItems.Count > 0 )
            {
                RASF.General.Data.Companies_Base CurrentRow = (RASF.General.Data.Companies_Base)this.grdCompany.SelectedItems[0].GetRow().DataRow;
                CurrentRow.RowState = RASF.General.Enums.RowState.Updated;
                this.marketingCompanyList1.Update();

               
              //  using (Aspose.Email.Mail.MailMessage message = new Aspose.Email.Mail.MailMessage())
                //{
                //    message.From = "marketing@razi-foundation.com";
                //    message.To = CurrentRow.Email;
                //    message.Subject = "پذیرش کار جدید";
                //    message.HtmlBody = "پذیرش کار جدید برای شرکت" + CurrentRow.CompanyName;
                //    Utility.SendMailMarketing(message);
                //}
                               
            }
            this.marketingCompanyList1.Fill();
            this.grdCompany.Refetch();


        }

        private void grdCompany_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToDateTime(e.Row.Cells["dateRecieption"].Value) != DateTime.MinValue)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.TwoFormat;
            }
        }

      
    }
}
