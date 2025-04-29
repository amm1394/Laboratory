using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.Main.Classes
{
    public class Insert_PaymentAmount_Master
    {
        
        private Stimulsoft.Report.StiReport Report;
        public Insert_PaymentAmount_Master()
        {
            this.Report = new Stimulsoft.Report.StiReport();
        }

        public Guid Update(Guid CompanyId, int PayMentType, Guid CashCode, Int64 PaymentAmount)
        {
            RASF.General.Lists.PaymentAmount_MasterList PaymentAmount_MasterList = new General.Lists.PaymentAmount_MasterList();
            RASF.General.Data.PaymentAmount_Master PaymentAmount_Master = new RASF.General.Data.PaymentAmount_Master();
            PaymentAmount_Master.PaymentAmountMasterCode = PaymentAmount_MasterList.GetId();
            PaymentAmount_Master.FinancialYear = RASF.General.Classes.Global.FinancialYear;
            PaymentAmount_Master.CompaniesCode = CompanyId;
            PaymentAmount_Master.PayMentType = PayMentType;
            PaymentAmount_Master.CashesCode = CashCode;
            PaymentAmount_Master.Amount = PaymentAmount;
            PaymentAmount_Master.UserID = RASF.General.Classes.Global.CurrentUserCode;

            PaymentAmount_MasterList.Add(PaymentAmount_Master);
            PaymentAmount_MasterList.Update();

            return PaymentAmount_Master.PaymentAmountMasterCode;
        }

        public void InsertReceiptAssignment(DateTime AssignmentDate, String AssignmentNo, String AssignmentBanks, Guid BanksCode, Guid MasterPaymantAmountCode)
        {
            RASF.General.Lists.Payment_AssignmentList Payment_AssignmentList = new RASF.General.Lists.Payment_AssignmentList();
            RASF.General.Data.Payment_Assignment Payment_Assignment = new RASF.General.Data.Payment_Assignment();
            Payment_Assignment.AssignmentDate = AssignmentDate;
            Payment_Assignment.AssignmentNo = AssignmentNo;
            //Payment_Assignment.AssignmentBanksCode = AssignmentBanks;
            Payment_Assignment.AssignmentBanksCode = BanksCode;
            Payment_Assignment.MasterPaymantAmountCode = MasterPaymantAmountCode;
            Payment_AssignmentList.Add(Payment_Assignment);
            Payment_AssignmentList.Update();
        }

        public void ShowReport(Guid PaymentAmountMasterCode, String ReportName)
        {
            Report.Load(ReportName);
            Report["@PaymentAmountMasterCode"] = PaymentAmountMasterCode;
            Report.Show();
        }
    }
}
