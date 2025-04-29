using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ContractsBaseDeclareCostList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_Base>
    {
        public ContractsBaseDeclareCostList()
        {
            this.spName = "Contracts_Base_DeclareCost";
            this.list = new List<RASF.General.Data.Contracts_Base>();
            this.deletedlist = new List<RASF.General.Data.Contracts_Base>();

        }

        public ContractsBaseDeclareCostList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
        public int GetContractNo()
        {
            TimeSpan ts = DateTime.Now - RASF.General.Classes.Global.LastUpdate;
            if (ts.TotalMilliseconds < RASF.General.Classes.Global.SleepInterval)
            {
                System.Threading.Thread.Sleep(RASF.General.Classes.Global.SleepInterval);
            }

            int ContractNo;
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(readconnectionString))
            {
                Connection.Open();
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("GetContractNoDeclareCost", Connection))
                {
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", this.list[0].ContractsCode));
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    ContractNo =(int)Command.ExecuteScalar();
                }
                Connection.Close();
            }
            return ContractNo;
        }

    }
    
}
