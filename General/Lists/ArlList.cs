using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ArlList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Arl_Elements>
    {
        public String FileName { get; set; }

        public ArlList()
        {
            this.list = new List<RASF.General.Data.Arl_Elements>();
            this.deletedlist = new List<RASF.General.Data.Arl_Elements>();
        }

        public ArlList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill()
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Path.GetDirectoryName(this.FileName) + ";Extended Properties=dBASE IV;User ID=;Password=;");
            try
            {
                using (System.Data.OleDb.OleDbCommand Command = new System.Data.OleDb.OleDbCommand(String.Format("select * from {0}", System.IO.Path.GetFileName(this.FileName)), con))
                {
                    con.Open();
                    using (System.Data.OleDb.OleDbDataReader reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            System.Data.IDataRecord record = (System.Data.IDataRecord)reader;
                            RASF.General.Data.Arl_Elements el = new Data.Arl_Elements();
                            el.Task = record[0].ToString();
                            el.Base = record[2].ToString();
                            el.Name = record[8].ToString();
                            el.Date = String .Format("{0}-{1}", RASF.General.Classes.Utility.DateConvertor((DateTime)record[5]), record[6].ToString());
                            el.Base = reader.GetName(18).Replace("%", "");
                            for (int i=19; i< record.FieldCount; i++)
                            {
                                RASF.General.Data.Arl_Eleman eleman = new Data.Arl_Eleman();
                                eleman.Value = record[i].ToString();
                                eleman.Name=  reader.GetName(i);
                                el.Eleman.Add(eleman);
                            }
                            this.list.Add(el);
                        }
                        reader.Close();

                    }
                }
            }
            catch (Exception ex)
            {
            }
            return this.list.Count;
        }

    }
}

