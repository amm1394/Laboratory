using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Base
{
    public partial class ViewTarrif : RASF.General.Forms.Base.DockContentForm
    {
        public ViewTarrif()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
          //  this.ShowpnlUpdate = false;
            this.viewTarrifList2.spName = "ComonTarrifs";

        }

        private void ViewTarrif_Load(object sender, EventArgs e)
        {
            this.viewTarrifList1.Fill();
            this.grdview.Refetch();

            this.viewTarrifList2.Fill();
            this.grdComonTarif.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdview.ExportToExcel("تعرفه");
            this.grdComonTarif.ExportToExcel("تعرفه های پرکاربرد");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Report2.Load(String.Format("{0}\\Report\\ComonTarrifs.mrt", Application.StartupPath));
            Report2.Render();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Report2.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);
            string to = this.txtEmail.Text;

            using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
            {
                foreach (string t in to.Split(','))
                {
                    msg.To.Add(new System.Net.Mail.MailAddress(t));
                }

                //   msg.To.Add(new System.Net.Mail.MailAddress(this.txtEmail.Text));
                msg.From = new System.Net.Mail.MailAddress("Invoice@razi-foundation.com");
                msg.Subject = string.Format("تعرفه ها");
            //    msg.Body = String.Format("<p dir={0}>مشتری گرامی <br />با سلام؛<br />احتراما به استحضار می رساند درخواست آن مشتری گرامی، طی نامه شماره{1} مورخ {2}، با شماره پیگیری {3} به این بنیاد پذیرش گردیده است. <br />بر همین اساس اعلام هزینه پذیرش مذکور در فایل پیوست قابل مشاهده می باشد.<br />خواهشمند است مقرر فرمایید هماهنگی های لازم برای تایید دریافت مدارک واریز وجه با بخش دبیرخانه و تایید انجام خدمات درخواستی و تایید مالی با بخش مالی آزمایشگاه ها صورت پذیرد.<br /> نام و نام خانوادگی رابط {4}<br />  شماره تماس رابط : 49732-021 داخلی  {5}<br />شماره تماس دبیرخانه 021-49732 داخلی 273 سرکار خانم رجب زاده<br /> شماره تماس واحد مالی آزمایشگاه ها 49732-021 داخلی 110  آقای اسماعیلی/ داخلی 266 سر کار خانم یاری<br />با احترام مجدد <br /> بنیاد علوم کاربردی رازی</p>", "rtl", this.costomerCostList1[0].LetterNo.ToString(), this.costomerCostList1[0].LetterDate.ToString(), this.costomerCostList1[0].ContractNo.ToString(), this.costomerCostList1[0].ConnectorName.ToString(), this.costomerCostList1[0].EXT.ToString());
                msg.Attachments.Add(new System.Net.Mail.Attachment(ms, string.Format(@"تعرفه ها.pdf")));
                msg.IsBodyHtml = true;
                SendSMS.Classes.Utility.Send(msg);
                System.Windows.Forms.MessageBox.Show("برگه تعرفه  با موفقیت ارسال شد");
            }
        }
    }
}
