using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2402HW
{
    class PersonSortByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
