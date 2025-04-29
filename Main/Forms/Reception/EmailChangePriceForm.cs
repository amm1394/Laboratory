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
    public partial class EmailChangePriceForm : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime from;
        private DateTime to;
        
        public EmailChangePriceForm()
        {

            InitializeComponent();
            this.checkContractList1.spName = "EmailChangePrice";
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

        private void CheckContract_Load(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@From", from));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@To", to));
            this.checkContractList1.Fill(Parameters);
            this.grdReport.Refetch();
        }

        private void grdReport_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Contracts_Base_Edit Current_Contract = (RASF.General.Data.Contracts_Base_Edit)this.grdReport.SelectedItems[0].GetRow().DataRow;
            //switch (e.Column.Key)
            //{
            //    case "ContractNo":
            //        if (this.grdReport.SelectedItems.Count > 0)
            //        {
                      
                        if (Current_Contract != null)
                        {
                          
                            List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                            Parameter3.Add(new System.Data.SqlClient.SqlParameter("@Code", Current_Contract.ContractsCode));
                            this.costomerCostList1.Fill(Parameter3);

                            if (this.costomerCostList1.Count() > 0)
                            {
                                String FileName = System.IO.Path.ChangeExtension(System.IO.Path.Combine(System.IO.Path.GetTempPath() + System.IO.Path.GetRandomFileName()), "Bmp");

                                Aspose.Words.Document doc;

                                doc = new Aspose.Words.Document(new System.IO.MemoryStream(global::RASF.General.Resource.Documents.Cost_LetterInA4Paper));
                                Report2.Load(String.Format("{0}\\Report\\CustomerscostInA4PaperForEmail.mrt", Application.StartupPath));

                                Aspose.Words.Saving.SaveOptions SaveOption = Aspose.Words.Saving.SaveOptions.CreateSaveOptions(Aspose.Words.SaveFormat.Bmp);
                                SaveOption.PrettyFormat = true;
                                SaveOption.UseAntiAliasing = true;
                                SaveOption.UseHighQualityRendering = true;

                                if (this.costomerCostList1.list[0].Delivery > DateTime.MinValue)
                                {
                                    doc.Range.Bookmarks["Delivery"].Text = this.costomerCostList1[0].DeliveryString.ToString();
                                }
                                else
                                {
                                    doc.Range.Bookmarks["Delivery"].Text = "";
                                }

                                doc.Range.Bookmarks["Amount"].Text = this.costomerCostList1[0].Amount.ToString();
                                doc.Range.Bookmarks["CoName"].Text = this.costomerCostList1[0].CompanyName;
                                doc.Range.Bookmarks["Date"].Text = this.costomerCostList1[0].LetterDate;
                                doc.Range.Bookmarks["LetterNo"].Text = this.costomerCostList1[0].LetterNo;
                                doc.Range.Bookmarks["ContractNo"].Text = this.costomerCostList1[0].ContractNo.ToString();
                                doc.Range.Bookmarks["DateOfDay"].Text = this.costomerCostList1[0].DateOfDay;

                                doc.Save(FileName, SaveOption);

                                Report2["@Code"] = this.costomerCostList1[0].ContractsCode;
                                Stimulsoft.Report.Components.StiImage image = Report2.GetComponents()["Image1"] as Stimulsoft.Report.Components.StiImage;
                                image.File = FileName;
                                Report2.Render();
                                // Report2.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, @"c:\Scan\MyReport.pdf");

                                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                                Report2.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, ms);
                                ms.Seek(0, System.IO.SeekOrigin.Begin);
                                string to2 = this.costomerCostList1[0].Email2;

                                using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                                {

                                    foreach (string t in to2.Split(','))
                                    {
                                        msg.To.Add(new System.Net.Mail.MailAddress(t));
                                    }
                                    msg.From = new System.Net.Mail.MailAddress("Invoice@razi-foundation.com");
                                    msg.Subject = string.Format("اعلام هزینه قرارداد {0}", this.costomerCostList1[0].ContractNo.ToString());
                                    msg.Body = String.Format("<p dir={0}>مشتری گرامی <br />با سلام؛<br />احتراما به استحضار می رساند درخواست آن مشتری گرامی، طی نامه شماره{1} مورخ {2}، با شماره پیگیری {3} به این بنیاد پذیرش گردیده است. <br />بر همین اساس اعلام هزینه پذیرش مذکور در فایل پیوست قابل مشاهده می باشد.<br />خواهشمند است مقرر فرمایید هماهنگی های لازم برای تایید دریافت مدارک واریز وجه با بخش دبیرخانه و تایید انجام خدمات درخواستی و تایید مالی با بخش مالی آزمایشگاه ها صورت پذیرد.<br /> نام و نام خانوادگی رابط {4}<br />  شماره تماس رابط : 49732-021 داخلی  {5}<br />شماره تماس دبیرخانه 021-49732 داخلی 273 سرکار خانم رجب زاده<br /> شماره تماس واحد مالی آزمایشگاه ها 49732-021 داخلی 110  آقای اسماعیلی/ داخلی 266 سر کار خانم یاری<br />با احترام مجدد <br /> بنیاد علوم کاربردی رازی</p>", "rtl", this.costomerCostList1[0].LetterNo.ToString(), this.costomerCostList1[0].LetterDate.ToString(), this.costomerCostList1[0].ContractNo.ToString(), this.costomerCostList1[0].ConnectorName.ToString(), this.costomerCostList1[0].EXT.ToString());
                                    msg.Attachments.Add(new System.Net.Mail.Attachment(ms, string.Format(@"اعلام هزینه قرارداد {0}.pdf", this.checkContractList1[0].ContractNo.ToString())));
                                    msg.IsBodyHtml = true;
                                    SendSMS.Classes.Utility.Send(msg);
                                }

                                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                                Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", this.costomerCostList1[0].ContractsCode));
                                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
                                Parameter.Add(new System.Data.SqlClient.SqlParameter("@EmailAddFaxNo", to));
                                RASF.General.Lists.Base.BaseList<Object>.FillScalar("EmailCost_Select", Parameter);

                                Current_Contract.RowState = General.Enums.RowState.Updated;
                                Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                                this.checkContractList1.Update();

                                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                                Parameters.Add(new System.Data.SqlClient.SqlParameter("@From", from));
                                Parameters.Add(new System.Data.SqlClient.SqlParameter("@To", to));
                                this.checkContractList1.Fill(Parameters);
                                this.grdReport.Refetch();

                            }
                    //    }
                    //}
                    //break;
            
            }
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
            from = e.From;
            to = e.To;
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@From", e.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@To", e.To));
            this.checkContractList1.Fill(Parameters);
            this.grdReport.Refetch();
        }

        private void grdReport_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }
    }
}
