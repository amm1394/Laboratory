using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS
{
    public class ContractInfoList
    {
        public List<ContractInfoList> list = new List<ContractInfoList>();
        public Int32 ContractNo { get; set; }
        public Int32 Tax { get; set; }
        public Int64 Amount { get; set; }
        public string LetterDate { get; set; }
        public string LetterNo { get; set; }
        public string Referred { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }

        public ContractInfoList()
        {
        }
        public void Fill(int FinancialYear, int ContractNo)
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("CostomerCostEmailWithHeadercontractinfo_Select", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                    Connection.Open();
                    System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                    while(dr.Read())
                    {
                        ContractInfoList ContractInfo = new ContractInfoList();
                        ContractInfo.CompanyName = dr.GetValue(0).ToString();
                        ContractInfo.ContractNo = (Int32)dr.GetValue(1);
                        ContractInfo.Referred = dr.GetValue(2).ToString();
                        ContractInfo.LetterDate = dr.GetValue(3).ToString();
                        ContractInfo.LetterNo = dr.GetValue(4).ToString();
                        ContractInfo.Amount = (Int64)dr.GetValue(5);
                        ContractInfo.Tax = (Int32)dr.GetValue(6);
                        ContractInfo.Email = dr.GetValue(7).ToString();
                        list.Add(ContractInfo);
                    }
                    Connection.Close();
                }
            }
        }
    }
}
