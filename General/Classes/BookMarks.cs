using Aspose.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Classes
{
    public class BookMarks
    {
        public static byte[] SetTotalPage(byte[] Document, Int32 StartPage, Int32 TotalPage, Boolean ReportType)
        {
            //using (System.IO.MemoryStream doc = new System.IO.MemoryStream())
            //{
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(Document))
                {
                    Aspose.Words.Document document = new Aspose.Words.Document(ms);

                    Aspose.Words.DocumentBuilder Builder = new Aspose.Words.DocumentBuilder(document);
                    if (ReportType == true)
                    {
                        Builder.MoveToBookmark("TotalPageNumber");
                        Builder.StartBookmark("TotalPageNumber");
                        Builder.Font.Name = "Calibri";
                        Builder.Font.Size = 9;//9
                        Builder.Write(TotalPage.ToString());
                        Builder.EndBookmark("TotalPageNumber");
                    }
                    else
                    {
                        CorrectString(TotalPage.ToString(), Builder, "TotalPageNumber");
                    }
                    document.FirstSection.PageSetup.PageStartingNumber = StartPage;
                    document.FirstSection.PageSetup.RestartPageNumbering = true;
                    string filename = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetRandomFileName());
                    document.Save(filename, Aspose.Words.SaveFormat.Pdf);
                    Document = System.IO.File.ReadAllBytes(filename);
                    System.IO.File.Delete(filename);
                    //document.Save(doc, Aspose.Words.SaveFormat.Pdf);
                    //Document = doc.ToArray();
                }
                return Document;
           // }
        }

   
        public static byte[] SetBookMarks(Guid PartsTestMasterCode, byte[] Document, RASF.General.Enums.BookMark SetBookMark, Boolean ReportType)
        {
            RASF.General.Lists.BookMarksList BookMarksList = new Lists.BookMarksList();
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", PartsTestMasterCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportType", ReportType));
            BookMarksList.Fill(Parameters);
            RASF.General.Data.BookMarks BookMarks = BookMarksList.FirstOrDefault();

            if (BookMarks != null)
            {
                using (System.IO.MemoryStream doc = new System.IO.MemoryStream())
                {
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(Document))
                    {
                        Aspose.Words.Document document = new Aspose.Words.Document(ms);
                        Aspose.Words.DocumentBuilder Builder = new Aspose.Words.DocumentBuilder(document);
                        if (ReportType == true)
                        {
                           // Builder.CurrentSection.PageSetup.HeaderDistance = 0.18;
                            document.FirstSection.PageSetup.PageNumberStyle = Aspose.Words.NumberStyle.ThaiArabic;

                        }
                        foreach (System.Reflection.PropertyInfo property in BookMarks.GetType().GetProperties())
                        {
                            Object[] Attributes = property.GetCustomAttributes(typeof(RASF.General.Attributes.DataAttribute), false);

                            if (Convert.ToInt16(((RASF.General.Attributes.DataAttribute)Attributes[0]).SetBookMark) >= Convert.ToInt16(SetBookMark))
                            {
                                String BookMarkName = property.Name;
                                if (document.Range.Bookmarks[BookMarkName] != null)
                                {
                                    document.Range.Bookmarks[BookMarkName].Text = "";
                                    if (ReportType == true)
                                    {
                                        if (BookMarkName == "PartName")
                                        {
                                            Builder.MoveToBookmark(BookMarkName);
                                            Builder.StartBookmark(BookMarkName);
                                            Builder.Font.Name = "Calibri";
                                            Builder.Font.Size =8;//7
                                            Builder.Write(property.GetValue(BookMarks).ToString());
                                            Builder.EndBookmark(BookMarkName);
                                        }
                                        else
                                        {

                                            Builder.MoveToBookmark(BookMarkName);
                                            Builder.StartBookmark(BookMarkName);
                                            Builder.Font.Name = "Calibri";
                                            Builder.Font.Size = 8;//8
                                            Builder.Write(property.GetValue(BookMarks).ToString());
                                            Builder.EndBookmark(BookMarkName);
                                        }
                                    }
                                    else
                                    {
                                        CorrectString(property.GetValue(BookMarks).ToString(), Builder, BookMarkName);
                                    }
                                }
                            }
                        }

                        if (SetBookMark == Enums.BookMark.AddState)
                        {
                            if (document.Range.Bookmarks["Temperature"] != null)
                            {
                                CorrectString(RASF.General.Classes.Global.temprature.ToString() + "C", Builder, "Temperature");
                            }

                            if (document.Range.Bookmarks["Humidity"] != null)
                            {
                                if (ReportType == true)
                                {
                                    Builder.MoveToBookmark("Humidity");
                                    Builder.StartBookmark("Humidity");
                                    Builder.Font.Name = "Calibri";
                                    Builder.Font.Size = 9;
                                    Builder.Write("%" + RASF.General.Classes.Global.humid.ToString());
                                    Builder.EndBookmark("Humidity");
                                }
                                else
                                {
                                    CorrectString("%" + RASF.General.Classes.Global.humid.ToString(), Builder, "Humidity");
                                }
                            }
                        }

                        document.Save(doc, Aspose.Words.SaveFormat.Docx);
                        Document = doc.ToArray();
                    }
                }
            }
            return Document;
        }

        public static void CorrectString(String text, Aspose.Words.DocumentBuilder Builder, String BookMarkName)
        {
            //List<String> test = new List<String>();
            //List<int> max_list = new List<int>();
            //bool IsComplex = false;
            //int i = 0;
            //while (i <= text.Length - 1)
            
            //{
            //    int max = 0;
            //    String txt = String.Empty;
            //    if ((int)text[i] > 127)
            //    {
            //        while ((i < text.Length) && (((int)text[i] > 127)))
            //        {
            //            txt += text[i];
            //            max = Math.Max(max, text[i]);
            //            if (((int)text[i] == 45))
            //            {
            //                if (txt.Length > 1)
            //                {
            //                    txt = txt.Replace("-", "");
            //                }
            //                else
            //                {
            //                    i++;
            //                }
            //                break;
            //            }
            //            i++;
            //        }
            //    }
            //    else
            //    {
            //        while ((i < text.Length) && (((int)text[i] <= 127)))
            //        {
            //            txt += text[i];
            //            max = Math.Max(max, text[i]);
            //            if (((int)text[i] == 45))
            //            {
            //                if (txt.Length > 1)
            //                {
            //                    txt = txt.Replace("-", "");
            //                }
            //                else
            //                {
            //                    i++;
            //                }
            //                break;
            //            }
            //            i++;
            //        }
            //        if (max > 58)
            //        {
            //            IsComplex = true;
            //        }
            //    }
            //    test.Add(txt);
            //    max_list.Add(max);
            //}

            //Builder.MoveToBookmark(BookMarkName);
            //Builder.ParagraphFormat.Alignment = Aspose.Words.ParagraphAlignment.Left;
            //Builder.StartBookmark(BookMarkName);
            //int j = 0;
            //foreach (String txt in test)
            //{
            //    if (String.IsNullOrEmpty(txt.Trim()) == false)
            //    {
            //        if ((int)txt[0] > 127)
            //        {
            //            Builder.Font.Name = "B Lotus";
            //            Builder.Font.Size = 9;
            //            Builder.Font.SizeBi = 9;
            //            Builder.Font.Bidi = true;
            //            Builder.Write(txt + " ");
            //        }
            //        else
            //        {
            //            if ((max_list[j] < 58) && (IsComplex == false))
            //            {
            //                Builder.Font.Name = "B Lotus";
            //                Builder.Font.Size = 9;
            //                Builder.Font.SizeBi = 9;
            //                Builder.Font.Bidi = true;
            //            }
            //            else
            //            {
            //                Builder.Font.Size = 9;
            //                if (((int)txt.Trim()[0] == 40) || ((int)txt.Trim()[0] == 41) || ((int)txt.Trim()[0] == 45))
            //                {
            //                    Builder.Font.Name = "B Lotus";
            //                    Builder.Font.Size = 9;
            //                    Builder.Font.SizeBi = 9;
            //                    Builder.Font.Bidi = true;
            //                }
            //                else
            //                {
            //                    Builder.Font.Bidi = false;
            //                    Builder.Font.Name = "Calibri";
            //                }
            //            }
            //            Builder.Font.Bidi = false;
            //            Builder.Write(txt + " ");
            //            Builder.ParagraphFormat.Alignment = Aspose.Words.ParagraphAlignment.Left;
            //        }
            //    }
            //    j++;
            //}
            //Builder.EndBookmark(BookMarkName);
//--------------------------------------------------------------------
           // List<string> list = new List<string>();
           // List<int> list2 = new List<int>();
           // bool flag = false;
           // int num = 0;
           // while (num <= (text.Length - 1))
           // {
           //     int num2 = 0;
           //     string item = string.Empty;
           //     if (text[num] <= 127)
           //     {
           //       //  goto Label_00B2;
           //         if ((num < text.Length) && (text[num] <= 127))
           //         {
           //             //  goto Label_0087;
           //             item = item + text[num];
           //             num2 = Math.Max(num2, text[num]);
           //             num++;
           //         }
           //         if (num2 > 58)
           //         {
           //             flag = true;
           //         }
           //     }
           //     while ((num < text.Length) && (text[num] > 127))
           //     {
           //         item = item + text[num];
           //         num2 = Math.Max(num2, text[num]);
           //         num++;
           //     }
           //  //   goto Label_00E7;
           //     list.Add(item);
           //     list2.Add(num2);
           //// Label_0087:
           //     //item = item + text[num];
           //     //num2 = Math.Max(num2, text[num]);
           //     //num++;
           //// Label_00B2:
           //     if ((num < text.Length) && (text[num] <= 127))
           //     {
           //       //  goto Label_0087;
           //         item = item + text[num];
           //         num2 = Math.Max(num2, text[num]);
           //         num++;
           //     }
           //     if (num2 > 58)
           //     {
           //         flag = true;
           //     }

           //// Label_00E7:
           //     list.Add(item);
           //     list2.Add(num2);
           // }
           // Builder.MoveToBookmark(BookMarkName);
           // Builder.ParagraphFormat.Alignment = ParagraphAlignment.Left;
           // Builder.StartBookmark(BookMarkName);
           // int num3 = 0;
           // foreach (string str in list)
           // {
           //     if (!string.IsNullOrEmpty(str.Trim()))
           //     {
           //         if (str[0] > 127)
           //         {
           //             Builder.Font.Name = "B Lotus";
           //             Builder.Font.Size = 9.0;
           //             Builder.Font.SizeBi = 9.0;
           //             Builder.Font.Bidi = true;
           //             Builder.Write(str + " ");
           //         }
           //         else
           //         {
           //             if (!((list2[num3] >= 0x3a) || flag))
           //             {
           //                 Builder.Font.Name = "B Lotus";
           //             }
           //             else
           //             {
           //                 Builder.Font.Name = "Calibri";
           //             }
           //             Builder.Font.Size = 9.0;
           //             Builder.Font.Bidi = false;
           //             Builder.Write(str + " ");
           //             Builder.ParagraphFormat.Alignment = ParagraphAlignment.Left;
           //         }
           //     }
           //     num3++;
           // }
           // Builder.EndBookmark(BookMarkName);

            List<String> test = new List<String>();
            List<int> max_list = new List<int>();
            bool IsComplex = false;
            int i = 0;
            while (i <= text.Length - 1)
            {
                int max = 0;
                String txt = String.Empty;
                if ((int)text[i] > 127)
                {
                    while ((i < text.Length) && ((int)text[i] > 127))
                    {
                        txt += text[i];
                        max = Math.Max(max, text[i]);
                        i++;
                    }
                }
                else
                {
                    while ((i < text.Length) && ((int)text[i] <= 127))
                    {
                        txt += text[i];
                        max = Math.Max(max, text[i]);
                        i++;
                    }
                    if (max > 58)
                    {
                        IsComplex = true;
                    }
                }
                test.Add(txt);
                max_list.Add(max);
            }

            Builder.MoveToBookmark(BookMarkName);
            Builder.ParagraphFormat.Alignment = Aspose.Words.ParagraphAlignment.Left;
            Builder.StartBookmark(BookMarkName);
            int j = 0;
            foreach (String txt in test)
            {
                if (String.IsNullOrEmpty(txt.Trim()) == false)
                {
                    if ((int)txt[0] > 127)
                    {
                        Builder.Font.Name = "B Lotus";//B Lotus
                        Builder.Font.Size = 9;//9
                        Builder.Font.SizeBi = 9;//9
                        Builder.Font.Bidi = true;
                        Builder.Write(txt + " ");
                        Builder.ParagraphFormat.Alignment = Aspose.Words.ParagraphAlignment.Left;
                    }
                    else
                    {
                        if ((max_list[j] < 58) && (IsComplex == false))
                        {
                            Builder.Font.Name = "B Lotus";//B Lotus
                            Builder.Font.Size = 9;//9
                        }
                        else
                        {
                            Builder.Font.Name = "Calibri";
                            Builder.Font.Size = 7;//7
                        }
                        Builder.Font.Bidi = false;
                        Builder.Write(txt + " ");
                        Builder.ParagraphFormat.Alignment = Aspose.Words.ParagraphAlignment.Left;

                    }
                }
                j++;
            }
            Builder.EndBookmark(BookMarkName);
            //return text;
        }

        public static string CorrectStringReturn(String text, Aspose.Words.DocumentBuilder Builder, String BookMarkName)
        {
            List<String> test = new List<String>();
            List<int> max_list = new List<int>();
            bool IsComplex = false;
            int i = 0;
            while (i <= text.Length - 1)
            {
                int max = 0;
                String txt = String.Empty;
                if ((int)text[i] > 127)
                {
                    while ((i < text.Length) && ((int)text[i] > 127))
                    {
                        txt += text[i];
                        max = Math.Max(max, text[i]);
                        i++;
                    }
                }
                else
                {
                    while ((i < text.Length) && ((int)text[i] <= 127))
                    {
                        txt += text[i];
                        max = Math.Max(max, text[i]);
                        i++;
                    }
                    if (max > 58)
                    {
                        IsComplex = true;
                    }
                }
                test.Add(txt);
                max_list.Add(max);
            }

            Builder.MoveToBookmark(BookMarkName);
            Builder.ParagraphFormat.Alignment = Aspose.Words.ParagraphAlignment.Left;
            Builder.StartBookmark(BookMarkName);
            int j = 0;
            foreach (String txt in test)
            {
                if (String.IsNullOrEmpty(txt.Trim()) == false)
                {
                    if ((int)txt[0] > 127)
                    {
                        Builder.Font.Name = "B Lotus";
                        Builder.Font.Size = 9;//9
                        Builder.Font.SizeBi = 9;//9
                        Builder.Font.Bidi = true;
                        Builder.Write(txt + " ");
                        Builder.ParagraphFormat.Alignment = Aspose.Words.ParagraphAlignment.Right;
                    }
                    else
                    {
                        if ((max_list[j] < 58) && (IsComplex == false))
                        {
                            Builder.Font.Name = "B Lotus";
                            Builder.Font.Size =9;//9
                        }
                        else
                        {
                            Builder.Font.Name = "Calibri";
                            Builder.Font.Size = 7;//7
                        }
                        Builder.Font.Bidi = false;
                        Builder.Write(txt + " ");
                        Builder.ParagraphFormat.Alignment = Aspose.Words.ParagraphAlignment.Right;
                                              
                    }
                }
                j++;
            }
            Builder.EndBookmark(BookMarkName);
            return text;
        }
    }
}
