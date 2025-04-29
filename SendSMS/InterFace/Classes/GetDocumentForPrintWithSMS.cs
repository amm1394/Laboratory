using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
  public class GetDocumentForPrintWithSMS
    {
       public List<GetDocumentForPrintWithSMS> list = new List<GetDocumentForPrintWithSMS>();

       public byte[] Content { get; set; }
       public Guid PartsTestMasterCode { get; set; }
       public Int16 TotalPage { get; set; }
       public string LaboratoryType { get; set; }
       public string ManagerName { get; set; }

        public void Fill(int FinancialYear, int ContractNo)
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("GetDocumentForPrintWithSMS_select", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                    Connection.Open();
                    System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                    while (dr.Read())
                    {
                        GetDocumentForPrintWithSMS GetDocument = new GetDocumentForPrintWithSMS();
                        GetDocument.Content = (byte[])dr.GetValue(0);
                        GetDocument.PartsTestMasterCode = (Guid) dr.GetValue(1);
                        GetDocument.TotalPage = Convert.ToInt16(dr.GetValue(2));
                        GetDocument.LaboratoryType = dr.GetValue(3).ToString();
                        GetDocument.ManagerName  = dr.GetValue(4).ToString();

                        list.Add(GetDocument);
                    }
                    Connection.Close();
                }
            }
        }
    }
}
