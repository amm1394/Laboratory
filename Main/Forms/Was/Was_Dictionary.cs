using System;
using System.Collections.Generic;

namespace Was.Dictionary
{
    public struct Was_Dictionary
    {
        private static Dictionary<string, short> _dictionary_PercentMax;
        private static Dictionary<string, short> _dictionary_PercentMin;
        private static Dictionary<string, float> _dictionary_Trace;
        private static Dictionary<string, float> _dictionary_None;
        private static Dictionary<string, float> _dictionary_PercentValue;
        static Was_Dictionary()
        {
            _dictionary_PercentMax = new Dictionary<string, short>();
            _dictionary_PercentMin = new Dictionary<string, short>();
            _dictionary_Trace = new Dictionary<string, float>();
            _dictionary_None = new Dictionary<string, float>();
            _dictionary_PercentValue = new Dictionary<string, float>();
            _dictionary_PercentMax.Add("Ag", 3);
            _dictionary_PercentMax.Add("Al", 3);
            _dictionary_PercentMax.Add("As", 3);
            _dictionary_PercentMax.Add("B", 4);
            _dictionary_PercentMax.Add("Be", 3);
            _dictionary_PercentMax.Add("Bi", 3);
            _dictionary_PercentMax.Add("C", 3);
            _dictionary_PercentMax.Add("Ca", 3);
            _dictionary_PercentMax.Add("Cd", 3);
            _dictionary_PercentMax.Add("Co", 3);
            _dictionary_PercentMax.Add("Cr", 3);
            _dictionary_PercentMax.Add("Cu", 3);
            _dictionary_PercentMax.Add("Fe", 3);
            _dictionary_PercentMax.Add("Ga", 3);
            _dictionary_PercentMax.Add("Li", 3);
            _dictionary_PercentMax.Add("Mg", 3);
            _dictionary_PercentMax.Add("Mn", 3);
            _dictionary_PercentMax.Add("Mo", 3);
            _dictionary_PercentMax.Add("Na", 3);
            _dictionary_PercentMax.Add("Nb", 3);
            _dictionary_PercentMax.Add("Ni", 3);
            _dictionary_PercentMax.Add("P", 3);
            _dictionary_PercentMax.Add("Pb", 3);
            _dictionary_PercentMax.Add("S", 3);
            _dictionary_PercentMax.Add("Si", 3);
            _dictionary_PercentMax.Add("Sn", 3);
            _dictionary_PercentMax.Add("Sr", 3);
            _dictionary_PercentMax.Add("Ti", 3);
            _dictionary_PercentMax.Add("V", 3);
            _dictionary_PercentMax.Add("W", 3);
            _dictionary_PercentMax.Add("Zn", 3);
            _dictionary_PercentMax.Add("Zr", 3);
            _dictionary_PercentMin.Add("Ag", 2);
            _dictionary_PercentMin.Add("Al", 2);
            _dictionary_PercentMin.Add("As", 2);
            _dictionary_PercentMin.Add("B", 4);
            _dictionary_PercentMin.Add("Be", 2);
            _dictionary_PercentMin.Add("Bi", 2);
            _dictionary_PercentMin.Add("C", 2);
            _dictionary_PercentMin.Add("Ca", 2);
            _dictionary_PercentMin.Add("Cd", 2);
            _dictionary_PercentMin.Add("Co", 2);
            _dictionary_PercentMin.Add("Cr", 2);
            _dictionary_PercentMin.Add("Cu", 2);
            _dictionary_PercentMin.Add("Fe", 2);
            _dictionary_PercentMin.Add("Ga", 2);
            _dictionary_PercentMin.Add("Li", 2);
            _dictionary_PercentMin.Add("Mg", 3);
            _dictionary_PercentMin.Add("Mn", 2);
            _dictionary_PercentMin.Add("Mo", 2);
            _dictionary_PercentMin.Add("Na", 2);
            _dictionary_PercentMin.Add("Nb", 2);
            _dictionary_PercentMin.Add("Ni", 2);
            _dictionary_PercentMin.Add("P", 2);
            _dictionary_PercentMin.Add("Pb", 2);
            _dictionary_PercentMin.Add("S", 2);
            _dictionary_PercentMin.Add("Si", 2);
            _dictionary_PercentMin.Add("Sn", 2);
            _dictionary_PercentMin.Add("Sr", 2);
            _dictionary_PercentMin.Add("Ti", 2);
            _dictionary_PercentMin.Add("V", 2);
            _dictionary_PercentMin.Add("W", 2);
            _dictionary_PercentMin.Add("Zn", 2);
            _dictionary_PercentMin.Add("Zr", 2);
            _dictionary_Trace.Add("Ag", 0.001f);
            _dictionary_Trace.Add("Al", 0.001f);
            _dictionary_Trace.Add("As", 0.001f);
            _dictionary_Trace.Add("B", 0.0001f);
            _dictionary_Trace.Add("Be", 0.001f);
            _dictionary_Trace.Add("Bi", 0.001f);
            _dictionary_Trace.Add("C", 0.001f);
            _dictionary_Trace.Add("Ca", 0.001f);
            _dictionary_Trace.Add("Cd", 0.001f);
            _dictionary_Trace.Add("Co", 0.001f);
            _dictionary_Trace.Add("Cr", 0.001f);
            _dictionary_Trace.Add("Cu", 0.001f);
            _dictionary_Trace.Add("Fe", 0.001f);
            _dictionary_Trace.Add("Ga", 0.001f);
            _dictionary_Trace.Add("Li", 0.001f);
            _dictionary_Trace.Add("Mg", 0.001f);
            _dictionary_Trace.Add("Mn", 0.001f);
            _dictionary_Trace.Add("Mo", 0.001f);
            _dictionary_Trace.Add("Na", 0.001f);
            _dictionary_Trace.Add("Nb", 0.001f);
            _dictionary_Trace.Add("Ni", 0.001f);
            _dictionary_Trace.Add("P", 0.001f);
            _dictionary_Trace.Add("Pb", 0.001f);
            _dictionary_Trace.Add("S", 0.001f);
            _dictionary_Trace.Add("Si", 0.001f);
            _dictionary_Trace.Add("Sn", 0.001f);
            _dictionary_Trace.Add("Sr", 0.001f);
            _dictionary_Trace.Add("Ti", 0.001f);
            _dictionary_Trace.Add("V", 0.001f);
            _dictionary_Trace.Add("W", 0.001f);
            _dictionary_Trace.Add("Zn", 0.001f);
            _dictionary_Trace.Add("Zr", 0.001f);
            _dictionary_PercentValue.Add("Ag", 0.009f);
            _dictionary_PercentValue.Add("Al", 0.1f);
            _dictionary_PercentValue.Add("As", 0.1f);
            _dictionary_PercentValue.Add("B", 0.0009f);
            _dictionary_PercentValue.Add("Be", 0.009f);
            _dictionary_PercentValue.Add("Bi", 0.009f);
            _dictionary_PercentValue.Add("C", 0.1f);
            _dictionary_PercentValue.Add("Ca", 0.009f);
            _dictionary_PercentValue.Add("Cd", 0.009f);
            _dictionary_PercentValue.Add("Co", 0.009f);
            _dictionary_PercentValue.Add("Cr", 0.009f);
            _dictionary_PercentValue.Add("Cu", 0.009f);
            _dictionary_PercentValue.Add("Fe", 0.009f);
            _dictionary_PercentValue.Add("Ga", 0.009f);
            _dictionary_PercentValue.Add("Li", 0.009f);
            _dictionary_PercentValue.Add("Mg", 0.0009f);
            _dictionary_PercentValue.Add("Mn", 0.009f);
            _dictionary_PercentValue.Add("Mo", 0.009f);
            _dictionary_PercentValue.Add("Na", 0.009f);
            _dictionary_PercentValue.Add("Nb", 0.1f);
            _dictionary_PercentValue.Add("Ni", 0.009f);
            _dictionary_PercentValue.Add("P", 0.1f);
            _dictionary_PercentValue.Add("Pb", 0.009f);
            _dictionary_PercentValue.Add("S", 0.1f);
            _dictionary_PercentValue.Add("Si", 0.009f);
            _dictionary_PercentValue.Add("Sn", 0.1f);
            _dictionary_PercentValue.Add("Sr", 0.009f);
            _dictionary_PercentValue.Add("Ti", 0.1f);
            _dictionary_PercentValue.Add("V", 0.1f);
            _dictionary_PercentValue.Add("W", 0.009f);
            _dictionary_PercentValue.Add("Zn", 0.009f);
            _dictionary_PercentValue.Add("Zr", 0.009f);
            _dictionary_None.Add("Ag", 0f);
            _dictionary_None.Add("Al", 0f);
            _dictionary_None.Add("As", 0f);
            _dictionary_None.Add("B", 0f);
            _dictionary_None.Add("Be", 0f);
            _dictionary_None.Add("Bi", 0f);
            _dictionary_None.Add("C", 0f);
            _dictionary_None.Add("Ca", 0f);
            _dictionary_None.Add("Cd", 0f);
            _dictionary_None.Add("Co", 0f);
            _dictionary_None.Add("Cr", 0f);
            _dictionary_None.Add("Cu", 0f);
            _dictionary_None.Add("Fe", 0f);
            _dictionary_None.Add("Ga", 0f);
            _dictionary_None.Add("Li", 0f);
            _dictionary_None.Add("Mg", 0f);
            _dictionary_None.Add("Mn", 0f);
            _dictionary_None.Add("Mo", 0f);
            _dictionary_None.Add("Na", 0f);
            _dictionary_None.Add("Nb", 0f);
            _dictionary_None.Add("Ni", 0f);
            _dictionary_None.Add("P", 0f);
            _dictionary_None.Add("Pb", 0f);
            _dictionary_None.Add("S", 0f);
            _dictionary_None.Add("Si", 0f);
            _dictionary_None.Add("Sn", 0f);
            _dictionary_None.Add("Sr", 0f);
            _dictionary_None.Add("Ti", 0f);
            _dictionary_None.Add("V", 0f);
            _dictionary_None.Add("W", 0f);
            _dictionary_None.Add("Zn", 0f);
            _dictionary_None.Add("Zr", 0f);
        }

        public static double GetValue(string elementsName, float Value)
        {
            float num;
            short num2;
            if (_dictionary_PercentValue.ContainsKey(elementsName))
            {
                num = _dictionary_PercentValue[elementsName];
            }
            else
            {
                num = 0.009f;
            }
            if (Value <= num)
            {
                if (_dictionary_PercentMax.ContainsKey(elementsName))
                {
                    num2 = _dictionary_PercentMax[elementsName];
                }
                else
                {
                    num2 = 3;
                }
            }
            else if (_dictionary_PercentMin.ContainsKey(elementsName))
            {
                num2 = _dictionary_PercentMin[elementsName];
            }
            else
            {
                num2 = 2;
            }
            return Math.Round((double)Value, num2);
        }

        public static float GetTrace(string elementsName)
        {
            if (_dictionary_Trace.ContainsKey(elementsName))
            {
                return _dictionary_Trace[elementsName];
            }
            return 0.001f;
        }

        public static float GetNone(string elementsName)
        {
            if (_dictionary_None.ContainsKey(elementsName))
            {
                return _dictionary_None[elementsName];
            }
            return 0f;
        }
    }
}