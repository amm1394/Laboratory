using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Classes
{
    public class CorrectString
    {
        public List<String> CorrectedText { get; private set; }
        public Boolean IsComplex { get; private set; }
        public List<int> Max_list { get; private set; }
        public CorrectString()
        {
        }

        public void Correction(String text)
        {
            this.CorrectedText = new List<String>();
            this.IsComplex = false;
            this.Max_list = new List<int>();
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
                CorrectedText.Add(txt);
                this.Max_list.Add(max);
            }
        }
    }
}
