using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS
{
    public class DrawTable : SendSMS.InterFace.MessageInterFace
    {
        public int FinancialYear { get; set; }

        public int ContractNo { get; set; }
        public Message Message { get; set; }

        public void DoWork()
        {
            AddTable();
        }

        private void AddTable()
        {
            ContractInfoList ContractInfo = new ContractInfoList();
            ContractInfo.Fill(FinancialYear, ContractNo);

            PartsInfoList PartsInfo = new PartsInfoList();
            PartsInfo.Fill(FinancialYear, ContractNo);

            TestInfoList TestInfo = new TestInfoList();
            TestInfo.Fill(FinancialYear, ContractNo);

            Aspose.Words.Tables.Cell[] Cell = new Aspose.Words.Tables.Cell[12];
            Aspose.Words.Document doc = new Aspose.Words.Document(new System.IO.MemoryStream(Resource.Cost_LetterPartsMasterWithHeader));
            Aspose.Words.DocumentBuilder builder = new Aspose.Words.DocumentBuilder(doc);
            doc.Range.Bookmarks["Amount"].Text = ContractInfo.list[0].Amount.ToString();
            doc.Range.Bookmarks["CoName"].Text = ContractInfo.list[0].CompanyName;
            doc.Range.Bookmarks["Date"].Text = ContractInfo.list[0].LetterDate;
            doc.Range.Bookmarks["LetterNo"].Text = ContractInfo.list[0].LetterNo;
            doc.Range.Bookmarks["ContractNo"].Text = ContractInfo.list[0].ContractNo.ToString();
            builder.MoveToBookmark("AddTable");

            Aspose.Words.Tables.Table table = builder.StartTable();
            builder.CellFormat.Width = 50;
            builder.Font.Size = 9;

            foreach (PartsInfoList Parts in PartsInfo.list)
            {
                Cell[0] = builder.InsertCell();
                builder.Write(Parts.PiecesName);
                Cell[0].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
                for (int i = 1; i < 11; i++)
                {
                    Cell[i] = builder.InsertCell();
                    Cell[i].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;
                }
                Cell[11] = builder.InsertCell();
                builder.Write("نام قطعه:");
                Cell[11].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.None;

                builder.EndRow();

                Cell[0] = builder.InsertCell();
                Cell[0].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
                builder.Write("قیمت واحد به ریال");
                Cell[1] = builder.InsertCell();
                Cell[1].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;
                Cell[2] = builder.InsertCell();
                Cell[2].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.None;
                builder.Write("تعداد");
                Cell[3] = builder.InsertCell();
                Cell[3].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
                builder.Write("نام آزمایش");
                for (int i = 4; i < 11; i++)
                {
                    Cell[i] = builder.InsertCell();
                    Cell[i].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;
                }
                Cell[11] = builder.InsertCell();
                Cell[11].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.None;
                builder.Write("ردیف");
                builder.EndRow();

                int Radif = 1;
                foreach (TestInfoList Test in TestInfo.list.Where(row => row.PartNumber == Parts.PartNumber))
                {
                    Cell[0] = builder.InsertCell();
                    Cell[0].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
                    builder.Write(Test.TotalPrice.ToString());
                    Cell[1] = builder.InsertCell();
                    Cell[1].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;
                    Cell[2] = builder.InsertCell();
                    Cell[2].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.None;
                    builder.Write(Test.NumberOfTests.ToString());
                    Cell[3] = builder.InsertCell();
                    Cell[3].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
                    builder.Write(Test.MasterName);
                    for (int i = 4; i < 11; i++)
                    {
                        Cell[i] = builder.InsertCell();
                        Cell[i].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;
                    }
                    Cell[11] = builder.InsertCell();
                    Cell[11].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.None;
                    builder.Write(Radif.ToString());
                    builder.EndRow();
                    Radif++;
                }
            }

            Cell[0] = builder.InsertCell();
            builder.Write("مجموع تعداد تنوع :" + PartsInfo.list.Count.ToString());
            Cell[0].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
            for (int i = 1; i < 12; i++)
            {
                Cell[i] = builder.InsertCell();
                Cell[i].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;
            }
            builder.EndRow();

            builder.Font.Size = 8;
            Cell[0] = builder.InsertCell();
            builder.Write((ContractInfo.list[0].Amount + (ContractInfo.list[0].Amount * ContractInfo.list[0].Tax / 100)).ToString());
            Cell[0].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
            Cell[1] = builder.InsertCell();
            Cell[1].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;

            builder.Font.Size = 5.5;
            Cell[2] = builder.InsertCell();
            builder.Write("جمع مبلغ با مالیات برارزش افزوده");
            Cell[2].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
            Cell[3] = builder.InsertCell();
            Cell[3].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;

            builder.Font.Size = 8;
            Cell[4] = builder.InsertCell();
            builder.Write((ContractInfo.list[0].Amount * ContractInfo.list[0].Tax / 100).ToString());
            Cell[4].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
            Cell[5] = builder.InsertCell();
            Cell[5].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;

            builder.Font.Size = 5.5;
            Cell[6] = builder.InsertCell();
            builder.Write("جمع مبلغ مالیات برارزش افزوده");
            Cell[6].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
            Cell[7] = builder.InsertCell();
            Cell[7].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;

            builder.Font.Size = 8;
            Cell[8] = builder.InsertCell();
            builder.Write(ContractInfo.list[0].Amount.ToString());
            Cell[8].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
            Cell[9] = builder.InsertCell();
            Cell[9].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;

            builder.Font.Size = 4.7;
            Cell[10] = builder.InsertCell();
            builder.Write("جمع مبلغ بدون مالیات برارزش افزوده");
            Cell[10].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.First;
            Cell[11] = builder.InsertCell();
            Cell[11].CellFormat.HorizontalMerge = Aspose.Words.Tables.CellMerge.Previous;
            builder.EndRow();
            builder.EndTable();
            doc.Save("Test.html", Aspose.Words.SaveFormat.Html);

            using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
            {
                msg.To.Add(new System.Net.Mail.MailAddress(ContractInfo.list[0].Email));
                msg.From = new System.Net.Mail.MailAddress("Reports@razi-foundation.com");
                msg.Subject = "Reoprt From Razi Applied Science Foundation";
                msg.Body = System.IO.File.ReadAllText("Test.html");
                msg.IsBodyHtml = true;
                SendSMS.Classes.Utility.Send(msg);
            }

            System.IO.File.Delete("Test.html");
            Message.Result = String.Format("برگه هزینه قرارداد به شماره پیگیری {0} متعلق به سال{1}به ایمیل {2}ارسال گردید", ContractNo, FinancialYear, ContractInfo.list[0].Email);
        }
          
    }
}
