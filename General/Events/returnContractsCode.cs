using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Events
{
    public class ReturnContractsCodeEventArgs : EventArgs
    {
        public readonly Guid ContractsCode;

        public ReturnContractsCodeEventArgs(Guid contractsCode)
        {
            this.ContractsCode = contractsCode;
        }
    }

    public delegate void ReturnContractsCode(ReturnContractsCodeEventArgs e);
}
