using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class SampleSendingTypeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SampleSendingType>
    {
        public SampleSendingTypeList()
        {
            this.spName = "SampleSendingType";
            this.list = new List<RASF.General.Data.SampleSendingType>();
            this.deletedlist = new List<RASF.General.Data.SampleSendingType>();

        }

        public SampleSendingTypeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }    
}
