using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Reception_PicList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Reception_Pic>
    {
        public Reception_PicList()
        {
            this.spName = "Reception_Pic";
            this.list = new List<RASF.General.Data.Reception_Pic>();
            this.deletedlist = new List<RASF.General.Data.Reception_Pic>();
        }

        public Reception_PicList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);

            //foreach (RASF.General.Data.Reception_Pic row in this)
            //{
            //    try
            //    {
            //        int Zoom = Convert.ToInt16(System.IO.Path.GetFileNameWithoutExtension(row.FileName).Split('-')[1]);
            //        row.Pciture = RASF.General.Classes.Utility.Add_Gage(row.Pciture, RASF.General.Dictionary.GageDictionary.GetValue(Zoom));
            //        row.Icon = RASF.General.Classes.Utility.ReadPic(row.Pciture, 80);
            //    }
            //    catch
            //    {
            //    }
            //}

            return this.list.Count;
        }
    }
}
