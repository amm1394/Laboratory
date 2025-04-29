using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class LaboratoryCotracetExecutersList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Laboratory_Contract_Executer>
    {
        public LaboratoryCotracetExecutersList()
        {
            this.spName = "Laboratory_Contract_Executer";
            this.list = new List<RASF.General.Data.Laboratory_Contract_Executer>();
            this.deletedlist = new List<RASF.General.Data.Laboratory_Contract_Executer>();

        }

        public LaboratoryCotracetExecutersList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
