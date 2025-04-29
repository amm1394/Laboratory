using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arl
{
    public static class Insert_Arl_Table
    {
        public static void Insert_Table(RASF.General.Data.Arl_Elements Elements, Microsoft.Office.Interop.Word.Document MyDocument)
        {
            int cellText1;
            int count;
            string str;
            object missing = Type.Missing;
            if (Elements.Eleman.Count <= 11)
            {
                count = Elements.Eleman.Count;
                cellText1 = 2;
            }
            else if (Elements.Eleman.Count <= 22)
            {
                count = 11;
                cellText1 = 4;
            }
            else if (Elements.Eleman.Count <= 24)
            {
                count = 12;
                cellText1 = 4;
            }
            else if (Elements.Eleman.Count <= 26)
            {
                count = 13;
                cellText1 = 4;
            }
            else if (Elements.Eleman.Count <= 28)
            {
                count = 14;
                cellText1 = 4;
            }
            else if (Elements.Eleman.Count <= 30)
            {
                count = 15;
                cellText1 = 4;
            }
            else if (Elements.Eleman.Count > 32)
            {
                count = 17;
                cellText1 = 4;
            }
            else
            {
                count = 16;
                cellText1 = 4;
            }
            object obj = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow;
            MyDocument.Application.Selection.RtlPara();
            Microsoft.Office.Interop.Word.Range range = MyDocument.Application.Selection.Range;
            range.Select();
            range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            MyDocument.Application.Selection.LtrPara();
            Microsoft.Office.Interop.Word.Table cellText = MyDocument.Tables.Add(range, cellText1, count, ref missing, ref obj);
            cellText.TableDirection = Microsoft.Office.Interop.Word.WdTableDirection.wdTableDirectionLtr;
            cellText.Borders.Enable = 1;
            cellText.Rows[1].Cells.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
            Microsoft.Office.Interop.Word.Row item = cellText.Rows[1];
            float single = 17f;
            float single1 = single;
            cellText.Rows[2].Height = single;
            item.Height = single1;
            for (int i = 1; i < cellText1; i = i + 2)
            {
                for (int j = 1; j <= count; j++)
                {
                    cellText.Rows[i].Cells[j].Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray10;
                }
            }
            int num = 1;
            for (int k = 1; k <= count; k++)
            {
                str = Get_Cell_Text1(Elements.Eleman[k - 1].Name);
                cellText.Rows[1].Cells[k].Range.Text = Get_Cell_Text1(str);
                cellText.Rows[2].Cells[k].Range.Text = Get_Cell_Text(Convert.ToSingle(Elements.Eleman[k - 1].Value), str, Elements.Task);
                cellText.Columns[k].Width = MyDocument.Application.InchesToPoints(0.73f);
                num++;
            }
            if (cellText1 == 4)
            {
                num = 1;
                int num1 = 1;
                Microsoft.Office.Interop.Word.Row variable = cellText.Rows[3];
                float single2 = 17f;
                float single3 = single2;
                cellText.Rows[4].Height = single2;
                variable.Height = single3;
                for (int l = count + 1; l <= Elements.Eleman.Count; l++)
                {
                    str = Get_Cell_Text1(Elements.Eleman[l - 1].Name.ToString());
                    cellText.Rows[3].Cells[num1].Range.Text = Get_Cell_Text1(str);
                    if (Elements.Eleman[l - 1].Value == "")
                    {
                        cellText.Rows[4].Cells[num1].Range.Text = "-";
                    }
                    else
                    {
                        cellText.Rows[4].Cells[num1].Range.Text = Get_Cell_Text(Convert.ToSingle(Elements.Eleman[l - 1].Value), str, Elements.Task);
                    }
                    num++;
                    num1++;
                }
            }
            cellText.Rows[cellText1 - 1].Cells[num].Range.Text = Get_Cell_Text1(Get_Cell_Text1(Elements.Base));
            cellText.Rows[cellText1].Cells[num].Range.Text = "Base";
            cellText.Rows.Alignment = Microsoft.Office.Interop.Word.WdRowAlignment.wdAlignRowCenter;
        }

        private static string Get_Cell_Text1(string Elemnt_Name)
        {
            string str = "";
            if (Elemnt_Name.Length > 0)
            {
                str = (Elemnt_Name.Length != 1 ? string.Concat(Elemnt_Name.Substring(0, 1).ToUpper(), Elemnt_Name.Substring(1, 1).ToLower()) : Elemnt_Name);
            }
            return str;
        }

        private static string Get_Cell_Text(float Element_Value, string Element_Name, string Elemnt_Task)
        {
            string str = "";
            double value = Dictionary.Arl_Dictionary.GetValue(Element_Name, Element_Value);
            double none_value = Dictionary.Arl_Dictionary.GetTrace(Element_Name, Elemnt_Task);
            if (value >= (double)Dictionary.Arl_Dictionary.GetNone(Element_Name))
            {
                str = (value >= none_value ? value.ToString() : string.Format ("< {0}" , none_value.ToString()));
            }
            else
            {
                str = "None";
            }
            return str.Trim();
        }
   
    }
}
