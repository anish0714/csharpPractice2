using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class AppointmentsList : IEnumerable<Appointments>
    {
        private List<Appointments> appointmentList = null;

        public AppointmentsList()
        {
            appointmentList = new List<Appointments>();
        }
        public List<Appointments> AppointmentList
        {
            get => this.appointmentList; set => this.appointmentList = value;
        }
        public IEnumerator<Appointments> GetEnumerator()
        {
            return ((IEnumerable<Appointments>)appointmentList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Appointments>)appointmentList).GetEnumerator();
        }
       /* public Appointments this[int i]
        {
            get { return appointmentList[i]; }
            set { appointmentList[i] = value; }
        }*/
        public Appointments this[int i]
        {
            get => this.appointmentList[i]; set => this.appointmentList[i] = value;
        }

        public int Count
        {
            get => this.appointmentList.Count;
        }

        public void Add(Appointments appointment)
        {
            this.appointmentList.Add(appointment);
        }

        public void Sort()
        {
            appointmentList.Sort();
        }
     
    }
}
