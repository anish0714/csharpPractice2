using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    interface IGeneric<T>
    {
        int Count { get; }
        void Add(T item);
        T Get(int index);

    }
}
