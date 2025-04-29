using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TestForThePresenceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DetailOfReception>
    {
        public TestForThePresenceList()
        {
            this.spName = "TestForThePresence";
            this.list = new List<RASF.General.Data.DetailOfReception>();
            this.deletedlist = new List<RASF.General.Data.DetailOfReception>();
        }

        public TestForThePresenceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

