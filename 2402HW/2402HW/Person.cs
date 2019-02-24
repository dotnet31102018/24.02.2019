using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2402HW
{
    class Person : IComparable<Person>
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }

        private static readonly IComparer<Person> _compareById;
        private static readonly IComparer<Person> _compareByAge;
        private static readonly IComparer<Person> _compareByName;
        private static readonly IComparer<Person> _compareByHeight;

        public static IComparer<Person> IDComparer
        {
            get
            {
                return _compareById;
            }
        }

        public static IComparer<Person> AgeComparer
        {
            get
            {
                return _compareByAge;
            }
        }

        public static IComparer<Person> HeightComparer
        {
            get
            {
                return _compareByHeight;
            }
        }


        public static IComparer<Person> NameComparer
        {
            get
            {
                return _compareByName;
            }
        }

        // ==================================  Etgar metoraf!!!
        private static IComparer<Person> DefaultComparer;
        public static void ModifyDefaultComparer(IComparer<Person> newComparer)
        {
            DefaultComparer = newComparer;
        }
        private static IComparer<Person> GetDefaultComparer()
        {
            return DefaultComparer;
        }
        // =================================== End etgar metoraf !!!

        static Person()
        {
            _compareById = new PersonCompareById();
            _compareByHeight = new PersonCompareByHeight();
            _compareByAge = new PersonSortByAge();
            _compareByName = new PersonCompareByName();

            DefaultComparer = _compareById; // Etgar metoraf!!!
        }

        /// <summary>
        /// Default sort is by ID
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Person other)
        {
            //---- without Etgar
            // return this.Id - other.Id;

            // with Etgar metoraf!
            return DefaultComparer.Compare(this, other);
        }

        public Person(int id, int age, float height, string name)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }

        public override string ToString()
        {
            return $"Person Name: {Name, 15} ID: {Id, 5} Height: {Height, 7} Age: {Age, 5} ";
        }
    }
}
