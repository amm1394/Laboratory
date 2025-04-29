using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Events
{
    public class ReturnTestEventArgs : EventArgs
    {
        public readonly RASF.General.Data.MasterTestStatus MasterTestStatus;

        public ReturnTestEventArgs(RASF.General.Data.MasterTestStatus masterTestStatus)
        {
            this.MasterTestStatus = masterTestStatus;
        }
    }

    public delegate void ReturnTest(ReturnTestEventArgs e);

}
