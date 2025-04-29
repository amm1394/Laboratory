using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Was
{
    public static class Insert_Was_Table
    {
        public static void Insert_Table(RASF.General.Data.Csv_Contract Contract, Microsoft.Office.Interop.Word.Document MyDocument)
        {
            int num; 
            int count;
            string str;
            object missing = Type.Missing;
            if (Contract.Csv_DataList.Count <= 11)
            {
                count = Contract.Csv_DataList.Count;
                num = 2;
            }
            else if (Contract.Csv_DataList.Count <= 22)
            {
                count = 11;
                num = 4;
            }
            else if (Contract.Csv_DataList.Count <= 24)
            {
                count = 12;
                num = 4;
            }
            else if (Contract.Csv_DataList.Count <= 26)
            {
                count = 13;
                num = 4;
            }
            else if (Contract.Csv_DataList.Count <= 28)
            {
                count = 14;
                num = 4;
            }
            else if (Contract.Csv_DataList.Count <= 30)
            {
                count = 15;
                num = 4;
            }
            else if (Contract.Csv_DataList.Count > 32)
            {
                count = 17;
                num = 4;
            }
            else
            {
                count = 16;
                num = 4;
            }

            object obj = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow;
            MyDocument.Application.Selection.RtlPara();
            Microsoft.Office.Interop.Word.Range range = MyDocument.Application.Selection.Range;
            range.Select();
            range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            MyDocument.Application.Selection.LtrPara();
            Microsoft.Office.Interop.Word.Table table = MyDocument.Tables.Add(range, num, count, ref missing, ref obj);
            table.TableDirection = Microsoft.Office.Interop.Word.WdTableDirection.wdTableDirectionLtr;
            table.Borders.Enable = 1;
            table.Rows[1].Cells.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
            Microsoft.Office.Interop.Word.Row item = table.Rows[1];
            float single = 17f;
            float single1 = single;
            table.Rows[2].Height = single;
            for (int i = 1; i < num; i += 2)
            {
                for (int k = 1; k <= count; k++)
                {
                    table.Rows[i].Cells[k].Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray10;
                }
            }
            int num5 = 1;
            for (int j = 1; j <= count; j++)
            {
                str = Get_Cell_Text1(Contract.Csv_DataList[j].Name);
                table.Rows[1].Cells[j].Range.Text = Get_Cell_Text1(str);
                table.Rows[2].Cells[j].Range.Text = Get_Cell_Text(Convert.ToSingle(Contract.Csv_DataList[j].Value), str, Contract.Csv_DataList[j].Sign.ToString());
                table.Columns[j].Width = MyDocument.Application.InchesToPoints(0.73f);
                num5++;
            }
            if (num == 4)
            {
                num5 = 1;
                int num7 = 1;
                table.Rows[3].Height = table.Rows[4].Height = 17f;
                for (int k = count + 1; k < Contract.Csv_DataList.Count; k++)
                {
                    str = Get_Cell_Text1(Contract.Csv_DataList[k].Name.ToString());
                    table.Rows[3].Cells[num7].Range.Text = Get_Cell_Text1(str);
                    if (Contract.Csv_DataList[k].Value != "")
                    {
                        table.Rows[4].Cells[num7].Range.Text = Get_Cell_Text(Convert.ToSingle(Contract.Csv_DataList[k].Value), str, Contract.Csv_DataList[k].Sign.ToString());
                    }
                    else
                    {
                        table.Rows[4].Cells[num7].Range.Text = "-";
                    }
                    num5++;
                    num7++;
                }
            }
            table.Rows[num - 1].Cells[num5].Range.Text = Get_Cell_Text1(Get_Cell_Text1(Contract.Csv_DataList[0].Name.ToString()));
            table.Rows[num].Cells[num5].Range.Text = "Base";
            table.Rows.Alignment = Microsoft.Office.Interop.Word.WdRowAlignment.wdAlignRowCenter;
        }

        private static string Get_Cell_Text(float Element_Value, string Element_Name, string Element_Sign)
        {
            string str = "";
            if (Element_Name.ToUpper().CompareTo("W") == 0)
            {
                if (Element_Sign.Length == 0)
                {
                    double num = Was.Dictionary.Was_Dictionary.GetValue(Element_Name, Element_Value);
                    if (num <= Was.Dictionary.Was_Dictionary.GetNone(Element_Name))
                    {
                        str = "None";
                    }
                    else if (num < Was.Dictionary.Was_Dictionary.GetTrace(Element_Name))
                    {
                        str = "Trace";
                    }
                    else
                    {
                        str = Element_Sign + " " + num.ToString();
                    }
                }
                else
                {
                    str = Element_Sign + " " + Math.Round((double)Element_Value, 3).ToString();
                }
            }
            else
            {
                double num3 = Was.Dictionary.Was_Dictionary.GetValue(Element_Name, Element_Value);
                if (num3 <= Was.Dictionary.Was_Dictionary.GetNone(Element_Name))
                {
                    str = "None";
                }
                else if (num3 < Was.Dictionary.Was_Dictionary.GetTrace(Element_Name))
                {
                    str = "Trace";
                }
                else
                {
                    str = Element_Sign + " " + num3.ToString();
                }
            }
            return str.Trim();
        }

        private static string Get_Cell_Text1(string Elemnt_Name)
        {
            string str = "";
            if (Elemnt_Name.Length <= 0)
            {
                return str;
            }
            if (Elemnt_Name.Length == 1)
            {
                return Elemnt_Name;
            }
            return (Elemnt_Name.Substring(0, 1).ToUpper() + Elemnt_Name.Substring(1, 1).ToLower());
        }
   
    }
}
