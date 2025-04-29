using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class Parts_Master_DeclareCostList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Parts_MasterDeclareCost>
    {
        Int16 PartNumber = -1;
        public Parts_Master_DeclareCostList()
        {
            this.spName = "Parts_Master_DeclareCost";
            this.list = new List<RASF.General.Data.Parts_MasterDeclareCost>();
            this.deletedlist = new List<RASF.General.Data.Parts_MasterDeclareCost>();
        }

        public Parts_Master_DeclareCostList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override void Update()
        {
            foreach (RASF.General.Data.Parts_MasterDeclareCost test in this)
            {
                test.UserIdUpdate = RASF.General.Classes.Global.CurrentUserCode;
            }
            base.Update();
        }

        public Int16 TotalPrice()
        {
            Int16 price = 0;

            foreach (RASF.General.Data.Parts_MasterDeclareCost parts in this)
            {
                price += (Int16)parts.Tests.Sum(row => row.InvoicePrice * row.NumberOfTests);
            }
            return price;
        }

        public Int16 GetPartNumber(Guid ContractsBaseCode)
        {
            if (PartNumber == -1)
            {
                TimeSpan ts = DateTime.Now - RASF.General.Classes.Global.LastUpdate;
                if (ts.TotalMilliseconds < RASF.General.Classes.Global.SleepInterval)
                {
                    System.Threading.Thread.Sleep(RASF.General.Classes.Global.SleepInterval);
                }

                using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(readconnectionString))
                {
                    using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("GetPartNumberDeclareCost", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContractsBaseCode", ContractsBaseCode));
                        Connection.Open();
                        Object Value = Command.ExecuteScalar();
                        if (Value != DBNull.Value)
                        {
                            this.PartNumber = Convert.ToInt16(Value);
                        }
                        else
                        {
                            this.PartNumber = 0;
                        }
                    }
                    Connection.Close();
                }
            }

            Int16 Max1 = 0, Max2 = 0;
            if (this.Count() > 0)
            {
                Max1 = (Int16)this.Max(row => row.PartNumber);
            }
            if (this.deletedlist.Count > 0)
            {
                Max2 = (Int16)this.deletedlist.Max(row => row.PartNumber);
            }
            return (Int16)Math.Max(Math.Max(Max1 , Max2) + 1, this.PartNumber);
        }

      

        public Boolean IsDataCompleted(Boolean EnglishReporter)
        {
            if (EnglishReporter == true)
            {
                if (((this.Where(row => String.IsNullOrEmpty(row.Englishname.Trim()) == false).Count() == 0) || (this.Where(row => row.Picture != null).Count()) == 0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if ((this.Where(row => row.Picture != null).Count()) == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }    
}
