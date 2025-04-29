using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RequestOfContractorDoesnotSendList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RequestOfContractorDoesnotSend>
    {
        public RequestOfContractorDoesnotSendList()
        {
            this.spName = "RequestOfContractorDoesnotSend";
            this.list = new List<RASF.General.Data.RequestOfContractorDoesnotSend>();
            this.deletedlist = new List<RASF.General.Data.RequestOfContractorDoesnotSend>();
        }

        public RequestOfContractorDoesnotSendList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
    }

