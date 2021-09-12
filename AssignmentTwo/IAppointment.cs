using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    interface IAppointment 
    {
        /* string time { get; set; }
         Customer property { get; set; }*/

        void Add(Appointments appointment);
        void Sort();

    }
}
