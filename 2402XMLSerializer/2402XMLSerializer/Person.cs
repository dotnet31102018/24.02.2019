using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _2402XMLSerializer
{
    [XmlRoot("SpecialPerson")]
    public class Person
    {
        [XmlElement("PrivateName")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int code = 1;
        protected string neighebrhood = "ofakim";
        internal int cars = 4;
        public static int numberStatic = 4;

        [XmlIgnore]
        public int Age = 5;

        [XmlAttribute]
        public string IAMAttribute = "hello";

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
