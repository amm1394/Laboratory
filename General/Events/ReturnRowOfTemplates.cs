using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Events
{
    public class ReturnRowEventArgs : EventArgs
    {
        public readonly Object sender;
        public readonly Object row;


        public ReturnRowEventArgs(Object Sender, Object Row)
        {
            this.sender = Sender;
            this.row = Row;
        }
    }

    public delegate void ReturnRow(ReturnRowEventArgs e);
}
