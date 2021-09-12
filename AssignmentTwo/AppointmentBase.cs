using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class AppointmentBase : IComparable<AppointmentBase>
    {
        public string time;
        //private Property property;
        public Customer property;
        public string Time { get => time; set => time = value; }
        // internal Property PropertyType { get => property; set => property = value; }
        internal Customer PropertyType { get => property; set => property = value; }
        public int CompareTo(AppointmentBase obj)
        {
            return this.property.SizeOfLot.CompareTo(obj.property.SizeOfLot);
        }
    }
}
