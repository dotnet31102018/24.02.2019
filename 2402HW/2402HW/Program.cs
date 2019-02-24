using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2402HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons =
            {
                new Person(1, 30, 1.89f, "Oren hazan"),
                new Person(5, 25, 1.65f, "Tzipi livni"),
                new Person(4, 22, 1.55f, "Donald Trumph"),
                new Person(3, 42, 2.05f, "Mickey mouse"),
                new Person(2, 12, 0.44f, "Goofy")
            };

            PrintPersons(persons);

            // this is without static 
            SortAndPrint(persons, new PersonCompareById());
            SortAndPrint(persons, new PersonSortByAge());
            SortAndPrint(persons, new PersonCompareByHeight());
            SortAndPrint(persons, new PersonCompareByName());

            // this is with static
            SortAndPrint(persons, Person.IDComparer);
            SortAndPrint(persons, Person.AgeComparer);
            SortAndPrint(persons, Person.HeightComparer);
            SortAndPrint(persons, Person.NameComparer);

            // this is etgar metoraf!
            // here we change the default comparer and make the Array.Sort(persons) behave differentlly
            Array.Sort(persons);
            PrintPersons(persons); // the default compare is by id
            Person.ModifyDefaultComparer(Person.NameComparer);
            Array.Sort(persons);
            PrintPersons(persons); // now the default sort is by name! hahaha
            Person.ModifyDefaultComparer(Person.HeightComparer);
            Array.Sort(persons);
            PrintPersons(persons); // now the default sort is by height! hahaha
        }

        static void SortAndPrint(Person[] persons, IComparer<Person> theComparer)
        {
            Console.WriteLine("==================");
            Console.WriteLine($"== Sort by {theComparer.GetType()}");
            Console.WriteLine("==================");
            Array.Sort(persons, theComparer);
            PrintPersons(persons);
        }

        static void PrintPersons(Person[] persons)
        {
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }
        }
    }
}
