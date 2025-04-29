using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.Main.Classes
{
    public class Insert_ReceiptAmount_Master
    {
        
        private Stimulsoft.Report.StiReport Report;
        public Insert_ReceiptAmount_Master()
        {
            this.Report = new Stimulsoft.Report.StiReport();
        }

        public Guid Update(Guid CompanyId, int howToPay, Guid CashCode, Int64 ReceiptAmount)
        {
            RASF.General.Lists.ReceiptAmountMasterList receiptAmountMasterList = new General.Lists.ReceiptAmountMasterList();
            RASF.General.Data.ReceiptAmount_Master ReceiptAmount_Master = new RASF.General.Data.ReceiptAmount_Master();
            ReceiptAmount_Master.ReceiptAmountMasterCode = receiptAmountMasterList.GetId();
            ReceiptAmount_Master.FinancialYear = RASF.General.Classes.Global.FinancialYear;
            ReceiptAmount_Master.CompaniesCode = CompanyId;
            ReceiptAmount_Master.HowToPay = howToPay;
            ReceiptAmount_Master.CashesCode = CashCode;
            ReceiptAmount_Master.Amount = ReceiptAmount;
            ReceiptAmount_Master.UserName = RASF.General.Classes.Global.CurrentUserName;

            receiptAmountMasterList.Add(ReceiptAmount_Master);
            receiptAmountMasterList.Update();

            return ReceiptAmount_Master.ReceiptAmountMasterCode;
        }

        public void InsertReceiptAssignment(DateTime AssignmentDate, String AssignmentNo, String AssignmentBanks, Guid BanksCode, Guid ReceiptAmount_MasterCode)
        {
            RASF.General.Lists.ReceiptAssignmentList receiptAssignmentList = new RASF.General.Lists.ReceiptAssignmentList();
            RASF.General.Data.ReceiptAssignment ReceiptAssignment = new RASF.General.Data.ReceiptAssignment();
            ReceiptAssignment.AssignmentDate = AssignmentDate;
            ReceiptAssignment.AssignmentNo = AssignmentNo;
            ReceiptAssignment.AssignmentBanks = AssignmentBanks;
            ReceiptAssignment.BanksCode = BanksCode;
            ReceiptAssignment.ReceiptAmount_MasterCode = ReceiptAmount_MasterCode;
            receiptAssignmentList.Add(ReceiptAssignment);
            receiptAssignmentList.Update();
        }

        public void ShowReport(Guid ReceiptAmountMasterCode, String ReportName)
        {
            Report.Load(ReportName);
            Report["@ReceiptAmountMasterCode"] = ReceiptAmountMasterCode;
            Report.Show();
        }
    }
}
