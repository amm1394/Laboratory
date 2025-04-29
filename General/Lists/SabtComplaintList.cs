using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SabtComplaintList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Complaint>
    {
        public SabtComplaintList()
        {
            this.spName = "SabtComplaint";
            this.list = new List<RASF.General.Data.Complaint>();
            this.deletedlist = new List<RASF.General.Data.Complaint>();
        }

        public SabtComplaintList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
