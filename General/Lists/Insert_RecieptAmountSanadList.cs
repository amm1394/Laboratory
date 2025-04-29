using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Insert_RecieptAmountSanadList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Insert_RecieptAmountSanad>
    {
        public Insert_RecieptAmountSanadList()
        {
            this.spName = "Insert_RecieptAmountSanad";
            this.list = new List<RASF.General.Data.Insert_RecieptAmountSanad>();
            this.deletedlist = new List<RASF.General.Data.Insert_RecieptAmountSanad>();
        }

        public Insert_RecieptAmountSanadList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public void Update(DateTime BillDate)
        {
            //using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(connection))
            //{
            //    using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand(String.Format("{0}_Insert", spName), Connection))
            //    {
            //        Command.CommandType = System.Data.CommandType.StoredProcedure;
            //        Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("BillDate", BillDate));
            //        Connection.Open();
            //        Command.ExecuteNonQuery();
            //    }
            //    Connection.Close();
            //}
        }
    }
    
}
