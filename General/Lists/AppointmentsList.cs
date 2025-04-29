using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class AppointmentsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Appointments>
    {
        public AppointmentsList()
        {
            this.spName = "Appointments";
            this.list = new List<RASF.General.Data.Appointments>();
            this.deletedlist = new List<RASF.General.Data.Appointments>();
        }

        public AppointmentsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

