using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
    public class InvalidMessage : InterFace.MessageInterFace
    {
        public int FinancialYear { get; set; }
        public int ContractNo { get; set; }
        public Message Message { get; set; }
        public void DoWork()
        {
            Message.Result = "اطلاعات ارسالی صحیح نمی باشد لطفا در صورت هرگونه ابهام به سایت این بنیاد به آدرس Razi-Foundation.Com مراجعه نمایید.";
        }
    }
}
