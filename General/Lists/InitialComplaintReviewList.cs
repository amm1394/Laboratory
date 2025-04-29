using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class InitialComplaintReviewList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Complaint>
    {
        public InitialComplaintReviewList()
        {
            this.spName = "InitialComplaintReview";
            this.list = new List<RASF.General.Data.Complaint>();
            this.deletedlist = new List<RASF.General.Data.Complaint>();
        }

        public InitialComplaintReviewList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
