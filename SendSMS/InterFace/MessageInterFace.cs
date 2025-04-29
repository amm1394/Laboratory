using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.InterFace
{
   public interface MessageInterFace
    {
       int FinancialYear { get; set; }
       int ContractNo { get; set; }
       Message Message { get; set; }
       void DoWork();
    }
}
