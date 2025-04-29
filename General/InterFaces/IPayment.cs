using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.InterFaces
{
    public interface IPayment
    {
        Guid UpdateData(Guid CompanyId);

        void ShowReport(Guid ReceiptAmountMasterCode, Boolean InformalPayments);

        //Int64 Remind { set; }

        Guid CashCode { get; }

        Boolean chekData(Int64 Total);

        void Reset();
    }
}
