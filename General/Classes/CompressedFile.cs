using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Classes
{
    public class CompressedFile : IDisposable
    {
        public System.IO.MemoryStream File { get; set; }
        public String Name { get; set; }
        
        public CompressedFile(Byte[] bytes, String name)
        {
            this.File = new System.IO.MemoryStream(bytes);
            this.Name = name;
        }

        public void Dispose()
        {
            if (File != null)
            {
                File.Dispose();
            }
        }
    }
}
