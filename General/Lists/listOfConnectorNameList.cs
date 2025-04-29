using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class listOfConnectorNameList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Base>
    {
        public listOfConnectorNameList()
        {
            this.spName = "listOfConnectorName";
            this.list = new List<RASF.General.Data.Companies_Base>();
            this.deletedlist = new List<RASF.General.Data.Companies_Base>();
        }

        public listOfConnectorNameList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

