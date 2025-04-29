using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS
{
    public class EmailMarketingList
    {
        public List<EmailMarketingList> list = new List<EmailMarketingList>();

        public string CompanyName { get; set; }
        public string EmailAdd { get; set; }
     
       public void Fill()
       {
           using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
           {
               using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("emailTest_Select", Connection))
               {
                   Command.CommandType = System.Data.CommandType.StoredProcedure;
                   Connection.Open();
                   System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                   while (dr.Read())
                   {
                       EmailMarketingList ContractInfo = new EmailMarketingList();
                       ContractInfo.EmailAdd = dr.GetValue(0).ToString();
                       
                       list.Add(ContractInfo);
                   }
                   Connection.Close();
               }
           }
       }


    }
}
