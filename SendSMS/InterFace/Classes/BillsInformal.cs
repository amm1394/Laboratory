using Aspose.Words;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SendSMS.Classes 
{
    public class BillsInformal : InterFace.MessageInterFace
    {
        public int FinancialYear { get; set; }

        public int ContractNo { get; set; }
        public Message Message { get; set; }

        public void DoWork()
        {
            SurvayBillForEmailBillList SurvayBillInfo = new SurvayBillForEmailBillList();
            SurvayBillInfo.Fill(FinancialYear, ContractNo);

            this.MakeBill();

            if (SurvayBillInfo.list[0].Check == 0)
            {
                using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                {
                    msg.To.Add(new System.Net.Mail.MailAddress(SurvayBillInfo.list[0].Email));
                    msg.From = new System.Net.Mail.MailAddress("Reports@razi-foundation.com");
                    msg.Subject = "Reoprt From Razi Applied Science Foundation";
                    msg.Body = "<h3>Please see the attachment</h3>";
                    msg.Attachments.Add(new System.Net.Mail.Attachment(this.MakeBill(), "Bill.pdf"));
                    msg.IsBodyHtml = true;
                    SendSMS.Classes.Utility.Send(msg);
                }

                this.Message.Result = string.Format("برگه صورت حساب درخواست به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2}ارسال گردید", this.ContractNo, this.FinancialYear, SurvayBillInfo.list[0].Email);
            }
            else
            {
                if ((SurvayBillInfo.list[0].Check & 1) == 1)
                {
                    Message.Result = String.Format("از ارسال برگه صورت حساب درخواست به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2} معذوریم این قرارداد ابطال گردیده است", ContractNo, FinancialYear, SurvayBillInfo.list[0].Email);
                }
                else
                {
                    if ((SurvayBillInfo.list[0].Check & 2) == 2)
                    {
                        Message.Result = String.Format("از ارسال برگه صورت حساب درخواست به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2} معذوریم صورت حساب صادر نگردیده است ", ContractNo, FinancialYear, SurvayBillInfo.list[0].Email);
                    }
                    else
                    {
                        Message.Result = String.Format("از ارسال برگه صورت جساب درخواست به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2} به علت ابطال معذوریم  ", ContractNo, FinancialYear, SurvayBillInfo.list[0].Email);
                    }
                }
            }
        }

        public System.IO.MemoryStream MakeBill()
        {
            int num2;
            contractinfoForEmailOfBillLList list = new contractinfoForEmailOfBillLList();
            list.Fill(this.FinancialYear, this.ContractNo);

            MasterBillForEmailList list2 = new MasterBillForEmailList();
            list2.Fill(this.FinancialYear, this.ContractNo);

            Document doc = new Document(new MemoryStream(Resource.صورت_حساب_فروش_غیر_رسمی));
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.ParagraphFormat.Alignment = ParagraphAlignment.Right;

            doc.Range.Bookmarks["CompanyName"].Text = RASF.General.Classes.BookMarks.CorrectStringReturn(list.list[0].CompanyName, builder, "CompanyName");
            doc.Range.Bookmarks["CmpanyAddress"].Text = RASF.General.Classes.BookMarks.CorrectStringReturn(list.list[0].CmpanyAddress, builder, "CmpanyAddress");
            doc.Range.Bookmarks["EconomicCode"].Text = list.list[0].EconomicCode;
            doc.Range.Bookmarks["LetterDate"].Text = list.list[0].LetterDate;
            doc.Range.Bookmarks["LetterNo"].Text = list.list[0].LetterNo;
            doc.Range.Bookmarks["PostCode"].Text = list.list[0].PostCode;
            doc.Range.Bookmarks["SetNum"].Text = list.list[0].SetNum;
            doc.Range.Bookmarks["ContractNo"].Text = this.ContractNo.ToString();
            doc.Range.Bookmarks["BillNumber"].Text = list2.list[0].BillNumber.ToString();
            doc.Range.Bookmarks["BillDate"].Text = list2.list[0].BillDate.ToString();
            builder.MoveToBookmark("AddTable");

            Aspose.Words.Tables.Table table = doc.FirstSection.Body.Tables[0];
            
            Node node = table.LastRow.Clone(true);

            table.LastRow.Remove();

            Run[] runArray = new Run[11];
            Paragraph[] paragraphArray = new Paragraph[11];
            int num = 1;
            foreach (MasterBillForEmailList list3 in list2.list)
            {
                num2 = 0;
                while (num2 < 11)
                {
                    runArray[num2] = new Run(doc);
                    runArray[num2].Font.Bidi = true;
                    runArray[num2].Font.NameBi = "BMitra";
                    runArray[num2].Font.SizeBi = 8.0;
                    paragraphArray[num2] = new Paragraph(doc);
                    paragraphArray[num2].ParagraphFormat.Alignment = ParagraphAlignment.Center;
                    num2++;
                }
                runArray[0].Text = num.ToString();
                runArray[1].Text = "";
                runArray[2].Text = list3.MasterName;
                runArray[3].Text = list3.NumberOfTests.ToString("N0");
                runArray[4].Text = "عدد";
                runArray[5].Text = list3.InvoicePrice.ToString("N0");
                runArray[6].Text = list3.TotalPrice.ToString("N0");
                runArray[7].Text = list3.DisCount.ToString("N0");
                Int64 num3 = list3.TotalPrice - list3.DisCount;
                runArray[8].Text = num3.ToString("N0");
                runArray[9].Text = list3.Tax.ToString("N0");
                runArray[10].Text = ((list3.TotalPrice - list3.DisCount) + list3.Tax).ToString("N0");
                Node node2 = table.FirstRow.Clone(true);
                ((Aspose.Words.Tables.Row)node2).RowFormat.Height = 21.0;
                num2 = 0;
                while (num2 < 11)
                {
                    paragraphArray[num2].AppendChild(runArray[num2]);
                    ((Aspose.Words.Tables.Row)node2).Cells[num2].ChildNodes.Clear();
                    ((Aspose.Words.Tables.Row)node2).Cells[num2].ChildNodes.Add(paragraphArray[num2]);
                    num2++;
                }
                table.Rows.Add(node2);
                if ((num % 10) == 0)
                {
                    Node node3 = table.FirstRow.Clone(true);
                    table.Rows.Add(node3);
                }
                num++;
            }
            for (num2 = 0; num2 < 11; num2++)
            {
                runArray[num2] = new Run(doc);
                runArray[num2].Font.Bidi = true;
                runArray[num2].Font.NameBi = "BMitra";
                runArray[num2].Font.SizeBi = 8.0;
                paragraphArray[num2] = new Paragraph(doc);
                paragraphArray[num2].ParagraphFormat.Alignment = ParagraphAlignment.Center;
            }
            runArray[1].Text = list2.list.Sum<MasterBillForEmailList>(((Func<MasterBillForEmailList, Int64>)(row => row.TotalPrice))).ToString("N0");
            runArray[2].Text = list2.list.Sum<MasterBillForEmailList>(((Func<MasterBillForEmailList, Int64>)(row => row.DisCount))).ToString("N0");
            runArray[3].Text = list2.list.Sum<MasterBillForEmailList>(((Func<MasterBillForEmailList, Int64>)(row => (row.TotalPrice - row.DisCount)))).ToString("N0");
            runArray[4].Text = list2.list.Sum<MasterBillForEmailList>(((Func<MasterBillForEmailList, Int64>)(row => row.Tax))).ToString("N0");
            runArray[5].Text = list2.list.Sum<MasterBillForEmailList>(((Func<MasterBillForEmailList, Int64>)(row => ((row.TotalPrice - row.DisCount) + row.Tax)))).ToString("N0");
            for (num2 = 1; num2 < 6; num2++)
            {
                paragraphArray[num2].AppendChild(runArray[num2]);
                ((Aspose.Words.Tables.Row)node).Cells[num2].ChildNodes.Clear();
                ((Aspose.Words.Tables.Row)node).Cells[num2].ChildNodes.Add(paragraphArray[num2]);
            }
            ((Aspose.Words.Tables.Row)node).RowFormat.Height = 21.0;
            table.Rows.Add(node);
            MemoryStream stream = new MemoryStream();
            doc.Save(stream, SaveFormat.Pdf);
            stream.Flush();
            return stream;
        }

    }
}