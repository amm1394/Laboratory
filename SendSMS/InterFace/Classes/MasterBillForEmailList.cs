using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS
{
  public class MasterBillForEmailList
    {
      public List<MasterBillForEmailList> list = new List<MasterBillForEmailList>();

      public string MasterName { get; set; }
      public Int64 NumberOfTests { get; set; }
      public Int64 InvoicePrice { get; set; }
      public Int64 TotalPrice { get; set; }
      public Int64 DisCount { get; set; }
      public Int64 Tax { get; set; }
      public Int64 BillNumber { get; set; }
      public string BillDate { get; set; }


      public void Fill(int FinancialYear, int ContractNo)
      {
          using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
          {
              using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("MasterBillForEmail_Select", Connection))
              {
                  Command.CommandType = System.Data.CommandType.StoredProcedure;
                  Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                  Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                  Connection.Open();
                  System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                  while (dr.Read())
                  {
                      MasterBillForEmailList Billinfo = new MasterBillForEmailList();
                      Billinfo.MasterName = dr.GetValue(0).ToString();
                      Billinfo.NumberOfTests = Convert.ToInt64(dr.GetValue(1));
                      Billinfo.InvoicePrice = Convert.ToInt64( dr.GetValue(2));
                      Billinfo.TotalPrice = Convert.ToInt64(dr.GetValue(3));
                      Billinfo.DisCount =  Convert.ToInt64( dr.GetValue(4));
                      Billinfo.Tax =  Convert.ToInt64( dr.GetValue(5));
                      Billinfo.BillNumber = Convert.ToInt64(dr.GetValue(6));
                      Billinfo.BillDate = Convert.ToString(dr.GetValue(7));


                      list.Add(Billinfo);
                  }
                  Connection.Close();
              }
          }
      }


    }
}
