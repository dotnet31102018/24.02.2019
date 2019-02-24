using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2402XMLSerializer
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // parametersless ctor for serialization
        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
