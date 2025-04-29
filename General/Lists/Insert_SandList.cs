using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Insert_SandList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Insert_Sand>
    {
        public Insert_SandList()
        {
            this.spName = "Insert_Sand";
            this.list = new List<RASF.General.Data.Insert_Sand>();
            this.deletedlist = new List<RASF.General.Data.Insert_Sand>();
        }

        public Insert_SandList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public void Update(DateTime BillDate)
        {
            TimeSpan ts = DateTime.Now - RASF.General.Classes.Global.LastUpdate;
            if (ts.TotalMilliseconds < RASF.General.Classes.Global.SleepInterval)
            {
                System.Threading.Thread.Sleep(RASF.General.Classes.Global.SleepInterval);
            }

            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(readconnectionString))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand(String.Format("{0}_Insert", spName), Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("BillDate", BillDate));
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                Connection.Close();
            }
        }
    }
    
}
