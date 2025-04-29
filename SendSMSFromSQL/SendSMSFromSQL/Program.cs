using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMSFromSQL
{
  static  class Program
    {
        static void Main(string[] args)
        {
            SendSMS Test = new SendSMS();
            Test.DoWork();
        }
    }
}
