using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists.Base
{
    [System.ComponentModel.Category("RASF")]
    [SerializableAttribute]
    public class BaseList<T> : System.ComponentModel.Component, IList<T>, ICollection<T>, System.Collections.IList, System.Collections.ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable<T>
    {
       // protected static String connection = "Data Source=sql-1;Initial Catalog=LaboratoryForMe;Persist Security Info=True;User ID=sa;Password=AliReza23280";
        protected static String readconnectionString = "Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280;ApplicationIntent=ReadOnly";
        protected static String updateconnectionString = "Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280";
        public String spName;
        public System.Collections.Generic.List<T> list { get; protected set; }
        public System.Collections.Generic.List<T> deletedlist;
        
        public BaseList()
        {
        }

        public BaseList(System.ComponentModel.IContainer container)
        {
            container.Add(this);
        }

        public bool ContainsListCollection
        {
            get { return false; }
        }

        public System.Collections.IList GetList()
        {
            return this.list;
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        public void Add(T row)
        {
            ((RASF.General.InterFaces.IRow)row).RowState = Enums.RowState.Added;
            this.list.Add(row);
        }

        public void AddWithOutRowState(T row)
        {
            this.list.Add(row);
        }

        public void Add(T row, Enums.RowState rowState)
        {
            ((RASF.General.InterFaces.IRow)row).RowState = rowState;
            this.list.Add(row);
        }

        public void AddRange(List<T> rows)
        {
            this.list.AddRange(rows);
        }

        public static Object FillScalar(String spName)
        {
            Object ReturnValue = null;
            try
            {
                RASF.General.Classes.Global.LastUpdate = DateTime.Now;
                using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(updateconnectionString))
                {
                    using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand(spName, Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Connection.Open();
                        ReturnValue = Command.ExecuteScalar();
                    }
                    Connection.Close();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return ReturnValue;
        }

        public static Object FillScalar(String spName, List<System.Data.SqlClient.SqlParameter> parameters)
        {
            Object ReturnValue = null;
            try
            {
                RASF.General.Classes.Global.LastUpdate = DateTime.Now;
                using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(updateconnectionString))
                {
                    using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand(spName, Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Command.Parameters.AddRange(parameters.ToArray());
                        Connection.Open();
                        ReturnValue = Command.ExecuteScalar();
                    }
                    Connection.Close();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return ReturnValue;
        }

        public virtual Object FillScalar()
        {
            Object ReturnValue = null;
            try
            {
                RASF.General.Classes.Global.LastUpdate = DateTime.Now;
                using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(updateconnectionString))
                {
                    using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand(String.Format("{0}_Insert", this.spName), Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Connection.Open();
                        ReturnValue = Command.ExecuteScalar();
                    }
                    Connection.Close();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return ReturnValue;
        }

        public virtual Object FillScalar(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            Object ReturnValue = null;
            try
            {
                RASF.General.Classes.Global.LastUpdate = DateTime.Now; 
                using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(updateconnectionString))
                {
                    using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand(String.Format("{0}_Insert", this.spName), Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Command.Parameters.AddRange(parameters.ToArray());
                        Connection.Open();
                        ReturnValue = Command.ExecuteScalar();
                    }
                    Connection.Close();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return ReturnValue;
        }

        public virtual int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            try
            {
                TimeSpan ts = DateTime.Now - RASF.General.Classes.Global.LastUpdate;
                if (ts.TotalMilliseconds < RASF.General.Classes.Global.SleepInterval)
                {
                    System.Threading.Thread.Sleep(RASF.General.Classes.Global.SleepInterval);
                }

                Type RowType = this.list.GetType().GenericTypeArguments[0];
                this.list.Clear();
                using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(readconnectionString))
                {
                    using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand(String.Format("{0}_Select", this.spName), Connection))
                    {
                      
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Command.Parameters.AddRange(parameters.ToArray());
                        Connection.Open();
                        Command.CommandTimeout = 200;
                        using (System.Data.SqlClient.SqlDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                System.Data.IDataRecord record = (System.Data.IDataRecord)reader;
                                Object instance = Activator.CreateInstance(RowType);
                                for (int i = 0; i < record.FieldCount; i++)
                                {
                                    System.Reflection.PropertyInfo info = RowType.GetProperty(reader.GetName(i));
                                    if ((info != null) && (reader[i] != DBNull.Value))
                                    {
                                        info.SetValue(instance, record[i]);
                                    }
                                }
                                System.Reflection.PropertyInfo RowState = RowType.GetProperty("RowState");
                                RowState.SetValue(instance, RASF.General.Enums.RowState.Original);
                                this.list.Add((T)instance);
                            }
                            reader.Close();
                        }
                    }
                    Connection.Close();
                }
            }
            catch (Exception e )
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return list.Count;
        }

        public virtual int Fill()
        {
            try
            {
                TimeSpan ts = DateTime.Now - RASF.General.Classes.Global.LastUpdate;
                if (ts.TotalMilliseconds < RASF.General.Classes.Global.SleepInterval)
                {
                    System.Threading.Thread.Sleep(RASF.General.Classes.Global.SleepInterval);
                }

                this.list.Clear();
                Type RowType = this.list.GetType().GenericTypeArguments[0];
                using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(readconnectionString))
                {
                    using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand(String.Format("{0}_Select", this.spName), Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;
                        Connection.Open();
                        Command.CommandTimeout = 200;
                        using (System.Data.SqlClient.SqlDataReader reader = Command.ExecuteReader())
            
                        {
                            while (reader.Read())
                            {
                                System.Data.IDataRecord record = (System.Data.IDataRecord)reader;
                                Object instance = Activator.CreateInstance(RowType);
                                try
                                {
                                    for (int i = 0; i < record.FieldCount; i++)
                                    {
                                        System.Reflection.PropertyInfo info = RowType.GetProperty(reader.GetName(i));
                                        if ((info != null) && (reader[i] != DBNull.Value))
                                        {
                                            info.SetValue(instance, record[i]);
                                        }
                                    }
                                    System.Reflection.PropertyInfo RowState = RowType.GetProperty("RowState");
                                    RowState.SetValue(instance, RASF.General.Enums.RowState.Original);
                                    this.list.Add((T)instance);
                                }
                                catch (Exception e)
                                {
                                    System.Windows.Forms.MessageBox.Show(e.Message);
                                }
                            }
                            reader.Close();
                        }
                    }
                    Connection.Close();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return list.Count;
        }



        public virtual void Update()
        {
            Type RowType = this.list.GetType().GenericTypeArguments[0];
            this.Update(String.Format("{0}_Insert", this.spName), this.list.Where(row => (RASF.General.Enums.RowState)RowType.GetProperty("RowState").GetValue(row) == RASF.General.Enums.RowState.Added).ToList());
            this.Update(String.Format("{0}_Update", this.spName), this.list.Where(row => (RASF.General.Enums.RowState)RowType.GetProperty("RowState").GetValue(row) == RASF.General.Enums.RowState.Updated).ToList());
            this.Update(String.Format("{0}_Delete", this.spName), this.deletedlist);
            this.deletedlist.Clear();
        }

      
        public Guid GetId()
        {
            Guid Id;
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(readconnectionString))
            {
                Connection.Open();
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("CreateGUID", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Id = new Guid(Command.ExecuteScalar().ToString());
                }
                Connection.Close();
            }
            return Id;
        }

        private void Update(String SPName, List<T> Rows)
        {
            try
            {
               if (Rows.Count() > 0)
                {
                    Type RowType = this.list.GetType().GenericTypeArguments[0];
                    RASF.General.Classes.Global.LastUpdate = DateTime.Now;
                   using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(updateconnectionString))
                    {
                        Connection.Open();
                        List<String> Parameters = new List<String>();
                        using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("SelectParameter", Connection))
                        {
                            Command.CommandType = System.Data.CommandType.StoredProcedure;
                            Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@specific_name", SPName));
                            using (System.Data.SqlClient.SqlDataReader reader = Command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Parameters.Add(((System.Data.IDataRecord)reader)[0].ToString().Replace("@", ""));
                                }
                                reader.Close();
                            }
                        }

                        using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand(SPName, Connection))
                        {
                            Command.CommandType = System.Data.CommandType.StoredProcedure;
                            foreach (var row in Rows)
                            {
                                Command.Parameters.Clear();
                                foreach (string PName in Parameters)
                                {
                                    System.Data.SqlClient.SqlParameter Parameter = new System.Data.SqlClient.SqlParameter(PName, RowType.GetProperty(PName).GetValue(row));
                                    if (RowType.GetProperty(PName).PropertyType.IsArray == true)
                                    {
                                        Parameter.DbType = System.Data.DbType.Binary;
                                        if (Parameter.Value == null)
                                        {
                                            Parameter.Value = DBNull.Value;
                                        }
                                    }
                                    Command.Parameters.Add(Parameter);
                                }
                                Command.ExecuteNonQuery();
                                RowType.GetProperty("RowState").SetValue(row, RASF.General.Enums.RowState.Original);
                            }
                        }
                        Connection.Close();
                    }
                }
             }
            catch
            {
                System.Windows.Forms.MessageBox.Show("عملیات نا موفق");
            }

        }

        public int IndexOf(T item)
        {
            return this.list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            this.list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.list.RemoveAt(index);
        }

        public T this[int index]
        {
            get
            {
                  return this.list[index];
            }
            set
            {
                this.list[index] = value;
            }
        }

        public void Clear()
        {
            this.list.Clear();
        }

        public bool Contains(T item)
        {
            return this.list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.list.CopyTo(array, arrayIndex);
        }

        int ICollection<T>.Count
        {
            get { return this.list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            if (((RASF.General.InterFaces.IRow)item).RowState != Enums.RowState.Added)
            {
                this.deletedlist.Add(item);
            }

            return this.list.Remove(item);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        public int Add(object value)
        {
            RASF.General.InterFaces.IRow Row = ((RASF.General.InterFaces.IRow)value);
            Row.RowState = Enums.RowState.Added;
            this.list.Add((T)Row);
            return this.list.Count - 1;
        }

        public bool Contains(object value)
        {
            return this.list.Contains((T)value);
        }

        public int IndexOf(object value)
        {
            return this.list.IndexOf((T)value);
        }

        public void Insert(int index, object value)
        {
            this.list.Insert(index, (T)value);
        }

        public bool IsFixedSize
        {
            get { return false; }
        }

        public void Remove(object value)
        {
            if (((RASF.General.InterFaces.IRow)value).RowState != Enums.RowState.Added)
            {
                this.deletedlist.Add((T)value);
            }
            
            this.list.Remove((T)value);
        }

        object System.Collections.IList.this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                this.list[index] = (T)value;
            }
        }

        public void CopyTo(Array array, int index)
        {
         //   this.list.CopyTo(array, index);
        }

        int System.Collections.ICollection.Count
        {
            get { return this.list.Count; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return null; }
        }

        int IReadOnlyCollection<T>.Count
        {
            get { return this.list.Count; }
        }
    }
}   