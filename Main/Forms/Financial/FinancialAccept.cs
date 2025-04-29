using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class FinancialAccept : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        private string To;
        private Janus.Windows.GridEX.GridEXFormatStyle FourFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle NotInvoiceFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle FourtyPercentageOFCredit;
        public FinancialAccept()
        {
            InitializeComponent();
            this.pnlButton.Visible = true;
            this.ShowpnlSave = true;
            this.btnSave.Text = "ذخیره در اکسل";
           // this.btnSave.Size = (85,23);
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = true;

            this.FourFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.FourFormat.BackColor = Color.Red;
            this.FourFormat.ForeColor = Color.Black;

            this.NotInvoiceFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NotInvoiceFormat.BackColor = Color.Green;
            this.NotInvoiceFormat.ForeColor = Color.Black;

            this.FourtyPercentageOFCredit = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.FourtyPercentageOFCredit.BackColor = Color.DarkOrange;
            this.FourtyPercentageOFCredit.ForeColor = Color.Black;


        }
       // RASF.General.Data.Contracts_Base_Edit Current_Contract = (RASF.General.Data.Contracts_Base_Edit)grdContracts.SelectedItems[0].GetRow().DataRow;

        private void ReissuesForm_Load(object sender, EventArgs e)
        {
            this.validatorOfFinancialList1.Fill();
            General.Classes.Utility.Create_DropDown(this.grdContracts.RootTable.Columns["ValidatorCode"], this.validatorOfFinancialList1,"ValidatorCode", "Validator");
            this.grdContracts.RootTable.Columns["ValidatorCode"].DefaultValue = this.validatorOfFinancialList1[2].ValidatorCode;
            RefreshGrid();
       }

        private void RefreshGrid() 
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.financiacceptList1.Fill(Parameters);
            this.grdContracts.Refetch();
        }

        private void grdContracts_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdContracts.CurrentRow != null) && (this.grdContracts.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpContracts.Text = String.Format("قرارداد {0}", this.grdContracts.CurrentRow.Cells["ContractNo"].Value);

                        
            }
            else
            {
                this.grpContracts.Text = "";
            }


            if (this.grdContracts.SelectedItems.Count > 0)
            {
                RASF.General.Data.Contracts_Base_Edit Current_Contract = (RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow;

                if (Current_Contract != null)
                {

                    this.ContractsCode = Current_Contract.ContractsCode;
                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("Code", Current_Contract.ContractsCode));
                    this.finanicalAcceptTets1.Fill(Parameters);

                    this.grdBill.Refetch();
                }
                else
                {
                    this.finanicalAcceptTets1.Clear();
                    //this.grdBill.Refetch();
                    this.ContractsCode = Guid.Empty;
                }
            }
            else
            {
                this.finanicalAcceptTets1.Clear();
                this.grdBill.Refetch();
                this.ContractsCode = Guid.Empty;
            }

        
        }

        private void grdBill_CurrentCellChanged(object sender, EventArgs e)
        {
            this.finanicalAcceptTets1.UpdateRow();
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Contracts_Base_Edit Current_Contract1 = (RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow;

            if (MessageBox.Show("تغییر تاریخ تحویل قرارداد", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {

                RASF.Main.Forms.Harmony.DeliveryDateChange DeliveryDateChange = new RASF.Main.Forms.Harmony.DeliveryDateChange();
                DeliveryDateChange.ShowDialog();
            }



            if (ContractsCode != Guid.Empty && Current_Contract1.ValidatorCode.ToString() != "00000000-0000-0000-0000-000000000000" && Current_Contract1.ValidatorCode != Guid.Empty)
            {

                ((RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
                Current_Contract1.UserId = RASF.General.Classes.Global.CurrentUserCode;
                this.financiacceptList1.Update();
                this.finanicalAcceptTets1.Update();


                RefreshGrid();


                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Current_Contract1.ContractsCode));
                To = RASF.General.Lists.SendEmailList.FillScalar("CheckDelivery_Select", Parameter2).ToString();

                if (To == "1" )
                {
                    System.Windows.Forms.MessageBox.Show("تاریخ تحویل کوچکتر از تاریخ تایید مالی می باشد");
                    if (MessageBox.Show("تغییر تاریخ تحویل قرارداد", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {

                        RASF.Main.Forms.Harmony.DeliveryDateChange DeliveryDateChange = new RASF.Main.Forms.Harmony.DeliveryDateChange();
                        DeliveryDateChange.ShowDialog();
                    }
                }

           



                //String FileName = System.IO.Path.ChangeExtension(System.IO.Path.Combine(System.IO.Path.GetTempPath() + System.IO.Path.GetRandomFileName()), "Bmp");

                //Aspose.Words.Document doc;

                //doc = new Aspose.Words.Document(new System.IO.MemoryStream(global::RASF.General.Resource.Documents.Cost_LetterInA4Paper));
                //Report2.Load(String.Format("{0}\\Report\\CustomerscostInA4PaperForEmail.mrt", Application.StartupPath));

                //Aspose.Words.Saving.SaveOptions SaveOption = Aspose.Words.Saving.SaveOptions.CreateSaveOptions(Aspose.Words.SaveFormat.Bmp);
                //SaveOption.PrettyFormat = true;
                //SaveOption.UseAntiAliasing = true;
                //SaveOption.UseHighQualityRendering = true;

                //if (Current_Contract1.Delivery > DateTime.MinValue)
                //{
                //    doc.Range.Bookmarks["Delivery"].Text = Current_Contract1.DeliveryString.ToString();
                //}
                //else
                //{
                //    doc.Range.Bookmarks["Delivery"].Text = "";
                //}

                //doc.Range.Bookmarks["Amount"].Text = Current_Contract1.Debtor.ToString();
                //doc.Range.Bookmarks["CoName"].Text = Current_Contract1.CompanyName;
                //doc.Range.Bookmarks["Date"].Text = Current_Contract1.LetterDate;
                //doc.Range.Bookmarks["LetterNo"].Text = Current_Contract1.LetterNo;
                //doc.Range.Bookmarks["ContractNo"].Text = Current_Contract1.ContractNo.ToString();
                //doc.Range.Bookmarks["DateOfDay"].Text = Current_Contract1.DateOfDay;

                //doc.Save(FileName, SaveOption);

                //Report2["@Code"] = Current_Contract1.ContractsCode;//this.grdContracts.CurrentRow.Cells["ContractsCode"].Value;
                //Stimulsoft.Report.Components.StiImage image = Report2.GetComponents()["Image1"] as Stimulsoft.Report.Components.StiImage;
                //image.File = FileName;
                //Report2.Render();
                //// Report2.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, @"c:\Scan\MyReport.pdf");

                //List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                //Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Current_Contract1.ContractsCode));
                //To = RASF.General.Lists.SendEmailList.FillScalar("SendEmail_Select", Parameter2).ToString();

                //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //Report2.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, ms);
                //ms.Seek(0, System.IO.SeekOrigin.Begin);

                //using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                //{
                //    msg.To.Add(new System.Net.Mail.MailAddress(To));
                //    msg.From = new System.Net.Mail.MailAddress("Invoice@razi-foundation.com");
                //    msg.Subject = string.Format(" تایید مالی قرارداد {0}", Current_Contract1.ContractNo);
                //    msg.Body = String.Format("<p dir={0}>مشتری گرامی <br />با سلام؛<br />احتراما به استحضار می رساند درخواست آن مشتری گرامی، طی نامه شماره{1} مورخ {2}، با شماره پیگری {3} به این بنیاد پذیرش گردیده است. <br />اعلام هزینه و برگه قرارداد آزمونهای پذیرش شده در فایل پیوست قابل مشاهده می باشد.<br />خواهشمند است جهت هماهنگی امور مالی و تایید انجام خدمات درخواستی با بخش مالی آزمایشگاههای این بنیاد تماس حاصل فرمایید.<br /> نام و نام خانوادگی رابط {4}<br />  شماره تماس رابط : 49732-021 داخلی  {5}<br /> شماره تماس واحد مالی آزمایشگاه ها 49732-021 داخلی 110 آقای اسماعیلی / داخلی 102 خانم قربانی<br />با احترام مجدد <br /> بنیاد علوم کاربردی رازی</p>", "rtl", Current_Contract1.LetterNo.ToString(), Current_Contract1.LetterDate.ToString(), Current_Contract1.ContractNo.ToString(), Current_Contract1.ConnectorName.ToString(), Current_Contract1.EXT.ToString());
                //    msg.Attachments.Add(new System.Net.Mail.Attachment(ms, string.Format(@" تایید مالی قرارداد {0}.pdf", Current_Contract1.ContractNo)));
                //    msg.IsBodyHtml = true;
                //    SendSMS.Classes.Utility.Send(msg);
                //}
            }
         //   this.financiacceptList1.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           RefreshGrid();
           //if (MessageBox.Show("تغییر تاریخ تحویل قرارداد", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
           //{

           //    RASF.Main.Forms.Harmony.DeliveryDateChange DeliveryDateChange = new RASF.Main.Forms.Harmony.DeliveryDateChange();
           //    DeliveryDateChange.ShowDialog();
           //}
      

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdContracts.ExportToExcel("تایید مالی نشده");
        }

        private void grdContracts_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            string Contains1 = Convert.ToString(e.Row.Cells["StepByStep"].Value);
            if (Contains1.Contains("بله"))
            {
                e.Row.Cells["StepByStep"].FormatStyle = this.FourFormat;

                //if (Convert.ToInt64(e.Row.Cells["Notinvoice"].Value) > Convert.ToInt64(e.Row.Cells["Credit"].Value))
                //{
                    //if (Convert.ToInt64(e.Row.Cells["Notinvoice"].Value) <= Convert.ToInt64(e.Row.Cells["FourtyPercentageOFCredit"].Value))
                    //{
                    //    e.Row.Cells["Notinvoice"].FormatStyle = this.FourtyPercentageOFCredit;
                    //}
                    //else
                    //{
                    //    e.Row.Cells["Notinvoice"].FormatStyle = this.FourFormat;
                    //}
                //}
                //else
                //{
                //    e.Row.Cells["Notinvoice"].FormatStyle = this.NotInvoiceFormat;
                //}
            }
        }
    }
}
