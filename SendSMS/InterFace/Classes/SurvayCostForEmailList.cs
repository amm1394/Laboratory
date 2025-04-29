using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
  public  class SurvayCostForEmailList
    {
      public List<SurvayCostForEmailList> list = new List<SurvayCostForEmailList>();

        public Int16 Check { get; set; }


        public void Fill(int FinancialYear, int ContractNo)
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("SurvayCostForEmail_Select", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                    Connection.Open();
                    System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                    while (dr.Read())
                    {
                        SurvayCostForEmailList SurvayCost = new SurvayCostForEmailList();
                        SurvayCost.Check = Convert.ToInt16(dr.GetValue(0));

                        list.Add(SurvayCost);
                    }
                    Connection.Close();
                }
            }
        }
    }
}
