using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
   public  class PartsMasterPrintReportWithSMS
    {
       public List<PartsMasterPrintReportWithSMS> list = new List<PartsMasterPrintReportWithSMS>();

       public Guid PartsMasterCode { get; set; }
        public string Name { get; set; }
        public Int16 PartNumber { get; set; }
        public string ReceptionDate { get; set; }
        public string Delivery { get; set; }
      
        public void Fill(int FinancialYear, int ContractNo)
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("PartsMasterPrintReportWithSMS_select", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", ContractNo));
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", FinancialYear));
                    Connection.Open();
                    System.Data.SqlClient.SqlDataReader dr = Command.ExecuteReader();
                    while (dr.Read())
                    {
                        PartsMasterPrintReportWithSMS PrintRepor = new PartsMasterPrintReportWithSMS();
                        PrintRepor.PartsMasterCode = (Guid)dr.GetValue(0);
                        PrintRepor.Name = dr.GetValue(1).ToString();
                        PrintRepor.PartNumber = Convert.ToInt16(dr.GetValue(2));
                        PrintRepor.ReceptionDate = dr.GetValue(3).ToString();
                        PrintRepor.Delivery = dr.GetValue(4).ToString();
                      
                        list.Add(PrintRepor);
                    }
                    Connection.Close();
                }
            }
        }
    }
}
