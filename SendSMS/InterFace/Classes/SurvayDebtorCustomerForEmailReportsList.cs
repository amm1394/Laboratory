using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
 public class SurvayDebtorCustomerForEmailReportsList
    {
     public List<SurvayDebtorCustomerForEmailReportsList> list = new List<SurvayDebtorCustomerForEmailReportsList>();

     public Int16 Check { get; set; }

     public string Email { get; set; }


     public void Fill(int FinancialYear, int ContractNo)
     {
         using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
         {
             using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("SurvayDebtorCustomerForEmailReports_Select", Connection))
             {
                 Command.CommandType = System.Data.CommandType.StoredProcedure;
                 Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                 Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                 Connection.Open();
                 System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                 while (dr.Read())
                 {
                     SurvayDebtorCustomerForEmailReportsList SurvayDebtor = new SurvayDebtorCustomerForEmailReportsList();
                     SurvayDebtor.Check = Convert.ToInt16(dr.GetValue(0));
                     SurvayDebtor.Email = dr.GetString(1);

                     list.Add(SurvayDebtor);
                 }
                 Connection.Close();
             }
         }
     }
    }
}
