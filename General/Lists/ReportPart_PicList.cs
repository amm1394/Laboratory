using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportPart_PicList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Metal_Pic>
    {
        public ReportPart_PicList()
        {
            this.spName = "Reciption_Pic";
            this.list = new List<RASF.General.Data.Metal_Pic>();
            this.deletedlist = new List<RASF.General.Data.Metal_Pic>();
        }

        public ReportPart_PicList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);

            foreach(RASF.General.Data.Metal_Pic row in this)
            {
                try
                {
                    row.Icon = RASF.General.Classes.Utility.ReadPic(row.Pciture, 80);
                }
                catch
                {
                }
            }

            return this.list.Count;
        }
    }
}
