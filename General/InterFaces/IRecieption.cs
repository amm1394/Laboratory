using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.InterFaces
{
    public interface IRecieption
    {
        Guid UpdateData(Guid CompanyId);

        void ShowReport(Guid ReceiptAmountMasterCode, Boolean InformalReceipt);

        Int64 Remind { set; }

        Guid CashCode { get; }

        Boolean chekData(Int64 Total);

        void Reset();
    }
}
