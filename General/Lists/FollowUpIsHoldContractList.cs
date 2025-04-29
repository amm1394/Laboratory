using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FollowUpIsHoldContractList : RASF.General.Lists.Base.BaseList<RASF.General.Data.FollowUpIsHoldContract>
    {
        public FollowUpIsHoldContractList()
        {
            this.spName = "FollowUpIsHoldContract";
            this.list = new List<RASF.General.Data.FollowUpIsHoldContract>();
            this.deletedlist = new List<RASF.General.Data.FollowUpIsHoldContract>();
        }

        public FollowUpIsHoldContractList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

