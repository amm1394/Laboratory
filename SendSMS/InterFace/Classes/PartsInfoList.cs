using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS
{
    public class PartsInfoList
    {
        public List<PartsInfoList> list = new List<PartsInfoList>();
        public string PiecesName { get; set; }
        public int PartNumber { get; set; }
        public void TestInfo()
        {
        }

        public void Fill(int FinancialYear,int ContractNo)
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("CostomerCostEmailWithHeaderpartInfo_Select", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                    Connection.Open();
                    System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                    while (dr.Read())
                    {
                        PartsInfoList PartsInfo = new PartsInfoList();
                        PartsInfo.PiecesName = dr.GetValue(0).ToString();
                        PartsInfo.PartNumber = (int)dr.GetValue(1);
                        list.Add(PartsInfo);
                    }
                    Connection.Close();
                }
            }
        }
    }
}
