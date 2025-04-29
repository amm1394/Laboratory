using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Classes
{
   public  class GageSize
    {
       public int Size { get; set; }
       public int lengeht{ get; set; }

       public GageSize(int size, int lengeht)
       {
           this.Size = size;
           this.lengeht = lengeht;
       }
    }
}
