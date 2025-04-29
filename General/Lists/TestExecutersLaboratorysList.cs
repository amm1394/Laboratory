using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TestExecutersLaboratorysList : RASF.General.Lists.Base.BaseList<RASF.General.Data.TestExecutersLaboratorys>
    {
        public TestExecutersLaboratorysList()
        {
            this.spName = "TestExecutersLaboratorys";
            this.list = new List<RASF.General.Data.TestExecutersLaboratorys>();
            this.deletedlist = new List<RASF.General.Data.TestExecutersLaboratorys>();
        }

        public TestExecutersLaboratorysList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }


        public void FillList2()
        {
            using (AD.ADHelper helper = new AD.ADHelper())
            {
                TimeSpan ts = DateTime.Now - RASF.General.Classes.Global.LastUpdate;
                if (ts.TotalMilliseconds < RASF.General.Classes.Global.SleepInterval)
                {
                    System.Threading.Thread.Sleep(RASF.General.Classes.Global.SleepInterval);
                }

                using (SqlConnection connection = new SqlConnection(readconnectionString))
                {
                    using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("select Laboratory.LaboratoryCode from Laboratory where Status= 1", connection))
                    {
                        connection.Open();
                        using (System.Data.SqlClient.SqlDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Guid LabCode = new Guid(reader.GetValue(0).ToString());
                                list.AddRange(helper.GetLabodeList(LabCode));
                            }
                        }
                    }
                }
            }
        }
    }
}

