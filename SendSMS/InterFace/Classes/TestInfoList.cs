using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS
{
    public class TestInfoList
    {
        public List<TestInfoList> list = new List<TestInfoList>();
        public String MasterName { get; set; }
        public int NumberOfTests { get; set; }
        public int InvoicePrice { get; set; }
        public int TotalPrice { get; set; }
        public int PartNumber { get; set; }  
        public TestInfoList()
        {
        }

        public void Fill(int FinancialYear, int ContractNo)
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("CostomerCostEmailWithHeadertestinfo_Select", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                    Connection.Open();
                    System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                    while (dr.Read())                    
                    {
                        TestInfoList TestInfo = new TestInfoList();
                        TestInfo.MasterName = dr.GetValue(0).ToString();
                        TestInfo.NumberOfTests = (int)dr.GetValue(1);
                        TestInfo.InvoicePrice = (int)dr.GetValue(2);
                        TestInfo.TotalPrice = (int)dr.GetValue(3);
                        TestInfo.PartNumber = (int)dr.GetValue(4);
                        list.Add(TestInfo);
                    }
                    Connection.Close();
                }
            }
        }
    }
}


