using System;
using System.Collections.Generic;

namespace Arl.Dictionary
{
	public struct Arl_Dictionary
	{
		private static Dictionary<string, short> _dictionary_PercentMax;

		private static Dictionary<string, short> _dictionary_PercentMin;

		private static Dictionary<string, float> _dictionary_Trace;

		private static Dictionary<string, float> _dictionary_None;

		private static Dictionary<string, float> _dictionary_PercentValue;

        private static Dictionary<string, float> _dictionary_Trace_FECOLAST;

        private static Dictionary<string, float> _dictionary_Trace_FECOCAIR;

        private static Dictionary<string, float> _dictionary_Trace_FECOCRNI;

        private static Dictionary<string, float> _dictionary_Trace_FECOMNST;

        private static Dictionary<string, float> _dictionary_Trace_FECOHACI;

        private static Dictionary<string, float> _dictionary_Trace_FECOCRST;


        static Arl_Dictionary()
        {
            Arl_Dictionary._dictionary_PercentMax = new Dictionary<string, short>();
            Arl_Dictionary._dictionary_PercentMin = new Dictionary<string, short>();
            Arl_Dictionary._dictionary_Trace = new Dictionary<string, float>();
            Arl_Dictionary._dictionary_None = new Dictionary<string, float>();
            Arl_Dictionary._dictionary_PercentValue = new Dictionary<string, float>();
            Arl_Dictionary._dictionary_Trace_FECOLAST = new Dictionary<string, float>();
            Arl_Dictionary._dictionary_Trace_FECOCAIR = new Dictionary<string, float>();
            Arl_Dictionary._dictionary_Trace_FECOCRNI = new Dictionary<string, float>();
            Arl_Dictionary._dictionary_Trace_FECOMNST = new Dictionary<string, float>();
            Arl_Dictionary._dictionary_Trace_FECOHACI = new Dictionary<string, float>();
            Arl_Dictionary._dictionary_Trace_FECOCRST = new Dictionary<string, float>();

            Arl_Dictionary._dictionary_PercentMax.Add("Ag", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Al", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("As", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("B", 4);
            Arl_Dictionary._dictionary_PercentMax.Add("Be", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Bi", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("C", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Ca", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Cd", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Co", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Cr", 2);
            Arl_Dictionary._dictionary_PercentMax.Add("Cu", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Fe", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Ga", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Li", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Mg", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Mn", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Mo", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Na", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Nb", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Ni", 2);
            Arl_Dictionary._dictionary_PercentMax.Add("P", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Pb", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("S", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Si", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Sn", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Sr", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Ti", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("V", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("W", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Zn", 3);
            Arl_Dictionary._dictionary_PercentMax.Add("Zr", 3);

            Arl_Dictionary._dictionary_PercentMin.Add("Ag", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Al", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("As", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("B", 4);
            Arl_Dictionary._dictionary_PercentMin.Add("Be", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Bi", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("C", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Ca", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Cd", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Co", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Cr", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Cu", 3);
            Arl_Dictionary._dictionary_PercentMin.Add("Fe", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Ga", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Li", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Mg", 3);
            Arl_Dictionary._dictionary_PercentMin.Add("Mn", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Mo", 3);
            Arl_Dictionary._dictionary_PercentMin.Add("Na", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Nb", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Ni", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("P", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Pb", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("S", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Si", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Sn", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Sr", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Ti", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("V", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("W", 3);
            Arl_Dictionary._dictionary_PercentMin.Add("Zn", 2);
            Arl_Dictionary._dictionary_PercentMin.Add("Zr", 2);
            Arl_Dictionary._dictionary_Trace.Add("Ag", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Al", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("As", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("B", 0.0001f);
            Arl_Dictionary._dictionary_Trace.Add("Be", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Bi", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("C", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Ca", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Cd", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Co", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Cr", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Cu", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Fe", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Ga", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Li", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Mg", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Mn", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Mo", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Na", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Nb", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Ni", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("P", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Pb", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("S", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Si", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Sn", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Sr", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Ti", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("V", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("W", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Zn", 0.001f);
            Arl_Dictionary._dictionary_Trace.Add("Zr", 0.001f);

            Arl_Dictionary._dictionary_PercentValue.Add("Ag", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Al", 0.1f);
            Arl_Dictionary._dictionary_PercentValue.Add("As", 0.1f);
            Arl_Dictionary._dictionary_PercentValue.Add("B", 0.0009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Be", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Bi", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("C", 0.1f);
            Arl_Dictionary._dictionary_PercentValue.Add("Ca", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Cd", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Co", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Cr", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Cu", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Fe", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Ga", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Li", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Mg", 0.0009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Mn", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Mo", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Na", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Nb", 0.1f);
            Arl_Dictionary._dictionary_PercentValue.Add("Ni", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("P", 0.1f);
            Arl_Dictionary._dictionary_PercentValue.Add("Pb", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("S", 0.1f);
            Arl_Dictionary._dictionary_PercentValue.Add("Si", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Sn", 0.1f);
            Arl_Dictionary._dictionary_PercentValue.Add("Sr", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Ti", 0.1f);
            Arl_Dictionary._dictionary_PercentValue.Add("V", 0.1f);
            Arl_Dictionary._dictionary_PercentValue.Add("W", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Zn", 0.009f);
            Arl_Dictionary._dictionary_PercentValue.Add("Zr", 0.009f);

            Arl_Dictionary._dictionary_None.Add("Ag", 0f);
            Arl_Dictionary._dictionary_None.Add("Al", 0f);
            Arl_Dictionary._dictionary_None.Add("As", 0f);
            Arl_Dictionary._dictionary_None.Add("B", 0f);
            Arl_Dictionary._dictionary_None.Add("Be", 0f);
            Arl_Dictionary._dictionary_None.Add("Bi", 0f);
            Arl_Dictionary._dictionary_None.Add("C", 0f);
            Arl_Dictionary._dictionary_None.Add("Ca", 0f);
            Arl_Dictionary._dictionary_None.Add("Cd", 0f);
            Arl_Dictionary._dictionary_None.Add("Co", 0f);
            Arl_Dictionary._dictionary_None.Add("Cr", 0f);
            Arl_Dictionary._dictionary_None.Add("Cu", 0f);
            Arl_Dictionary._dictionary_None.Add("Fe", 0f);
            Arl_Dictionary._dictionary_None.Add("Ga", 0f);
            Arl_Dictionary._dictionary_None.Add("Li", 0f);
            Arl_Dictionary._dictionary_None.Add("Mg", 0f);
            Arl_Dictionary._dictionary_None.Add("Mn", 0f);
            Arl_Dictionary._dictionary_None.Add("Mo", 0f);
            Arl_Dictionary._dictionary_None.Add("Na", 0f);
            Arl_Dictionary._dictionary_None.Add("Nb", 0f);
            Arl_Dictionary._dictionary_None.Add("Ni", 0f);
            Arl_Dictionary._dictionary_None.Add("P", 0f);
            Arl_Dictionary._dictionary_None.Add("Pb", 0f);
            Arl_Dictionary._dictionary_None.Add("S", 0f);
            Arl_Dictionary._dictionary_None.Add("Si", 0f);
            Arl_Dictionary._dictionary_None.Add("Sn", 0f);
            Arl_Dictionary._dictionary_None.Add("Sr", 0f);
            Arl_Dictionary._dictionary_None.Add("Ti", 0f);
            Arl_Dictionary._dictionary_None.Add("V", 0f);
            Arl_Dictionary._dictionary_None.Add("W", 0f);
            Arl_Dictionary._dictionary_None.Add("Zn", 0f);
            Arl_Dictionary._dictionary_None.Add("Zr", 0f);

            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("C", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Si", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Mn", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("P", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("S", 0.004f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Cr", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Mo", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Ni", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Al", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Co", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Cu", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Nb", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Ti", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("V", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("W", 0.015f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Pb", 0.01f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Sn", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("B", 0.0008f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Zr", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("Bi", 0.01f);
            Arl_Dictionary._dictionary_Trace_FECOLAST.Add("As", 0.004f);

            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("C", 1.6f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Si", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Mn", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("P", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("S", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Cr", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Mo", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Ni", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Al", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Co", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Cu", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Mg", 0.0003f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Nb", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Ti", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("V", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Pb", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Sn", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("B", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Ce", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Zr", 0.004f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Zn", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("Bi", 0.007f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("As", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCAIR.Add("La", 0.001f);

            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("C", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Si", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Mn", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("P", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("S", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Cr", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Mo", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Ni", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Al", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Co", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Cu", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Nb", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Ti", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("V", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("W", 0.02f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Pb", 0.015f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Sn", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRNI.Add("Se", 0.005f);

            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("C", 0.004f);
            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("Si", 0.004f);
            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("Mn", 0.000f);
            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("P", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("S", 0.004f);
            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("Cr", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("Mo", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("Ni", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("Al", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("Cu", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOMNST.Add("V", 0.002f);

            Arl_Dictionary._dictionary_Trace_FECOHACI.Add("C", 0.50f);
            Arl_Dictionary._dictionary_Trace_FECOHACI.Add("Si", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOHACI.Add("Mn", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOHACI.Add("P", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOHACI.Add("S", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOHACI.Add("Cr", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOHACI.Add("Mo", 0.004f);
            Arl_Dictionary._dictionary_Trace_FECOHACI.Add("Ni", 0.004f);
            Arl_Dictionary._dictionary_Trace_FECOHACI.Add("Cu", 0.002f);

            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("C", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Si", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Mn", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("P", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("S", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Cr", 0.005f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Mo", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Ni", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Al", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Co", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Cu", 0.001f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Nb", 0.003f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Ti", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("V", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("W", 0.02f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Pb", 0.015f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Sn", 0.002f);
            Arl_Dictionary._dictionary_Trace_FECOCRST.Add("Se", 0.005f);

        }

		public static float GetNone(string elementsName)
		{
			if (!Arl_Dictionary._dictionary_None.ContainsKey(elementsName))
			{
				return 0f;
			}
			return Arl_Dictionary._dictionary_None[elementsName];
		}

        public static double GetTrace(string elementsName, string Task)
		{
            float value = 0.000f;
            switch(Task.ToUpper())
            {
                case "FECOLAST":
                    {
                        if (Arl_Dictionary._dictionary_Trace_FECOLAST.ContainsKey(elementsName))
                        {
                            value = Arl_Dictionary._dictionary_Trace_FECOLAST[elementsName];
                        }
                    }
                    break;
                case "FECOCAIR":
                    {
                        if (Arl_Dictionary._dictionary_Trace_FECOCAIR.ContainsKey(elementsName))
                        {
                            value = Arl_Dictionary._dictionary_Trace_FECOCAIR[elementsName];
                        }
                    }
                    break;
                case "FECOCRNI":
                    {
                        if (Arl_Dictionary._dictionary_Trace_FECOCRNI.ContainsKey(elementsName))
                        {
                            value = Arl_Dictionary._dictionary_Trace_FECOCRNI[elementsName];
                        }
                    }
                    break;
                case "FECOMNST":
                    {
                        if (Arl_Dictionary._dictionary_Trace_FECOMNST.ContainsKey(elementsName))
                        {
                            value = Arl_Dictionary._dictionary_Trace_FECOMNST[elementsName];
                        }
                    }
                    break;
                case "FECOHACI":
                    {
                        if (Arl_Dictionary._dictionary_Trace_FECOHACI.ContainsKey(elementsName))
                        {
                            value = Arl_Dictionary._dictionary_Trace_FECOHACI[elementsName];
                        }
                    }
                    break;
                case "FECOCRST":
                    {
                        if (Arl_Dictionary._dictionary_Trace_FECOCRST.ContainsKey(elementsName))
                        {
                            value = Arl_Dictionary._dictionary_Trace_FECOCRST[elementsName];
                        }
                    }
                    break;
                default:
                    {
                        if (Arl_Dictionary._dictionary_Trace.ContainsKey(elementsName))
                        {
                            value = Arl_Dictionary._dictionary_Trace[elementsName];
                        }
                    }
                    break;
            }
            return GetValue(elementsName, value);
		}

		public static double GetValue(string elementsName, float Value)
		{
			float single;
			short item;
			single = (!Arl_Dictionary._dictionary_PercentValue.ContainsKey(elementsName) ? 0.009f : Arl_Dictionary._dictionary_PercentValue[elementsName]);
			if (Value <= single)
			{
				if (!Arl_Dictionary._dictionary_PercentMax.ContainsKey(elementsName))
				{
					item = 3;
				}
				else
				{
					item = Arl_Dictionary._dictionary_PercentMax[elementsName];
				}
			}
			else if (!Arl_Dictionary._dictionary_PercentMin.ContainsKey(elementsName))
			{
				item = 2;
			}
			else
			{
				item = Arl_Dictionary._dictionary_PercentMin[elementsName];
			}
			return Math.Round((double)Value, item);
		}
	}
}