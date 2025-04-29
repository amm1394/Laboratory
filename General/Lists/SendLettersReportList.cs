using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SendLettersReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SendLetters>
    {
        public SendLettersReportList()
        {
            this.spName = "SendLettersReport";
            this.list = new List<RASF.General.Data.SendLetters>();
            this.deletedlist = new List<RASF.General.Data.SendLetters>();
        }

        public SendLettersReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
