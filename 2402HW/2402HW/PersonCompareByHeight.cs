using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2402HW
{
    class PersonCompareByHeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Height > y.Height)
            {
                return 1;
            }
            else if (x.Height == y.Height)
            {
                return 0;
            }
            return -1;
        }
    }
}
