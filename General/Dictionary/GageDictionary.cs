using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Dictionary
{
    public struct GageDictionary
    {
        private static Dictionary<int, RASF.General.Classes.GageSize> Dictionary = new Dictionary<int, RASF.General.Classes.GageSize>();

        static GageDictionary()
        {
            Dictionary.Add(40, new Classes.GageSize(100, 72));
            Dictionary.Add(100, new Classes.GageSize(100, 179));
            Dictionary.Add(200, new Classes.GageSize(100, 262));
            Dictionary.Add(500, new Classes.GageSize(50, 325));
            Dictionary.Add(1000, new Classes.GageSize(20, 260));
        }

        public static RASF.General.Classes.GageSize GetValue(int Value)
        {
            if (Dictionary.ContainsKey(Value))
                return Dictionary[Value];
            else
                return null;
        }

    }
}
