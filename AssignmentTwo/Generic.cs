using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Generic<T> : IGeneric<T>
    {
        private int size;
        private string time;
        private List<T> appointments;

        public string Time { get => time; set => time = value; }

        public Generic() {
            size = 0;
            appointments = new List<T>();
        }
        public int Count { get => size; }
        public void Add(T item)
        {
            // this.appointments[this.size] = item;
            this.appointments.Add(item);
            this.size++;
        }
                                
        public T  Get(int index)
        {
            return this.appointments[index];
        }
        public void Remove(int index)
        {

            this.appointments.RemoveAt(index);
            this.size--;
            
        }
        public void Sort()
        {
            this.appointments.Sort();
        }
    }
}
