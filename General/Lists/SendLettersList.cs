using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SendLettersList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SendLetters>
    {
        public SendLettersList()
        {
            this.spName = "SendLetters";
            this.list = new List<RASF.General.Data.SendLetters>();
            this.deletedlist = new List<RASF.General.Data.SendLetters>();
        }

        public SendLettersList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public string GetLetterNo()
        {
            TimeSpan ts = DateTime.Now - RASF.General.Classes.Global.LastUpdate;
            if (ts.TotalMilliseconds < RASF.General.Classes.Global.SleepInterval)
            {
                System.Threading.Thread.Sleep(RASF.General.Classes.Global.SleepInterval);
            }

            string LetterNo;
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(readconnectionString))
            {
                Connection.Open();
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("GetLetterNo", Connection))
                {
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SendLettersCode", this.list[0].SendLettersCode));
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    LetterNo = (string)Command.ExecuteScalar();
                }
                Connection.Close();
            }
            return LetterNo;
        }
    }
    
}
