using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
     
    [System.ComponentModel.Category("RASF")]
    public class MasterTestStatusDeclareCostList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterTestStatus>
    {
        public MasterTestStatusDeclareCostList()
        {
            this.spName = "MasterTestStatusDeclareCost";
            this.list = new List<RASF.General.Data.MasterTestStatus>();
            this.deletedlist = new List<RASF.General.Data.MasterTestStatus>();
        }

        public MasterTestStatusDeclareCostList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override void Update()
        {
            foreach(RASF.General.Data.MasterTestStatus Test in this)
            {
                Test.UserIdUpdate = RASF.General.Classes.Global.CurrentUserCode;
            }
            base.Update();
        }
    }
}
