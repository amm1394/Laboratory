using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS
{
   public class contractinfoForEmailOfBillLList
    {
       public List<contractinfoForEmailOfBillLList> list = new List<contractinfoForEmailOfBillLList>();

       public string CompanyName { get; set; }
       public string CmpanyAddress { get; set; }
       public string EconomicCode { get; set; }
       public string SetNum { get; set; }
       public string LetterDate { get; set; }
       public string LetterNo { get; set; }
       public string PostCode { get; set; }
       public string CooperationName { get; set; }
       public string AgencyName { get; set; }
       public string NationalArgument { get; set; } 



       public void Fill(int FinancialYear, int ContractNo)
       {
           using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
           {
               using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("contractinfoForEmailOfBill_Select", Connection))
               {
                   Command.CommandType = System.Data.CommandType.StoredProcedure;
                   Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                   Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                   Connection.Open();
                   System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                   while (dr.Read())
                   {
                       contractinfoForEmailOfBillLList ContractInfo = new contractinfoForEmailOfBillLList();
                       ContractInfo.CompanyName = dr.GetValue(0).ToString();
                       ContractInfo.CmpanyAddress = dr.GetValue(1).ToString();
                       ContractInfo.EconomicCode = dr.GetValue(9).ToString();
                       ContractInfo.SetNum = dr.GetValue(3).ToString();
                       ContractInfo.LetterDate = dr.GetValue(4).ToString();
                       ContractInfo.LetterNo = dr.GetValue(5).ToString();
                       ContractInfo.PostCode = dr.GetValue(6).ToString();
                       ContractInfo.CooperationName = dr.GetValue(7).ToString();
                       ContractInfo.AgencyName = dr.GetValue(8).ToString();
                       ContractInfo.NationalArgument = dr.GetValue(9).ToString();

                       list.Add(ContractInfo);
                   }
                   Connection.Close();
               }
           }
       }


    }
}
