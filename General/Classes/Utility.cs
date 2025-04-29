using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Classes
{
    public static class Utility
    {
        [System.ComponentModel.Category("RASF")]
        public static void CreateDropDow(General.Controls.DropDown dropDown, String displayMember, String valueMember, Object dataSource)
        {
            dropDown.DataSource = dataSource;
            dropDown.DisplayMember = displayMember;
            dropDown.ValueMember = valueMember;
        }
        [System.ComponentModel.Category("RASF")]

        public static void Create_DropDown(Janus.Windows.GridEX.GridEXColumn Col, System.Collections.IEnumerable DataList, String ValueCol, String DisplayCol)
        {
            Col.HasValueList = true;
            Col.ValueList.Clear();
            Col.EditType = Janus.Windows.GridEX.EditType.DropDownList;
            Col.ValueList.PopulateValueList(DataList, ValueCol, DisplayCol);
            Col.CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text;
        }

        public static void Create_DropDownWithParameter(Janus.Windows.GridEX.GridEXColumn Col, System.Collections.IEnumerable DataList, String ValueCol, String DisplayCol,object Param)
        {
            Col.HasValueList = true;
            Col.EditType = Janus.Windows.GridEX.EditType.DropDownList;
            Col.ValueList.PopulateValueList(DataList, ValueCol, DisplayCol);
            Col.CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text;
        }

        public static Byte[] ReadPic(String FileName, Int32 ImageHeight)
        {
            if (System.IO.File.Exists(FileName) == true)
            {
                System.IO.MemoryStream OutPutImage = new System.IO.MemoryStream();

                System.IO.MemoryStream InputStream = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(FileName));
                System.Drawing.Bitmap InputImage = new System.Drawing.Bitmap(InputStream);

                Single ImageRatio = (Single)InputImage.Width / (Single)InputImage.Height;
                Int32 ImageWeight = (Int32)(ImageHeight * ImageRatio);

                System.Drawing.Bitmap Image1 = new System.Drawing.Bitmap(InputImage, new System.Drawing.Size(ImageWeight, ImageHeight));
                Image1.Save(OutPutImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                OutPutImage.Flush();

                InputStream.Dispose();
                Image1.Dispose();
                InputStream = null;
                Image1 = null;
                GC.Collect();

                return OutPutImage.ToArray();
            }
            else
                return null;
        }

        public static Byte[] ReadPic(Byte[] Picture, Int32 ImageHeight)
        {
            if ((Picture != null) && (Picture.Length > 0))
            {
                System.IO.MemoryStream OutPutImage = new System.IO.MemoryStream();

                System.IO.MemoryStream InputStream = new System.IO.MemoryStream(Picture);
                System.Drawing.Bitmap InputImage = new System.Drawing.Bitmap(InputStream);

                Single ImageRatio = (Single)InputImage.Width / (Single)InputImage.Height;
                Int32 ImageWeight = (Int32)(ImageHeight * ImageRatio);
                

                System.Drawing.Bitmap Image1 = new System.Drawing.Bitmap(InputImage, new System.Drawing.Size(ImageWeight, ImageHeight));
                Image1.Save(OutPutImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                OutPutImage.Flush();

                InputStream.Dispose();
                Image1.Dispose();
                InputStream = null;
                Image1 = null;
                GC.Collect();

                return OutPutImage.ToArray();
            }
            else
                return null;
        }

        public static String DateConvertor(DateTime CurrentDate)
        {
            System.Globalization.PersianCalendar PersianCalendar = new System.Globalization.PersianCalendar();
            DateTime curentDate = Convert.ToDateTime(CurrentDate);
            return String.Format("{0}/{1}/{2}", PersianCalendar.GetYear(CurrentDate), PersianCalendar.GetMonth(CurrentDate), PersianCalendar.GetDayOfMonth(CurrentDate));
        }

        public static String CorrectFileName(String FileName)
        {
            FileName = FileName.Replace(":", "").Replace("*", "").Replace("\"", "").Replace(@"/", "").Replace("#",
               "").Replace("@", "").Replace("$", "").Replace("<", "").Replace(">", "").Replace("(",
               "").Replace(")", "").Replace("?", "").Replace("؟", "").Replace("!", "").Replace("\r","");
            return FileName.Trim();
        }
        
        public static Byte[] Add_Gage(Byte[] Image, GageSize gageSize)
        {
            System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.Pen MyPen = new System.Drawing.Pen(brush);
            MyPen.Width = 8;
            using (System.IO.MemoryStream Picture = new System.IO.MemoryStream(Image))
            {
                using (System.Drawing.Bitmap SourceBitmap = new System.Drawing.Bitmap(Picture))
                {
                    System.Drawing.Bitmap MyBitmap = new System.Drawing.Bitmap(SourceBitmap.Width, SourceBitmap.Height + 70);
                    System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(MyBitmap);
                    graphics.Clear(System.Drawing.Color.White);
                    graphics.DrawImageUnscaled(SourceBitmap, 0, 0);
                    graphics.DrawLine(MyPen, MyBitmap.Width - 2, MyBitmap.Height - 5, MyBitmap.Width - 2, MyBitmap.Height - 70);
                    graphics.DrawLine(MyPen, MyBitmap.Width - 2 - gageSize.lengeht, MyBitmap.Height - 5, MyBitmap.Width - 2 - gageSize.lengeht, MyBitmap.Height - 70);
                    graphics.DrawLine(MyPen, MyBitmap.Width - 2 - gageSize.lengeht, MyBitmap.Height - 5, MyBitmap.Width - 2, MyBitmap.Height - 5);
                    String MyText = String.Format("{0} µm", gageSize.Size);
                    graphics.DrawString(MyText, new System.Drawing.Font("Arial", 50f, System.Drawing.FontStyle.Bold), brush, MyBitmap.Width - gageSize.lengeht - 300, MyBitmap.Height - 80);
                    brush.Dispose();

                    System.IO.MemoryStream ReturnValue = new System.IO.MemoryStream();
                    MyBitmap.Save(ReturnValue, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ReturnValue.ToArray();
                }
            }
        }

        public static void Carte_Table(Microsoft.Office.Interop.Word.Document MyDocument, List<RASF.General.Data.Metal_Pic> pictureList)
        {
            object missing = System.Type.Missing;

            Int16 RowCount = Convert.ToInt16((pictureList.Count + 1) / 2);
            object SaveWithDocument = true;
            object MyParam = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow;
            MyDocument.Application.Selection.RtlPara();
            Microsoft.Office.Interop.Word.Range MyRange = MyDocument.Application.Selection.Range;
            Microsoft.Office.Interop.Word.Table PictureTable = MyDocument.Tables.Add(MyRange, RowCount * 2, 2, ref missing, ref MyParam);
            PictureTable.TableDirection = Microsoft.Office.Interop.Word.WdTableDirection.wdTableDirectionLtr;
            PictureTable.Borders.Enable = 1;
            PictureTable.Columns[1].Width = PictureTable.Columns[2].Width = 240;

            int j = 0;
            for (int i = 1; i < RowCount * 2; i += 2)
            {
                if (j < pictureList.Count)
                {
                    String ImageName = String.Format("{0}{1}.jpg", System.IO.Path.GetTempPath(), System.IO.Path.GetFileNameWithoutExtension(System.IO.Path.GetRandomFileName()));
                    System.IO.File.WriteAllBytes(ImageName, pictureList[j].Pciture);
                    PictureTable.Rows[i].Cells[1].Range.InlineShapes.AddPicture(ImageName, ref missing, ref SaveWithDocument, ref missing);
                    System.IO.File.Delete(ImageName);
                }
                j++;
                if (j < pictureList.Count)
                {
                    String ImageName = String.Format("{0}{1}.jpg", System.IO.Path.GetTempPath(), System.IO.Path.GetFileNameWithoutExtension(System.IO.Path.GetRandomFileName()));
                    System.IO.File.WriteAllBytes(ImageName, pictureList[j].Pciture);
                    PictureTable.Rows[i].Cells[2].Range.InlineShapes.AddPicture(ImageName, ref missing, ref SaveWithDocument, ref missing);
                    System.IO.File.Delete(ImageName);
                }
                j++;
            }
        }

        public static void Carte_Part_Table(Microsoft.Office.Interop.Word.Document MyDocument, List<RASF.General.Data.Metal_Pic> pictureList)
        {
            object missing = System.Type.Missing;

            Int16 RowCount = (Int16)pictureList.Count;
            if (RowCount > 0)
            {
                object SaveWithDocument = true;
                object MyParam = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow;
                MyDocument.Application.Selection.RtlPara();
                Microsoft.Office.Interop.Word.Range MyRange = MyDocument.Application.Selection.Range;
                Microsoft.Office.Interop.Word.Table PictureTable = MyDocument.Tables.Add(MyRange, RowCount, 1, ref missing, ref MyParam);
                PictureTable.TableDirection = Microsoft.Office.Interop.Word.WdTableDirection.wdTableDirectionLtr;
                PictureTable.Borders.Enable = 1;
                PictureTable.Columns[1].Width = 400;
                PictureTable.Rows.Alignment = Microsoft.Office.Interop.Word.WdRowAlignment.wdAlignRowCenter;
                
                int j = 0;
                for (int i = 0; i < RowCount; i++)
                {
                    String ImageName = String.Format("{0}{1}.jpg", System.IO.Path.GetTempPath(), System.IO.Path.GetFileNameWithoutExtension(System.IO.Path.GetRandomFileName()));
                    System.IO.File.WriteAllBytes(ImageName, pictureList[i].Pciture);
                    PictureTable.Rows[i + 1].Cells[1].Range.InlineShapes.AddPicture(ImageName, ref missing, ref SaveWithDocument, ref missing);
                    System.IO.File.Delete(ImageName);
                }
            }
        }

        public static void Insert_Standard(Microsoft.Office.Interop.Word.Document MyDocument, General.Lists.StandardDataList StandardData)
        {
            object missing = System.Type.Missing;

            object param = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow;
            MyDocument.Application.Selection.RtlPara();
            Microsoft.Office.Interop.Word.Range StandardRange = MyDocument.Application.Selection.Range;
            StandardRange.InsertAfter("\n");
            StandardRange.MoveEnd(ref missing, ref missing);
            StandardRange.Select();
            StandardRange.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            MyDocument.Application.Selection.LtrPara();

            Microsoft.Office.Interop.Word.Table StandardTable = MyDocument.Tables.Add(StandardRange, 3, StandardData.Count() + 1, ref missing, ref param);
            StandardTable.TableDirection = Microsoft.Office.Interop.Word.WdTableDirection.wdTableDirectionLtr;
            StandardTable.Borders.Enable = 1;
            StandardTable.Rows[1].Cells.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
            StandardTable.Rows[2].Cells[1].Range.Text = "Min";
            StandardTable.Rows[3].Cells[1].Range.Text = "Max";
            StandardTable.Columns[1].Width = 40f;

            StandardTable.Rows[1].Cells[1].Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray10;
            StandardTable.Rows[2].Cells[1].Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray10;
            StandardTable.Rows[3].Cells[1].Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray10;

            int Count =  StandardData.Count();
            for (int i = 0; i < Count; i++)
            {
                StandardTable.Columns[i + 2].Width = 40f;
                StandardTable.Rows[1].Cells[i + 2].Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray10;
                StandardTable.Rows[1].Cells[i + 2].Range.Text = StandardData[i].Name;
                StandardTable.Rows[2].Cells[i + 2].Range.Text = StandardData[i].MinData;
                StandardTable.Rows[3].Cells[i + 2].Range.Text = StandardData[i].MaxData;
            }
            StandardTable.Rows.Alignment = Microsoft.Office.Interop.Word.WdRowAlignment.wdAlignRowCenter;
        }
    }
}
