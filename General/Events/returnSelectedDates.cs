using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Events
{
    public class ReturnSelectedDatesEventArgs : EventArgs
    {
        public readonly DateTime From;
        public readonly DateTime To;

        public ReturnSelectedDatesEventArgs(DateTime from, DateTime to)
        {
            this.From = from;
            this.To = to;
        }
    }

    public delegate void ReturnSelectedDates(ReturnSelectedDatesEventArgs e);
}
