using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CompanyWorkFlowList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CompanyWorkFlow>
    {
        public CompanyWorkFlowList()
        {
            this.spName = "CompanyWorkFlow";
            this.list = new List<RASF.General.Data.CompanyWorkFlow>();
            this.deletedlist = new List<RASF.General.Data.CompanyWorkFlow>();
        }

        public CompanyWorkFlowList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);
            this.list[0].Reminding += this.list[0].Remind;

            if (this.list.Count > 1)
            {
                for (int i = 1; i < this.list.Count; i++)
                {
                    this.list[i].Reminding =this.list[i].Remind+ this.list[i - 1].Reminding;

                }
            }
            return this.list.Count;

        }
    }
    
}
